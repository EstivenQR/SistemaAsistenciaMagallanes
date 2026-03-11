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
	}
}
