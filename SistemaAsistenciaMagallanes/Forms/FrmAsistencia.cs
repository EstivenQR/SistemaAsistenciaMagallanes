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
        private bool cargandoMaterias = false;
        public FrmAsistencia()
		{
			InitializeComponent();
            

        }

        private bool tablaConfigurada = false;

        private void FrmAsistencia_Load(object sender, EventArgs e)
		{
            dgvAsistencia.AllowUserToAddRows = false;
            cmbMateria.DataSource = null;
			dgvAsistencia.AutoGenerateColumns = false;
			ConfigurarTabla();
            CargarSecciones();
			dgvAsistencia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvAsistencia.CellValueChanged += dgvAsistencia_CellValueChanged;
			dgvAsistencia.CurrentCellDirtyStateChanged += dgvAsistencia_CurrentCellDirtyStateChanged;
			RedondearBoton(btnGuardar, 20);
			RedondearBoton(btnMarcarTodos, 20);
			RedondearBoton(btnSalir, 20);

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

			// 🔥 ID
			if (!dgvAsistencia.Columns.Contains("IdEstudiante"))
			{
				dgvAsistencia.Columns.Add(new DataGridViewTextBoxColumn()
				{
					Name = "IdEstudiante",
					DataPropertyName = "IdEstudiante",
					Visible = false
				});
			}

			// 🔥 Estudiante
			if (!dgvAsistencia.Columns.Contains("Estudiante"))
			{
				dgvAsistencia.Columns.Add(new DataGridViewTextBoxColumn()
				{
					Name = "Estudiante",
					HeaderText = "Estudiante",
					DataPropertyName = "Estudiante"
				});
			}

			// 🔥 Estado
			if (!dgvAsistencia.Columns.Contains("Estado"))
			{
				dgvAsistencia.Columns.Add(new DataGridViewComboBoxColumn()
				{
					Name = "Estado",
					HeaderText = "Estado",
					DataSource = new List<string>
			{
				"Presente", "Ausente", "Tardía", "Justificado"
			}
				});
			}
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
			cargandoMaterias = true;

			AsistenciaService service = new AsistenciaService();

			cmbMateria.DataSource = null;

			// GUARDA EL DATATABLE
			DataTable dt = service.ObtenerMateriasDocente(Sesion.IdUsuario, idSeccion);

			// AGREGAR FILA POR DEFECTO
			DataRow fila = dt.NewRow();
			fila["IdAsignacion"] = 0;
			fila["NombreMateria"] = "-- Seleccione una materia --";
			dt.Rows.InsertAt(fila, 0);

			cmbMateria.DataSource = dt;
			cmbMateria.DisplayMember = "NombreMateria";
			cmbMateria.ValueMember = "IdAsignacion";

			cargandoMaterias = false;
		}

		private bool cargandoEstudiantes = false;
		private void CargarEstudiantes(int idSeccion, int idAsignacion)
		{
			if (cargandoEstudiantes) return;
			cargandoEstudiantes = true;

			var tabla = service.ObtenerEstudiantesPorSeccion(idSeccion, idAsignacion);

			dgvAsistencia.SuspendLayout();

			dgvAsistencia.DataSource = null;
			dgvAsistencia.DataSource = tabla;

			dgvAsistencia.ResumeLayout();

			foreach (DataGridViewRow fila in dgvAsistencia.Rows)
			{
				fila.Cells["Estado"].Value = "Presente";
			}

			cargandoEstudiantes = false;
		}


		private void cmbMateria_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void cmbSeccion_SelectedIndexChanged(object sender, EventArgs e)
		{
			
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

			if (service.ExisteClase(idAsignacion, fecha))
			{
				MessageBox.Show("Ya se registró asistencia para esta materia en esta fecha");
				return;
			}

			// 1Crea la clase
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
			if (cargandoMaterias) return;

			if (cmbSeccion.SelectedValue == null) return;
			if (cmbMateria.SelectedValue == null) return;

			int idSeccion = Convert.ToInt32(cmbSeccion.SelectedValue);
			int idAsignacion = Convert.ToInt32(cmbMateria.SelectedValue);

			// evitar opción por defecto
			if (idAsignacion == 0)
			{
				dgvAsistencia.DataSource = null; // limpia grid
				return;
			}

			CargarEstudiantes(idSeccion, idAsignacion);
		}

		private void btnJustificarSeleccionado_Click(object sender, EventArgs e)
		{

		}

		private void dgvAsistencia_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void flowLayoutPanel1_Resize(object sender, EventArgs e)
		{
			flowLayoutPanel1.Left = (pnlfiltros.Width - flowLayoutPanel1.Width) / 2;
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
