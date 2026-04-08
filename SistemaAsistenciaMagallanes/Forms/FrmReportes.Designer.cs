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
			this.btnJustificarSeleccionado = new System.Windows.Forms.Button();
			this.dtpHasta = new System.Windows.Forms.DateTimePicker();
			this.dtpDesde = new System.Windows.Forms.DateTimePicker();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.cmbMateria = new System.Windows.Forms.ComboBox();
			this.cmbSeccion = new System.Windows.Forms.ComboBox();
			this.cmbEstudiante = new System.Windows.Forms.ComboBox();
			this.pnlResumen = new System.Windows.Forms.Panel();
			this.pnlJustificado = new System.Windows.Forms.Panel();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.lblJustificado = new System.Windows.Forms.Label();
			this.lblTotalJustificado = new System.Windows.Forms.Label();
			this.pnlTardias = new System.Windows.Forms.Panel();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.lblTituloTardias = new System.Windows.Forms.Label();
			this.lblTotalTardias = new System.Windows.Forms.Label();
			this.pnlAusencia = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.lblTituloAusencias = new System.Windows.Forms.Label();
			this.lblAusenciasCentro = new System.Windows.Forms.Label();
			this.pnlTotal = new System.Windows.Forms.Panel();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.lblTituloTotal = new System.Windows.Forms.Label();
			this.lblTotalCentro = new System.Windows.Forms.Label();
			this.chartporcentaje = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.dgvReporte = new System.Windows.Forms.DataGridView();
			this.pnlBotones = new System.Windows.Forms.Panel();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnExcel = new System.Windows.Forms.Button();
			this.btnPDF = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.pnlResumen.SuspendLayout();
			this.pnlJustificado.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			this.pnlTardias.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			this.pnlAusencia.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.pnlTotal.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartporcentaje)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
			this.pnlBotones.SuspendLayout();
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
			this.label1.Location = new System.Drawing.Point(422, 20);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.label1.Size = new System.Drawing.Size(350, 67);
			this.label1.TabIndex = 1;
			this.label1.Text = "REPORTES      ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnJustificarSeleccionado);
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
			// btnJustificarSeleccionado
			// 
			this.btnJustificarSeleccionado.BackColor = System.Drawing.Color.Orange;
			this.btnJustificarSeleccionado.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnJustificarSeleccionado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnJustificarSeleccionado.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnJustificarSeleccionado.ForeColor = System.Drawing.Color.White;
			this.btnJustificarSeleccionado.Image = ((System.Drawing.Image)(resources.GetObject("btnJustificarSeleccionado.Image")));
			this.btnJustificarSeleccionado.Location = new System.Drawing.Point(824, 70);
			this.btnJustificarSeleccionado.Name = "btnJustificarSeleccionado";
			this.btnJustificarSeleccionado.Size = new System.Drawing.Size(112, 37);
			this.btnJustificarSeleccionado.TabIndex = 8;
			this.btnJustificarSeleccionado.Text = "Justificar";
			this.btnJustificarSeleccionado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnJustificarSeleccionado.UseVisualStyleBackColor = false;
			this.btnJustificarSeleccionado.Click += new System.EventHandler(this.btnJustificarSeleccionado_Click);
			// 
			// dtpHasta
			// 
			this.dtpHasta.Location = new System.Drawing.Point(472, 76);
			this.dtpHasta.Name = "dtpHasta";
			this.dtpHasta.Size = new System.Drawing.Size(184, 20);
			this.dtpHasta.TabIndex = 7;
			// 
			// dtpDesde
			// 
			this.dtpDesde.Location = new System.Drawing.Point(238, 76);
			this.dtpDesde.Name = "dtpDesde";
			this.dtpDesde.Size = new System.Drawing.Size(184, 20);
			this.dtpDesde.TabIndex = 6;
			// 
			// btnBuscar
			// 
			this.btnBuscar.BackColor = System.Drawing.Color.Orange;
			this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscar.ForeColor = System.Drawing.Color.White;
			this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
			this.btnBuscar.Location = new System.Drawing.Point(706, 70);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(112, 37);
			this.btnBuscar.TabIndex = 5;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBuscar.UseVisualStyleBackColor = false;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// cmbMateria
			// 
			this.cmbMateria.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmbMateria.FormattingEnabled = true;
			this.cmbMateria.Location = new System.Drawing.Point(706, 23);
			this.cmbMateria.Name = "cmbMateria";
			this.cmbMateria.Size = new System.Drawing.Size(230, 21);
			this.cmbMateria.TabIndex = 2;
			// 
			// cmbSeccion
			// 
			this.cmbSeccion.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmbSeccion.FormattingEnabled = true;
			this.cmbSeccion.Location = new System.Drawing.Point(472, 23);
			this.cmbSeccion.Name = "cmbSeccion";
			this.cmbSeccion.Size = new System.Drawing.Size(184, 21);
			this.cmbSeccion.TabIndex = 1;
			this.cmbSeccion.SelectedIndexChanged += new System.EventHandler(this.cmbSeccion_SelectedIndexChanged);
			// 
			// cmbEstudiante
			// 
			this.cmbEstudiante.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbEstudiante.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbEstudiante.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmbEstudiante.FormattingEnabled = true;
			this.cmbEstudiante.Location = new System.Drawing.Point(238, 23);
			this.cmbEstudiante.Name = "cmbEstudiante";
			this.cmbEstudiante.Size = new System.Drawing.Size(184, 21);
			this.cmbEstudiante.TabIndex = 0;
			this.cmbEstudiante.SelectionChangeCommitted += new System.EventHandler(this.cmbEstudiante_SelectionChangeCommitted);
			// 
			// pnlResumen
			// 
			this.pnlResumen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlResumen.Controls.Add(this.pnlJustificado);
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
			// pnlJustificado
			// 
			this.pnlJustificado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlJustificado.Controls.Add(this.pictureBox5);
			this.pnlJustificado.Controls.Add(this.lblJustificado);
			this.pnlJustificado.Controls.Add(this.lblTotalJustificado);
			this.pnlJustificado.Location = new System.Drawing.Point(573, 32);
			this.pnlJustificado.Name = "pnlJustificado";
			this.pnlJustificado.Size = new System.Drawing.Size(172, 100);
			this.pnlJustificado.TabIndex = 11;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(16, 44);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(38, 37);
			this.pictureBox5.TabIndex = 8;
			this.pictureBox5.TabStop = false;
			// 
			// lblJustificado
			// 
			this.lblJustificado.AutoSize = true;
			this.lblJustificado.Location = new System.Drawing.Point(44, 16);
			this.lblJustificado.Name = "lblJustificado";
			this.lblJustificado.Size = new System.Drawing.Size(0, 13);
			this.lblJustificado.TabIndex = 6;
			// 
			// lblTotalJustificado
			// 
			this.lblTotalJustificado.AutoSize = true;
			this.lblTotalJustificado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblTotalJustificado.Location = new System.Drawing.Point(60, 44);
			this.lblTotalJustificado.Name = "lblTotalJustificado";
			this.lblTotalJustificado.Size = new System.Drawing.Size(0, 13);
			this.lblTotalJustificado.TabIndex = 4;
			this.lblTotalJustificado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(19, 44);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(38, 37);
			this.pictureBox4.TabIndex = 9;
			this.pictureBox4.TabStop = false;
			// 
			// lblTituloTardias
			// 
			this.lblTituloTardias.AutoSize = true;
			this.lblTituloTardias.Location = new System.Drawing.Point(63, 16);
			this.lblTituloTardias.Name = "lblTituloTardias";
			this.lblTituloTardias.Size = new System.Drawing.Size(0, 13);
			this.lblTituloTardias.TabIndex = 9;
			// 
			// lblTotalTardias
			// 
			this.lblTotalTardias.AutoSize = true;
			this.lblTotalTardias.Location = new System.Drawing.Point(65, 40);
			this.lblTotalTardias.Name = "lblTotalTardias";
			this.lblTotalTardias.Size = new System.Drawing.Size(0, 13);
			this.lblTotalTardias.TabIndex = 8;
			// 
			// pnlAusencia
			// 
			this.pnlAusencia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlAusencia.Controls.Add(this.pictureBox2);
			this.pnlAusencia.Controls.Add(this.lblTituloAusencias);
			this.pnlAusencia.Controls.Add(this.lblAusenciasCentro);
			this.pnlAusencia.Location = new System.Drawing.Point(763, 32);
			this.pnlAusencia.Name = "pnlAusencia";
			this.pnlAusencia.Size = new System.Drawing.Size(172, 100);
			this.pnlAusencia.TabIndex = 11;
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
			// lblTituloAusencias
			// 
			this.lblTituloAusencias.AutoSize = true;
			this.lblTituloAusencias.Location = new System.Drawing.Point(60, 11);
			this.lblTituloAusencias.Name = "lblTituloAusencias";
			this.lblTituloAusencias.Size = new System.Drawing.Size(0, 13);
			this.lblTituloAusencias.TabIndex = 7;
			// 
			// lblAusenciasCentro
			// 
			this.lblAusenciasCentro.AutoSize = true;
			this.lblAusenciasCentro.Location = new System.Drawing.Point(70, 40);
			this.lblAusenciasCentro.Name = "lblAusenciasCentro";
			this.lblAusenciasCentro.Size = new System.Drawing.Size(0, 13);
			this.lblAusenciasCentro.TabIndex = 5;
			// 
			// pnlTotal
			// 
			this.pnlTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlTotal.Controls.Add(this.pictureBox3);
			this.pnlTotal.Controls.Add(this.lblTituloTotal);
			this.pnlTotal.Controls.Add(this.lblTotalCentro);
			this.pnlTotal.Location = new System.Drawing.Point(384, 32);
			this.pnlTotal.Name = "pnlTotal";
			this.pnlTotal.Size = new System.Drawing.Size(172, 100);
			this.pnlTotal.TabIndex = 10;
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
			// lblTituloTotal
			// 
			this.lblTituloTotal.AutoSize = true;
			this.lblTituloTotal.Location = new System.Drawing.Point(44, 16);
			this.lblTituloTotal.Name = "lblTituloTotal";
			this.lblTituloTotal.Size = new System.Drawing.Size(0, 13);
			this.lblTituloTotal.TabIndex = 6;
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
			// chartporcentaje
			// 
			this.chartporcentaje.BackColor = System.Drawing.Color.Transparent;
			this.chartporcentaje.BorderlineColor = System.Drawing.Color.Transparent;
			chartArea1.Name = "ChartArea1";
			this.chartporcentaje.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chartporcentaje.Legends.Add(legend1);
			this.chartporcentaje.Location = new System.Drawing.Point(-1, -1);
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
			this.pnlBotones.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBotones_Paint);
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.Color.DarkOrange;
			this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.ForeColor = System.Drawing.Color.White;
			this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
			this.btnSalir.Location = new System.Drawing.Point(672, 11);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(121, 43);
			this.btnSalir.TabIndex = 2;
			this.btnSalir.Text = "Salir";
			this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSalir.UseVisualStyleBackColor = false;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// btnExcel
			// 
			this.btnExcel.BackColor = System.Drawing.Color.YellowGreen;
			this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExcel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcel.ForeColor = System.Drawing.Color.White;
			this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
			this.btnExcel.Location = new System.Drawing.Point(510, 11);
			this.btnExcel.Name = "btnExcel";
			this.btnExcel.Size = new System.Drawing.Size(121, 43);
			this.btnExcel.TabIndex = 1;
			this.btnExcel.Text = "Generar Excel";
			this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnExcel.UseVisualStyleBackColor = false;
			this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
			// 
			// btnPDF
			// 
			this.btnPDF.BackColor = System.Drawing.Color.OrangeRed;
			this.btnPDF.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPDF.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPDF.ForeColor = System.Drawing.Color.White;
			this.btnPDF.Image = ((System.Drawing.Image)(resources.GetObject("btnPDF.Image")));
			this.btnPDF.Location = new System.Drawing.Point(339, 11);
			this.btnPDF.Name = "btnPDF";
			this.btnPDF.Size = new System.Drawing.Size(121, 43);
			this.btnPDF.TabIndex = 0;
			this.btnPDF.Text = "Generar PDF";
			this.btnPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPDF.UseVisualStyleBackColor = false;
			this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
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
			this.pnlJustificado.ResumeLayout(false);
			this.pnlJustificado.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			this.pnlTardias.ResumeLayout(false);
			this.pnlTardias.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.pnlAusencia.ResumeLayout(false);
			this.pnlAusencia.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.pnlTotal.ResumeLayout(false);
			this.pnlTotal.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartporcentaje)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
			this.pnlBotones.ResumeLayout(false);
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
		private System.Windows.Forms.Button btnJustificarSeleccionado;
		private System.Windows.Forms.Panel pnlJustificado;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.Label lblJustificado;
		private System.Windows.Forms.Label lblTotalJustificado;
	}
}