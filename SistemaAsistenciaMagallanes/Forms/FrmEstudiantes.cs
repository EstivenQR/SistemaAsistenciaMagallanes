using SistemaAsistenciaMagallanes.DAO;
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
	public partial class FrmEstudiantes : Form
	{
		int idEstudiante = 0;
		public FrmEstudiantes()
		{
			InitializeComponent();
		}

		private void LimpiarCampos()
		{
			txtCedula.Clear();
			txtNombre.Clear();
			txtApellido.Clear();
			txtNumeroEncargado.Clear();
			
		}

		private void CargarEstudiantes(string buscar)
		{
			EstudiantesService service = new EstudiantesService();

			bool? estado = null;

			if (!chkMostrarInactivos.Checked)
				estado = true;

			dgvEstudiantes.DataSource = service.ListarEstudiantes(buscar, estado);

			dgvEstudiantes.Columns["IdEstudiante"].Visible = false;
			dgvEstudiantes.Columns["IdSeccion"].Visible = false;
		}

		private void txtbuscar_TextChanged(object sender, EventArgs e)
		{
			CargarEstudiantes(txtbuscar.Text);
		}

		private void CargarSecciones()
		{
			SeccionesService service = new SeccionesService();

			cmbSeccion.DataSource = service.ListarSecciones("");

			cmbSeccion.DisplayMember = "Sección";
			cmbSeccion.ValueMember = "IdSeccion";
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			EstudiantesService service = new EstudiantesService();

			service.InsertarEstudiante(
				txtCedula.Text,
				txtNombre.Text,
				txtApellido.Text,
				dtpFechaNacimiento.Value,
				txtNumeroEncargado.Text,
				Convert.ToInt32(cmbSeccion.SelectedValue)
			);

			MessageBox.Show("Estudiante guardado correctamente");

			CargarEstudiantes("");
			LimpiarCampos();
		}

		private void FrmEstudiantes_Load(object sender, EventArgs e)
		{
			CargarSecciones();
			CargarEstudiantes("");
			RedondearBoton(btnbuscar, 20);
			RedondearBoton(btnAgregar, 20);
			RedondearBoton(btnEditar, 20);
			RedondearBoton(btnEliminar, 20);
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

		private void dgvEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		

		}

		private void dgvEstudiantes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (dgvEstudiantes.Columns[e.ColumnIndex].Name == "Estado")
			{
				if (e.Value != null)
				{
					if (e.Value.ToString() == "Activo")
					{
						e.CellStyle.ForeColor = Color.Green;
						e.CellStyle.Font = new Font(dgvEstudiantes.Font, FontStyle.Bold);
					}
					else
					{
						e.CellStyle.ForeColor = Color.Red;
					}
				}
			}
		}

		private void dgvEstudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow fila = dgvEstudiantes.Rows[e.RowIndex];

				idEstudiante = Convert.ToInt32(fila.Cells["IdEstudiante"].Value);

				txtCedula.Text = fila.Cells["Cedula"].Value.ToString();
				txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
				txtApellido.Text = fila.Cells["Apellido"].Value.ToString();

				dtpFechaNacimiento.Value = Convert.ToDateTime(fila.Cells["FechaNacimiento"].Value);

				txtNumeroEncargado.Text = fila.Cells["NumeroEncargado"].Value.ToString();

				cmbSeccion.Text = fila.Cells["Seccion"].Value.ToString();

			}

		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			if (dgvEstudiantes.CurrentRow != null)
			{
				FrmEditarEstudiante frm = new FrmEditarEstudiante();

				frm.IdEstudiante = idEstudiante;
				frm.Cedula = txtCedula.Text;
				frm.Nombre = txtNombre.Text;
				frm.Apellido = txtApellido.Text;
				frm.FechaNacimiento = dtpFechaNacimiento.Value;
				frm.NumeroEncargado = txtNumeroEncargado.Text;
				frm.IdSeccion = Convert.ToInt32(dgvEstudiantes.CurrentRow.Cells["IdSeccion"].Value);
				frm.Estado = dgvEstudiantes.CurrentRow.Cells["Estado"].Value.ToString() == "Activo";

				if (frm.ShowDialog() == DialogResult.OK)
				{
					CargarEstudiantes("");
					LimpiarCampos();
				}
			}
		}

		private void chkMostrarInactivos_CheckedChanged(object sender, EventArgs e)
		{
			CargarEstudiantes("");
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
