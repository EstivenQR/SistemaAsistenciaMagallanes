using SistemaAsistenciaMagallanes.Conexion_BD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SistemaAsistenciaMagallanes.Forms
{

	public partial class FrmHome : Form
	{
		bool menuExpandido = false;
		int alturaMaxima = 150;
		public FrmHome()
		{
			InitializeComponent();
		}

		private void FrmHome_Load(object sender, EventArgs e)
		{
			lblUsuario.Text = " Bienvenid@: " + Sesion.Nombre;

			if (Sesion.IdRol == 1 || Sesion.IdRol == 2 || Sesion.IdRol == 4)
			{
				BtnAdministracion.Visible = true;
			}
			else
			{
				BtnAdministracion.Visible = false;
			}

		}

		private void timerMenu_Tick(object sender, EventArgs e)
		{
			if (menuExpandido == false)
			{
				panelAdminSubmenu.Height += 16;

				if (panelAdminSubmenu.Height >= alturaMaxima)
				{
					timerMenu.Stop();
					menuExpandido = true;
				}
			}
			else
			{
				panelAdminSubmenu.Height -= 16;

				if (panelAdminSubmenu.Height <= 0)
				{
					timerMenu.Stop();
					menuExpandido = false;
				}
			}
		}

		private void BtnAdministracion_Click(object sender, EventArgs e)
		{
			timerMenu.Start();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void btnUsuarios_Click(object sender, EventArgs e)
		{
			FrmUsuarios frm = new FrmUsuarios();
			frm.Show();
		}


		private void btnAsistencia_Click(object sender, EventArgs e)
		{
			timerMenu.Start();
		}

		private void panelLogo_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnMaterias_Click(object sender, EventArgs e)
		{
			FrmMaterias frm = new FrmMaterias();
			frm.Show();
		}

		private void btnSecciones_Click(object sender, EventArgs e)
		{
			{
				FrmSecciones frm = new FrmSecciones();
				frm.Show();
			}
		}


		private void btnEstudiantes_Click(object sender, EventArgs e)
		{
			FrmEstudiantes frm = new FrmEstudiantes();
			frm.Show();
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{

			DialogResult respuesta = MessageBox.Show(
				   "¿Desea cerrar sesión?",
				   "Cerrar sesión",
				   MessageBoxButtons.YesNo,
				   MessageBoxIcon.Question
			   );

			if (respuesta == DialogResult.Yes)
			{
				Sesion.IdUsuario = 0;
				Sesion.Nombre = "";
				Sesion.IdRol = 0;

				FrmLogin login = new FrmLogin();
				login.Show();

				this.Close();
			}
		}

		private void panelMenu_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnAsistencia_Click_1(object sender, EventArgs e)
		{

			FrmAsistencia frm = new FrmAsistencia();
			frm.Show();

		}
	}
}
