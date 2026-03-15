namespace SistemaAsistenciaMagallanes.Forms
{
	partial class FrmEstudiantes
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstudiantes));
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panelprincipal = new System.Windows.Forms.Panel();
			this.panelcontenido = new System.Windows.Forms.Panel();
			this.panelformulario = new System.Windows.Forms.Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.chkReligion = new System.Windows.Forms.CheckBox();
			this.btnEditar = new System.Windows.Forms.Button();
			this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
			this.cmbSeccion = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtNumeroEncargado = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtCedula = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.paneltabla = new System.Windows.Forms.Panel();
			this.chkMostrarInactivos = new System.Windows.Forms.CheckBox();
			this.dgvEstudiantes = new System.Windows.Forms.DataGridView();
			this.panelbuscador = new System.Windows.Forms.Panel();
			this.btnbuscar = new System.Windows.Forms.Button();
			this.txtbuscar = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panelprincipal.SuspendLayout();
			this.panelcontenido.SuspendLayout();
			this.panelformulario.SuspendLayout();
			this.paneltabla.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
			this.panelbuscador.SuspendLayout();
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
			this.panel1.Size = new System.Drawing.Size(1154, 100);
			this.panel1.TabIndex = 1;
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
			this.label1.Size = new System.Drawing.Size(725, 67);
			this.label1.TabIndex = 1;
			this.label1.Text = "GESTIÓN DE ESTUDIANTES     ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panelprincipal
			// 
			this.panelprincipal.BackColor = System.Drawing.Color.White;
			this.panelprincipal.Controls.Add(this.panelcontenido);
			this.panelprincipal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelprincipal.Location = new System.Drawing.Point(0, 100);
			this.panelprincipal.Name = "panelprincipal";
			this.panelprincipal.Padding = new System.Windows.Forms.Padding(20);
			this.panelprincipal.Size = new System.Drawing.Size(1154, 560);
			this.panelprincipal.TabIndex = 3;
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
			this.panelcontenido.Size = new System.Drawing.Size(1114, 520);
			this.panelcontenido.TabIndex = 0;
			// 
			// panelformulario
			// 
			this.panelformulario.BackColor = System.Drawing.Color.Transparent;
			this.panelformulario.Controls.Add(this.label9);
			this.panelformulario.Controls.Add(this.chkReligion);
			this.panelformulario.Controls.Add(this.btnEditar);
			this.panelformulario.Controls.Add(this.dtpFechaNacimiento);
			this.panelformulario.Controls.Add(this.cmbSeccion);
			this.panelformulario.Controls.Add(this.label8);
			this.panelformulario.Controls.Add(this.txtNumeroEncargado);
			this.panelformulario.Controls.Add(this.label7);
			this.panelformulario.Controls.Add(this.txtCedula);
			this.panelformulario.Controls.Add(this.label4);
			this.panelformulario.Controls.Add(this.label6);
			this.panelformulario.Controls.Add(this.txtApellido);
			this.panelformulario.Controls.Add(this.txtNombre);
			this.panelformulario.Controls.Add(this.label5);
			this.panelformulario.Controls.Add(this.label3);
			this.panelformulario.Controls.Add(this.btnSalir);
			this.panelformulario.Controls.Add(this.btnEliminar);
			this.panelformulario.Controls.Add(this.btnAgregar);
			this.panelformulario.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelformulario.Location = new System.Drawing.Point(10, 255);
			this.panelformulario.Name = "panelformulario";
			this.panelformulario.Size = new System.Drawing.Size(1090, 251);
			this.panelformulario.TabIndex = 2;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(443, 116);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(136, 21);
			this.label9.TabIndex = 29;
			this.label9.Text = "Recibe Religión:";
			// 
			// chkReligion
			// 
			this.chkReligion.AutoSize = true;
			this.chkReligion.Location = new System.Drawing.Point(608, 123);
			this.chkReligion.Name = "chkReligion";
			this.chkReligion.Size = new System.Drawing.Size(15, 14);
			this.chkReligion.TabIndex = 28;
			this.chkReligion.UseVisualStyleBackColor = true;
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
			this.btnEditar.Location = new System.Drawing.Point(964, 113);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(109, 50);
			this.btnEditar.TabIndex = 27;
			this.btnEditar.Text = "Editar";
			this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEditar.UseVisualStyleBackColor = false;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// dtpFechaNacimiento
			// 
			this.dtpFechaNacimiento.Cursor = System.Windows.Forms.Cursors.Hand;
			this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFechaNacimiento.Location = new System.Drawing.Point(608, 25);
			this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
			this.dtpFechaNacimiento.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.dtpFechaNacimiento.Size = new System.Drawing.Size(227, 20);
			this.dtpFechaNacimiento.TabIndex = 26;
			this.dtpFechaNacimiento.Value = new System.DateTime(2026, 3, 11, 0, 0, 0, 0);
			// 
			// cmbSeccion
			// 
			this.cmbSeccion.FormattingEnabled = true;
			this.cmbSeccion.Location = new System.Drawing.Point(608, 89);
			this.cmbSeccion.Name = "cmbSeccion";
			this.cmbSeccion.Size = new System.Drawing.Size(227, 21);
			this.cmbSeccion.TabIndex = 25;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(474, 86);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(74, 21);
			this.label8.TabIndex = 24;
			this.label8.Text = "Sección:";
			// 
			// txtNumeroEncargado
			// 
			this.txtNumeroEncargado.Location = new System.Drawing.Point(608, 59);
			this.txtNumeroEncargado.Name = "txtNumeroEncargado";
			this.txtNumeroEncargado.Size = new System.Drawing.Size(227, 20);
			this.txtNumeroEncargado.TabIndex = 23;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(443, 56);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(165, 21);
			this.label7.TabIndex = 22;
			this.label7.Text = "Número Encargado:";
			// 
			// txtCedula
			// 
			this.txtCedula.Location = new System.Drawing.Point(200, 86);
			this.txtCedula.Name = "txtCedula";
			this.txtCedula.Size = new System.Drawing.Size(227, 20);
			this.txtCedula.TabIndex = 20;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(443, 24);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(155, 21);
			this.label4.TabIndex = 19;
			this.label4.Text = "Fecha Nacimineto:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(35, 83);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(68, 21);
			this.label6.TabIndex = 18;
			this.label6.Text = "Cedula:";
			// 
			// txtApellido
			// 
			this.txtApellido.Location = new System.Drawing.Point(200, 55);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(227, 20);
			this.txtApellido.TabIndex = 17;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(200, 24);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(227, 20);
			this.txtNombre.TabIndex = 16;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(35, 52);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(89, 21);
			this.label5.TabIndex = 15;
			this.label5.Text = "Apellidos:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(35, 21);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 21);
			this.label3.TabIndex = 14;
			this.label3.Text = "Nombre:";
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.Color.Orange;
			this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSalir.FlatAppearance.BorderSize = 0;
			this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
			this.btnSalir.Location = new System.Drawing.Point(964, 169);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(109, 50);
			this.btnSalir.TabIndex = 13;
			this.btnSalir.Text = "Salir";
			this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSalir.UseVisualStyleBackColor = false;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.Color.Crimson;
			this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEliminar.FlatAppearance.BorderSize = 0;
			this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
			this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEliminar.Location = new System.Drawing.Point(844, 169);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(114, 50);
			this.btnEliminar.TabIndex = 12;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEliminar.UseVisualStyleBackColor = false;
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
			this.btnAgregar.Location = new System.Drawing.Point(844, 113);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(114, 50);
			this.btnAgregar.TabIndex = 11;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// paneltabla
			// 
			this.paneltabla.Controls.Add(this.chkMostrarInactivos);
			this.paneltabla.Controls.Add(this.dgvEstudiantes);
			this.paneltabla.Dock = System.Windows.Forms.DockStyle.Top;
			this.paneltabla.Location = new System.Drawing.Point(10, 110);
			this.paneltabla.Name = "paneltabla";
			this.paneltabla.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
			this.paneltabla.Size = new System.Drawing.Size(1090, 145);
			this.paneltabla.TabIndex = 1;
			// 
			// chkMostrarInactivos
			// 
			this.chkMostrarInactivos.AutoSize = true;
			this.chkMostrarInactivos.Location = new System.Drawing.Point(1008, 23);
			this.chkMostrarInactivos.Name = "chkMostrarInactivos";
			this.chkMostrarInactivos.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.chkMostrarInactivos.Size = new System.Drawing.Size(15, 16);
			this.chkMostrarInactivos.TabIndex = 1;
			this.chkMostrarInactivos.UseVisualStyleBackColor = true;
			this.chkMostrarInactivos.CheckedChanged += new System.EventHandler(this.chkMostrarInactivos_CheckedChanged);
			// 
			// dgvEstudiantes
			// 
			this.dgvEstudiantes.AllowUserToAddRows = false;
			this.dgvEstudiantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvEstudiantes.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgvEstudiantes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvEstudiantes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvEstudiantes.GridColor = System.Drawing.SystemColors.Control;
			this.dgvEstudiantes.Location = new System.Drawing.Point(0, 20);
			this.dgvEstudiantes.Name = "dgvEstudiantes";
			this.dgvEstudiantes.ReadOnly = true;
			this.dgvEstudiantes.Size = new System.Drawing.Size(1090, 125);
			this.dgvEstudiantes.TabIndex = 0;
			this.dgvEstudiantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstudiantes_CellClick);
			this.dgvEstudiantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstudiantes_CellContentClick);
			this.dgvEstudiantes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvEstudiantes_CellFormatting);
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
			this.panelbuscador.Size = new System.Drawing.Size(1090, 100);
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
			// FrmEstudiantes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1154, 660);
			this.Controls.Add(this.panelprincipal);
			this.Controls.Add(this.panel1);
			this.Name = "FrmEstudiantes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmEstudiantes";
			this.Load += new System.EventHandler(this.FrmEstudiantes_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panelprincipal.ResumeLayout(false);
			this.panelcontenido.ResumeLayout(false);
			this.panelformulario.ResumeLayout(false);
			this.panelformulario.PerformLayout();
			this.paneltabla.ResumeLayout(false);
			this.paneltabla.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).EndInit();
			this.panelbuscador.ResumeLayout(false);
			this.panelbuscador.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panelprincipal;
		private System.Windows.Forms.Panel panelcontenido;
		private System.Windows.Forms.Panel panelformulario;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Panel paneltabla;
		private System.Windows.Forms.DataGridView dgvEstudiantes;
		private System.Windows.Forms.Panel panelbuscador;
		private System.Windows.Forms.Button btnbuscar;
		private System.Windows.Forms.TextBox txtbuscar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNumeroEncargado;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtCedula;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtApellido;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
		private System.Windows.Forms.ComboBox cmbSeccion;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.CheckBox chkMostrarInactivos;
		private System.Windows.Forms.CheckBox chkReligion;
		private System.Windows.Forms.Label label9;
	}
}