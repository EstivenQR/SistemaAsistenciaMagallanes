using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClosedXML.Excel;
using SistemaAsistenciaMagallanes.Services;

namespace SistemaAsistenciaMagallanes.Forms
{
	public partial class FrmImportarEstudiantes : Form
	{
		private string rutaArchivo = "";
		private DataTable tablaExcel = new DataTable();

		// Obligatorias
		private const string COL_CEDULA = "Cedula";
		private const string COL_NOMBRE = "Nombre";
		private const string COL_APELLIDO = "Apellido";
		private const string COL_APELLIDO1 = "Primer apellido";     // plantilla del liceo
		private const string COL_APELLIDO2 = "Segundo apellido";    // plantilla del liceo

		// Opcionales
		private const string COL_FECHA = "FechaNacimiento";
		private const string COL_FECHA_ALT = "Fecha de nacimiento"; // plantilla del liceo
		private const string COL_ENCARGADO = "NumeroEncargado";
		private const string COL_RELIGION = "RecibeReligion";

		public FrmImportarEstudiantes()
		{
			InitializeComponent();
		}

		private void FrmImportarEstudiantes_Load(object sender, EventArgs e)
		{
			CargarSecciones();

			lblArchivo.Text = "Archivo: Ninguno";
			lblTotalRegistros.Text = "Registros detectados: 0";

			// Al editar una celda, se recalculan las filas incompletas
			dgvPreview.CellEndEdit += (s, ev) => PintarIncompletos();

			// Al eliminar una fila, se actualiza el contador
			dgvPreview.UserDeletedRow += (s, ev) =>
				lblTotalRegistros.Text = "Registros detectados: " + tablaExcel.DefaultView.Count;
		}

		private void CargarSecciones()
		{
			SeccionesService service = new SeccionesService();

			cmbSeccion.DataSource = service.ListarSecciones("");

			cmbSeccion.DisplayMember = "Sección";
			cmbSeccion.ValueMember = "IdSeccion";
		}

		// =====================================================
		// AUXILIARES
		// =====================================================

		// Quita tildes y mayúsculas para comparar nombres de columnas
		private static string Normalizar(string s)
		{
			if (string.IsNullOrWhiteSpace(s)) return "";

			string d = s.Trim().ToLowerInvariant().Normalize(NormalizationForm.FormD);
			var sb = new StringBuilder();

			foreach (char c in d)
				if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
					sb.Append(c);

			return sb.ToString();
		}

		private static string Texto(IXLCell celda)
		{
			try { return celda.GetFormattedString().Trim(); }
			catch { return ""; }
		}

		// Devuelve el primer valor no vacío entre las columnas indicadas
		private string Valor(DataRow row, params string[] nombres)
		{
			foreach (string nombre in nombres)
				foreach (DataColumn col in row.Table.Columns)
					if (Normalizar(col.ColumnName) == Normalizar(nombre))
					{
						string v = row[col].ToString().Trim();
						if (v != "") return v;
					}
			return "";
		}

		private DateTime? LeerFecha(string texto)
		{
			if (string.IsNullOrWhiteSpace(texto)) return null;

			var cultura = new CultureInfo("es-CR");
			string[] formatos = { "dd/MM/yyyy", "d/M/yyyy", "yyyy-MM-dd" };

			if (DateTime.TryParseExact(texto, formatos, cultura, DateTimeStyles.None, out DateTime f))
				return f.Date;

			if (DateTime.TryParse(texto, cultura, DateTimeStyles.None, out f))
				return f.Date;

			return null;
		}

		// Vacío o sin columna = Sí. Solo "No" o "0" da 0.
		private int ConvertirReligion(string valor)
		{
			if (string.IsNullOrWhiteSpace(valor))
				return 1;

			string v = Normalizar(valor);
			return (v == "no" || v == "0") ? 0 : 1;
		}

		private bool ExisteColumna(DataTable dt, params string[] nombres)
		{
			foreach (string nombre in nombres)
				foreach (DataColumn col in dt.Columns)
					if (Normalizar(col.ColumnName) == Normalizar(nombre))
						return true;
			return false;
		}

		// Agrega las columnas opcionales si el Excel no las trae
		private void AsegurarColumnas(DataTable dt)
		{
			if (!ExisteColumna(dt, COL_FECHA, COL_FECHA_ALT))
				dt.Columns.Add(COL_FECHA);

			if (!ExisteColumna(dt, COL_ENCARGADO))
				dt.Columns.Add(COL_ENCARGADO);

			if (!ExisteColumna(dt, COL_RELIGION))
			{
				dt.Columns.Add(COL_RELIGION);
				foreach (DataRow r in dt.Rows)
					r[COL_RELIGION] = "Si";
			}
		}

		// Pone en rosa las filas a las que les falta cédula, nombre o apellido
		private void PintarIncompletos()
		{
			foreach (DataGridViewRow fila in dgvPreview.Rows)
			{
				var vista = fila.DataBoundItem as DataRowView;
				if (vista == null) continue;

				DataRow row = vista.Row;

				string apellido = (Valor(row, COL_APELLIDO1) + " " + Valor(row, COL_APELLIDO2)).Trim();
				if (apellido == "")
					apellido = Valor(row, COL_APELLIDO);

				bool incompleto = Valor(row, COL_CEDULA) == ""
							   || Valor(row, COL_NOMBRE) == ""
							   || apellido == "";

				fila.DefaultCellStyle.BackColor = incompleto ? Color.MistyRose : Color.White;
			}
		}

		// =====================================================
		// LECTURA DEL EXCEL
		// =====================================================

		private DataTable LeerExcel(string ruta)
		{
			var dt = new DataTable();

			using (var wb = new XLWorkbook(ruta))
			{
				var ws = wb.Worksheet(1);
				int ultimaFila = ws.LastRowUsed()?.RowNumber() ?? 0;
				int ultimaCol = ws.LastColumnUsed()?.ColumnNumber() ?? 0;

				// 1. Buscar la fila de encabezados: la que contiene "Cédula"
				int filaEnc = 0;
				for (int r = 1; r <= Math.Min(ultimaFila, 20) && filaEnc == 0; r++)
					for (int c = 1; c <= ultimaCol; c++)
						if (Normalizar(Texto(ws.Cell(r, c))) == "cedula") { filaEnc = r; break; }

				if (filaEnc == 0)
					throw new Exception("No se encontró la columna 'Cédula'. Revise que sea la plantilla correcta.");

				// 2. Solo las columnas que tienen encabezado
				var columnas = new List<int>();
				var ignorar = new[] { "seccion", "especialidad", "edad" };   // columnas que no se usan

				for (int c = 1; c <= ultimaCol; c++)
				{
					string enc = Texto(ws.Cell(filaEnc, c));

					if (enc == "" || enc == "0") continue;         
					if (dt.Columns.Contains(enc)) continue;
					if (ignorar.Contains(Normalizar(enc))) continue;

					dt.Columns.Add(enc);
					columnas.Add(c);
				}

				// 3. Filas de datos (se saltan las ocultas y las vacías)
				for (int r = filaEnc + 1; r <= ultimaFila; r++)
				{
					if (ws.Row(r).IsHidden) continue;

					DataRow fila = dt.NewRow();
					bool tieneDatos = false;

					for (int i = 0; i < columnas.Count; i++)
					{
						var celda = ws.Cell(r, columnas[i]);

						string valor = celda.DataType == XLDataType.DateTime
							? celda.GetDateTime().ToString("dd/MM/yyyy")
							: Texto(celda);

						fila[i] = valor;
						if (valor != "") tieneDatos = true;
					}

					if (tieneDatos) dt.Rows.Add(fila);
				}
			}

			return dt;
		}

		// =====================================================
		// BOTONES
		// =====================================================

		private void btnSeleccionarExcel_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "Archivos Excel (*.xlsx)|*.xlsx";

			if (ofd.ShowDialog() != DialogResult.OK)
				return;

			try
			{
				rutaArchivo = ofd.FileName;

				tablaExcel = LeerExcel(rutaArchivo);
				AsegurarColumnas(tablaExcel);

				dgvPreview.DataSource = tablaExcel;
				dgvPreview.ReadOnly = false;
				dgvPreview.AllowUserToAddRows = false;
				dgvPreview.AllowUserToDeleteRows = true;

				PintarIncompletos();

				lblArchivo.Text = "Archivo: " + Path.GetFileName(rutaArchivo);
				lblTotalRegistros.Text = "Registros detectados: " + tablaExcel.DefaultView.Count;
			}
			catch (Exception ex)
			{
				MessageBox.Show("No se pudo leer el archivo:\n" + ex.Message,
					"Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnImportar_Click(object sender, EventArgs e)
		{
			dgvPreview.EndEdit();   // confirma la celda que se estaba editando

			if (tablaExcel.DefaultView.Count == 0)
			{
				MessageBox.Show("Debe seleccionar un archivo Excel.");
				return;
			}

			if (cmbSeccion.SelectedValue == null)
			{
				MessageBox.Show("Seleccione una sección.");
				return;
			}

			EstudiantesService service = new EstudiantesService();
			int idSeccion = Convert.ToInt32(cmbSeccion.SelectedValue);

			int importados = 0, duplicados = 0, errores = 0;
			var detalles = new List<string>();

			foreach (DataRow row in tablaExcel.Rows)
			{
				if (row.RowState == DataRowState.Deleted) continue;

				string cedula = Valor(row, COL_CEDULA);

				try
				{
					string nombre = Valor(row, COL_NOMBRE);

					// Dos apellidos (plantilla del liceo) o uno solo ("Apellido")
					string apellido = (Valor(row, COL_APELLIDO1) + " " + Valor(row, COL_APELLIDO2)).Trim();
					if (apellido == "")
						apellido = Valor(row, COL_APELLIDO);

					// Solo estos tres son obligatorios
					if (cedula == "" || nombre == "" || apellido == "")
					{
						errores++;
						detalles.Add($"{(cedula == "" ? "(sin cédula)" : cedula)}: faltan cédula, nombre o apellido");
						continue;
					}

					// Opcionales
					DateTime fecha = LeerFecha(Valor(row, COL_FECHA, COL_FECHA_ALT))
									 ?? new DateTime(1900, 1, 1);                       // relleno si falta
					string encargado = Valor(row, COL_ENCARGADO);                       // "" si falta
					int recibeReligion = ConvertirReligion(Valor(row, COL_RELIGION));   // Sí si falta

					if (service.ExisteEstudiantePorCedula(cedula))
					{
						duplicados++;
						continue;
					}

					service.InsertarEstudiante(
						cedula,
						nombre,
						apellido,
						fecha,
						encargado,
						idSeccion,
						recibeReligion
					);

					importados++;
				}
				catch (Exception ex)
				{
					errores++;
					detalles.Add($"{cedula}: {ex.Message}");
				}
			}

			string mensaje =
				"Importación completada.\n\n" +
				$"Importados: {importados}\n" +
				$"Duplicados: {duplicados}\n" +
				$"Errores: {errores}";

			if (detalles.Count > 0)
				mensaje += "\n\nPrimeros errores:\n" + string.Join("\n", detalles.Take(10));

			MessageBox.Show(mensaje);

			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Eventos vacíos enlazados en el diseñador (no borrar, o no compila)
		private void panelHead_Paint(object sender, PaintEventArgs e) { }
		private void cmbSeccion_SelectedIndexChanged(object sender, EventArgs e) { }
		private void label1_Click(object sender, EventArgs e) { }
	}
}