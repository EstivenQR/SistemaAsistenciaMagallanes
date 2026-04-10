namespace SistemaAsistenciaMagallanes.Forms
{
	partial class FrmTareas
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTareas));
			this.paneltop = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pnlfiltros = new System.Windows.Forms.Panel();
			this.cmbTarea = new System.Windows.Forms.ComboBox();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.lblTarea = new System.Windows.Forms.Label();
			this.cmbMateria = new System.Windows.Forms.ComboBox();
			this.lblMateria = new System.Windows.Forms.Label();
			this.cmbSeccion = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dgvTareas = new System.Windows.Forms.DataGridView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
			this.btnCrearTarea = new System.Windows.Forms.Button();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.txtTitulo = new System.Windows.Forms.TextBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.paneltop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.pnlfiltros.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// paneltop
			// 
			this.paneltop.BackColor = System.Drawing.Color.Orange;
			this.paneltop.Controls.Add(this.pictureBox2);
			this.paneltop.Controls.Add(this.pictureBox1);
			this.paneltop.Controls.Add(this.label1);
			this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
			this.paneltop.Location = new System.Drawing.Point(0, 0);
			this.paneltop.Name = "paneltop";
			this.paneltop.Size = new System.Drawing.Size(1143, 99);
			this.paneltop.TabIndex = 1;
			// 
			// pictureBox1
			// 
			this.pictureBox1.ErrorImage = null;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(6, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(159, 118);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1143, 99);
			this.label1.TabIndex = 0;
			this.label1.Text = "GESTIÓN DE TAREAS";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnlfiltros
			// 
			this.pnlfiltros.Controls.Add(this.cmbTarea);
			this.pnlfiltros.Controls.Add(this.btnGuardar);
			this.pnlfiltros.Controls.Add(this.lblTarea);
			this.pnlfiltros.Controls.Add(this.cmbMateria);
			this.pnlfiltros.Controls.Add(this.lblMateria);
			this.pnlfiltros.Controls.Add(this.cmbSeccion);
			this.pnlfiltros.Controls.Add(this.label2);
			this.pnlfiltros.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlfiltros.Location = new System.Drawing.Point(0, 99);
			this.pnlfiltros.Name = "pnlfiltros";
			this.pnlfiltros.Size = new System.Drawing.Size(1143, 120);
			this.pnlfiltros.TabIndex = 2;
			// 
			// cmbTarea
			// 
			this.cmbTarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTarea.FormattingEnabled = true;
			this.cmbTarea.Location = new System.Drawing.Point(767, 46);
			this.cmbTarea.Name = "cmbTarea";
			this.cmbTarea.Size = new System.Drawing.Size(150, 21);
			this.cmbTarea.TabIndex = 5;
			this.cmbTarea.SelectedIndexChanged += new System.EventHandler(this.cmbTarea_SelectedIndexChanged);
			this.cmbTarea.SelectionChangeCommitted += new System.EventHandler(this.cmbTarea_SelectionChangeCommitted);
			// 
			// btnGuardar
			// 
			this.btnGuardar.BackColor = System.Drawing.Color.YellowGreen;
			this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardar.ForeColor = System.Drawing.Color.White;
			this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
			this.btnGuardar.Location = new System.Drawing.Point(968, 26);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(103, 56);
			this.btnGuardar.TabIndex = 7;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnGuardar.UseVisualStyleBackColor = false;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// lblTarea
			// 
			this.lblTarea.AutoSize = true;
			this.lblTarea.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTarea.Location = new System.Drawing.Point(721, 46);
			this.lblTarea.Name = "lblTarea";
			this.lblTarea.Size = new System.Drawing.Size(40, 17);
			this.lblTarea.TabIndex = 4;
			this.lblTarea.Text = "Tarea";
			// 
			// cmbMateria
			// 
			this.cmbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbMateria.FormattingEnabled = true;
			this.cmbMateria.Location = new System.Drawing.Point(530, 46);
			this.cmbMateria.Name = "cmbMateria";
			this.cmbMateria.Size = new System.Drawing.Size(150, 21);
			this.cmbMateria.TabIndex = 3;
			this.cmbMateria.SelectedIndexChanged += new System.EventHandler(this.cmbMateria_SelectedIndexChanged);
			this.cmbMateria.SelectionChangeCommitted += new System.EventHandler(this.cmbMateria_SelectionChangeCommitted);
			// 
			// lblMateria
			// 
			this.lblMateria.AutoSize = true;
			this.lblMateria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMateria.Location = new System.Drawing.Point(472, 46);
			this.lblMateria.Name = "lblMateria";
			this.lblMateria.Size = new System.Drawing.Size(53, 17);
			this.lblMateria.TabIndex = 2;
			this.lblMateria.Text = "Materia";
			// 
			// cmbSeccion
			// 
			this.cmbSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSeccion.FormattingEnabled = true;
			this.cmbSeccion.Location = new System.Drawing.Point(272, 46);
			this.cmbSeccion.Name = "cmbSeccion";
			this.cmbSeccion.Size = new System.Drawing.Size(150, 21);
			this.cmbSeccion.TabIndex = 1;
			this.cmbSeccion.SelectedIndexChanged += new System.EventHandler(this.cmbSeccion_SelectedIndexChanged);
			this.cmbSeccion.SelectionChangeCommitted += new System.EventHandler(this.cmbSeccion_SelectionChangeCommitted);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(214, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Sección";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.dgvTareas);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 219);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1143, 331);
			this.panel1.TabIndex = 3;
			// 
			// dgvTareas
			// 
			this.dgvTareas.AllowUserToAddRows = false;
			this.dgvTareas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvTareas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvTareas.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvTareas.Dock = System.Windows.Forms.DockStyle.Top;
			this.dgvTareas.Location = new System.Drawing.Point(0, 0);
			this.dgvTareas.Name = "dgvTareas";
			this.dgvTareas.Size = new System.Drawing.Size(1143, 206);
			this.dgvTareas.TabIndex = 0;
			this.dgvTareas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTareas_CellClick);
			this.dgvTareas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTareas_CellContentClick);
			this.dgvTareas.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTareas_CellValueChanged);
			this.dgvTareas.SelectionChanged += new System.EventHandler(this.dgvTareas_SelectionChanged);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnEliminar);
			this.panel2.Controls.Add(this.btnEditar);
			this.panel2.Controls.Add(this.btnSalir);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.dtpFechaEntrega);
			this.panel2.Controls.Add(this.btnCrearTarea);
			this.panel2.Controls.Add(this.txtDescripcion);
			this.panel2.Controls.Add(this.txtTitulo);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 423);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1143, 207);
			this.panel2.TabIndex = 4;
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.Color.Crimson;
			this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.ForeColor = System.Drawing.Color.White;
			this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
			this.btnEliminar.Location = new System.Drawing.Point(684, 40);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(103, 56);
			this.btnEliminar.TabIndex = 10;
			this.btnEliminar.Text = "Eliminar Tarea";
			this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.BackColor = System.Drawing.Color.SteelBlue;
			this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditar.ForeColor = System.Drawing.Color.White;
			this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
			this.btnEditar.Location = new System.Drawing.Point(575, 110);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(103, 56);
			this.btnEditar.TabIndex = 9;
			this.btnEditar.Text = "Editar Tarea";
			this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEditar.UseVisualStyleBackColor = false;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.Color.Orange;
			this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.ForeColor = System.Drawing.Color.White;
			this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
			this.btnSalir.Location = new System.Drawing.Point(684, 110);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(103, 56);
			this.btnSalir.TabIndex = 8;
			this.btnSalir.Text = "Salir";
			this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSalir.UseVisualStyleBackColor = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(174, 123);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 17);
			this.label5.TabIndex = 6;
			this.label5.Text = "Descripción";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(188, 73);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 17);
			this.label4.TabIndex = 5;
			this.label4.Text = "Titulo";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(165, 17);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(113, 17);
			this.label3.TabIndex = 4;
			this.label3.Text = "Fecha de Entrega";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// dtpFechaEntrega
			// 
			this.dtpFechaEntrega.Location = new System.Drawing.Point(127, 40);
			this.dtpFechaEntrega.Name = "dtpFechaEntrega";
			this.dtpFechaEntrega.Size = new System.Drawing.Size(200, 20);
			this.dtpFechaEntrega.TabIndex = 3;
			// 
			// btnCrearTarea
			// 
			this.btnCrearTarea.BackColor = System.Drawing.Color.YellowGreen;
			this.btnCrearTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCrearTarea.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCrearTarea.ForeColor = System.Drawing.Color.White;
			this.btnCrearTarea.Image = ((System.Drawing.Image)(resources.GetObject("btnCrearTarea.Image")));
			this.btnCrearTarea.Location = new System.Drawing.Point(577, 40);
			this.btnCrearTarea.Name = "btnCrearTarea";
			this.btnCrearTarea.Size = new System.Drawing.Size(103, 56);
			this.btnCrearTarea.TabIndex = 0;
			this.btnCrearTarea.Text = "Crear Tarea";
			this.btnCrearTarea.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCrearTarea.UseVisualStyleBackColor = false;
			this.btnCrearTarea.Click += new System.EventHandler(this.btnCrearTarea_Click);
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Location = new System.Drawing.Point(127, 146);
			this.txtDescripcion.Multiline = true;
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(200, 47);
			this.txtDescripcion.TabIndex = 2;
			this.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtTitulo
			// 
			this.txtTitulo.Location = new System.Drawing.Point(127, 93);
			this.txtTitulo.Name = "txtTitulo";
			this.txtTitulo.Size = new System.Drawing.Size(200, 20);
			this.txtTitulo.TabIndex = 1;
			this.txtTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(706, 12);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(119, 73);
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// FrmTareas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1143, 630);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pnlfiltros);
			this.Controls.Add(this.paneltop);
			this.Name = "FrmTareas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmTareas";
			this.Load += new System.EventHandler(this.FrmTareas_Load);
			this.paneltop.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.pnlfiltros.ResumeLayout(false);
			this.pnlfiltros.PerformLayout();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel paneltop;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel pnlfiltros;
		private System.Windows.Forms.ComboBox cmbMateria;
		private System.Windows.Forms.Label lblMateria;
		private System.Windows.Forms.ComboBox cmbSeccion;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dgvTareas;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ComboBox cmbTarea;
		private System.Windows.Forms.Label lblTarea;
		private System.Windows.Forms.Button btnCrearTarea;
		private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.TextBox txtTitulo;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.PictureBox pictureBox2;
	}
}