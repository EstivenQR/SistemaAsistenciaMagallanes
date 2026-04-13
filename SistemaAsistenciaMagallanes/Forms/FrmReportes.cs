using SistemaAsistenciaMagallanes.Conexion_BD;
using SistemaAsistenciaMagallanes.Reportes;
using SistemaAsistenciaMagallanes.Services;
using SistemaAsistenciaMagallanes.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.MonthCalendar;

namespace SistemaAsistenciaMagallanes.Forms
{
	public partial class FrmReportes : Form
	{
		public FrmReportes()
		{
			InitializeComponent();
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			ReportesService service = new ReportesService();

			int? idEstudiante = null;
			int? idSeccion = null;
			int? idMateria = null;
			DateTime? desde = null;
			DateTime? hasta = null;

			// VALIDAR COMBOS 
			if (cmbEstudiante.SelectedValue != null && Convert.ToInt32(cmbEstudiante.SelectedValue) != 0)
				idEstudiante = Convert.ToInt32(cmbEstudiante.SelectedValue);

			if (cmbSeccion.SelectedValue != null && Convert.ToInt32(cmbSeccion.SelectedValue) != 0)
				idSeccion = Convert.ToInt32(cmbSeccion.SelectedValue);

			if (cmbMateria.SelectedValue != null && Convert.ToInt32(cmbMateria.SelectedValue) != 0)
				idMateria = Convert.ToInt32(cmbMateria.SelectedValue);

			// Fechas 
			desde = dtpDesde.Value.Date;
			hasta = dtpHasta.Value.Date;

			// CONSULTA
			DataTable dt = service.ObtenerReporte(idEstudiante, idSeccion, idMateria, desde, hasta);

			dgvReporte.DataSource = dt;
			dgvReporte.Columns["IdEstudiante"].Visible = false;

			// COLORES
			PintarEstados();

			// RESUMEN
			CalcularResumen(dt);
			var dtTareas = service.ObtenerReporteTareas(idSeccion, idMateria, desde, hasta, Sesion.IdUsuario);
			CalcularResumenTareas(dtTareas);
		}

		private void AnimarContador(Label lbl, int valorFinal)
		{
			int valorActual = 0;

			Timer timer = new Timer();
			timer.Interval = 30;

			timer.Tick += (s, e) =>
			{
				if (valorActual < valorFinal)
				{
					valorActual += Math.Max(1, valorFinal / 20);

					if (valorActual > valorFinal)
						valorActual = valorFinal;

					lbl.Text = valorActual.ToString();
				}
				else
				{
					timer.Stop();
					timer.Dispose();
				}
			};

			timer.Start();
		}

		private void PintarEstados()
		{
			foreach (DataGridViewRow row in dgvReporte.Rows)
			{
				string estado = row.Cells["Estado"].Value.ToString();

				if (estado == "Ausente")
				{
					row.DefaultCellStyle.BackColor = Color.Red;
					row.DefaultCellStyle.ForeColor = Color.White;
				}
				else if (estado == "Tardía")
				{
					row.DefaultCellStyle.BackColor = Color.Goldenrod;
					row.DefaultCellStyle.ForeColor = Color.White;
				}
				else if (estado == "Presente")
				{
					row.DefaultCellStyle.BackColor = Color.Green;
					row.DefaultCellStyle.ForeColor = Color.White;
				}
				else if (estado == "Justificado")
				{
					row.DefaultCellStyle.BackColor = Color.Blue;
					row.DefaultCellStyle.ForeColor = Color.White;
				}
			}
		}

		private void CalcularResumen(DataTable dt)
		{
			int total = dt.Rows.Count;

			int presentes = dt.AsEnumerable()
				.Count(r => r["Estado"].ToString() == "Presente");

			int ausentes = dt.AsEnumerable()
				.Count(r => r["Estado"].ToString() == "Ausente");

			int tardias = dt.AsEnumerable()
				.Count(r => r["Estado"].ToString() == "Tardía");

			int justificadas = dt.AsEnumerable()
				.Count(r => r["Estado"].ToString() == "Justificado");




			double porcentaje = total > 0 ? (presentes * 100) / total : 0;

			AnimarContador(lblTotalCentro, presentes);
			AnimarContador(lblAusenciasCentro, ausentes);
			AnimarContador(lblTotalTardias, tardias);
			AnimarContador(lblTotalJustificado, justificadas);

			// LABELS KPI 
			lblTotalCentro.Text = presentes.ToString();
			lblAusenciasCentro.Text = ausentes.ToString();
			lblTotalTardias.Text=tardias.ToString();
			lblTotalJustificado.Text=justificadas.ToString();

			lblTotalCentro.Font = new Font("Arial", 28, FontStyle.Bold);
			lblTotalTardias.Font = new Font("Arial", 28, FontStyle.Bold);
			lblAusenciasCentro.Font = new Font("Arial", 28, FontStyle.Bold);
			lblTotalJustificado.Font = new Font("Arial", 28, FontStyle.Bold);

			lblTotalCentro.ForeColor = Color.FromArgb(52, 152, 219);   // azul
			lblAusenciasCentro.ForeColor = Color.FromArgb(220, 53, 69); // rojo
			lblTotalTardias.ForeColor = Color.Goldenrod;
			lblTotalJustificado.ForeColor = Color.Blue;

			lblTotalCentro.BackColor = Color.Transparent;
			lblAusenciasCentro.BackColor = Color.Transparent;
			lblAusenciasCentro.BackColor = Color.Transparent;
			lblTotalJustificado.BackColor= Color.Transparent;

			lblTotalCentro.TextAlign = ContentAlignment.MiddleCenter;
			lblAusenciasCentro.TextAlign = ContentAlignment.MiddleCenter;
			lblAusenciasCentro.TextAlign = ContentAlignment.MiddleCenter;
			lblTotalJustificado.TextAlign= ContentAlignment.MiddleCenter;

			//títulos pequeños
			lblTituloTotal.Text = "Total Presentes";
			lblTituloAusencias.Text = "Ausencias";
			lblTituloTardias.Text = "Tardias";
			lblJustificado.Text = "Justificadas";

			//LIMPIA el chart antes de cargar datos
			chartporcentaje.Series.Clear();


			// Crear nueva serie
			Series serie = new Series("Asistencia");
			chartporcentaje.BackColor = Color.Transparent;
			chartporcentaje.ChartAreas[0].BackColor = Color.Transparent;
			chartporcentaje.BorderlineColor = Color.Transparent;
			chartporcentaje.BorderlineWidth = 0;
			chartporcentaje.Legends[0].BackColor = Color.Transparent;
			chartporcentaje.AntiAliasing = AntiAliasingStyles.All;
			chartporcentaje.TextAntiAliasingQuality = TextAntiAliasingQuality.High;
			chartporcentaje.Width = 400;
			chartporcentaje.Height = 200;
			serie.IsValueShownAsLabel = false;

			serie.ChartType = SeriesChartType.Doughnut;
			serie["DoughnutRadius"] = "75";
			serie["PieLabelStyle"] = "Outside";
			serie.Font = new Font("Arial", 8, FontStyle.Bold);
			serie.IsValueShownAsLabel = false;
			serie.SmartLabelStyle.AllowOutsidePlotArea = LabelOutsidePlotAreaStyle.Yes;
			serie.SmartLabelStyle.IsOverlappedHidden = false;

			chartporcentaje.ChartAreas[0].Position = new ElementPosition(3, 3, 94, 94);
			chartporcentaje.ChartAreas[0].InnerPlotPosition = new ElementPosition(10, 10, 80, 80);
			chartporcentaje.Legends[0].Docking = Docking.Right;
			chartporcentaje.Legends[0].Alignment = StringAlignment.Center;
			chartporcentaje.ChartAreas[0].BorderWidth = 0;
			chartporcentaje.BorderlineDashStyle = ChartDashStyle.NotSet;
			chartporcentaje.Legends[0].Enabled = false;

			serie.SmartLabelStyle.Enabled = true;
			serie.IsValueShownAsLabel = false;

			// Tamaño del texto
			serie.Font = new Font("Arial", 7, FontStyle.Bold);

			// AGREGAR SOLO SI > 0
			if (presentes > 0)
			{
				var p = serie.Points.AddXY("Presentes", presentes);
				serie.Points[p].Color = Color.FromArgb(40, 167, 69); // verde
			}

			if (ausentes > 0)
			{
				var p = serie.Points.AddXY("Ausentes", ausentes);
				serie.Points[p].Color = Color.FromArgb(220, 53, 69); // rojo
			}

			if (tardias > 0)
			{
				var p = serie.Points.AddXY("Tardías", tardias);
				serie.Points[p].Color = Color.FromArgb(255, 193, 7); // amarillo
			}


			// Texto mostrado
			serie.Label = "#VALX\n#PERCENT";

			// Leyenda
			chartporcentaje.Legends[0].Font = new Font("Arial", 8);
			chartporcentaje.ChartAreas[0].Position = new ElementPosition(5, 5, 90, 90);


			chartporcentaje.Series.Clear();
			chartporcentaje.Series.Add(serie);

			pnlAusencia.Visible = true;
			pnlTardias.Visible = true;
			pnlTotal.Visible = true;
			pnlJustificado.Visible = true;

		}

		private void CalcularResumenTareas(DataTable dt)
		{


					int total = dt.AsEnumerable()
				.Select(r => r["IdTarea"])
				.Distinct()
				.Count();

					int entregados = dt.AsEnumerable()
				.Count(r => Convert.ToDecimal(r["Porcentaje"]) > 0);



					int noEntregados = dt.AsEnumerable()
				.Count(r => Convert.ToDecimal(r["Porcentaje"]) == 0);


			// PROMEDIO
			decimal promedio = dt.Rows.Count > 0
				? dt.AsEnumerable().Average(r => Convert.ToDecimal(r["Porcentaje"]))
				: 0;

			// ANIMACIONES
			AnimarContador(lblTotalTareas, total);
			AnimarContador(lblEntregados, entregados);
			AnimarContador(lblNoEntregados, noEntregados);
			AnimarContador(lblPromedio, (int)Math.Round(promedio));

			// TEXTOS
			lblTotalTareas.Text = total.ToString();
			lblEntregados.Text = entregados.ToString();
			lblNoEntregados.Text = noEntregados.ToString();
			lblPromedio.Text = promedio.ToString("0") + "%";

			// ESTILOS
			lblTotalTareas.Font = new Font("Arial", 28, FontStyle.Bold);
			lblEntregados.Font = new Font("Arial", 28, FontStyle.Bold);
			lblNoEntregados.Font = new Font("Arial", 28, FontStyle.Bold);
			lblPromedio.Font = new Font("Arial", 28, FontStyle.Bold);

			lblTotalTareas.ForeColor = Color.Black;
			lblEntregados.ForeColor = Color.FromArgb(40, 167, 69); // verde
			lblNoEntregados.ForeColor = Color.FromArgb(220, 53, 69); // rojo
			lblPromedio.ForeColor = Color.FromArgb(52, 152, 219); // azul

			lblTotalTareas.TextAlign = ContentAlignment.MiddleCenter;
			lblEntregados.TextAlign = ContentAlignment.MiddleCenter;
			lblNoEntregados.TextAlign = ContentAlignment.MiddleCenter;
			lblPromedio.TextAlign = ContentAlignment.MiddleCenter;

			lblTituloTotalTareas.Text = "Total de Tareas";
			lblTituloEntregados.Text = "Entregados";
			lblTituloNoEntregados.Text = "No entregados";
			lblTituloPromedio.Text = "Promedio";

			//MOSTRAR PANELES
			pnlTareas.Visible = true;
			pnlNoEntregados.Visible = true;
			pnlPromedio.Visible = true;
			pnlEntregados.Visible = true;
		}



		private void btnPDF_Click(object sender, EventArgs e)
		{
			PdfHelper pdf = new PdfHelper();
			ReportesService service = new ReportesService();

			if (dgvReporte.Columns.Contains("IdEstudiante"))
				dgvReporte.Columns["IdEstudiante"].Visible = false;

			int? idSeccion = cmbSeccion.SelectedValue != null ? (int?)Convert.ToInt32(cmbSeccion.SelectedValue) : null;
			int? idMateria = cmbMateria.SelectedValue != null ? (int?)Convert.ToInt32(cmbMateria.SelectedValue) : null;
			int? idEstudiante = cmbEstudiante.SelectedValue != null ? (int?)Convert.ToInt32(cmbEstudiante.SelectedValue) : null;


			DataTable dtTareas = service.ObtenerReporteTareas(idSeccion, idMateria, idEstudiante);


			try
			{
				pdf.GenerarPDF(
					dgvReporte,
					dtTareas,
					lblTotalCentro.Text,
					lblAusenciasCentro.Text,
					lblTotalTardias.Text,
					lblTotalJustificado.Text,
					cmbEstudiante.Text,
					cmbSeccion.Text
				);
			}
			catch (IOException)
			{
				MessageBox.Show(
				"El archivo PDF está abierto. Por favor ciérrelo antes de generar uno nuevo.",
				"Archivo en uso",
		MessageBoxButtons.OK,
		MessageBoxIcon.Warning
				);
			}
			catch (Exception ex)
			{
				MessageBox.Show(
					"Ocurrió un error al generar el PDF:\n" + ex.Message,
					"Error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
			}
		}

		private void FrmReportes_Load(object sender, EventArgs e)
		{
			if (Sesion.IdRol == 1 || Sesion.IdRol == 2 || Sesion.IdRol == 4)
			{
				btnJustificarSeleccionado.Visible = true;
			}
			else
			{
				btnJustificarSeleccionado.Visible = false;
			}
			CargarSecciones();
			chartporcentaje.ChartAreas[0].BackColor = Color.Transparent;
			pnlAusencia.Visible = false;
			pnlTareas.Visible = false;
			pnlTardias.Visible = false;
			pnlTotal.Visible = false;
			pnlJustificado.Visible = false;
			pnlTareas.Visible = false;
			pnlNoEntregados.Visible = false;
			pnlPromedio.Visible = false;
			pnlEntregados.Visible=false;


			RedondearBoton(btnBuscar, 20);
			RedondearBoton(btnSalir, 20);
			RedondearBoton(btnExcel, 20);
			RedondearBoton(btnPDF, 20);
			RedondearBoton(btnSalir, 20);
			RedondearBoton(btnJustificarSeleccionado, 20);

		}

		private void CargarSecciones()
		{
			ReportesService service = new ReportesService();

			//Agregar opción por defecto
			DataTable dt = service.ObtenerSecciones(Sesion.IdUsuario);

			DataRow fila = dt.NewRow();
			fila["IdSeccion"] = 0;
			fila["NombreSeccion"] = "-- Seleccione una sección --";
			dt.Rows.InsertAt(fila, 0);

			cmbSeccion.DataSource = dt;
			cmbSeccion.DisplayMember = "NombreSeccion";
			cmbSeccion.ValueMember = "IdSeccion";

		}

		private void CargarMaterias(int idSeccion)
		{
			ReportesService service = new ReportesService();

			DataTable dt = service.ObtenerMaterias(Sesion.IdUsuario, idSeccion);

			DataRow fila = dt.NewRow();
			fila["IdMateria"] = 0;
			fila["NombreMateria"] = "-- Seleccione una Materia --";
			dt.Rows.InsertAt(fila, 0);

			cmbMateria.DataSource = dt;
			cmbMateria.DisplayMember = "NombreMateria";
			cmbMateria.ValueMember = "IdMateria";
		}
		private void CargarEstudiantes(int idSeccion)
		{
			ReportesService service = new ReportesService();

			DataTable dt = service.ObtenerEstudiantes(idSeccion);

			DataRow fila = dt.NewRow();
			fila["IdEstudiante"] = 0;
			fila["NombreCompleto"] = "-- Seleccione un Estudiante --";
			dt.Rows.InsertAt(fila, 0);

			cmbEstudiante.DataSource = dt;
			cmbEstudiante.DisplayMember = "NombreCompleto";
			cmbEstudiante.ValueMember = "IdEstudiante";

	
		}

		private void cmbSeccion_SelectedIndexChanged(object sender, EventArgs e)
		{

			if (cmbSeccion.SelectedValue == null || cmbSeccion.SelectedValue is DataRowView)
				return;
			
				
				int idSeccion = Convert.ToInt32(cmbSeccion.SelectedValue);

				CargarMaterias(idSeccion);
				CargarEstudiantes(idSeccion);

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

		private void lblPorcentaje_Click(object sender, EventArgs e)
		{

		}

		private void chartporcentaje_Click(object sender, EventArgs e)
		{

		}

		private void pnlBotones_Paint(object sender, PaintEventArgs e)
		{

		}

		private void cmbEstudiante_SelectionChangeCommitted(object sender, EventArgs e)
		{
		
		}

		private void btnJustificarSeleccionado_Click(object sender, EventArgs e)
		{
			if (dgvReporte.CurrentRow == null)
			{
				MessageBox.Show("Seleccione una fila");
				return;
			}

			var row = dgvReporte.CurrentRow;

			string estado = row.Cells["Estado"].Value.ToString();

			// VALIDACIÓN
			if (estado != "Ausente" && estado != "Tardía")
			{
				MessageBox.Show("Solo se pueden justificar ausencias o tardías");
				return;
			}

			int idEstudiante = Convert.ToInt32(row.Cells["IdEstudiante"].Value);
			DateTime fecha = Convert.ToDateTime(row.Cells["Fecha"].Value);

			// ABRIR FORM
			string nombre = row.Cells["Estudiante"].Value.ToString();
			FrmJustificar frm = new FrmJustificar(idEstudiante,nombre, fecha);
			frm.ShowDialog();
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnExcel_Click(object sender, EventArgs e)
		{
			ExcelHelper excel = new ExcelHelper();

			excel.ExportarExcel(
			dgvReporte,
			int.Parse(lblTotalCentro.Text),
			int.Parse(lblAusenciasCentro.Text),
			int.Parse(lblTotalTardias.Text),
			int.Parse(lblTotalJustificado.Text)
			);
		}

		private void lblPromedio_Click(object sender, EventArgs e)
		{

		}

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbEstudiante_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Resize(object sender, EventArgs e)
        {
            tableLayoutPanel2.Left = (panel2.Width - tableLayoutPanel2.Width) / 2;
            tableLayoutPanel2.Left = (this.ClientSize.Width - tableLayoutPanel2.Width) / 2;
            tableLayoutPanel2.Top = (panel2.Height - tableLayoutPanel2.Height) / 2;
        }

		private void tableLayoutPanel2_Resize(object sender, EventArgs e)
		{

		}

		private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void pictureBox10_Click(object sender, EventArgs e)
		{

		}
	}
}
