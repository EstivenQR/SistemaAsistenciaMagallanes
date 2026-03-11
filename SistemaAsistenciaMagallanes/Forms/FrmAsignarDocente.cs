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
	public partial class FrmAsignarDocente : Form
	{
		public FrmAsignarDocente()
		{
			InitializeComponent();
		}

		private void FrmAsignarDocente_Load(object sender, EventArgs e)
		{
			

			CargarDocentes();
			CargarSecciones();
			CargarMaterias();
			CargarAsignaciones("");
		}

		private void CargarAsignaciones(string buscar)
		{
			ServiceAsignacionDocente service = new ServiceAsignacionDocente();
			dgvAsignaciones.DataSource = service.ListarAsignaciones(buscar);

			dgvAsignaciones.Columns["IdAsignacion"].Visible = false;
		}

		private void CargarDocentes()
		{
			UsuarioService service = new UsuarioService();

			cmbDocente.DataSource = service.ListarUsuarios("", false);
			cmbDocente.DisplayMember = "Nombre";
			cmbDocente.ValueMember = "IdUsuario";
		}

		private void CargarSecciones()
		{
			SeccionesService service = new SeccionesService();

			cmbSeccion.DataSource = service.ListarSecciones("");
			cmbSeccion.DisplayMember = "Sección";
			cmbSeccion.ValueMember = "IdSeccion";
		}

		private void CargarMaterias()
		{
			MateriaService service = new MateriaService();

			cmbMateria.DataSource = service.ListarMaterias("");
			cmbMateria.DisplayMember = "Materia";
			cmbMateria.ValueMember = "IdMateria";
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btnAsignar_Click(object sender, EventArgs e)
		{
			try
			{
				if (cmbDocente.SelectedIndex == -1 ||
					cmbSeccion.SelectedIndex == -1 ||
					cmbMateria.SelectedIndex == -1)
				{
					MessageBox.Show("Debe seleccionar docente, sección y materia");
					return;
				}

				int idDocente = Convert.ToInt32(cmbDocente.SelectedValue);
				int idSeccion = Convert.ToInt32(cmbSeccion.SelectedValue);
				int idMateria = Convert.ToInt32(cmbMateria.SelectedValue);

				ServiceAsignacionDocente service = new ServiceAsignacionDocente();

				service.CrearAsignacion(idDocente, idSeccion, idMateria);

				MessageBox.Show("Asignación realizada correctamente");

				CargarAsignaciones("");

				cmbDocente.SelectedIndex = -1;
				cmbSeccion.SelectedIndex = -1;
				cmbMateria.SelectedIndex = -1;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (dgvAsignaciones.SelectedRows.Count == 0)
			{
				MessageBox.Show("Seleccione una asignación para eliminar");
				return;
			}

			DialogResult resultado = MessageBox.Show(
				"¿Está seguro de eliminar esta asignación?",
				"Confirmar",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning);

			if (resultado == DialogResult.Yes)
			{
				int idAsignacion = Convert.ToInt32(
					dgvAsignaciones.SelectedRows[0].Cells["IdAsignacion"].Value
				);

				ServiceAsignacionDocente service = new ServiceAsignacionDocente();
				service.EliminarAsignacion(idAsignacion);

				MessageBox.Show("Asignación eliminada correctamente");

				CargarAsignaciones("");
			}
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void txtbuscar_TextChanged(object sender, EventArgs e)
		{
			CargarAsignaciones(txtbuscar.Text);
		}

		private void btnbuscar_Click(object sender, EventArgs e)
		{

		}
	}
}
