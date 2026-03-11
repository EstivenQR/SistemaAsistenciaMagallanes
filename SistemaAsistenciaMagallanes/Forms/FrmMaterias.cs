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

namespace SistemaAsistenciaMagallanes.Forms
{
	public partial class FrmMaterias : Form
	{
		public FrmMaterias()
		{
			InitializeComponent();
		}

		private void FrmMaterias_Load(object sender, EventArgs e)
		{
			CargarMaterias("");
			dgvMaterias.Columns["IdMateria"].Visible = false;

			RedondearBoton(btnbuscar, 20);
			RedondearBoton(btnAgregar, 20);
			RedondearBoton(btnEliminar, 20);
			RedondearBoton(btnSalir, 20);

		}
		private void CargarMaterias(string buscar)
		{
			MateriaService service = new MateriaService();
			dgvMaterias.DataSource = service.ListarMaterias(buscar);
			dgvMaterias.Columns["Materia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgvMaterias.Columns["Materia"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

		}

		private void txtbuscar_TextChanged(object sender, EventArgs e)
		{
			CargarMaterias(txtbuscar.Text);
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			MateriaService service = new MateriaService();

			service.CrearMateria(txtNombre.Text);

			MessageBox.Show("Materia agregada correctamente");

			CargarMaterias("");
			txtNombre.Clear();
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

		private void chkEstado_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void btnEliminar_Click_1(object sender, EventArgs e)
		{
			if (dgvMaterias.SelectedRows.Count > 0)
			{
				int idMateria = Convert.ToInt32(dgvMaterias.SelectedRows[0].Cells["IdMateria"].Value);

				MateriaService service = new MateriaService();
				service.EliminarMateria(idMateria);

				MessageBox.Show("Materia eliminada");

				CargarMaterias("");
			}
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
