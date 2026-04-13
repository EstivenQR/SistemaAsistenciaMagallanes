using iText.Kernel.Pdf.Canvas.Wmf;
using SistemaAsistenciaMagallanes.DAO;
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
	public partial class FrmJustificaciones : Form
	{
		private JustificacionesService service = new JustificacionesService();
		DataTable dtOriginal;
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


        public FrmJustificaciones()
		{
			InitializeComponent();
			Cargar();
		}

		private void FrmJustificaciones_Load(object sender, EventArgs e)
		{
			
			tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
			dgvJustificaciones.Columns["IdJustificacion"].Visible = false;
			dgvJustificaciones.Columns["IdEstudiante"].Visible = false;
			RedondearBoton(btnAprobar, 20);
			RedondearBoton(btnSalir, 20);
			RedondearBoton(btnRechazar, 20);
			ColorCeldas();

		}

		private void Cargar()
		{
			dtOriginal = service.GetTodas();
			dgvJustificaciones.DataSource = dtOriginal;
			txtBuscar.TextChanged += txtBuscar_TextChanged;
			dgvJustificaciones.DataSource = service.GetTodas();
			dgvJustificaciones.Columns["Fecha"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgvJustificaciones.Columns["Estudiante"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgvJustificaciones.Columns["Motivo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgvJustificaciones.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dgvJustificaciones.Columns["Motivo"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
			dgvJustificaciones.Columns["Sección"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgvJustificaciones.Columns["Estado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgvJustificaciones.Columns["Materia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgvJustificaciones.Columns["IdEstudiante"].Visible = false;
			dgvJustificaciones.Columns["IdJustificacion"].Visible = false;





		}

		private void btnAprobar_Click(object sender, EventArgs e)
		{
			if (dgvJustificaciones.CurrentRow == null)
			{
				MessageBox.Show("Seleccione una justificación");
				return;
			}

			var row = dgvJustificaciones.CurrentRow;

			int idJustificacion = Convert.ToInt32(row.Cells["IdJustificacion"].Value);
			int idEstudiante = Convert.ToInt32(row.Cells["IdEstudiante"].Value);
			DateTime fecha = Convert.ToDateTime(row.Cells["Fecha"].Value);

			service.AprobarJustificacion(idJustificacion);

			//NUEVO: actualizar asistencia
			service.MarcarAsistenciaComoJustificada(idEstudiante, fecha);

			MessageBox.Show("Justificación aprobada y aplicada");

			Cargar();
		}

		private void btnRechazar_Click(object sender, EventArgs e)
		{
			if (dgvJustificaciones.CurrentRow == null)
			{
				MessageBox.Show("Seleccione una justificación");
				return;
			}

			int id = Convert.ToInt32(
				dgvJustificaciones.CurrentRow.Cells["IdJustificacion"].Value
			);

			DialogResult confirm = MessageBox.Show(
				"¿Desea rechazar esta justificación?",
				"Confirmar",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning
			);

			if (confirm == DialogResult.Yes)
			{
				service.RechazarJustificacion(id);

				MessageBox.Show("Justificación rechazada");

				Cargar(); 
			}
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

		private void ColorCeldas()
		{
			foreach (DataGridViewRow row in dgvJustificaciones.Rows)
			{
				string estado = row.Cells["Estado"].Value.ToString();

				if (estado == "Pendiente")
					row.DefaultCellStyle.ForeColor = Color.Gray;

				else if (estado == "Aprobado")
					row.DefaultCellStyle.ForeColor = Color.Green;

				else if (estado == "Rechazado")
					row.DefaultCellStyle.ForeColor = Color.Red;
			}
		}

		private void txtBuscar_TextChanged(object sender, EventArgs e)
		{
			string filtro=txtBuscar.Text.Trim();
			filtro = filtro.Replace("'", "''");
			ColorCeldas();

			if (string.IsNullOrEmpty(filtro) || filtro == "Buscar..." )
			{
				dgvJustificaciones.DataSource = null;
				dgvJustificaciones.DataSource = dtOriginal;
				dgvJustificaciones.Columns["IdEstudiante"].Visible = false;
				dgvJustificaciones.Columns["IdJustificacion"].Visible = false;
				ColorCeldas();

			}
			else
			{
				DataView dv = dtOriginal.DefaultView;

				dv.RowFilter = $@"
				Estudiante LIKE '%{filtro}%'
				OR Materia LIKE '%{filtro}%'
				OR Sección LIKE '%{filtro}%'
				OR Motivo LIKE '%{filtro}%'
				";

				dgvJustificaciones.DataSource = dv;
			}
		}

		private void tabPage1_Click(object sender, EventArgs e)
		{

		}

		private void FiltrarEstado(string estado)
		{
			DataView dv = dtOriginal.DefaultView;

			if (string.IsNullOrEmpty(estado))
				dv.RowFilter = "";
			else
				dv.RowFilter = $"Estado = '{estado}'";

			dgvJustificaciones.DataSource = dv;
		}

		private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			string estado = "";

			switch (tabControl.SelectedTab.Name)
			{
				case "tabTodos":
					FiltrarEstado("");
					ColorCeldas();
					return;

				case "tabPendientes":
					estado = "Pendiente";
					ColorCeldas();
					break;

				case "tabAprobadas":
					estado = "Aprobado";
					ColorCeldas();
					break;

				case "tabRechazados":
					estado = "Rechazado";
					ColorCeldas();
					break;
			}

			FiltrarEstado(estado);


		}
	}
}
