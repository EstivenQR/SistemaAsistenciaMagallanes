using SistemaAsistenciaMagallanes.Conexion_BD;
using SistemaAsistenciaMagallanes.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAsistenciaMagallanes.Forms
{
	public partial class FrmHistorialAsistencia : Form
	{

		AsistenciaService service = new AsistenciaService();
		public FrmHistorialAsistencia()
		{
			InitializeComponent();
		}

		private void panel3_Paint(object sender, PaintEventArgs e)
		{

		}

		private void FrmHistorialAsistencia_Load(object sender, EventArgs e)
		{
			this.PerformLayout();
			flowBotones.PerformLayout();
			flowFiltros.PerformLayout();
			RedondearBoton(btnBuscar, 20);
			RedondearBoton(btnGuardar, 20);
			RedondearBoton(btnSalir, 20);
			dgvLista.DataError += dgvLista_DataError;
			
			CentrarFiltros();
			AjustarFooter();
			RedondearPanel(panelKPI1, 20);
			RedondearPanel(panelKPI2, 20);
			RedondearPanel(panelKPI3, 20);
			RedondearPanel(panelKPI4, 20);
			CargarLecciones();
			CargarSecciones();


		}


		private void CargarSecciones()
		{
			DataTable dt = service.ObtenerSeccionesHistorial(
				Sesion.IdUsuario,
				Sesion.IdRol
			);

			DataRow fila = dt.NewRow();
			fila["IdSeccion"] = 0;
			fila["NombreSeccion"] = "-- Seleccione una sección --";
			dt.Rows.InsertAt(fila, 0);

			cmbSeccion.DataSource = dt;
			cmbSeccion.DisplayMember = "NombreSeccion";
			cmbSeccion.ValueMember = "IdSeccion";
		}


		private void CargarLecciones()
		{
			DataTable dt = new DataTable();

			dt.Columns.Add("Id", typeof(int));
			dt.Columns.Add("Texto", typeof(string));

			DataRow filaDefault = dt.NewRow();
			filaDefault["Id"] = 0;
			filaDefault["Texto"] = "-- Seleccione lección --";
			dt.Rows.Add(filaDefault);

			for (int i = 1; i <= 8; i++)
			{
				DataRow fila = dt.NewRow();
				fila["Id"] = i;
				fila["Texto"] = i + "° Lección";
				dt.Rows.Add(fila);
			}

			cmbLeccion.DataSource = dt;
			cmbLeccion.DisplayMember = "Texto";
			cmbLeccion.ValueMember = "Id";
		}

		private void CargarLista()
		{
			if (cmbSeccion.SelectedValue == null ||
				cmbMateria.SelectedValue == null)
			{
				MessageBox.Show("Seleccione sección y materia");
				return;
			}

			// VALIDAR LECCIÓN
			if (cmbLeccion.SelectedValue == null ||
				Convert.ToInt32(cmbLeccion.SelectedValue) == 0)
			{
				MessageBox.Show("Seleccione una lección.");
				return;
			}

			int idAsignacion = Convert.ToInt32(cmbMateria.SelectedValue);

			if (idAsignacion == 0)
				return;

			int numeroLeccion = Convert.ToInt32(cmbLeccion.SelectedValue);

			DataTable dt = service.ObtenerListaAsistencia(
				idAsignacion,
				dtpFecha.Value.Date,
				numeroLeccion
			);

			if (dt.Rows.Count == 0)
			{
				MessageBox.Show("No existe asistencia registrada para esa fecha y lección.");
				dgvLista.DataSource = null;
				return;
			}

			dgvLista.DataSource = dt;

			lblTotaltotalEstudiantes.Text = dt.Rows.Count.ToString();
			lblTotalSeccion.Text = cmbSeccion.Text;
			lblTotalMateria.Text = cmbMateria.Text;

			string nombreCompleto = dt.Rows[0]["Docente"].ToString();
			string[] partes = nombreCompleto.Split(' ');

			if (partes.Length >= 2)
				lblTotalDocente.Text = partes[0] + " " + partes[1];
			else
				lblTotalDocente.Text = nombreCompleto;

			ConfigurarGrid();

			bool esHoy = dtpFecha.Value.Date == DateTime.Today;

			dgvLista.ReadOnly = !esHoy;
			btnGuardar.Enabled = esHoy;

			if (!esHoy)
			{
				MessageBox.Show(
					"Solo se pueden modificar listas del día actual.",
					"Modo consulta",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information
				);
			}
		}

		private void ConfigurarGrid()
		{
			dgvLista.Columns["IdDetalle"].Visible = false;
			dgvLista.Columns["IdEstudiante"].Visible = false;
			dgvLista.Columns["Docente"].Visible = false;

			dgvLista.Columns["Estudiante"].AutoSizeMode =
				DataGridViewAutoSizeColumnMode.Fill;

			dgvLista.Columns["Estudiante"].ReadOnly = true;

			if (!dgvLista.Columns.Contains("EstadoCombo"))
			{
				int index = dgvLista.Columns["Estado"].Index;

				dgvLista.Columns.Remove("Estado");

				DataGridViewComboBoxColumn combo =
					new DataGridViewComboBoxColumn();

				combo.Name = "Estado";
				combo.HeaderText = "Estado";

				combo.Items.Add("Presente");
				combo.Items.Add("Ausente");
				combo.Items.Add("Tardía");
				combo.Items.Add("Justificado");

				combo.DataPropertyName = "Estado";

				dgvLista.Columns.Insert(index, combo);
			}
			dgvLista.Columns["Observacion"].HeaderText = "Observación";
			dgvLista.Columns["Observacion"].AutoSizeMode =
				DataGridViewAutoSizeColumnMode.Fill;
		}

		private void RedondearBoton(Button btn, int radio)
		{
			GraphicsPath path = new GraphicsPath();
			path.StartFigure();

			path.AddArc(new Rectangle(0, 0, radio, radio), 180, 90);
			path.AddArc(new Rectangle(btn.Width - radio, 0, radio, radio), 270, 90);
			path.AddArc(new Rectangle(btn.Width - radio, btn.Height - radio, radio, radio), 0, 90);
			path.AddArc(new Rectangle(0, btn.Height - radio, radio, radio), 90, 90);

			path.CloseFigure();

			btn.Region = new Region(path);
		}


		private void CentrarFiltros()
		{
			flowFiltros.Left = (pnlFiltrosContenedor.Width - flowFiltros.Width) / 2;
			flowFiltros.Top = (pnlFiltrosContenedor.Height - flowFiltros.Height) / 2;
		}

		private void RedondearPanel(Panel pnl, int radio)
		{
			GraphicsPath path = new GraphicsPath();

			path.StartFigure();
			path.AddArc(new Rectangle(0, 0, radio, radio), 180, 90);
			path.AddArc(new Rectangle(pnl.Width - radio, 0, radio, radio), 270, 90);
			path.AddArc(new Rectangle(pnl.Width - radio, pnl.Height - radio, radio, radio), 0, 90);
			path.AddArc(new Rectangle(0, pnl.Height - radio, radio, radio), 90, 90);
			path.CloseFigure();

			pnl.Region = new Region(path);
		}

		private void AjustarFooter()
		{
			flowBotones.PerformLayout();

			flowBotones.Left = (pnlFooter.ClientSize.Width - flowBotones.Width) / 2;
			flowBotones.Top = (pnlFooter.ClientSize.Height - flowBotones.Height) / 2;
		}

		private void FrmHistorialAsistencia_Resize(object sender, EventArgs e)
		{
			CentrarFiltros();
			AjustarFooter();
		}

		private void pnlFooter_Paint(object sender, PaintEventArgs e)
		{

		}

		private void cmbSeccion_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void cmbSeccion_SelectionChangeCommitted(object sender, EventArgs e)
		{
			if (cmbSeccion.SelectedValue == null)
				return;

			int idSeccion = Convert.ToInt32(cmbSeccion.SelectedValue);

			if (idSeccion == 0)
			{
				cmbMateria.DataSource = null;
				return;
			}

			DataTable dt = service.ObtenerMateriasHistorial(
				Sesion.IdUsuario,
				Sesion.IdRol,
				idSeccion
			);

			DataRow fila = dt.NewRow();
			fila["IdAsignacion"] = 0;
			fila["NombreMateria"] = "-- Seleccione una materia --";
			dt.Rows.InsertAt(fila, 0);

			cmbMateria.DataSource = dt;
			cmbMateria.DisplayMember = "NombreMateria";
			cmbMateria.ValueMember = "IdAsignacion";
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			CargarLista();
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{


			DialogResult r = MessageBox.Show(
				"¿Guardar cambios?",
				"Confirmar",
				MessageBoxButtons.YesNo
			);
			foreach (DataGridViewRow row in dgvLista.Rows)
			{
				if (row.IsNewRow) continue;

				int idDetalle = Convert.ToInt32(
					row.Cells["IdDetalle"].Value
				);

				string estado = row.Cells["Estado"].Value?.ToString();

				string observacion =
					row.Cells["Observacion"].Value?.ToString();

				service.ActualizarDetalleAsistencia(
					idDetalle,
					estado,
					observacion,
					Sesion.IdUsuario
				);
			}
			CargarLista();

			Cursor = Cursors.Default;

			MessageBox.Show("Cambios guardados correctamente.");
		}

		private void dgvLista_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.RowIndex < 0)
				return;

			if (!dgvLista.Columns.Contains("Estado"))
				return;

			if (dgvLista.Rows[e.RowIndex].Cells["Estado"].Value == null)
				return;

			string estado = dgvLista.Rows[e.RowIndex]
				.Cells["Estado"]
				.Value
				.ToString();

			DataGridViewRow row = dgvLista.Rows[e.RowIndex];

			switch (estado)
			{
				case "Presente":
					row.DefaultCellStyle.BackColor = Color.Honeydew;
					row.DefaultCellStyle.ForeColor = Color.DarkGreen;
					break;

				case "Ausente":
					row.DefaultCellStyle.BackColor = Color.MistyRose;
					row.DefaultCellStyle.ForeColor = Color.DarkRed;
					break;

				case "Justificado":
					row.DefaultCellStyle.BackColor = Color.LemonChiffon;
					row.DefaultCellStyle.ForeColor = Color.DarkOrange;
					break;

				default:
					row.DefaultCellStyle.BackColor = Color.White;
					row.DefaultCellStyle.ForeColor = Color.Black;
					break;
			}
		}

		private void dgvLista_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (dgvLista.IsCurrentCellDirty)
			{
				dgvLista.CommitEdit(DataGridViewDataErrorContexts.Commit);
				dgvLista.Refresh();
			}
		}

		private void panelHead_Paint(object sender, PaintEventArgs e)
		{

		}

		private void dgvLista_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
			try
			{
				var valor = dgvLista.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

				MessageBox.Show(
					$"Fila: {e.RowIndex}\n" +
					$"Columna: {e.ColumnIndex}\n" +
					$"Valor: {valor}\n" +
					$"Error: {e.Exception?.Message}"
				);

				e.ThrowException = false;
			}
			catch
			{
			}
		}
	}
}
