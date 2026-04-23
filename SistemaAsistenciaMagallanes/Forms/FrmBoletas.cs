using SistemaAsistenciaMagallanes.Conexion_BD;
using SistemaAsistenciaMagallanes.Reportes;
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
	public partial class FrmBoletas : Form
	{
		int idBoletaSeleccionada = 0;
		BoletasService service = new BoletasService();

		public FrmBoletas()
		{
			InitializeComponent();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label3_Click_1(object sender, EventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void FrmBoletas_Load(object sender, EventArgs e)
		{
			CargarSecciones();
			CargarBoletas();
			CargarSeccionesFiltro();
			CargarEstudiantesFiltro(0);
			RedondearBoton(btnbuscar, 20);
			RedondearBoton(BtnCrear, 20);
			RedondearBoton(BtnEditar, 20);
			RedondearBoton(BtnEliminar, 20);
			RedondearBoton(BtnReporte, 20);
			RedondearBoton(BtnSalir, 20);
			RedondearBoton(btnLimpiar, 20);

		}

		DataTable dtBoletas;
		private void CargarBoletas()
		{
			dtBoletas = service.ListarBoletas(Sesion.IdUsuario, Sesion.IdRol);
			dgvBoletas.DataSource = dtBoletas;
			dgvBoletas.Columns["IdBoleta"].Visible = false;
			dgvBoletas.Columns["IdEstudiante"].Visible = false;
			dgvBoletas.Columns["IdSeccion"].Visible = false;

		}

		private void CargarEstudiantes()
		{
			DataTable dt = service.ObtenerEstudiantes(Sesion.IdUsuario, Sesion.IdRol);



			cmbEstudiante.DataSource = dt;
			cmbEstudiante.DisplayMember = "NombreCompleto";
			cmbEstudiante.ValueMember = "IdEstudiante";
		}

		private void CargarSecciones()
		{
			var dt = service.ObtenerSecciones(Sesion.IdUsuario, Sesion.IdRol);

			DataRow fila = dt.NewRow();
			fila["IdSeccion"] = 0;
			fila["NombreSeccion"] = "-- Seleccione una Sección --";
			dt.Rows.InsertAt(fila, 0);

			cmbSeccion.DataSource = dt;
			cmbSeccion.DisplayMember = "NombreSeccion";
			cmbSeccion.ValueMember = "IdSeccion";
		}

		private void CargarSeccionesFiltro()
		{
			DataTable dt = service.ObtenerSecciones(Sesion.IdUsuario, Sesion.IdRol);

			DataRow fila = dt.NewRow();
			fila["IdSeccion"] = 0;
			fila["NombreSeccion"] = "-- Todas las secciones --";
			dt.Rows.InsertAt(fila, 0);

			CmbSeccionFiltro.DataSource = dt;
			CmbSeccionFiltro.DisplayMember = "NombreSeccion";
			CmbSeccionFiltro.ValueMember = "IdSeccion";
		}

		private void CargarEstudiantesFiltro(int idSeccion)
		{
			DataTable dt;

			if (idSeccion == 0)
				dt = service.ObtenerEstudiantes(Sesion.IdUsuario, Sesion.IdRol);
			else
				dt = service.ObtenerEstudiantesPorSeccion(idSeccion);

			DataRow fila = dt.NewRow();
			fila["IdEstudiante"] = 0;
			fila["NombreCompleto"] = "-- Todos los estudiantes --";
			dt.Rows.InsertAt(fila, 0);

			cmbNombre.DataSource = dt;
			cmbNombre.DisplayMember = "NombreCompleto";
			cmbNombre.ValueMember = "IdEstudiante";
		}

		private void AjustarLayout()
		{
			int margin = 40;
			int maxWidth = 1300;

			pnlContenido.Width = Math.Min(this.ClientSize.Width - margin, maxWidth);
			pnlContenido.Left = (this.ClientSize.Width - pnlContenido.Width) / 2;
		}

		private void FrmBoletas_Resize(object sender, EventArgs e)
		{


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

		private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void BtnCrear_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtMotivo.Text))
			{
				MessageBox.Show("Ingrese un motivo");
				return;
			}

			int idEstudiante = Convert.ToInt32(cmbEstudiante.SelectedValue);
			string motivo = txtMotivo.Text;
			int porcentaje = Convert.ToInt32(txtPorcentaje.Text);
			DateTime fecha = dtpFecha.Value;

			service.GuardarBoleta(idEstudiante, fecha, motivo, porcentaje, Sesion.IdUsuario);

			MessageBox.Show("Boleta guardada correctamente");

			txtMotivo.Clear();
			txtPorcentaje.Clear();
			cmbEstudiante.SelectedIndex = 0;

			CargarBoletas();
		}




		private void cmbSeccion_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void cmbSeccion_SelectionChangeCommitted(object sender, EventArgs e)
		{
			if (cmbSeccion.SelectedValue == null) return;

			int idSeccion = Convert.ToInt32(cmbSeccion.SelectedValue);

			if (idSeccion == 0) return;

			DataTable dt = service.ObtenerEstudiantesPorSeccion(idSeccion);

			DataRow fila = dt.NewRow();
			fila["IdEstudiante"] = 0;
			fila["NombreCompleto"] = "-- Seleccione un Estudiante --";
			dt.Rows.InsertAt(fila, 0);

			cmbEstudiante.DataSource = dt;
			cmbEstudiante.DisplayMember = "NombreCompleto";
			cmbEstudiante.ValueMember = "IdEstudiante";
		}

		private void txtbuscar_TextChanged(object sender, EventArgs e)
		{
			if (dtBoletas == null) return;

			string filtro = txtBuscar.Text.Replace("'", "''");

			DataView dv = dtBoletas.DefaultView;

			dv.RowFilter = $"Estudiante LIKE '%{filtro}%' OR Seccion LIKE '%{filtro}%'";

			dgvBoletas.DataSource = dv;
		}

		private void dgvBoletas_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvBoletas.CurrentRow != null)
			{
				idBoletaSeleccionada = Convert.ToInt32(
					dgvBoletas.CurrentRow.Cells["IdBoleta"].Value
				);

				txtMotivo.Text = dgvBoletas.CurrentRow.Cells["Motivo"].Value.ToString();
				txtPorcentaje.Text = dgvBoletas.CurrentRow.Cells["Puntos"].Value.ToString();

				dtpFecha.Value = Convert.ToDateTime(
					dgvBoletas.CurrentRow.Cells["Fecha"].Value
				);


				int idSeccion = Convert.ToInt32(
					dgvBoletas.CurrentRow.Cells["IdSeccion"].Value
				);

				cmbSeccion.SelectedValue = idSeccion;

				// cargar estudiantes de esa sección primero
				cmbEstudiante.DataSource = service.ObtenerEstudiantesPorSeccion(idSeccion);
				cmbEstudiante.DisplayMember = "NombreCompleto";
				cmbEstudiante.ValueMember = "IdEstudiante";

				int idEstudiante = Convert.ToInt32(
					dgvBoletas.CurrentRow.Cells["IdEstudiante"].Value
				);

				cmbEstudiante.SelectedValue = idEstudiante;
			}
		}

		private void BtnEditar_Click(object sender, EventArgs e)
		{
			if (idBoletaSeleccionada == 0)
			{
				MessageBox.Show("Seleccione una boleta");
				return;
			}

			if (string.IsNullOrWhiteSpace(txtMotivo.Text))
			{
				MessageBox.Show("Ingrese un motivo");
				return;
			}

			service.ActualizarBoleta(
				idBoletaSeleccionada,
				Convert.ToInt32(cmbEstudiante.SelectedValue),
				dtpFecha.Value,
				txtMotivo.Text,
				Convert.ToInt32(txtPorcentaje.Text)
			);

			MessageBox.Show("Boleta actualizada");

			LimpiarCampos();
			CargarBoletas();
		}

		private void BtnEliminar_Click(object sender, EventArgs e)
		{
			if (idBoletaSeleccionada == 0)
			{
				MessageBox.Show("Seleccione una boleta");
				return;
			}

			var confirm = MessageBox.Show(
				"¿Seguro que desea eliminar esta boleta?",
				"Confirmar",
				MessageBoxButtons.YesNo
			);

			if (confirm == DialogResult.Yes)
			{
				service.EliminarBoleta(idBoletaSeleccionada);

				MessageBox.Show("Boleta eliminada");

				LimpiarCampos();
				CargarBoletas();
			}
		}

		private void LimpiarCampos()
		{
			idBoletaSeleccionada = 0;

			txtMotivo.Clear();
			txtPorcentaje.Clear();

			if (cmbSeccion.Items.Count > 0)
				cmbSeccion.SelectedIndex = 0;

			if (cmbEstudiante.DataSource != null)
				cmbEstudiante.SelectedValue = 0;
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			LimpiarCampos();
		}

		private void BtnSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void BtnReporte_Click(object sender, EventArgs e)
		{
			PdfHelper pdf = new PdfHelper();

			// SI HAY FILA SELECCIONADA  BOLETA INDIVIDUAL
			if (dgvBoletas.SelectedRows.Count > 0)
			{
				int idBoleta = Convert.ToInt32(
					dgvBoletas.SelectedRows[0].Cells["IdBoleta"].Value
				);

				DataRow boleta = service.ObtenerBoletaPorId(idBoleta);

				if (boleta == null)
				{
					MessageBox.Show("No se encontró la boleta");
					return;
				}

				pdf.GenerarBoletaPDF(boleta);
				return;
			}

		

			int? idSeccion = null;
			int? idEstudiante = null;

			// Sección
			if (CmbSeccionFiltro.SelectedValue != null && Convert.ToInt32(CmbSeccionFiltro.SelectedValue) != 0)
				idSeccion = Convert.ToInt32(CmbSeccionFiltro.SelectedValue);

			if (cmbNombre.SelectedValue != null && Convert.ToInt32(cmbNombre.SelectedValue) != 0)
				idEstudiante = Convert.ToInt32(cmbNombre.SelectedValue);

			
			DateTime? fechaInicio = null;
			DateTime? fechaFin = null;

			
			fechaInicio = dtpInicio.Value;
			fechaFin = dtpFin.Value;

			DataTable dt = service.ObtenerBoletasReporte(idSeccion, idEstudiante, fechaInicio, fechaFin);

			if (dt.Rows.Count == 0)
			{
				MessageBox.Show("No hay datos para el reporte");
				return;
			}

			pdf.GenerarReporteBoletasFiltros(dt, cmbSeccion.Text, cmbEstudiante.Text);
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void FiltrarBoletas()
		{
			int? idSeccion = null;
			int? idEstudiante = null;
			DateTime? inicio = null;
			DateTime? fin = null;

			// 🔥 USAR LOS FILTROS (NO LOS DE CREAR)
			if (CmbSeccionFiltro.SelectedValue != null && Convert.ToInt32(CmbSeccionFiltro.SelectedValue) != 0)
				idSeccion = Convert.ToInt32(CmbSeccionFiltro.SelectedValue);

			if (cmbNombre.SelectedValue != null && Convert.ToInt32(cmbNombre.SelectedValue) != 0)
				idEstudiante = Convert.ToInt32(cmbNombre.SelectedValue);

			inicio = dtpInicio.Value.Date;
			fin = dtpFin.Value.Date;

			dgvBoletas.DataSource = service.ObtenerBoletasReporte(idSeccion, idEstudiante, inicio, fin);
		}

		private void btnbuscar_Click(object sender, EventArgs e)
		{
			FiltrarBoletas();

		}

		private void CmbSeccionFiltro_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void CmbSeccionFiltro_SelectionChangeCommitted(object sender, EventArgs e)
		{
			if (CmbSeccionFiltro.SelectedValue == null) return;

			int idSeccion = Convert.ToInt32(CmbSeccionFiltro.SelectedValue);

			CargarEstudiantesFiltro(idSeccion);

		}

		private void cmbNombre_SelectionChangeCommitted(object sender, EventArgs e)
		{

		}
	}
}
