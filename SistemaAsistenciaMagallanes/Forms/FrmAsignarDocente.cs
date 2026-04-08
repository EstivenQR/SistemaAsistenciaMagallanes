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
			ServiceAsignacionDocente service = new ServiceAsignacionDocente();

			var anios = ObtenerAniosAMostrar();

			DataTable dt = service.ListarSeccionesPorAnios(anios);


			if (dt.Rows.Count == 0)
			{
				MessageBox.Show("No hay datos para esos años");
				return;
			}

			dt.Columns.Add("NombreCompleto", typeof(string));

			foreach (DataRow row in dt.Rows)
			{
				row["NombreCompleto"] = row["NombreSeccion"] + " " + row["Anio"];
			}

			clbSecciones.DataSource = null;
			clbSecciones.DataSource = dt;
			clbSecciones.DisplayMember = "NombreCompleto";
			clbSecciones.ValueMember = "IdSeccion";
		}

		private List<int> ObtenerAniosAMostrar()
		{
			int anio = DateTime.Now.Year;
			int mes = DateTime.Now.Month;

			List<int> anios = new List<int>();

			if (mes == 12)
			{
				// transición (matrícula)
				anios.Add(anio);       // ejemplo 2025-2026
				anios.Add(anio + 1);
				anios.Add(anio + 2);
			}
			else
			{
				// año normal
				anios.Add(anio);
				anios.Add(anio + 1);
			}

			return anios;
		}

		private void CargarMaterias()
		{
			MateriaService service = new MateriaService();
			DataTable dt = service.ListarMaterias("");

			clbMaterias.DataSource = dt;
			clbMaterias.DisplayMember = "Materia";
			clbMaterias.ValueMember = "IdMateria";
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btnAsignar_Click(object sender, EventArgs e)
		{
			try
			{
				if (cmbDocente.SelectedIndex == -1 ||
					clbSecciones.CheckedItems.Count == 0 ||
					clbMaterias.CheckedItems.Count == 0)
				{
					MessageBox.Show("Seleccione docente, al menos una sección y una materia");
					return;
				}

				int idDocente = Convert.ToInt32(cmbDocente.SelectedValue);

				ServiceAsignacionDocente service = new ServiceAsignacionDocente();

				//DOBLE LOOP (SECCIONES + MATERIAS)
				foreach (DataRowView sec in clbSecciones.CheckedItems)
				{
					int idSeccion = Convert.ToInt32(sec["IdSeccion"]);

					foreach (DataRowView mat in clbMaterias.CheckedItems)
					{
						int idMateria = Convert.ToInt32(mat["IdMateria"]);

						service.CrearAsignacion(idDocente, idSeccion, idMateria);
					}
				}

				MessageBox.Show("Asignaciones realizadas correctamente");

				CargarAsignaciones("");

				// limpiar
				cmbDocente.SelectedIndex = -1;

				LimpiarCheckedList(clbSecciones);
				LimpiarCheckedList(clbMaterias);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void LimpiarCheckedList(CheckedListBox clb)
		{
			for (int i = 0; i < clb.Items.Count; i++)
			{
				clb.SetItemChecked(i, false);
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

		private void dgvAsignaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
