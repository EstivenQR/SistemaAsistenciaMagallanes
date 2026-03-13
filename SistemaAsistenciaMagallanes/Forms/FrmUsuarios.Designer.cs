namespace SistemaAsistenciaMagallanes.Forms
{
	partial class FrmUsuarios
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarios));
			this.panelprincipal = new System.Windows.Forms.Panel();
			this.panelcontenido = new System.Windows.Forms.Panel();
			this.panelformulario = new System.Windows.Forms.Panel();
			this.btnmostrar = new System.Windows.Forms.Button();
			this.cmbRol = new System.Windows.Forms.ComboBox();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.chkEstado = new System.Windows.Forms.CheckBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.paneltabla = new System.Windows.Forms.Panel();
			this.chkMostrarInactivos = new System.Windows.Forms.CheckBox();
			this.dgvUsuarios = new System.Windows.Forms.DataGridView();
			this.panelbuscador = new System.Windows.Forms.Panel();
			this.btnbuscar = new System.Windows.Forms.Button();
			this.txtbuscar = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panelprincipal.SuspendLayout();
			this.panelcontenido.SuspendLayout();
			this.panelformulario.SuspendLayout();
			this.paneltabla.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
			this.panelbuscador.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panelprincipal
			// 
			this.panelprincipal.BackColor = System.Drawing.Color.White;
			this.panelprincipal.Controls.Add(this.panelcontenido);
			this.panelprincipal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelprincipal.Location = new System.Drawing.Point(0, 92);
			this.panelprincipal.Name = "panelprincipal";
			this.panelprincipal.Padding = new System.Windows.Forms.Padding(20);
			this.panelprincipal.Size = new System.Drawing.Size(1133, 512);
			this.panelprincipal.TabIndex = 0;
			this.panelprincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panelprincipal_Paint);
			// 
			// panelcontenido
			// 
			this.panelcontenido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelcontenido.Controls.Add(this.panelformulario);
			this.panelcontenido.Controls.Add(this.paneltabla);
			this.panelcontenido.Controls.Add(this.panelbuscador);
			this.panelcontenido.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelcontenido.Location = new System.Drawing.Point(20, 20);
			this.panelcontenido.Name = "panelcontenido";
			this.panelcontenido.Padding = new System.Windows.Forms.Padding(10);
			this.panelcontenido.Size = new System.Drawing.Size(1093, 472);
			this.panelcontenido.TabIndex = 0;
			// 
			// panelformulario
			// 
			this.panelformulario.BackColor = System.Drawing.Color.Transparent;
			this.panelformulario.Controls.Add(this.btnmostrar);
			this.panelformulario.Controls.Add(this.cmbRol);
			this.panelformulario.Controls.Add(this.btnSalir);
			this.panelformulario.Controls.Add(this.btnEditar);
			this.panelformulario.Controls.Add(this.btnAgregar);
			this.panelformulario.Controls.Add(this.chkEstado);
			this.panelformulario.Controls.Add(this.txtPassword);
			this.panelformulario.Controls.Add(this.txtUsuario);
			this.panelformulario.Controls.Add(this.txtNombre);
			this.panelformulario.Controls.Add(this.label7);
			this.panelformulario.Controls.Add(this.label6);
			this.panelformulario.Controls.Add(this.label5);
			this.panelformulario.Controls.Add(this.label3);
			this.panelformulario.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelformulario.Location = new System.Drawing.Point(10, 255);
			this.panelformulario.Name = "panelformulario";
			this.panelformulario.Size = new System.Drawing.Size(1069, 203);
			this.panelformulario.TabIndex = 2;
			// 
			// btnmostrar
			// 
			this.btnmostrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnmostrar.FlatAppearance.BorderSize = 0;
			this.btnmostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnmostrar.Image = ((System.Drawing.Image)(resources.GetObject("btnmostrar.Image")));
			this.btnmostrar.Location = new System.Drawing.Point(520, 92);
			this.btnmostrar.Name = "btnmostrar";
			this.btnmostrar.Size = new System.Drawing.Size(24, 21);
			this.btnmostrar.TabIndex = 15;
			this.btnmostrar.UseVisualStyleBackColor = true;
			this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
			// 
			// cmbRol
			// 
			this.cmbRol.FormattingEnabled = true;
			this.cmbRol.Location = new System.Drawing.Point(214, 125);
			this.cmbRol.Name = "cmbRol";
			this.cmbRol.Size = new System.Drawing.Size(300, 21);
			this.cmbRol.TabIndex = 14;
			this.cmbRol.SelectedIndexChanged += new System.EventHandler(this.cmbRol_SelectedIndexChanged);
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.Color.Orange;
			this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSalir.FlatAppearance.BorderSize = 0;
			this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
			this.btnSalir.Location = new System.Drawing.Point(883, 78);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(104, 50);
			this.btnSalir.TabIndex = 13;
			this.btnSalir.Text = "Salir";
			this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSalir.UseVisualStyleBackColor = false;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.BackColor = System.Drawing.Color.DodgerBlue;
			this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEditar.FlatAppearance.BorderSize = 0;
			this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
			this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEditar.Location = new System.Drawing.Point(763, 78);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(104, 50);
			this.btnEditar.TabIndex = 12;
			this.btnEditar.Text = "Editar";
			this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEditar.UseVisualStyleBackColor = false;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnAgregar
			// 
			this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAgregar.FlatAppearance.BorderSize = 0;
			this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
			this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAgregar.Location = new System.Drawing.Point(637, 78);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(109, 50);
			this.btnAgregar.TabIndex = 11;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// chkEstado
			// 
			this.chkEstado.AutoSize = true;
			this.chkEstado.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkEstado.Location = new System.Drawing.Point(317, 165);
			this.chkEstado.Name = "chkEstado";
			this.chkEstado.Size = new System.Drawing.Size(80, 25);
			this.chkEstado.TabIndex = 10;
			this.chkEstado.Text = "Activo";
			this.chkEstado.UseVisualStyleBackColor = true;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(214, 93);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(300, 20);
			this.txtPassword.TabIndex = 7;
			this.txtPassword.UseSystemPasswordChar = true;
			this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(214, 62);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(300, 20);
			this.txtUsuario.TabIndex = 6;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(214, 31);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(300, 20);
			this.txtNombre.TabIndex = 5;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(49, 125);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(41, 21);
			this.label7.TabIndex = 4;
			this.label7.Text = "Rol:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(49, 93);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(104, 21);
			this.label6.TabIndex = 3;
			this.label6.Text = "Contraseña:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(49, 59);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(76, 21);
			this.label5.TabIndex = 2;
			this.label5.Text = "Usuario:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(49, 28);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(159, 21);
			this.label3.TabIndex = 0;
			this.label3.Text = "Nombre Completo:";
			// 
			// paneltabla
			// 
			this.paneltabla.Controls.Add(this.chkMostrarInactivos);
			this.paneltabla.Controls.Add(this.dgvUsuarios);
			this.paneltabla.Dock = System.Windows.Forms.DockStyle.Top;
			this.paneltabla.Location = new System.Drawing.Point(10, 110);
			this.paneltabla.Name = "paneltabla";
			this.paneltabla.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
			this.paneltabla.Size = new System.Drawing.Size(1069, 145);
			this.paneltabla.TabIndex = 1;
			// 
			// chkMostrarInactivos
			// 
			this.chkMostrarInactivos.AutoSize = true;
			this.chkMostrarInactivos.Location = new System.Drawing.Point(849, 23);
			this.chkMostrarInactivos.Name = "chkMostrarInactivos";
			this.chkMostrarInactivos.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.chkMostrarInactivos.Size = new System.Drawing.Size(15, 16);
			this.chkMostrarInactivos.TabIndex = 3;
			this.chkMostrarInactivos.UseVisualStyleBackColor = true;
			this.chkMostrarInactivos.CheckedChanged += new System.EventHandler(this.chkMostrarInactivos_CheckedChanged);
			// 
			// dgvUsuarios
			// 
			this.dgvUsuarios.AllowUserToAddRows = false;
			this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvUsuarios.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvUsuarios.GridColor = System.Drawing.SystemColors.Control;
			this.dgvUsuarios.Location = new System.Drawing.Point(0, 20);
			this.dgvUsuarios.Name = "dgvUsuarios";
			this.dgvUsuarios.ReadOnly = true;
			this.dgvUsuarios.Size = new System.Drawing.Size(1069, 125);
			this.dgvUsuarios.TabIndex = 0;
			this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
			// 
			// panelbuscador
			// 
			this.panelbuscador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelbuscador.Controls.Add(this.btnbuscar);
			this.panelbuscador.Controls.Add(this.txtbuscar);
			this.panelbuscador.Controls.Add(this.label2);
			this.panelbuscador.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelbuscador.Location = new System.Drawing.Point(10, 10);
			this.panelbuscador.Name = "panelbuscador";
			this.panelbuscador.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
			this.panelbuscador.Size = new System.Drawing.Size(1069, 100);
			this.panelbuscador.TabIndex = 0;
			// 
			// btnbuscar
			// 
			this.btnbuscar.BackColor = System.Drawing.Color.Orange;
			this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnbuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnbuscar.FlatAppearance.BorderSize = 0;
			this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnbuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnbuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscar.Image")));
			this.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnbuscar.Location = new System.Drawing.Point(848, 32);
			this.btnbuscar.Name = "btnbuscar";
			this.btnbuscar.Size = new System.Drawing.Size(89, 35);
			this.btnbuscar.TabIndex = 2;
			this.btnbuscar.Text = "Buscar";
			this.btnbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnbuscar.UseVisualStyleBackColor = false;
			this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click_1);
			// 
			// txtbuscar
			// 
			this.txtbuscar.Location = new System.Drawing.Point(180, 42);
			this.txtbuscar.Name = "txtbuscar";
			this.txtbuscar.Size = new System.Drawing.Size(650, 20);
			this.txtbuscar.TabIndex = 1;
			this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(94, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 21);
			this.label2.TabIndex = 0;
			this.label2.Text = "BUSCAR:";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Orange;
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1133, 92);
			this.panel1.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, -6);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(145, 98);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
			this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label1.Location = new System.Drawing.Point(244, 9);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.label1.Size = new System.Drawing.Size(645, 67);
			this.label1.TabIndex = 0;
			this.label1.Text = "GESTIÓN DE DOCENTES     ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FrmUsuarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1133, 604);
			this.Controls.Add(this.panelprincipal);
			this.Controls.Add(this.panel1);
			this.Name = "FrmUsuarios";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmUsuarios";
			this.Load += new System.EventHandler(this.FrmUsuarios_Load);
			this.panelprincipal.ResumeLayout(false);
			this.panelcontenido.ResumeLayout(false);
			this.panelformulario.ResumeLayout(false);
			this.panelformulario.PerformLayout();
			this.paneltabla.ResumeLayout(false);
			this.paneltabla.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
			this.panelbuscador.ResumeLayout(false);
			this.panelbuscador.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panelprincipal;
		private System.Windows.Forms.Panel panelcontenido;
		private System.Windows.Forms.Panel panelbuscador;
		private System.Windows.Forms.TextBox txtbuscar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnbuscar;
		private System.Windows.Forms.Panel paneltabla;
		private System.Windows.Forms.DataGridView dgvUsuarios;
		private System.Windows.Forms.Panel panelformulario;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.CheckBox chkEstado;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.ComboBox cmbRol;
		private System.Windows.Forms.Button btnmostrar;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.CheckBox chkMostrarInactivos;
	}
}