namespace SistemaAsistenciaMagallanes.Forms
{
	partial class FrmHistorialAsistencia
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistorialAsistencia));
			this.panelMain = new System.Windows.Forms.Panel();
			this.pnlFooter = new System.Windows.Forms.Panel();
			this.flowBotones = new System.Windows.Forms.FlowLayoutPanel();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.dgvLista = new System.Windows.Forms.DataGridView();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panelKPI4 = new System.Windows.Forms.Panel();
			this.lblTotaltotalEstudiantes = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.panelKPI3 = new System.Windows.Forms.Panel();
			this.lblTotalDocente = new System.Windows.Forms.Label();
			this.lblDocente = new System.Windows.Forms.Label();
			this.panelKPI2 = new System.Windows.Forms.Panel();
			this.lblTotalMateria = new System.Windows.Forms.Label();
			this.lblMateria = new System.Windows.Forms.Label();
			this.panelKPI1 = new System.Windows.Forms.Panel();
			this.lblTotalSeccion = new System.Windows.Forms.Label();
			this.lblSeccion = new System.Windows.Forms.Label();
			this.pnlFiltrosContenedor = new System.Windows.Forms.Panel();
			this.flowFiltros = new System.Windows.Forms.FlowLayoutPanel();
			this.cmbMateria = new System.Windows.Forms.ComboBox();
			this.cmbSeccion = new System.Windows.Forms.ComboBox();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panelHead = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panelMain.SuspendLayout();
			this.pnlFooter.SuspendLayout();
			this.flowBotones.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.panelKPI4.SuspendLayout();
			this.panelKPI3.SuspendLayout();
			this.panelKPI2.SuspendLayout();
			this.panelKPI1.SuspendLayout();
			this.pnlFiltrosContenedor.SuspendLayout();
			this.flowFiltros.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panelHead.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panelMain
			// 
			this.panelMain.BackColor = System.Drawing.SystemColors.Window;
			this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelMain.Controls.Add(this.pnlFooter);
			this.panelMain.Controls.Add(this.dgvLista);
			this.panelMain.Controls.Add(this.tableLayoutPanel1);
			this.panelMain.Controls.Add(this.pnlFiltrosContenedor);
			this.panelMain.Controls.Add(this.panel2);
			this.panelMain.Controls.Add(this.panelHead);
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(0, 0);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(1186, 625);
			this.panelMain.TabIndex = 0;
			// 
			// pnlFooter
			// 
			this.pnlFooter.Controls.Add(this.flowBotones);
			this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlFooter.Location = new System.Drawing.Point(0, 553);
			this.pnlFooter.Name = "pnlFooter";
			this.pnlFooter.Padding = new System.Windows.Forms.Padding(10);
			this.pnlFooter.Size = new System.Drawing.Size(1184, 70);
			this.pnlFooter.TabIndex = 1;
			this.pnlFooter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFooter_Paint);
			// 
			// flowBotones
			// 
			this.flowBotones.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.flowBotones.AutoSize = true;
			this.flowBotones.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowBotones.Controls.Add(this.btnSalir);
			this.flowBotones.Controls.Add(this.btnGuardar);
			this.flowBotones.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.flowBotones.Location = new System.Drawing.Point(239, 12);
			this.flowBotones.Name = "flowBotones";
			this.flowBotones.Size = new System.Drawing.Size(312, 51);
			this.flowBotones.TabIndex = 0;
			this.flowBotones.WrapContents = false;
			// 
			// btnSalir
			// 
			this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSalir.BackColor = System.Drawing.Color.DarkOrange;
			this.btnSalir.FlatAppearance.BorderSize = 0;
			this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.ForeColor = System.Drawing.SystemColors.Window;
			this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
			this.btnSalir.Location = new System.Drawing.Point(189, 3);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(120, 45);
			this.btnSalir.TabIndex = 5;
			this.btnSalir.Text = "Salir";
			this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSalir.UseVisualStyleBackColor = false;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGuardar.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.btnGuardar.FlatAppearance.BorderSize = 0;
			this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardar.ForeColor = System.Drawing.SystemColors.Window;
			this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
			this.btnGuardar.Location = new System.Drawing.Point(3, 3);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(180, 45);
			this.btnGuardar.TabIndex = 6;
			this.btnGuardar.Text = "Guardar Cambios";
			this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnGuardar.UseVisualStyleBackColor = false;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// dgvLista
			// 
			this.dgvLista.AllowUserToAddRows = false;
			this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLista.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvLista.Location = new System.Drawing.Point(0, 347);
			this.dgvLista.Name = "dgvLista";
			this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvLista.Size = new System.Drawing.Size(1184, 276);
			this.dgvLista.TabIndex = 13;
			this.dgvLista.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvLista_CellFormatting);
			this.dgvLista.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvLista_CurrentCellDirtyStateChanged);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Controls.Add(this.panelKPI4, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.panelKPI3, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.panelKPI2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.panelKPI1, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 247);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1184, 100);
			this.tableLayoutPanel1.TabIndex = 12;
			// 
			// panelKPI4
			// 
			this.panelKPI4.Controls.Add(this.lblTotaltotalEstudiantes);
			this.panelKPI4.Controls.Add(this.lblTotal);
			this.panelKPI4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelKPI4.Location = new System.Drawing.Point(893, 20);
			this.panelKPI4.Margin = new System.Windows.Forms.Padding(10);
			this.panelKPI4.Name = "panelKPI4";
			this.panelKPI4.Size = new System.Drawing.Size(271, 60);
			this.panelKPI4.TabIndex = 5;
			// 
			// lblTotaltotalEstudiantes
			// 
			this.lblTotaltotalEstudiantes.AutoSize = true;
			this.lblTotaltotalEstudiantes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblTotaltotalEstudiantes.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotaltotalEstudiantes.Location = new System.Drawing.Point(0, 20);
			this.lblTotaltotalEstudiantes.Name = "lblTotaltotalEstudiantes";
			this.lblTotaltotalEstudiantes.Size = new System.Drawing.Size(0, 45);
			this.lblTotaltotalEstudiantes.TabIndex = 4;
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotal.Location = new System.Drawing.Point(0, 0);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(129, 20);
			this.lblTotal.TabIndex = 0;
			this.lblTotal.Text = "Total estudiantes";
			this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panelKPI3
			// 
			this.panelKPI3.Controls.Add(this.lblTotalDocente);
			this.panelKPI3.Controls.Add(this.lblDocente);
			this.panelKPI3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelKPI3.Location = new System.Drawing.Point(602, 20);
			this.panelKPI3.Margin = new System.Windows.Forms.Padding(10);
			this.panelKPI3.Name = "panelKPI3";
			this.panelKPI3.Size = new System.Drawing.Size(271, 60);
			this.panelKPI3.TabIndex = 5;
			// 
			// lblTotalDocente
			// 
			this.lblTotalDocente.AutoSize = true;
			this.lblTotalDocente.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblTotalDocente.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalDocente.Location = new System.Drawing.Point(0, 20);
			this.lblTotalDocente.Name = "lblTotalDocente";
			this.lblTotalDocente.Size = new System.Drawing.Size(0, 45);
			this.lblTotalDocente.TabIndex = 3;
			// 
			// lblDocente
			// 
			this.lblDocente.AutoSize = true;
			this.lblDocente.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblDocente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDocente.Location = new System.Drawing.Point(0, 0);
			this.lblDocente.Name = "lblDocente";
			this.lblDocente.Size = new System.Drawing.Size(67, 20);
			this.lblDocente.TabIndex = 0;
			this.lblDocente.Text = "Docente";
			this.lblDocente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panelKPI2
			// 
			this.panelKPI2.Controls.Add(this.lblTotalMateria);
			this.panelKPI2.Controls.Add(this.lblMateria);
			this.panelKPI2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelKPI2.Location = new System.Drawing.Point(311, 20);
			this.panelKPI2.Margin = new System.Windows.Forms.Padding(10);
			this.panelKPI2.Name = "panelKPI2";
			this.panelKPI2.Size = new System.Drawing.Size(271, 60);
			this.panelKPI2.TabIndex = 4;
			// 
			// lblTotalMateria
			// 
			this.lblTotalMateria.AutoSize = true;
			this.lblTotalMateria.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblTotalMateria.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalMateria.Location = new System.Drawing.Point(0, 20);
			this.lblTotalMateria.Name = "lblTotalMateria";
			this.lblTotalMateria.Size = new System.Drawing.Size(0, 45);
			this.lblTotalMateria.TabIndex = 2;
			// 
			// lblMateria
			// 
			this.lblMateria.AutoSize = true;
			this.lblMateria.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblMateria.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMateria.Location = new System.Drawing.Point(0, 0);
			this.lblMateria.Name = "lblMateria";
			this.lblMateria.Size = new System.Drawing.Size(63, 20);
			this.lblMateria.TabIndex = 0;
			this.lblMateria.Text = "Materia";
			this.lblMateria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panelKPI1
			// 
			this.panelKPI1.Controls.Add(this.lblTotalSeccion);
			this.panelKPI1.Controls.Add(this.lblSeccion);
			this.panelKPI1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelKPI1.Location = new System.Drawing.Point(20, 20);
			this.panelKPI1.Margin = new System.Windows.Forms.Padding(10);
			this.panelKPI1.Name = "panelKPI1";
			this.panelKPI1.Size = new System.Drawing.Size(271, 60);
			this.panelKPI1.TabIndex = 3;
			// 
			// lblTotalSeccion
			// 
			this.lblTotalSeccion.AutoSize = true;
			this.lblTotalSeccion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblTotalSeccion.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalSeccion.Location = new System.Drawing.Point(0, 20);
			this.lblTotalSeccion.Name = "lblTotalSeccion";
			this.lblTotalSeccion.Size = new System.Drawing.Size(0, 45);
			this.lblTotalSeccion.TabIndex = 1;
			// 
			// lblSeccion
			// 
			this.lblSeccion.AutoSize = true;
			this.lblSeccion.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblSeccion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSeccion.Location = new System.Drawing.Point(0, 0);
			this.lblSeccion.Name = "lblSeccion";
			this.lblSeccion.Size = new System.Drawing.Size(61, 20);
			this.lblSeccion.TabIndex = 0;
			this.lblSeccion.Text = "Sección";
			this.lblSeccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnlFiltrosContenedor
			// 
			this.pnlFiltrosContenedor.Controls.Add(this.flowFiltros);
			this.pnlFiltrosContenedor.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlFiltrosContenedor.Location = new System.Drawing.Point(0, 200);
			this.pnlFiltrosContenedor.Name = "pnlFiltrosContenedor";
			this.pnlFiltrosContenedor.Size = new System.Drawing.Size(1184, 47);
			this.pnlFiltrosContenedor.TabIndex = 3;
			// 
			// flowFiltros
			// 
			this.flowFiltros.AutoSize = true;
			this.flowFiltros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowFiltros.Controls.Add(this.cmbMateria);
			this.flowFiltros.Controls.Add(this.cmbSeccion);
			this.flowFiltros.Controls.Add(this.dtpFecha);
			this.flowFiltros.Controls.Add(this.btnBuscar);
			this.flowFiltros.Location = new System.Drawing.Point(244, 6);
			this.flowFiltros.Name = "flowFiltros";
			this.flowFiltros.Size = new System.Drawing.Size(680, 41);
			this.flowFiltros.TabIndex = 12;
			this.flowFiltros.WrapContents = false;
			// 
			// cmbMateria
			// 
			this.cmbMateria.FormattingEnabled = true;
			this.cmbMateria.Location = new System.Drawing.Point(3, 3);
			this.cmbMateria.Name = "cmbMateria";
			this.cmbMateria.Size = new System.Drawing.Size(170, 21);
			this.cmbMateria.TabIndex = 1;
			// 
			// cmbSeccion
			// 
			this.cmbSeccion.FormattingEnabled = true;
			this.cmbSeccion.Location = new System.Drawing.Point(179, 3);
			this.cmbSeccion.Name = "cmbSeccion";
			this.cmbSeccion.Size = new System.Drawing.Size(170, 21);
			this.cmbSeccion.TabIndex = 0;
			this.cmbSeccion.SelectedIndexChanged += new System.EventHandler(this.cmbSeccion_SelectedIndexChanged);
			this.cmbSeccion.SelectionChangeCommitted += new System.EventHandler(this.cmbSeccion_SelectionChangeCommitted);
			// 
			// dtpFecha
			// 
			this.dtpFecha.Location = new System.Drawing.Point(355, 3);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(200, 20);
			this.dtpFecha.TabIndex = 2;
			// 
			// btnBuscar
			// 
			this.btnBuscar.BackColor = System.Drawing.Color.DarkOrange;
			this.btnBuscar.FlatAppearance.BorderSize = 0;
			this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
			this.btnBuscar.Location = new System.Drawing.Point(561, 3);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(116, 35);
			this.btnBuscar.TabIndex = 3;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBuscar.UseVisualStyleBackColor = false;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.pictureBox2);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel2.Location = new System.Drawing.Point(0, 100);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1184, 100);
			this.panel2.TabIndex = 10;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(54, 15);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(36, 44);
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(96, 47);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(344, 21);
			this.label3.TabIndex = 1;
			this.label3.Text = "Solo se puede editar las listas del día actual.";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(96, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(449, 21);
			this.label2.TabIndex = 0;
			this.label2.Text = "Acá puedes ver y editar las listas de asistencia registradas.";
			// 
			// panelHead
			// 
			this.panelHead.BackColor = System.Drawing.Color.Orange;
			this.panelHead.Controls.Add(this.pictureBox1);
			this.panelHead.Controls.Add(this.label1);
			this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelHead.Location = new System.Drawing.Point(0, 0);
			this.panelHead.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.panelHead.Name = "panelHead";
			this.panelHead.Size = new System.Drawing.Size(1184, 100);
			this.panelHead.TabIndex = 9;
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
			this.label1.Location = new System.Drawing.Point(245, 18);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.label1.Size = new System.Drawing.Size(679, 67);
			this.label1.TabIndex = 1;
			this.label1.Text = "GESTIÓN DE ASISTENCIA     ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FrmHistorialAsistencia
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1186, 625);
			this.Controls.Add(this.panelMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.HelpButton = true;
			this.Name = "FrmHistorialAsistencia";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmHistorialAsistencia";
			this.Load += new System.EventHandler(this.FrmHistorialAsistencia_Load);
			this.Resize += new System.EventHandler(this.FrmHistorialAsistencia_Resize);
			this.panelMain.ResumeLayout(false);
			this.pnlFooter.ResumeLayout(false);
			this.pnlFooter.PerformLayout();
			this.flowBotones.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panelKPI4.ResumeLayout(false);
			this.panelKPI4.PerformLayout();
			this.panelKPI3.ResumeLayout(false);
			this.panelKPI3.PerformLayout();
			this.panelKPI2.ResumeLayout(false);
			this.panelKPI2.PerformLayout();
			this.panelKPI1.ResumeLayout(false);
			this.panelKPI1.PerformLayout();
			this.pnlFiltrosContenedor.ResumeLayout(false);
			this.pnlFiltrosContenedor.PerformLayout();
			this.flowFiltros.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panelHead.ResumeLayout(false);
			this.panelHead.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.ComboBox cmbMateria;
		private System.Windows.Forms.ComboBox cmbSeccion;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panelHead;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvLista;
		private System.Windows.Forms.Label lblSeccion;
		private System.Windows.Forms.Panel pnlFooter;
		private System.Windows.Forms.FlowLayoutPanel flowBotones;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Panel pnlFiltrosContenedor;
		private System.Windows.Forms.FlowLayoutPanel flowFiltros;
		private System.Windows.Forms.Panel panelKPI4;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Panel panelKPI3;
		private System.Windows.Forms.Label lblDocente;
		private System.Windows.Forms.Panel panelKPI2;
		private System.Windows.Forms.Label lblMateria;
		private System.Windows.Forms.Panel panelKPI1;
		private System.Windows.Forms.Label lblTotaltotalEstudiantes;
		private System.Windows.Forms.Label lblTotalDocente;
		private System.Windows.Forms.Label lblTotalMateria;
		private System.Windows.Forms.Label lblTotalSeccion;
	}
}