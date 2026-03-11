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
using System.Data.SqlClient;
using SistemaAsistenciaMagallanes.Conexion_BD;
using SistemaAsistenciaMagallanes.Services;

namespace SistemaAsistenciaMagallanes.Forms
{
	public partial class FrmUsuarios : Form
	{
		public FrmUsuarios()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}

		public void CargarRoles()
		{
			ConexionBD conexionBD = new ConexionBD();
			SqlConnection conexion = conexionBD.ObtenerConexion();

			try
			{
				conexion.Open();

				string consulta = "SELECT IdRol, NombreRol FROM Roles";

				SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
				DataTable tabla = new DataTable();

				adapter.Fill(tabla);

				cmbRol.DataSource = tabla;
				cmbRol.DisplayMember = "NombreRol";
				cmbRol.ValueMember = "IdRol";
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al cargar roles: " + ex.Message);
			}
			finally
			{
				conexion.Close();
			}
		}

		private void LimpiarCampos()
		{
			txtNombre.Clear();
			txtUsuario.Clear();
			txtPassword.Clear();
			cmbRol.SelectedIndex = -1;
			chkEstado.Checked = false;
		}

		private void CargarUsuarios(string buscar)
		{
			UsuarioService service = new UsuarioService();
			dgvUsuarios.DataSource = service.ListarUsuarios(buscar, chkMostrarInactivos.Checked);
		}




		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{

		}

		private void FrmUsuarios_Load(object sender, EventArgs e)
		{

			CargarUsuarios("");
			CargarRoles();
			dgvUsuarios.Columns["IdUsuario"].Visible = false;

			RedondearBoton(btnbuscar, 20);
			RedondearBoton(btnAgregar, 20);
			RedondearBoton(btnEditar, 20);
			RedondearBoton(btnSalir, 20);
			dgvUsuarios.RowPrePaint += dgvUsuarios_RowPrePaint;


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

		private void btnbuscar_Click_1(object sender, EventArgs e)
		{
			CargarUsuarios(txtbuscar.Text);
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void txtbuscar_TextChanged(object sender, EventArgs e)
		{
			CargarUsuarios(txtbuscar.Text);


		}



		private void btnAgregar_Click(object sender, EventArgs e)
		{
			UsuarioService service = new UsuarioService();

			int estado = chkEstado.Checked ? 1 : 0;
			MessageBox.Show("Estado enviado: " + estado);
			service.CrearUsuario(
				txtNombre.Text,
				txtUsuario.Text,
				txtPassword.Text,
				(int)cmbRol.SelectedValue,
				estado
			);

			MessageBox.Show("Usuario agregado correctamente");

			CargarUsuarios("");
			LimpiarCampos();
		}

		private void btnmostrar_Click(object sender, EventArgs e)
		{
			txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;

		}

		private void panelprincipal_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			if (dgvUsuarios.SelectedRows.Count > 0)
			{
				int idUsuario = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["IdUsuario"].Value);

				FrmEditarUsuario frm = new FrmEditarUsuario(idUsuario);
				frm.ShowDialog();

				CargarUsuarios(""); //Refresca la info de la tabla
			}
			else
			{
				MessageBox.Show("Seleccione un usuario para editar");

			}
		}

		private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void chkMostrarInactivos_CheckedChanged(object sender, EventArgs e)
		{
			CargarUsuarios(txtbuscar.Text);
		}

		private void dgvUsuarios_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
		{
			var fila = dgvUsuarios.Rows[e.RowIndex];

			if (fila.Cells["Estado"].Value != null)
			{
				string estado = fila.Cells["Estado"].Value.ToString().Trim();

				if (estado == "Inactivo")
				{
					fila.DefaultCellStyle.ForeColor = Color.Gray;
				}
			}
		}

		private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
