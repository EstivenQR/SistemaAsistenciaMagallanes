using SistemaAsistenciaMagallanes.Conexion_BD;
using SistemaAsistenciaMagallanes.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAsistenciaMagallanes.Forms
{
	public partial class FrmJustificar : Form
	{
		int idEstudiante;
		string nombreEstudiante;
		DateTime fecha;

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



        JustificacionesService service = new JustificacionesService();
		public FrmJustificar(int idEstudiante, string nombre, DateTime fecha)
		{
			InitializeComponent();
			this.idEstudiante = idEstudiante;
			this.nombreEstudiante = nombre;
			this.fecha = fecha;
	
		}

		private void FrmJustificar_Load(object sender, EventArgs e)
		{
			txtMotivo.Enter += txtMotivo_Enter;
			txtMotivo.Leave += txtMotivo_Leave;
			txtMotivo.Text = "Escriba el motivo...";
			txtMotivo.ForeColor = Color.Gray;
			lblEstudiante.Text="Estudiante: "+ nombreEstudiante;
			lblFecha.Text = "Fecha: " + fecha.ToShortDateString();
			RedondearBoton(btnGuardar, 20);
			RedondearBoton(btnSalir, 20);


		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtMotivo.Text))
			{
				MessageBox.Show("Ingrese un motivo");
				return;
			}

			service.CrearJustificacion(idEstudiante, fecha, txtMotivo.Text, Sesion.IdUsuario);

			MessageBox.Show("Justificación enviada");
			this.Close();
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();

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

		private void txtMotivo_Enter(object sender, EventArgs e)
		{
			if (txtMotivo.Text == "Escriba el motivo...")
			{
				txtMotivo.Text = "";
				txtMotivo.ForeColor = Color.Black;
			}
		}

		private void txtMotivo_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtMotivo.Text) || txtMotivo.Text == "Escriba el motivo...")
			{
				txtMotivo.Text = "Escriba el motivo...";
				txtMotivo.ForeColor = Color.Gray;
			}
		}

		private void txtMotivo_Leave_1(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtMotivo.Text) || txtMotivo.Text == "Escriba el motivo...")
			{
				txtMotivo.Text = "Escriba el motivo...";
				txtMotivo.ForeColor = Color.Gray;
			}
		}
	}
}
