using SistemaAsistenciaMagallanes.Conexion_BD;
using SistemaAsistenciaMagallanes.Models;
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
	public partial class FrmAsistencia : Form
	{

		AsistenciaService service = new AsistenciaService();
		public FrmAsistencia()
		{
			InitializeComponent();
			
		}

		private void FrmAsistencia_Load(object sender, EventArgs e)
		{
			cmbMateria.DataSource = null;
			dgvAsistencia.AutoGenerateColumns = false;
			ConfigurarTabla();
			CargarSecciones();
			dgvAsistencia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvAsistencia.CellValueChanged += dgvAsistencia_CellValueChanged;
			dgvAsistencia.CurrentCellDirtyStateChanged += dgvAsistencia_CurrentCellDirtyStateChanged;
			RedondearBoton(btnGuardar, 20);
			RedondearBoton(btnMarcarTodos, 20);

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
		private void ConfigurarTabla()
		{
			dgvAsistencia.AutoGenerateColumns = false;
			dgvAsistencia.Columns.Clear();

			// Columna ID (oculta)
			DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
			id.Name = "IdEstudiante";
			id.DataPropertyName = "IdEstudiante";
			id.Visible = false;

			dgvAsistencia.Columns.Add(id);

			// Columna Estudiante
			DataGridViewTextBoxColumn estudiante = new DataGridViewTextBoxColumn();
			estudiante.Name = "Estudiante";
			estudiante.HeaderText = "Estudiante";
			estudiante.DataPropertyName = "Estudiante";

			dgvAsistencia.Columns.Add(estudiante);

			// Columna Estado
			DataGridViewComboBoxColumn estado = new DataGridViewComboBoxColumn();
			estado.Name = "Estado";
			estado.HeaderText = "Estado";


			estado.Items.Add("Presente");
			estado.Items.Add("Ausente");
			estado.Items.Add("Tardía");
			estado.Items.Add("Justificado");

			dgvAsistencia.Columns.Add(estado);
		}

		private void CargarSecciones()
		{
			AsistenciaService service = new AsistenciaService();

			DataTable dt = service.ObtenerSeccionesDocente(Sesion.IdUsuario);

			//Agregar opción por defecto
			DataRow fila = dt.NewRow();
			fila["IdSeccion"] = 0;
			fila["NombreSeccion"] = "-- Seleccione una sección --";
			dt.Rows.InsertAt(fila, 0);

			cmbSeccion.DataSource = dt;
			cmbSeccion.DisplayMember = "NombreSeccion";
			cmbSeccion.ValueMember = "IdSeccion";
		}

		private void CargarMaterias(int idSeccion)
		{
			AsistenciaService service = new AsistenciaService();

			cmbMateria.DataSource = service.ObtenerMateriasDocente(Sesion.IdUsuario, idSeccion);

			cmbMateria.DisplayMember = "NombreMateria";
			cmbMateria.ValueMember = "IdAsignacion";

		}
		private void CargarEstudiantes(int idSeccion, int IdMateria)
		{
			AsistenciaService service = new AsistenciaService();

			DataTable tabla = service.ObtenerEstudiantesPorSeccion(idSeccion,IdMateria);

			if (tabla != null)
			{
				dgvAsistencia.AutoGenerateColumns = false;

				dgvAsistencia.DataSource = null;
				dgvAsistencia.DataSource = tabla;
			}

		}

		/*private void btnGuardar_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewRow fila in dgvAsistencia.Rows)
			{
				int idEstudiante = Convert.ToInt32(fila.Cells["IdEstudiante"].Value);

				string estado = fila.Cells["Estado"].Value.ToString();

				service.GuardarAsistencia(
					idEstudiante,
					Convert.ToInt32(cmbSeccion.SelectedValue),
					Convert.ToInt32(cmbMateria.SelectedValue),
					dtpFecha.Value,
					estado,
					Sesion.IdUsuario
				);
			}

			MessageBox.Show("Asistencia guardada correctamente");
		}*/

		private void cmbMateria_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void cmbSeccion_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbSeccion.SelectedValue != null && cmbSeccion.SelectedValue is int)
			{
				int idSeccion = Convert.ToInt32(cmbSeccion.SelectedValue);

				if (idSeccion == 0) return;

				CargarMaterias(idSeccion);

				// 🔥 ESPERAR a que cargue materias
				if (cmbMateria.SelectedValue != null)
				{
					int idMateria = Convert.ToInt32(cmbMateria.SelectedValue);
					CargarEstudiantes(idSeccion, idMateria);
				}
			}
		}

		private void cmbSeccion_SelectionChangeCommitted(object sender, EventArgs e)
		{
			int idSeccion = Convert.ToInt32(cmbSeccion.SelectedValue);

			if (idSeccion == 0) return;

			CargarMaterias(idSeccion);
		}

		private void dgvAsistencia_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == dgvAsistencia.Columns["Estado"].Index && e.RowIndex >= 0)
			{
				string estado = dgvAsistencia.Rows[e.RowIndex].Cells["Estado"].Value?.ToString();

				DataGridViewRow fila = dgvAsistencia.Rows[e.RowIndex];

				switch (estado)
				{
					case "Presente":
						fila.DefaultCellStyle.BackColor = Color.LightGreen;
						break;

					case "Ausente":
						fila.DefaultCellStyle.BackColor = Color.LightCoral;
						break;

					case "Tardía":
						fila.DefaultCellStyle.BackColor = Color.Khaki;
						break;

					case "Justificado":
						fila.DefaultCellStyle.BackColor = Color.LightBlue;
						break;

					default:
						fila.DefaultCellStyle.BackColor = Color.White;
						break;
				}
			}
		}

		private void dgvAsistencia_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (dgvAsistencia.IsCurrentCellDirty)
			{
				dgvAsistencia.CommitEdit(DataGridViewDataErrorContexts.Commit);
			}
		}

		private void btnGuardar_Click_1(object sender, EventArgs e)
		{
			AsistenciaService service = new AsistenciaService();

			int idAsignacion = Convert.ToInt32(cmbMateria.SelectedValue);
			DateTime fecha = DateTime.Now;

			// 1Crear la clase
			int idClase = service.CrearClase(idAsignacion, fecha);

			// 2Recorre el DataGridView
			foreach (DataGridViewRow fila in dgvAsistencia.Rows)
			{
				if (fila.Cells["IdEstudiante"].Value != null)
				{
					int idEstudiante = Convert.ToInt32(fila.Cells["IdEstudiante"].Value);
					string estado = fila.Cells["Estado"].Value?.ToString() ?? "Presente";

					service.GuardarDetalleAsistencia(idClase, idEstudiante, estado);
				}
			}

			MessageBox.Show("Asistencia guardada correctamente");
			this.Close();
		}

		private void btnMarcarTodos_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewRow fila in dgvAsistencia.Rows)
			{
				fila.Cells["Estado"].Value = "Presente";
			}
		}

		private void cmbMateria_SelectionChangeCommitted(object sender, EventArgs e)
		{
			if (cmbSeccion.SelectedValue == null) return;

			int idSeccion = Convert.ToInt32(cmbSeccion.SelectedValue);
			int idAsignacion = Convert.ToInt32(cmbMateria.SelectedValue);

			CargarEstudiantes(idSeccion, idAsignacion);
		}

		private void btnJustificarSeleccionado_Click(object sender, EventArgs e)
		{

		}

		private void dgvAsistencia_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
