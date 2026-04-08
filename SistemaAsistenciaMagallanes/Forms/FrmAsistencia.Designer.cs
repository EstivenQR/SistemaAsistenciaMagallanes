namespace SistemaAsistenciaMagallanes.Forms
{
	partial class FrmAsistencia
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAsistencia));
			this.paneltop = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pnlfiltros = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.cmbMateria = new System.Windows.Forms.ComboBox();
			this.lblMateria = new System.Windows.Forms.Label();
			this.cmbSeccion = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dgvAsistencia = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnMarcarTodos = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.paneltop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.pnlfiltros.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAsistencia)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// paneltop
			// 
			this.paneltop.BackColor = System.Drawing.Color.Orange;
			this.paneltop.Controls.Add(this.pictureBox1);
			this.paneltop.Controls.Add(this.label1);
			this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
			this.paneltop.Location = new System.Drawing.Point(0, 0);
			this.paneltop.Name = "paneltop";
			this.paneltop.Size = new System.Drawing.Size(1151, 99);
			this.paneltop.TabIndex = 0;
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
			this.label1.Size = new System.Drawing.Size(1151, 99);
			this.label1.TabIndex = 0;
			this.label1.Text = "ASISTENCIA DE ESTUDIANTES";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnlfiltros
			// 
			this.pnlfiltros.Controls.Add(this.label3);
			this.pnlfiltros.Controls.Add(this.dtpFecha);
			this.pnlfiltros.Controls.Add(this.cmbMateria);
			this.pnlfiltros.Controls.Add(this.lblMateria);
			this.pnlfiltros.Controls.Add(this.cmbSeccion);
			this.pnlfiltros.Controls.Add(this.label2);
			this.pnlfiltros.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlfiltros.Location = new System.Drawing.Point(0, 99);
			this.pnlfiltros.Name = "pnlfiltros";
			this.pnlfiltros.Size = new System.Drawing.Size(1151, 58);
			this.pnlfiltros.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(527, 23);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 17);
			this.label3.TabIndex = 5;
			this.label3.Text = "Fecha";
			// 
			// dtpFecha
			// 
			this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFecha.Location = new System.Drawing.Point(574, 23);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(200, 20);
			this.dtpFecha.TabIndex = 4;
			// 
			// cmbMateria
			// 
			this.cmbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbMateria.FormattingEnabled = true;
			this.cmbMateria.Location = new System.Drawing.Point(335, 23);
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
			this.lblMateria.Location = new System.Drawing.Point(277, 23);
			this.lblMateria.Name = "lblMateria";
			this.lblMateria.Size = new System.Drawing.Size(53, 17);
			this.lblMateria.TabIndex = 2;
			this.lblMateria.Text = "Materia";
			// 
			// cmbSeccion
			// 
			this.cmbSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSeccion.FormattingEnabled = true;
			this.cmbSeccion.Location = new System.Drawing.Point(77, 23);
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
			this.label2.Location = new System.Drawing.Point(19, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Sección";
			// 
			// dgvAsistencia
			// 
			this.dgvAsistencia.AllowUserToAddRows = false;
			this.dgvAsistencia.BackgroundColor = System.Drawing.Color.White;
			this.dgvAsistencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAsistencia.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvAsistencia.Location = new System.Drawing.Point(0, 0);
			this.dgvAsistencia.Name = "dgvAsistencia";
			this.dgvAsistencia.RowHeadersVisible = false;
			this.dgvAsistencia.RowTemplate.Height = 35;
			this.dgvAsistencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvAsistencia.Size = new System.Drawing.Size(1151, 401);
			this.dgvAsistencia.TabIndex = 2;
			this.dgvAsistencia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsistencia_CellContentClick);
			this.dgvAsistencia.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsistencia_CellValueChanged);
			this.dgvAsistencia.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvAsistencia_CurrentCellDirtyStateChanged);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 558);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1151, 70);
			this.panel1.TabIndex = 3;
			// 
			// panel2
			// 
			this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel2.Controls.Add(this.btnMarcarTodos);
			this.panel2.Controls.Add(this.btnGuardar);
			this.panel2.Location = new System.Drawing.Point(356, 8);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(450, 50);
			this.panel2.TabIndex = 2;
			// 
			// btnMarcarTodos
			// 
			this.btnMarcarTodos.BackColor = System.Drawing.Color.Orange;
			this.btnMarcarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMarcarTodos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMarcarTodos.ForeColor = System.Drawing.Color.White;
			this.btnMarcarTodos.Location = new System.Drawing.Point(12, 7);
			this.btnMarcarTodos.Name = "btnMarcarTodos";
			this.btnMarcarTodos.Size = new System.Drawing.Size(200, 40);
			this.btnMarcarTodos.TabIndex = 0;
			this.btnMarcarTodos.Text = "Marcar Todos Presentes";
			this.btnMarcarTodos.UseVisualStyleBackColor = false;
			this.btnMarcarTodos.Click += new System.EventHandler(this.btnMarcarTodos_Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.BackColor = System.Drawing.Color.YellowGreen;
			this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardar.ForeColor = System.Drawing.Color.White;
			this.btnGuardar.Location = new System.Drawing.Point(233, 7);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(200, 40);
			this.btnGuardar.TabIndex = 1;
			this.btnGuardar.Text = "Guardar Asistencia";
			this.btnGuardar.UseVisualStyleBackColor = false;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.dgvAsistencia);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(0, 157);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1151, 401);
			this.panel3.TabIndex = 4;
			// 
			// FrmAsistencia
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1151, 628);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pnlfiltros);
			this.Controls.Add(this.paneltop);
			this.Name = "FrmAsistencia";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmAsistencia";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FrmAsistencia_Load);
			this.paneltop.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.pnlfiltros.ResumeLayout(false);
			this.pnlfiltros.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAsistencia)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel paneltop;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel pnlfiltros;
		private System.Windows.Forms.ComboBox cmbMateria;
		private System.Windows.Forms.Label lblMateria;
		private System.Windows.Forms.ComboBox cmbSeccion;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.DataGridView dgvAsistencia;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnMarcarTodos;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
	}
}