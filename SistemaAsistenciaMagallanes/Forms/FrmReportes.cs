using SistemaAsistenciaMagallanes.Conexion_BD;
using SistemaAsistenciaMagallanes.Reportes;
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
using System.Windows.Forms.DataVisualization.Charting;

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

			dgvReporte.DataSource = service.FiltrarReportes(idSeccion, idMateria, idEstudiante);

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

			// COLORES
			PintarEstados();

			// RESUMEN
			CalcularResumen(dt);
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
					row.DefaultCellStyle.ForeColor = Color.Red;
				}
				else if (estado == "Tardía")
				{
					row.DefaultCellStyle.ForeColor = Color.Goldenrod; 
				}
				else if (estado == "Presente")
				{
					row.DefaultCellStyle.ForeColor = Color.Green;
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




			double porcentaje = total > 0 ? (presentes * 100) / total : 0;

			AnimarContador(lblTotalCentro, presentes);
			AnimarContador(lblAusenciasCentro, ausentes);
			AnimarContador(lblTotalTardias, tardias);

			// LABELS KPI 
			lblTotalCentro.Text = presentes.ToString();
			lblAusenciasCentro.Text = ausentes.ToString();
			lblTotalTardias.Text=tardias.ToString();

			lblTotalCentro.Font = new Font("Arial", 28, FontStyle.Bold);
			lblTotalTardias.Font = new Font("Arial", 28, FontStyle.Bold);
			lblAusenciasCentro.Font = new Font("Arial", 28, FontStyle.Bold);

			lblTotalCentro.ForeColor = Color.FromArgb(52, 152, 219);   // azul
			lblAusenciasCentro.ForeColor = Color.FromArgb(220, 53, 69); // rojo
			lblTotalTardias.ForeColor = Color.Goldenrod; 

			lblTotalCentro.BackColor = Color.Transparent;
			lblAusenciasCentro.BackColor = Color.Transparent;
			lblAusenciasCentro.BackColor = Color.Transparent;

			lblTotalCentro.TextAlign = ContentAlignment.MiddleCenter;
			lblAusenciasCentro.TextAlign = ContentAlignment.MiddleCenter;
			lblAusenciasCentro.TextAlign = ContentAlignment.MiddleCenter;

			//títulos pequeños
			lblTituloTotal.Text = "Total Presentes";
			lblTituloAusencias.Text = "Ausencias";
			lblTituloTardias.Text = "Tardias";

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
			chartporcentaje.Width = 350;
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


		}

		private void btnPDF_Click(object sender, EventArgs e)
		{
			PdfHelper pdf = new PdfHelper();
			
			pdf.GenerarPDF(
				dgvReporte,
				chartporcentaje.Text,
				lblAusenciasCentro.Text,
				lblTotalCentro.Text
			);
		}

		private void FrmReportes_Load(object sender, EventArgs e)
		{
			CargarSecciones();
			chartporcentaje.ChartAreas[0].BackColor = Color.Transparent;
			pnlAusencia.Visible = false;
			pnlTardias.Visible = false;
			pnlTotal.Visible = false;

		}

		private void CargarSecciones()
		{
			ReportesService service = new ReportesService();

			cmbSeccion.DataSource = service.ObtenerSecciones(Sesion.IdUsuario);
			cmbSeccion.DisplayMember = "NombreSeccion";
			cmbSeccion.ValueMember = "IdSeccion";

			cmbSeccion.SelectedIndex = -1; 
		}

		private void CargarMaterias(int idSeccion)
		{
			ReportesService service = new ReportesService();

			cmbMateria.DataSource = service.ObtenerMaterias(Sesion.IdUsuario, idSeccion);
			cmbMateria.DisplayMember = "NombreMateria";
			cmbMateria.ValueMember = "IdMateria";

			cmbMateria.SelectedIndex = -1;
		}
		private void CargarEstudiantes(int idSeccion)
		{
			ReportesService service = new ReportesService();

			cmbEstudiante.DataSource = service.ObtenerEstudiantes(idSeccion);
			cmbEstudiante.DisplayMember = "NombreCompleto";
			cmbEstudiante.ValueMember = "IdEstudiante";

			cmbEstudiante.SelectedIndex = -1;
		}

		private void cmbSeccion_SelectedIndexChanged(object sender, EventArgs e)
		{

			if (cmbSeccion.SelectedValue == null || cmbSeccion.SelectedValue is DataRowView)
				return;
			
				
				int idSeccion = Convert.ToInt32(cmbSeccion.SelectedValue);

				CargarMaterias(idSeccion);
				CargarEstudiantes(idSeccion);

		}

		private void lblPorcentaje_Click(object sender, EventArgs e)
		{

		}

		private void chartporcentaje_Click(object sender, EventArgs e)
		{

		}
	}
}
