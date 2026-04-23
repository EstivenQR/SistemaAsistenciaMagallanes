using SistemaAsistenciaMagallanes.Conexion_BD;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace SistemaAsistenciaMagallanes.Forms
{

	public partial class FrmHome : Form
	{
		bool menuExpandido = false;
		int alturaMaxima = 150;
		ToolTip tooltip = new ToolTip();
		public FrmHome()
		{
			InitializeComponent();
		}

		private void FrmHome_Load(object sender, EventArgs e)
		{
			IniciarTypewriter1("Liceo");
			IniciarTypewriter2("Magallanes");
			Fotter();

			lblUsuario.Text = " Bienvenid@: " + Sesion.Nombre;
			CargarTooltipTareas();
			CargarKPIs();


			if (Sesion.IdRol == 1 || Sesion.IdRol == 2 || Sesion.IdRol == 4)
			{
				BtnAdministracion.Visible = true;
				btnJustificacion.Visible = true;
			}
			else
			{
				BtnAdministracion.Visible = false;
				btnJustificacion.Visible = false;
			}

		}

		Timer timerType1 = new Timer();
		string texto1 = "Liceo ";
		int index1 = 0;
		bool mostrarCursor = true;

		Timer timerType2 = new Timer();
		string texto2 = "Magallanes";
		int index2 = 0;

		private void IniciarTypewriter1(string texto)
		{
			timerType1.Stop();

			texto1 = texto;
			index1 = 0;
			lblMensaje.Text = "";

			timerType1.Interval = 80;
			timerType1.Tick -= TimerType1_Tick;
			timerType1.Tick += TimerType1_Tick;

			timerType1.Start();
		}

		private void IniciarTypewriter2(string texto)
		{
			timerType2.Stop();

			texto2 = texto;
			index2 = 0;
			lblMensaje2.Text = "";

			timerType2.Interval = 80;
			timerType2.Tick -= TimerType2_Tick;
			timerType2.Tick += TimerType2_Tick;

			timerType2.Start();
		}
		private void TimerType1_Tick(object sender, EventArgs e)
		{
			if (index1 < texto1.Length)
			{
				lblMensaje.Text = texto1.Substring(0, index1 + 1) + "|";
				index1++;
			}
			else
			{
				timerType1.Stop();
				lblMensaje.Text = texto1;
			}
		}

		private void TimerType2_Tick(object sender, EventArgs e)
		{
			if (index2 < texto2.Length)
			{
				lblMensaje2.Text = texto2.Substring(0, index2 + 1) + "|";
				index2++;
			}
			else
			{
				timerType2.Stop();
				lblMensaje2.Text = texto2;
			}
		}



		private void CargarKPIs()
		{
			ReportesDAO dao = new ReportesDAO();

			lblTituloAusentes.Text = "Estudiantes Ausentes";
			lblTituloEstudiante.Text = "Total De Estudiantes";
			lblTituloPresentes.Text = "Estudiantes Presentes";
			lblTituloProfesores.Text = "Cantidad De Profesores";


			lblTotalEstudiantes.Text = dao.ObtenerTotalEstudiantes().ToString();
			lblTotalProfesores.Text = dao.ObtenerTotalProfesores().ToString();
			lblPresentes.Text = dao.ObtenerPresentesHoy().ToString();
			lblAusentes.Text = dao.ObtenerAusentesHoy().ToString();
		}

		private void CentrarTabla()
		{

			tableKPIs.Top = (this.ClientSize.Height - tableKPIs.Height) / 2;
			tableKPIs.Top = 350; // ajusta según tu diseño

			panel1.Margin = new Padding(10);
			panel2.Margin = new Padding(10);
			panel3.Margin = new Padding(10);
			panel4.Margin = new Padding(10);
			RedondearPanel(panel1, 20);
			RedondearPanel(panel2, 20);
			RedondearPanel(panel3, 20);
			RedondearPanel(panel4, 20);
		}

		public void RedondearPanel(Panel panel, int radio)
		{
			GraphicsPath path = new GraphicsPath();
			path.StartFigure();

			path.AddArc(new Rectangle(0, 0, radio, radio), 180, 90);
			path.AddArc(new Rectangle(panel.Width - radio, 0, radio, radio), 270, 90);
			path.AddArc(new Rectangle(panel.Width - radio, panel.Height - radio, radio, radio), 0, 90);
			path.AddArc(new Rectangle(0, panel.Height - radio, radio, radio), 90, 90);

			path.CloseFigure();
			panel.Region = new Region(path);
		}

		private void CargarTooltipTareas()
		{
			TareasService service = new TareasService();
			DataTable dt = service.ObtenerTareasHoy(Sesion.IdUsuario);

			if (dt.Rows.Count == 0)
			{
				tooltip.SetToolTip(btnTareas, "No hay tareas para hoy");
				return;
			}

			string mensaje = "";

			foreach (DataRow row in dt.Rows)
			{
				mensaje += "• " + row["NombreSeccion"] + " - " +
						   row["NombreMateria"] +
						   " (" + row["Titulo"] + ")\n";

			}

			tooltip.IsBalloon = true;
			tooltip.ToolTipIcon = ToolTipIcon.Info;
			tooltip.AutoPopDelay = 7000;
			tooltip.ToolTipTitle = "Tareas de hoy";
			tooltip.SetToolTip(btnTareas, mensaje);
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
			frm.ShowDialog();

			CargarKPIs();

		}



		private void btnReportes_Click(object sender, EventArgs e)
		{
			FrmReportes frm = new FrmReportes();
			frm.Show();
		}

		private void btnJustificacion_Click(object sender, EventArgs e)
		{
			FrmJustificaciones frm = new FrmJustificaciones();
			frm.Show();
		}

		private void btnTareas_Click(object sender, EventArgs e)
		{
			FrmTareas frm = new FrmTareas();
			frm.Show();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void FrmHome_Resize(object sender, EventArgs e)
		{
			CentrarTabla();
		}

		private void btnBoletas_Click(object sender, EventArgs e)
		{
			FrmBoletas frm = new FrmBoletas();
			frm.Show();
		}

		public void Fotter()
		{
		
			lblFooter.Text = $"Sistema Asistencia - Magallanes © {DateTime.Now.Year}";
			lblFooter.AutoSize = true;
			lblFooter.Top = 10;
			lblFooter.Left = (panelFooter.Width - lblFooter.Width) / 2;
		}
	}
}
