using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.Data;
using System.IO;
using System.Linq;
using SistemaAsistenciaMagallanes.Services;

namespace SistemaAsistenciaMagallanes.Forms
{
	public partial class FrmImportarEstudiantes : Form
	{

		private string rutaArchivo = "";
		private DataTable tablaExcel = new DataTable();

		private const string COL_CEDULA = "Cedula";
		private const string COL_NOMBRE = "Nombre";
		private const string COL_APELLIDO = "Apellido";
		private const string COL_FECHA = "FechaNacimiento";
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


		}

		private void CargarSecciones()
		{
			SeccionesService service = new SeccionesService();

			cmbSeccion.DataSource = service.ListarSecciones("");

			cmbSeccion.DisplayMember = "Sección";
			cmbSeccion.ValueMember = "IdSeccion";
		}

		private DataTable LeerExcel(string ruta)
		{
			DataTable dt = new DataTable();

			using (var workbook = new XLWorkbook(ruta))
			{
				var worksheet = workbook.Worksheet(1);

				bool primeraFila = true;

				foreach (var row in worksheet.RowsUsed())
				{
					if (primeraFila)
					{
						foreach (var cell in row.Cells())
						{
							dt.Columns.Add(cell.Value.ToString());
						}

						primeraFila = false;
					}
					else
					{
						DataRow nuevaFila = dt.NewRow();

						for (int i = 0; i < dt.Columns.Count; i++)
						{
							nuevaFila[i] = row.Cell(i + 1).Value.ToString();
						}

						dt.Rows.Add(nuevaFila);
					}
				}
			}

			return dt;
		}



		private int ConvertirReligion(string valor)
		{
			if (string.IsNullOrWhiteSpace(valor))
				return 0;

			valor = valor.Trim().ToLower();

			if (valor == "si" || valor == "sí")
				return 1;

			return 0;
		}

		private void btnImportar_Click(object sender, EventArgs e)
		{
			if (tablaExcel.Rows.Count == 0)
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

			int importados = 0;
			int duplicados = 0;
			int errores = 0;

			foreach (DataRow row in tablaExcel.Rows)
			{
				try
				{
					string cedula = row[COL_CEDULA].ToString().Trim();
					string nombre = row[COL_NOMBRE].ToString().Trim();
					string apellido = row[COL_APELLIDO].ToString().Trim();
					string encargado = row[COL_ENCARGADO].ToString().Trim();
					string religionTexto = row[COL_RELIGION].ToString();

					DateTime fechaNacimiento;

					object valorFecha = row["FechaNacimiento"];

					if (valorFecha is DateTime)
					{
						fechaNacimiento = ((DateTime)valorFecha).Date;
					}
					else if (!DateTime.TryParse(valorFecha.ToString(), out fechaNacimiento))
					{
						errores++;
						continue;
					}

					int recibeReligion =
						ConvertirReligion(religionTexto);

					if (service.ExisteEstudiantePorCedula(cedula))
					{
						duplicados++;
						continue;
					}

					service.InsertarEstudiante(
						cedula,
						nombre,
						apellido,
						fechaNacimiento,
						encargado,
						idSeccion,
						recibeReligion
					);

					importados++;
				}
				catch
				{
					errores++;
				}
			}

			MessageBox.Show(
				$"Importación completada.\n\n" +
				$"Importados: {importados}\n" +
				$"Duplicados: {duplicados}\n" +
				$"Errores: {errores}"
			);
			MessageBox.Show("Estudiantes Cargados Exitosamente.");

			this.Close();
		}

		private void btnSeleccionarExcel_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();

			ofd.Filter = "Archivos Excel (*.xlsx)|*.xlsx";

			if (ofd.ShowDialog() == DialogResult.OK)
			{
				rutaArchivo = ofd.FileName;

				tablaExcel = LeerExcel(rutaArchivo);

				dgvPreview.DataSource = tablaExcel;

				lblArchivo.Text = "Archivo: " + Path.GetFileName(rutaArchivo);
				lblTotalRegistros.Text = "Registros detectados: " + tablaExcel.Rows.Count;
			}
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
