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
	public partial class FrmSecciones : Form
	{
		public FrmSecciones()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{
			
		}

		private void CargarSecciones(string buscar)
		{
			SeccionesService service = new SeccionesService();
			dgvSecciones.DataSource = service.ListarSecciones(buscar);

		}

		private void FrmSecciones_Load(object sender, EventArgs e)
		{
			CargarSecciones("");
			dgvSecciones.Columns["IdSeccion"].Visible = false;
			RedondearBoton(btnbuscar, 20);
			RedondearBoton(btnAgregar, 20);
			RedondearBoton(btnEliminar, 20);
			RedondearBoton(btnSalir, 20);
			RedondearBoton(btnAsignar, 20);

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

		private void txtbuscar_TextChanged(object sender, EventArgs e)
		{
			CargarSecciones(txtbuscar.Text);
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			SeccionesService service = new SeccionesService();

			string nombre = txtNombre.Text;
			int anio = Convert.ToInt32(txtAnio.Text);

			service.CrearSeccion(nombre, anio);

			MessageBox.Show("Sección agregada correctamente");
			CargarSecciones("");

			txtNombre.Clear();
			txtAnio.Clear();
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (dgvSecciones.SelectedRows.Count > 0)
			{
				int idSeccion = Convert.ToInt32(dgvSecciones.SelectedRows[0].Cells["IdSeccion"].Value);

				SeccionesService service = new SeccionesService();
				service.EliminarSeccion(idSeccion);

				MessageBox.Show("Sección eliminada");

				CargarSecciones("");
			}
		}

		private void btnAsignar_Click(object sender, EventArgs e)
		{
			FrmAsignarDocente frm = new FrmAsignarDocente();
			frm.ShowDialog();
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();	
		}
	}
}
