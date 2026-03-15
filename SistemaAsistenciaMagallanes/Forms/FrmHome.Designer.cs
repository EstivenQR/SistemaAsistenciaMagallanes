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
			this.panelMenu = new System.Windows.Forms.Panel();
			this.btnLogout = new System.Windows.Forms.Button();
			this.btnTareas = new System.Windows.Forms.Button();
			this.btnBoletas = new System.Windows.Forms.Button();
			this.btnAsistencia = new System.Windows.Forms.Button();
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
			this.panelMenu.SuspendLayout();
			this.panelAdminSubmenu.SuspendLayout();
			this.panelLogo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panelPrincipal.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelMenu
			// 
			this.panelMenu.AutoScroll = true;
			this.panelMenu.BackColor = System.Drawing.Color.Orange;
			this.panelMenu.Controls.Add(this.btnLogout);
			this.panelMenu.Controls.Add(this.btnTareas);
			this.panelMenu.Controls.Add(this.btnBoletas);
			this.panelMenu.Controls.Add(this.btnAsistencia);
			this.panelMenu.Controls.Add(this.panelAdminSubmenu);
			this.panelMenu.Controls.Add(this.BtnAdministracion);
			this.panelMenu.Controls.Add(this.panelLogo);
			this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelMenu.Location = new System.Drawing.Point(0, 0);
			this.panelMenu.Name = "panelMenu";
			this.panelMenu.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
			this.panelMenu.Size = new System.Drawing.Size(247, 716);
			this.panelMenu.TabIndex = 0;
			this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
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
			this.btnLogout.Location = new System.Drawing.Point(0, 609);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.btnLogout.Size = new System.Drawing.Size(247, 89);
			this.btnLogout.TabIndex = 9;
			this.btnLogout.Text = " Salir";
			this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnLogout.UseVisualStyleBackColor = true;
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
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
			this.btnTareas.Location = new System.Drawing.Point(0, 520);
			this.btnTareas.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.btnTareas.Name = "btnTareas";
			this.btnTareas.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.btnTareas.Size = new System.Drawing.Size(247, 89);
			this.btnTareas.TabIndex = 8;
			this.btnTareas.Text = "Tareas";
			this.btnTareas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnTareas.UseVisualStyleBackColor = true;
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
			this.btnBoletas.Location = new System.Drawing.Point(0, 437);
			this.btnBoletas.Name = "btnBoletas";
			this.btnBoletas.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.btnBoletas.Size = new System.Drawing.Size(247, 83);
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
			this.btnAsistencia.Location = new System.Drawing.Point(0, 357);
			this.btnAsistencia.Name = "btnAsistencia";
			this.btnAsistencia.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.btnAsistencia.Size = new System.Drawing.Size(247, 80);
			this.btnAsistencia.TabIndex = 6;
			this.btnAsistencia.Text = " ASISTENCIA ";
			this.btnAsistencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAsistencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAsistencia.UseVisualStyleBackColor = true;
			this.btnAsistencia.Click += new System.EventHandler(this.btnAsistencia_Click_1);
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
			this.panelAdminSubmenu.Size = new System.Drawing.Size(247, 0);
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
			this.btnMaterias.Size = new System.Drawing.Size(247, 35);
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
			this.btnUsuarios.Size = new System.Drawing.Size(247, 36);
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
			this.btnSecciones.Size = new System.Drawing.Size(247, 36);
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
			this.btnEstudiantes.Size = new System.Drawing.Size(247, 36);
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
			this.BtnAdministracion.Size = new System.Drawing.Size(247, 82);
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
			this.panelLogo.Size = new System.Drawing.Size(247, 255);
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
			this.panelPrincipal.Controls.Add(this.panelMenu);
			this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
			this.panelPrincipal.Name = "panelPrincipal";
			this.panelPrincipal.Size = new System.Drawing.Size(1183, 716);
			this.panelPrincipal.TabIndex = 1;
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
			this.panelMenu.ResumeLayout(false);
			this.panelAdminSubmenu.ResumeLayout(false);
			this.panelLogo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panelPrincipal.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMenu;
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
	}
}