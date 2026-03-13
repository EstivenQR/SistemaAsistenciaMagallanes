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
using System.Runtime.InteropServices;
using SistemaAsistenciaMagallanes.Services;


namespace SistemaAsistenciaMagallanes.Forms
{
	public partial class FrmLogin : Form
	{

		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
		private static extern IntPtr CreateRoundRectRgn
(
		int nLeftRect,
		int nTopRect,
		int nRightRect,
		int nBottomRect,
		int nWidthEllipse,
		int nHeightEllipse
);
		public FrmLogin()
		{
			InitializeComponent();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void FrmLogin_Load(object sender, EventArgs e)
		{
			this.Opacity = 0;
			timer1.Start();
			panelLogin.Top = 300;
			timer2.Start();
			txtUsuario.Text = "Usuario";
			txtUsuario.ForeColor = Color.Gray;
			txtPassword.Text = "Contraseña";
			txtPassword.ForeColor = Color.Gray;
			txtPassword.UseSystemPasswordChar = false;
			BordesRedondos(panelLogin);
			btnLogin.Region = System.Drawing.Region.FromHrgn(
			CreateRoundRectRgn(0, 0, btnLogin.Width, btnLogin.Height, 20, 20));
			btnSalir.Region = System.Drawing.Region.FromHrgn(
			CreateRoundRectRgn(0, 0, btnSalir.Width, btnSalir.Height, 20, 20));


		}

		

		public void BordesRedondos(Panel panel)
		{
			GraphicsPath path = new GraphicsPath();
			int radius = 20;

			path.AddArc(0, 0, radius, radius, 180, 90);
			path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
			path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);
			path.AddArc(0, panel.Height - radius, radius, radius, 90, 90);
			path.CloseAllFigures();

			panel.Region = new Region(path);
		}


		private void btnLogin_Click(object sender, EventArgs e)
		{
			UsuarioService service = new UsuarioService();

			bool acceso = service.Login(txtUsuario.Text, txtPassword.Text);

			if (acceso)
			{
				FrmHome menu = new FrmHome();
				menu.Show();

				this.Hide();
			}
			else
			{
				MessageBox.Show("Usuario o contraseña incorrectos");
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (this.Opacity < 1)
			{
				this.Opacity += 0.05;
			}
			else
			{
				timer1.Stop();
			}
		}

		private void timer2_Tick(object sender, EventArgs e)
		{
			if (panelLogin.Top > 210)
			{
				panelLogin.Top -= 3;
			}
			else
			{
				timer2.Stop();
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtUsuario_Enter(object sender, EventArgs e)
		{
			if (txtUsuario.Text == "Usuario")
			{
				txtUsuario.Text = "";
				txtUsuario.ForeColor = Color.Black;
			}
		}

		private void txtUsuario_Leave(object sender, EventArgs e)
		{
			if (txtUsuario.Text == "")
			{
				txtUsuario.Text = "Usuario";
				txtUsuario.ForeColor = Color.Gray;
			}
		}

		private void textBox2_Enter(object sender, EventArgs e)
		{
			if (txtPassword.Text == "Contraseña")
			{
				txtPassword.Text = "";
				txtPassword.ForeColor = Color.Black;
				txtPassword.UseSystemPasswordChar = true;
			}
		}

		private void txtPassword_Leave(object sender, EventArgs e)
		{
			if (txtPassword.Text == "")
			{
				txtPassword.UseSystemPasswordChar = false;
				txtPassword.Text = "Contraseña";
				txtPassword.ForeColor = Color.Gray;
			}
		}

		private void txtPassword_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			Application.Exit();	
		}
	}
}
