namespace SistemaAsistenciaMagallanes.Forms
{
	partial class FrmMaterias
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMaterias));
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panelprincipal = new System.Windows.Forms.Panel();
			this.panelcontenido = new System.Windows.Forms.Panel();
			this.panelformulario = new System.Windows.Forms.Panel();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.paneltabla = new System.Windows.Forms.Panel();
			this.dgvMaterias = new System.Windows.Forms.DataGridView();
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
			((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
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
			this.panel1.Size = new System.Drawing.Size(1133, 92);
			this.panel1.TabIndex = 1;
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
			this.label1.Location = new System.Drawing.Point(252, 9);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.label1.Size = new System.Drawing.Size(646, 67);
			this.label1.TabIndex = 0;
			this.label1.Text = "GESTIÓN DE MATERIAS     ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.panelprincipal.TabIndex = 2;
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
			this.panelformulario.Controls.Add(this.btnSalir);
			this.panelformulario.Controls.Add(this.btnEliminar);
			this.panelformulario.Controls.Add(this.btnAgregar);
			this.panelformulario.Controls.Add(this.txtNombre);
			this.panelformulario.Controls.Add(this.label3);
			this.panelformulario.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelformulario.Location = new System.Drawing.Point(10, 255);
			this.panelformulario.Name = "panelformulario";
			this.panelformulario.Size = new System.Drawing.Size(1069, 203);
			this.panelformulario.TabIndex = 2;
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.Color.Orange;
			this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSalir.FlatAppearance.BorderSize = 0;
			this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
			this.btnSalir.Location = new System.Drawing.Point(883, 62);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(104, 50);
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
			this.btnEliminar.Location = new System.Drawing.Point(763, 62);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(114, 50);
			this.btnEliminar.TabIndex = 12;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
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
			this.btnAgregar.Location = new System.Drawing.Point(637, 62);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(109, 50);
			this.btnAgregar.TabIndex = 11;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(203, 78);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(300, 20);
			this.txtNombre.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(40, 77);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(145, 21);
			this.label3.TabIndex = 0;
			this.label3.Text = "Nombre Materia:";
			// 
			// paneltabla
			// 
			this.paneltabla.Controls.Add(this.dgvMaterias);
			this.paneltabla.Dock = System.Windows.Forms.DockStyle.Top;
			this.paneltabla.Location = new System.Drawing.Point(10, 110);
			this.paneltabla.Name = "paneltabla";
			this.paneltabla.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
			this.paneltabla.Size = new System.Drawing.Size(1069, 145);
			this.paneltabla.TabIndex = 1;
			// 
			// dgvMaterias
			// 
			this.dgvMaterias.AllowUserToAddRows = false;
			this.dgvMaterias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvMaterias.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgvMaterias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvMaterias.GridColor = System.Drawing.SystemColors.Control;
			this.dgvMaterias.Location = new System.Drawing.Point(0, 20);
			this.dgvMaterias.Name = "dgvMaterias";
			this.dgvMaterias.ReadOnly = true;
			this.dgvMaterias.Size = new System.Drawing.Size(1069, 125);
			this.dgvMaterias.TabIndex = 0;
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
			// FrmMaterias
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1133, 604);
			this.Controls.Add(this.panelprincipal);
			this.Controls.Add(this.panel1);
			this.Name = "FrmMaterias";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmMaterias";
			this.Load += new System.EventHandler(this.FrmMaterias_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panelprincipal.ResumeLayout(false);
			this.panelcontenido.ResumeLayout(false);
			this.panelformulario.ResumeLayout(false);
			this.panelformulario.PerformLayout();
			this.paneltabla.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
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
		private System.Windows.Forms.DataGridView dgvMaterias;
		private System.Windows.Forms.Panel panelbuscador;
		private System.Windows.Forms.Button btnbuscar;
		private System.Windows.Forms.TextBox txtbuscar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label3;
	}
}