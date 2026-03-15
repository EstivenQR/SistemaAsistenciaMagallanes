using SistemaAsistenciaMagallanes.Conexion_BD;
using SistemaAsistenciaMagallanes.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAsistenciaMagallanes.Forms
{
	public partial class FrmEditarUsuario : Form
	{
		int idUsuario;
		public FrmEditarUsuario(int id)
		{
			InitializeComponent();
			idUsuario= id;
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			UsuarioService service = new UsuarioService();

			int estado = chkEstado.Checked ? 1 : 0;

			service.ActualizarUsuario(
				idUsuario,
				txtNombre.Text,
				txtUsuario.Text,
				(int)cmbRol.SelectedValue,
				estado
			);

			MessageBox.Show("Usuario actualizado correctamente");
			this.Close();
		}



		private void panel2_Paint(object sender, PaintEventArgs e)
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

		private void FrmEditarUsuario_Load(object sender, EventArgs e)
		{
			CargarRoles();
			RedondearBoton(btnGuardar, 20);
			RedondearBoton(btnSalir, 20);
			UsuarioService service = new UsuarioService();
			DataRow usuario = service.ObtenerUsuarioPorId(idUsuario);

			txtNombre.Text = usuario["Nombre"].ToString();
			txtUsuario.Text = usuario["Usuario"].ToString();
			cmbRol.SelectedValue = usuario["IdRol"];
			chkEstado.Checked = Convert.ToBoolean(usuario["Estado"]);


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

		private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnmostrar_Click(object sender, EventArgs e)
		{
			txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;

		}

		private void chkEstado_CheckedChanged(object sender, EventArgs e)
		{

		}
	}
}
