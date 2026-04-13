namespace SistemaAsistenciaMagallanes.Forms
{
	partial class FrmHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.subpanel = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnTareas = new System.Windows.Forms.Button();
            this.btnBoletas = new System.Windows.Forms.Button();
            this.btnAsistencia = new System.Windows.Forms.Button();
            this.btnJustificacion = new System.Windows.Forms.Button();
            this.panelAdminSubmenu = new System.Windows.Forms.Panel();
            this.btnMaterias = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnSecciones = new System.Windows.Forms.Button();
            this.btnEstudiantes = new System.Windows.Forms.Button();
            this.BtnAdministracion = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerMenu = new System.Windows.Forms.Timer(this.components);
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelIndex = new System.Windows.Forms.Panel();
            this.tableKPIs = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblTotalEstudiantes = new System.Windows.Forms.Label();
            this.lblTituloEstudiante = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblTotalProfesores = new System.Windows.Forms.Label();
            this.lblTituloProfesores = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblAusentes = new System.Windows.Forms.Label();
            this.lblTituloAusentes = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblPresentes = new System.Windows.Forms.Label();
            this.lblTituloPresentes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.subpanel.SuspendLayout();
            this.panelAdminSubmenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelPrincipal.SuspendLayout();
            this.panelIndex.SuspendLayout();
            this.tableKPIs.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // subpanel
            // 
            this.subpanel.AutoScroll = true;
            this.subpanel.BackColor = System.Drawing.Color.Orange;
            this.subpanel.Controls.Add(this.btnLogout);
            this.subpanel.Controls.Add(this.btnReportes);
            this.subpanel.Controls.Add(this.btnTareas);
            this.subpanel.Controls.Add(this.btnBoletas);
            this.subpanel.Controls.Add(this.btnAsistencia);
            this.subpanel.Controls.Add(this.btnJustificacion);
            this.subpanel.Controls.Add(this.panelAdminSubmenu);
            this.subpanel.Controls.Add(this.BtnAdministracion);
            this.subpanel.Controls.Add(this.panelLogo);
            this.subpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.subpanel.Location = new System.Drawing.Point(0, 0);
            this.subpanel.Name = "subpanel";
            this.subpanel.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.subpanel.Size = new System.Drawing.Size(247, 716);
            this.subpanel.TabIndex = 0;
            this.subpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 778);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(230, 89);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = " Salir";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 689);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnReportes.Size = new System.Drawing.Size(230, 89);
            this.btnReportes.TabIndex = 10;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnTareas
            // 
            this.btnTareas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTareas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTareas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTareas.FlatAppearance.BorderSize = 0;
            this.btnTareas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTareas.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTareas.ForeColor = System.Drawing.Color.White;
            this.btnTareas.Image = ((System.Drawing.Image)(resources.GetObject("btnTareas.Image")));
            this.btnTareas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTareas.Location = new System.Drawing.Point(0, 600);
            this.btnTareas.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btnTareas.Name = "btnTareas";
            this.btnTareas.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnTareas.Size = new System.Drawing.Size(230, 89);
            this.btnTareas.TabIndex = 8;
            this.btnTareas.Text = "Tareas";
            this.btnTareas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTareas.UseVisualStyleBackColor = true;
            this.btnTareas.Click += new System.EventHandler(this.btnTareas_Click);
            // 
            // btnBoletas
            // 
            this.btnBoletas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBoletas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBoletas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBoletas.FlatAppearance.BorderSize = 0;
            this.btnBoletas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoletas.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoletas.ForeColor = System.Drawing.Color.White;
            this.btnBoletas.Image = ((System.Drawing.Image)(resources.GetObject("btnBoletas.Image")));
            this.btnBoletas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBoletas.Location = new System.Drawing.Point(0, 517);
            this.btnBoletas.Name = "btnBoletas";
            this.btnBoletas.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnBoletas.Size = new System.Drawing.Size(230, 83);
            this.btnBoletas.TabIndex = 7;
            this.btnBoletas.Text = "Amonestaciones";
            this.btnBoletas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBoletas.UseVisualStyleBackColor = true;
            // 
            // btnAsistencia
            // 
            this.btnAsistencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsistencia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAsistencia.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAsistencia.FlatAppearance.BorderSize = 0;
            this.btnAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsistencia.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsistencia.ForeColor = System.Drawing.Color.White;
            this.btnAsistencia.Image = ((System.Drawing.Image)(resources.GetObject("btnAsistencia.Image")));
            this.btnAsistencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsistencia.Location = new System.Drawing.Point(0, 437);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAsistencia.Size = new System.Drawing.Size(230, 80);
            this.btnAsistencia.TabIndex = 6;
            this.btnAsistencia.Text = " ASISTENCIA ";
            this.btnAsistencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsistencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAsistencia.UseVisualStyleBackColor = true;
            this.btnAsistencia.Click += new System.EventHandler(this.btnAsistencia_Click_1);
            // 
            // btnJustificacion
            // 
            this.btnJustificacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJustificacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnJustificacion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnJustificacion.FlatAppearance.BorderSize = 0;
            this.btnJustificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJustificacion.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJustificacion.ForeColor = System.Drawing.Color.White;
            this.btnJustificacion.Image = ((System.Drawing.Image)(resources.GetObject("btnJustificacion.Image")));
            this.btnJustificacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJustificacion.Location = new System.Drawing.Point(0, 357);
            this.btnJustificacion.Name = "btnJustificacion";
            this.btnJustificacion.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnJustificacion.Size = new System.Drawing.Size(230, 80);
            this.btnJustificacion.TabIndex = 11;
            this.btnJustificacion.Text = "Justificaciones";
            this.btnJustificacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJustificacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnJustificacion.UseVisualStyleBackColor = true;
            this.btnJustificacion.Click += new System.EventHandler(this.btnJustificacion_Click);
            // 
            // panelAdminSubmenu
            // 
            this.panelAdminSubmenu.Controls.Add(this.btnMaterias);
            this.panelAdminSubmenu.Controls.Add(this.btnUsuarios);
            this.panelAdminSubmenu.Controls.Add(this.btnSecciones);
            this.panelAdminSubmenu.Controls.Add(this.btnEstudiantes);
            this.panelAdminSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdminSubmenu.Location = new System.Drawing.Point(0, 357);
            this.panelAdminSubmenu.Name = "panelAdminSubmenu";
            this.panelAdminSubmenu.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panelAdminSubmenu.Size = new System.Drawing.Size(230, 0);
            this.panelAdminSubmenu.TabIndex = 0;
            // 
            // btnMaterias
            // 
            this.btnMaterias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaterias.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMaterias.FlatAppearance.BorderSize = 0;
            this.btnMaterias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterias.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterias.ForeColor = System.Drawing.Color.White;
            this.btnMaterias.Image = ((System.Drawing.Image)(resources.GetObject("btnMaterias.Image")));
            this.btnMaterias.Location = new System.Drawing.Point(0, 108);
            this.btnMaterias.Name = "btnMaterias";
            this.btnMaterias.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnMaterias.Size = new System.Drawing.Size(230, 35);
            this.btnMaterias.TabIndex = 3;
            this.btnMaterias.Text = "Materias";
            this.btnMaterias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaterias.UseVisualStyleBackColor = true;
            this.btnMaterias.Click += new System.EventHandler(this.btnMaterias_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 72);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnUsuarios.Size = new System.Drawing.Size(230, 36);
            this.btnUsuarios.TabIndex = 2;
            this.btnUsuarios.Text = "Docentes";
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnSecciones
            // 
            this.btnSecciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSecciones.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSecciones.FlatAppearance.BorderSize = 0;
            this.btnSecciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecciones.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecciones.ForeColor = System.Drawing.Color.White;
            this.btnSecciones.Image = ((System.Drawing.Image)(resources.GetObject("btnSecciones.Image")));
            this.btnSecciones.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSecciones.Location = new System.Drawing.Point(0, 36);
            this.btnSecciones.Name = "btnSecciones";
            this.btnSecciones.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnSecciones.Size = new System.Drawing.Size(230, 36);
            this.btnSecciones.TabIndex = 1;
            this.btnSecciones.Text = "Secciones";
            this.btnSecciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSecciones.UseVisualStyleBackColor = true;
            this.btnSecciones.Click += new System.EventHandler(this.btnSecciones_Click);
            // 
            // btnEstudiantes
            // 
            this.btnEstudiantes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstudiantes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEstudiantes.FlatAppearance.BorderSize = 0;
            this.btnEstudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstudiantes.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstudiantes.ForeColor = System.Drawing.Color.White;
            this.btnEstudiantes.Image = ((System.Drawing.Image)(resources.GetObject("btnEstudiantes.Image")));
            this.btnEstudiantes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEstudiantes.Location = new System.Drawing.Point(0, 0);
            this.btnEstudiantes.Name = "btnEstudiantes";
            this.btnEstudiantes.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnEstudiantes.Size = new System.Drawing.Size(230, 36);
            this.btnEstudiantes.TabIndex = 0;
            this.btnEstudiantes.Text = "Estudiantes";
            this.btnEstudiantes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEstudiantes.UseVisualStyleBackColor = true;
            this.btnEstudiantes.Click += new System.EventHandler(this.btnEstudiantes_Click);
            // 
            // BtnAdministracion
            // 
            this.BtnAdministracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdministracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAdministracion.FlatAppearance.BorderSize = 0;
            this.BtnAdministracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdministracion.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdministracion.ForeColor = System.Drawing.Color.White;
            this.BtnAdministracion.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdministracion.Image")));
            this.BtnAdministracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdministracion.Location = new System.Drawing.Point(0, 275);
            this.BtnAdministracion.Name = "BtnAdministracion";
            this.BtnAdministracion.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnAdministracion.Size = new System.Drawing.Size(230, 82);
            this.BtnAdministracion.TabIndex = 4;
            this.BtnAdministracion.Text = " Administración ▼";
            this.BtnAdministracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdministracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAdministracion.UseVisualStyleBackColor = false;
            this.BtnAdministracion.Click += new System.EventHandler(this.BtnAdministracion_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.lblUsuario);
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 20);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(230, 255);
            this.panelLogo.TabIndex = 5;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // lblUsuario
            // 
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(3, 216);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(300, 30);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Bienvenida";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-35, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 195);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timerMenu
            // 
            this.timerMenu.Interval = 15;
            this.timerMenu.Tick += new System.EventHandler(this.timerMenu_Tick);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.White;
            this.panelPrincipal.Controls.Add(this.panelIndex);
            this.panelPrincipal.Controls.Add(this.subpanel);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1183, 716);
            this.panelPrincipal.TabIndex = 1;
            // 
            // panelIndex
            // 
            this.panelIndex.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelIndex.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelIndex.BackgroundImage")));
            this.panelIndex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelIndex.Controls.Add(this.tableKPIs);
            this.panelIndex.Controls.Add(this.label3);
            this.panelIndex.Controls.Add(this.label2);
            this.panelIndex.Controls.Add(this.label1);
            this.panelIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelIndex.Location = new System.Drawing.Point(247, 0);
            this.panelIndex.Name = "panelIndex";
            this.panelIndex.Size = new System.Drawing.Size(936, 716);
            this.panelIndex.TabIndex = 5;
            // 
            // tableKPIs
            // 
            this.tableKPIs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableKPIs.BackColor = System.Drawing.Color.Transparent;
            this.tableKPIs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tableKPIs.ColumnCount = 2;
            this.tableKPIs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableKPIs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableKPIs.Controls.Add(this.panel1, 0, 0);
            this.tableKPIs.Controls.Add(this.panel3, 0, 1);
            this.tableKPIs.Controls.Add(this.panel4, 1, 1);
            this.tableKPIs.Controls.Add(this.panel2, 1, 0);
            this.tableKPIs.Location = new System.Drawing.Point(57, 304);
            this.tableKPIs.Name = "tableKPIs";
            this.tableKPIs.RowCount = 2;
            this.tableKPIs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableKPIs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableKPIs.Size = new System.Drawing.Size(836, 310);
            this.tableKPIs.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.lblTotalEstudiantes);
            this.panel1.Controls.Add(this.lblTituloEstudiante);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 149);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(53, 56);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(67, 70);
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // lblTotalEstudiantes
            // 
            this.lblTotalEstudiantes.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEstudiantes.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblTotalEstudiantes.Location = new System.Drawing.Point(3, 64);
            this.lblTotalEstudiantes.Name = "lblTotalEstudiantes";
            this.lblTotalEstudiantes.Size = new System.Drawing.Size(396, 48);
            this.lblTotalEstudiantes.TabIndex = 1;
            this.lblTotalEstudiantes.Text = "label4";
            this.lblTotalEstudiantes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTituloEstudiante
            // 
            this.lblTituloEstudiante.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEstudiante.ForeColor = System.Drawing.Color.White;
            this.lblTituloEstudiante.Location = new System.Drawing.Point(3, 16);
            this.lblTituloEstudiante.Name = "lblTituloEstudiante";
            this.lblTituloEstudiante.Size = new System.Drawing.Size(396, 37);
            this.lblTituloEstudiante.TabIndex = 0;
            this.lblTituloEstudiante.Text = "label4";
            this.lblTituloEstudiante.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Orange;
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.lblTotalProfesores);
            this.panel3.Controls.Add(this.lblTituloProfesores);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 158);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(412, 149);
            this.panel3.TabIndex = 8;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(53, 63);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(67, 70);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // lblTotalProfesores
            // 
            this.lblTotalProfesores.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProfesores.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTotalProfesores.Location = new System.Drawing.Point(3, 68);
            this.lblTotalProfesores.Name = "lblTotalProfesores";
            this.lblTotalProfesores.Size = new System.Drawing.Size(396, 37);
            this.lblTotalProfesores.TabIndex = 3;
            this.lblTotalProfesores.Text = "label4";
            this.lblTotalProfesores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTituloProfesores
            // 
            this.lblTituloProfesores.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloProfesores.ForeColor = System.Drawing.Color.White;
            this.lblTituloProfesores.Location = new System.Drawing.Point(3, 23);
            this.lblTituloProfesores.Name = "lblTituloProfesores";
            this.lblTituloProfesores.Size = new System.Drawing.Size(396, 37);
            this.lblTituloProfesores.TabIndex = 2;
            this.lblTituloProfesores.Text = "label4";
            this.lblTituloProfesores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Orange;
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.lblAusentes);
            this.panel4.Controls.Add(this.lblTituloAusentes);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(421, 158);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(412, 149);
            this.panel4.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(77, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 70);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // lblAusentes
            // 
            this.lblAusentes.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAusentes.ForeColor = System.Drawing.Color.Crimson;
            this.lblAusentes.Location = new System.Drawing.Point(10, 75);
            this.lblAusentes.Name = "lblAusentes";
            this.lblAusentes.Size = new System.Drawing.Size(396, 37);
            this.lblAusentes.TabIndex = 7;
            this.lblAusentes.Text = "label8";
            this.lblAusentes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTituloAusentes
            // 
            this.lblTituloAusentes.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAusentes.ForeColor = System.Drawing.Color.White;
            this.lblTituloAusentes.Location = new System.Drawing.Point(10, 23);
            this.lblTituloAusentes.Name = "lblTituloAusentes";
            this.lblTituloAusentes.Size = new System.Drawing.Size(396, 37);
            this.lblTituloAusentes.TabIndex = 6;
            this.lblTituloAusentes.Text = "label4";
            this.lblTituloAusentes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.lblPresentes);
            this.panel2.Controls.Add(this.lblTituloPresentes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(421, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(412, 149);
            this.panel2.TabIndex = 10;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(77, 56);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(67, 70);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // lblPresentes
            // 
            this.lblPresentes.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresentes.ForeColor = System.Drawing.Color.Navy;
            this.lblPresentes.Location = new System.Drawing.Point(10, 73);
            this.lblPresentes.Name = "lblPresentes";
            this.lblPresentes.Size = new System.Drawing.Size(396, 37);
            this.lblPresentes.TabIndex = 5;
            this.lblPresentes.Text = "label6";
            this.lblPresentes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTituloPresentes
            // 
            this.lblTituloPresentes.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPresentes.ForeColor = System.Drawing.Color.White;
            this.lblTituloPresentes.Location = new System.Drawing.Point(10, 21);
            this.lblTituloPresentes.Name = "lblTituloPresentes";
            this.lblTituloPresentes.Size = new System.Drawing.Size(396, 37);
            this.lblTituloPresentes.TabIndex = 4;
            this.lblTituloPresentes.Text = "label4";
            this.lblTituloPresentes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(0, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(936, 157);
            this.label3.TabIndex = 4;
            this.label3.Text = "\"MAGALLANES ES MAGALLANES\"";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 40F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 97);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label2.Size = new System.Drawing.Size(936, 98);
            this.label2.TabIndex = 6;
            this.label2.Text = "MAGALLANES";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 40F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label1.Size = new System.Drawing.Size(936, 97);
            this.label1.TabIndex = 5;
            this.label1.Text = "LICEO ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 716);
            this.Controls.Add(this.panelPrincipal);
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.Resize += new System.EventHandler(this.FrmHome_Resize);
            this.subpanel.ResumeLayout(false);
            this.panelAdminSubmenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelPrincipal.ResumeLayout(false);
            this.panelIndex.ResumeLayout(false);
            this.tableKPIs.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel subpanel;
		private System.Windows.Forms.Button BtnAdministracion;
		private System.Windows.Forms.Panel panelAdminSubmenu;
		private System.Windows.Forms.Button btnMaterias;
		private System.Windows.Forms.Button btnUsuarios;
		private System.Windows.Forms.Button btnSecciones;
		private System.Windows.Forms.Button btnEstudiantes;
		private System.Windows.Forms.Timer timerMenu;
		private System.Windows.Forms.Panel panelLogo;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panelPrincipal;
		private System.Windows.Forms.Button btnAsistencia;
		private System.Windows.Forms.Button btnTareas;
		private System.Windows.Forms.Button btnBoletas;
		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.Label lblUsuario;
		private System.Windows.Forms.Button btnReportes;
		private System.Windows.Forms.Button btnJustificacion;
		private System.Windows.Forms.Panel panelIndex;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblTotalEstudiantes;
		private System.Windows.Forms.Label lblTituloEstudiante;
		private System.Windows.Forms.Label lblPresentes;
		private System.Windows.Forms.Label lblTituloPresentes;
		private System.Windows.Forms.Label lblAusentes;
		private System.Windows.Forms.Label lblTituloAusentes;
		private System.Windows.Forms.Label lblTotalProfesores;
		private System.Windows.Forms.Label lblTituloProfesores;
		private System.Windows.Forms.TableLayoutPanel tableKPIs;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox2;
	}
}