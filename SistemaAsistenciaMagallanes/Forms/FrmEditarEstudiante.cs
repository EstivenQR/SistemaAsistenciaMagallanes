using SistemaAsistenciaMagallanes.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAsistenciaMagallanes.Forms
{
	public partial class FrmEditarEstudiante : Form
	{
		public int IdEstudiante;
		public string Cedula;
		public string Nombre;
		public string Apellido;
		public DateTime FechaNacimiento;
		public string NumeroEncargado;
		public int IdSeccion;
		public bool Estado;
		public FrmEditarEstudiante()
		{
			InitializeComponent();
		}

		private void CargarSecciones()
		{
			SeccionesService service = new SeccionesService();

			cmbSeccion.DataSource = service.ListarSecciones("");

			cmbSeccion.DisplayMember = "Sección";
			cmbSeccion.ValueMember = "IdSeccion";
		}

		private void panel3_Paint(object sender, PaintEventArgs e)
		{

		}

		private void EditarEstudiante_Load(object sender, EventArgs e)
		{
			CargarSecciones();
			txtCedula.Text = Cedula;
			txtNombre.Text = Nombre;
			txtApellido.Text = Apellido;
			dtpFechaNacimiento.Value = FechaNacimiento;
			txtNumeroEncargado.Text = NumeroEncargado;
			cmbSeccion.SelectedValue = IdSeccion;
			chkEstado.Checked = Estado;


		}

		private void LimpiarCampos()
		{
			txtCedula.Clear();
			txtNombre.Clear();
			txtApellido.Clear();
			txtNumeroEncargado.Clear();
		}


		private void btnGuardar_Click(object sender, EventArgs e)
		{
			EstudiantesService service = new EstudiantesService();

			bool estado = chkEstado.Checked;

			service.EditarEstudiante(
				IdEstudiante,
				txtCedula.Text,
				txtNombre.Text,
				txtApellido.Text,
				dtpFechaNacimiento.Value,
				txtNumeroEncargado.Text,
				Convert.ToInt32(cmbSeccion.SelectedValue),
				estado
			);

			MessageBox.Show("Estudiante actualizado");
			LimpiarCampos();
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
