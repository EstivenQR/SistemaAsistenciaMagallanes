namespace SistemaAsistenciaMagallanes.Forms
{
	partial class FrmReportes
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportes));
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dtpHasta = new System.Windows.Forms.DateTimePicker();
			this.dtpDesde = new System.Windows.Forms.DateTimePicker();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.cmbMateria = new System.Windows.Forms.ComboBox();
			this.cmbSeccion = new System.Windows.Forms.ComboBox();
			this.cmbEstudiante = new System.Windows.Forms.ComboBox();
			this.pnlResumen = new System.Windows.Forms.Panel();
			this.dgvReporte = new System.Windows.Forms.DataGridView();
			this.pnlBotones = new System.Windows.Forms.Panel();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnExcel = new System.Windows.Forms.Button();
			this.btnPDF = new System.Windows.Forms.Button();
			this.chartporcentaje = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.lblTotalCentro = new System.Windows.Forms.Label();
			this.lblAusenciasCentro = new System.Windows.Forms.Label();
			this.lblTituloTotal = new System.Windows.Forms.Label();
			this.lblTituloAusencias = new System.Windows.Forms.Label();
			this.lblTotalTardias = new System.Windows.Forms.Label();
			this.lblTituloTardias = new System.Windows.Forms.Label();
			this.pnlTotal = new System.Windows.Forms.Panel();
			this.pnlAusencia = new System.Windows.Forms.Panel();
			this.pnlTardias = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.pnlResumen.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
			this.pnlBotones.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartporcentaje)).BeginInit();
			this.pnlTotal.SuspendLayout();
			this.pnlAusencia.SuspendLayout();
			this.pnlTardias.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Orange;
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1189, 100);
			this.panel1.TabIndex = 2;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(164, 100);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
			this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label1.Location = new System.Drawing.Point(392, 18);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.label1.Size = new System.Drawing.Size(350, 67);
			this.label1.TabIndex = 1;
			this.label1.Text = "REPORTES      ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.dtpHasta);
			this.panel2.Controls.Add(this.dtpDesde);
			this.panel2.Controls.Add(this.btnBuscar);
			this.panel2.Controls.Add(this.cmbMateria);
			this.panel2.Controls.Add(this.cmbSeccion);
			this.panel2.Controls.Add(this.cmbEstudiante);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 100);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1189, 126);
			this.panel2.TabIndex = 3;
			// 
			// dtpHasta
			// 
			this.dtpHasta.Location = new System.Drawing.Point(472, 76);
			this.dtpHasta.Name = "dtpHasta";
			this.dtpHasta.Size = new System.Drawing.Size(121, 20);
			this.dtpHasta.TabIndex = 7;
			// 
			// dtpDesde
			// 
			this.dtpDesde.Location = new System.Drawing.Point(301, 76);
			this.dtpDesde.Name = "dtpDesde";
			this.dtpDesde.Size = new System.Drawing.Size(121, 20);
			this.dtpDesde.TabIndex = 6;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(638, 76);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(121, 23);
			this.btnBuscar.TabIndex = 5;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// cmbMateria
			// 
			this.cmbMateria.FormattingEnabled = true;
			this.cmbMateria.Location = new System.Drawing.Point(638, 23);
			this.cmbMateria.Name = "cmbMateria";
			this.cmbMateria.Size = new System.Drawing.Size(121, 21);
			this.cmbMateria.TabIndex = 2;
			// 
			// cmbSeccion
			// 
			this.cmbSeccion.FormattingEnabled = true;
			this.cmbSeccion.Location = new System.Drawing.Point(472, 23);
			this.cmbSeccion.Name = "cmbSeccion";
			this.cmbSeccion.Size = new System.Drawing.Size(121, 21);
			this.cmbSeccion.TabIndex = 1;
			this.cmbSeccion.SelectedIndexChanged += new System.EventHandler(this.cmbSeccion_SelectedIndexChanged);
			// 
			// cmbEstudiante
			// 
			this.cmbEstudiante.FormattingEnabled = true;
			this.cmbEstudiante.Location = new System.Drawing.Point(301, 23);
			this.cmbEstudiante.Name = "cmbEstudiante";
			this.cmbEstudiante.Size = new System.Drawing.Size(121, 21);
			this.cmbEstudiante.TabIndex = 0;
			// 
			// pnlResumen
			// 
			this.pnlResumen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlResumen.Controls.Add(this.pnlTardias);
			this.pnlResumen.Controls.Add(this.pnlAusencia);
			this.pnlResumen.Controls.Add(this.pnlTotal);
			this.pnlResumen.Controls.Add(this.chartporcentaje);
			this.pnlResumen.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlResumen.Location = new System.Drawing.Point(0, 226);
			this.pnlResumen.Name = "pnlResumen";
			this.pnlResumen.Size = new System.Drawing.Size(1189, 198);
			this.pnlResumen.TabIndex = 4;
			// 
			// dgvReporte
			// 
			this.dgvReporte.AllowUserToAddRows = false;
			this.dgvReporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvReporte.Dock = System.Windows.Forms.DockStyle.Top;
			this.dgvReporte.Location = new System.Drawing.Point(0, 424);
			this.dgvReporte.Name = "dgvReporte";
			this.dgvReporte.ReadOnly = true;
			this.dgvReporte.Size = new System.Drawing.Size(1189, 260);
			this.dgvReporte.TabIndex = 5;
			// 
			// pnlBotones
			// 
			this.pnlBotones.Controls.Add(this.btnSalir);
			this.pnlBotones.Controls.Add(this.btnExcel);
			this.pnlBotones.Controls.Add(this.btnPDF);
			this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlBotones.Location = new System.Drawing.Point(0, 679);
			this.pnlBotones.Name = "pnlBotones";
			this.pnlBotones.Size = new System.Drawing.Size(1189, 57);
			this.pnlBotones.TabIndex = 6;
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(638, 25);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(121, 23);
			this.btnSalir.TabIndex = 2;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			// 
			// btnExcel
			// 
			this.btnExcel.Location = new System.Drawing.Point(472, 25);
			this.btnExcel.Name = "btnExcel";
			this.btnExcel.Size = new System.Drawing.Size(121, 23);
			this.btnExcel.TabIndex = 1;
			this.btnExcel.Text = "Exportar Excel";
			this.btnExcel.UseVisualStyleBackColor = true;
			// 
			// btnPDF
			// 
			this.btnPDF.Location = new System.Drawing.Point(301, 25);
			this.btnPDF.Name = "btnPDF";
			this.btnPDF.Size = new System.Drawing.Size(121, 23);
			this.btnPDF.TabIndex = 0;
			this.btnPDF.Text = "Exportar PDF";
			this.btnPDF.UseVisualStyleBackColor = true;
			this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
			// 
			// chartporcentaje
			// 
			this.chartporcentaje.BackColor = System.Drawing.Color.Transparent;
			this.chartporcentaje.BorderlineColor = System.Drawing.Color.Transparent;
			chartArea1.Name = "ChartArea1";
			this.chartporcentaje.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chartporcentaje.Legends.Add(legend1);
			this.chartporcentaje.Location = new System.Drawing.Point(84, 5);
			this.chartporcentaje.Name = "chartporcentaje";
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.chartporcentaje.Series.Add(series1);
			this.chartporcentaje.Size = new System.Drawing.Size(350, 200);
			this.chartporcentaje.TabIndex = 3;
			this.chartporcentaje.Text = "Porcentaje";
			this.chartporcentaje.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal;
			this.chartporcentaje.Click += new System.EventHandler(this.chartporcentaje_Click);
			// 
			// lblTotalCentro
			// 
			this.lblTotalCentro.AutoSize = true;
			this.lblTotalCentro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblTotalCentro.Location = new System.Drawing.Point(60, 44);
			this.lblTotalCentro.Name = "lblTotalCentro";
			this.lblTotalCentro.Size = new System.Drawing.Size(0, 13);
			this.lblTotalCentro.TabIndex = 4;
			this.lblTotalCentro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblAusenciasCentro
			// 
			this.lblAusenciasCentro.AutoSize = true;
			this.lblAusenciasCentro.Location = new System.Drawing.Point(70, 40);
			this.lblAusenciasCentro.Name = "lblAusenciasCentro";
			this.lblAusenciasCentro.Size = new System.Drawing.Size(0, 13);
			this.lblAusenciasCentro.TabIndex = 5;
			// 
			// lblTituloTotal
			// 
			this.lblTituloTotal.AutoSize = true;
			this.lblTituloTotal.Location = new System.Drawing.Point(44, 16);
			this.lblTituloTotal.Name = "lblTituloTotal";
			this.lblTituloTotal.Size = new System.Drawing.Size(0, 13);
			this.lblTituloTotal.TabIndex = 6;
			// 
			// lblTituloAusencias
			// 
			this.lblTituloAusencias.AutoSize = true;
			this.lblTituloAusencias.Location = new System.Drawing.Point(60, 11);
			this.lblTituloAusencias.Name = "lblTituloAusencias";
			this.lblTituloAusencias.Size = new System.Drawing.Size(0, 13);
			this.lblTituloAusencias.TabIndex = 7;
			// 
			// lblTotalTardias
			// 
			this.lblTotalTardias.AutoSize = true;
			this.lblTotalTardias.Location = new System.Drawing.Point(65, 40);
			this.lblTotalTardias.Name = "lblTotalTardias";
			this.lblTotalTardias.Size = new System.Drawing.Size(0, 13);
			this.lblTotalTardias.TabIndex = 8;
			// 
			// lblTituloTardias
			// 
			this.lblTituloTardias.AutoSize = true;
			this.lblTituloTardias.Location = new System.Drawing.Point(63, 16);
			this.lblTituloTardias.Name = "lblTituloTardias";
			this.lblTituloTardias.Size = new System.Drawing.Size(0, 13);
			this.lblTituloTardias.TabIndex = 9;
			// 
			// pnlTotal
			// 
			this.pnlTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlTotal.Controls.Add(this.pictureBox3);
			this.pnlTotal.Controls.Add(this.lblTituloTotal);
			this.pnlTotal.Controls.Add(this.lblTotalCentro);
			this.pnlTotal.Location = new System.Drawing.Point(509, 32);
			this.pnlTotal.Name = "pnlTotal";
			this.pnlTotal.Size = new System.Drawing.Size(172, 100);
			this.pnlTotal.TabIndex = 10;
			// 
			// pnlAusencia
			// 
			this.pnlAusencia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlAusencia.Controls.Add(this.pictureBox2);
			this.pnlAusencia.Controls.Add(this.lblTituloAusencias);
			this.pnlAusencia.Controls.Add(this.lblAusenciasCentro);
			this.pnlAusencia.Location = new System.Drawing.Point(731, 32);
			this.pnlAusencia.Name = "pnlAusencia";
			this.pnlAusencia.Size = new System.Drawing.Size(172, 100);
			this.pnlAusencia.TabIndex = 11;
			// 
			// pnlTardias
			// 
			this.pnlTardias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlTardias.Controls.Add(this.pictureBox4);
			this.pnlTardias.Controls.Add(this.lblTituloTardias);
			this.pnlTardias.Controls.Add(this.lblTotalTardias);
			this.pnlTardias.Location = new System.Drawing.Point(952, 32);
			this.pnlTardias.Name = "pnlTardias";
			this.pnlTardias.Size = new System.Drawing.Size(172, 100);
			this.pnlTardias.TabIndex = 12;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(32, 44);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(38, 37);
			this.pictureBox2.TabIndex = 7;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(16, 44);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(38, 37);
			this.pictureBox3.TabIndex = 8;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(19, 44);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(38, 37);
			this.pictureBox4.TabIndex = 9;
			this.pictureBox4.TabStop = false;
			// 
			// FrmReportes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1189, 736);
			this.Controls.Add(this.pnlBotones);
			this.Controls.Add(this.dgvReporte);
			this.Controls.Add(this.pnlResumen);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "FrmReportes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmReportes";
			this.Load += new System.EventHandler(this.FrmReportes_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.pnlResumen.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
			this.pnlBotones.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chartporcentaje)).EndInit();
			this.pnlTotal.ResumeLayout(false);
			this.pnlTotal.PerformLayout();
			this.pnlAusencia.ResumeLayout(false);
			this.pnlAusencia.PerformLayout();
			this.pnlTardias.ResumeLayout(false);
			this.pnlTardias.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DateTimePicker dtpHasta;
		private System.Windows.Forms.DateTimePicker dtpDesde;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.ComboBox cmbMateria;
		private System.Windows.Forms.ComboBox cmbSeccion;
		private System.Windows.Forms.ComboBox cmbEstudiante;
		private System.Windows.Forms.Panel pnlResumen;
		private System.Windows.Forms.DataGridView dgvReporte;
		private System.Windows.Forms.Panel pnlBotones;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnExcel;
		private System.Windows.Forms.Button btnPDF;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartporcentaje;
		private System.Windows.Forms.Label lblAusenciasCentro;
		private System.Windows.Forms.Label lblTotalCentro;
		private System.Windows.Forms.Label lblTituloAusencias;
		private System.Windows.Forms.Label lblTituloTotal;
		private System.Windows.Forms.Label lblTotalTardias;
		private System.Windows.Forms.Label lblTituloTardias;
		private System.Windows.Forms.Panel pnlTotal;
		private System.Windows.Forms.Panel pnlTardias;
		private System.Windows.Forms.Panel pnlAusencia;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox3;
	}
}