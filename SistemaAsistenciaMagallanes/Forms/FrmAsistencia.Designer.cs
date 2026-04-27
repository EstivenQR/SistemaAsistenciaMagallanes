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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAsistencia));
			this.pnlfiltros = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbSeccion = new System.Windows.Forms.ComboBox();
			this.lblMateria = new System.Windows.Forms.Label();
			this.cmbMateria = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.dgvAsistencia = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnMarcarTodos = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.paneltop = new System.Windows.Forms.Panel();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.pnlTotalEstudiantes = new System.Windows.Forms.Panel();
			this.lblTotalEstudiantesTitulo = new System.Windows.Forms.Label();
			this.lblTotalEstudiantes = new System.Windows.Forms.Label();
			this.pnlfiltros.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAsistencia)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.paneltop.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.pnlTotalEstudiantes.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlfiltros
			// 
			this.pnlfiltros.Controls.Add(this.tableLayoutPanel1);
			this.pnlfiltros.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlfiltros.Location = new System.Drawing.Point(0, 99);
			this.pnlfiltros.Name = "pnlfiltros";
			this.pnlfiltros.Size = new System.Drawing.Size(1151, 58);
			this.pnlfiltros.TabIndex = 1;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.pnlTotalEstudiantes, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1151, 58);
			this.tableLayoutPanel1.TabIndex = 7;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.Controls.Add(this.label2);
			this.flowLayoutPanel1.Controls.Add(this.cmbSeccion);
			this.flowLayoutPanel1.Controls.Add(this.lblMateria);
			this.flowLayoutPanel1.Controls.Add(this.cmbMateria);
			this.flowLayoutPanel1.Controls.Add(this.label3);
			this.flowLayoutPanel1.Controls.Add(this.dtpFecha);
			this.flowLayoutPanel1.Controls.Add(this.panel4);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(348, 8);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(684, 47);
			this.flowLayoutPanel1.TabIndex = 6;
			this.flowLayoutPanel1.WrapContents = false;
			this.flowLayoutPanel1.Resize += new System.EventHandler(this.flowLayoutPanel1_Resize);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(3, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Sección";
			// 
			// cmbSeccion
			// 
			this.cmbSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSeccion.FormattingEnabled = true;
			this.cmbSeccion.Location = new System.Drawing.Point(61, 3);
			this.cmbSeccion.Name = "cmbSeccion";
			this.cmbSeccion.Size = new System.Drawing.Size(150, 21);
			this.cmbSeccion.TabIndex = 1;
			this.cmbSeccion.SelectedIndexChanged += new System.EventHandler(this.cmbSeccion_SelectedIndexChanged);
			this.cmbSeccion.SelectionChangeCommitted += new System.EventHandler(this.cmbSeccion_SelectionChangeCommitted);
			// 
			// lblMateria
			// 
			this.lblMateria.AutoSize = true;
			this.lblMateria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMateria.Location = new System.Drawing.Point(217, 0);
			this.lblMateria.Name = "lblMateria";
			this.lblMateria.Size = new System.Drawing.Size(53, 17);
			this.lblMateria.TabIndex = 2;
			this.lblMateria.Text = "Materia";
			// 
			// cmbMateria
			// 
			this.cmbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbMateria.FormattingEnabled = true;
			this.cmbMateria.Location = new System.Drawing.Point(276, 3);
			this.cmbMateria.Name = "cmbMateria";
			this.cmbMateria.Size = new System.Drawing.Size(150, 21);
			this.cmbMateria.TabIndex = 3;
			this.cmbMateria.SelectedIndexChanged += new System.EventHandler(this.cmbMateria_SelectedIndexChanged);
			this.cmbMateria.SelectionChangeCommitted += new System.EventHandler(this.cmbMateria_SelectionChangeCommitted);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(432, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 17);
			this.label3.TabIndex = 5;
			this.label3.Text = "Fecha";
			// 
			// dtpFecha
			// 
			this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFecha.Location = new System.Drawing.Point(479, 3);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(200, 20);
			this.dtpFecha.TabIndex = 4;
			// 
			// dgvAsistencia
			// 
			this.dgvAsistencia.AllowUserToAddRows = false;
			this.dgvAsistencia.BackgroundColor = System.Drawing.Color.White;
			this.dgvAsistencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Transparent;
			dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvAsistencia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
			this.dgvAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvAsistencia.DefaultCellStyle = dataGridViewCellStyle16;
			this.dgvAsistencia.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvAsistencia.Location = new System.Drawing.Point(0, 0);
			this.dgvAsistencia.Name = "dgvAsistencia";
			this.dgvAsistencia.RowHeadersVisible = false;
			this.dgvAsistencia.RowTemplate.Height = 40;
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
			this.panel2.Controls.Add(this.btnSalir);
			this.panel2.Controls.Add(this.btnMarcarTodos);
			this.panel2.Controls.Add(this.btnGuardar);
			this.panel2.Location = new System.Drawing.Point(239, 8);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(667, 50);
			this.panel2.TabIndex = 2;
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.Color.Chocolate;
			this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.ForeColor = System.Drawing.Color.White;
			this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
			this.btnSalir.Location = new System.Drawing.Point(455, 7);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(112, 40);
			this.btnSalir.TabIndex = 2;
			this.btnSalir.Text = "Salir";
			this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSalir.UseVisualStyleBackColor = false;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
			// paneltop
			// 
			this.paneltop.BackColor = System.Drawing.Color.Orange;
			this.paneltop.Controls.Add(this.tableLayoutPanel3);
			this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
			this.paneltop.Location = new System.Drawing.Point(0, 0);
			this.paneltop.Name = "paneltop";
			this.paneltop.Size = new System.Drawing.Size(1151, 99);
			this.paneltop.TabIndex = 0;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 3;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.86598F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.62628F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.50773F));
			this.tableLayoutPanel3.Controls.Add(this.pictureBox1, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.label1, 1, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(1151, 99);
			this.tableLayoutPanel3.TabIndex = 4;
			this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(13, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Padding = new System.Windows.Forms.Padding(20, 0, 10, 0);
			this.pictureBox1.Size = new System.Drawing.Size(142, 93);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
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
			this.label1.Location = new System.Drawing.Point(407, 0);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label1.Size = new System.Drawing.Size(379, 70);
			this.label1.TabIndex = 1;
			this.label1.Text = "ASISTENCIA     ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel4
			// 
			this.panel4.Location = new System.Drawing.Point(685, 3);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(200, 100);
			this.panel4.TabIndex = 7;
			// 
			// pnlTotalEstudiantes
			// 
			this.pnlTotalEstudiantes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlTotalEstudiantes.Controls.Add(this.lblTotalEstudiantes);
			this.pnlTotalEstudiantes.Controls.Add(this.lblTotalEstudiantesTitulo);
			this.pnlTotalEstudiantes.Location = new System.Drawing.Point(3, 8);
			this.pnlTotalEstudiantes.Name = "pnlTotalEstudiantes";
			this.pnlTotalEstudiantes.Size = new System.Drawing.Size(143, 47);
			this.pnlTotalEstudiantes.TabIndex = 7;
			// 
			// lblTotalEstudiantesTitulo
			// 
			this.lblTotalEstudiantesTitulo.AutoSize = true;
			this.lblTotalEstudiantesTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalEstudiantesTitulo.Location = new System.Drawing.Point(7, 0);
			this.lblTotalEstudiantesTitulo.Name = "lblTotalEstudiantesTitulo";
			this.lblTotalEstudiantesTitulo.Size = new System.Drawing.Size(128, 21);
			this.lblTotalEstudiantesTitulo.TabIndex = 0;
			this.lblTotalEstudiantesTitulo.Text = "Total Estudiantes:";
			// 
			// lblTotalEstudiantes
			// 
			this.lblTotalEstudiantes.AutoSize = true;
			this.lblTotalEstudiantes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalEstudiantes.Location = new System.Drawing.Point(55, 21);
			this.lblTotalEstudiantes.Name = "lblTotalEstudiantes";
			this.lblTotalEstudiantes.Size = new System.Drawing.Size(0, 20);
			this.lblTotalEstudiantes.TabIndex = 1;
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
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmAsistencia";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmAsistencia";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FrmAsistencia_Load);
			this.pnlfiltros.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAsistencia)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.paneltop.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.pnlTotalEstudiantes.ResumeLayout(false);
			this.pnlTotalEstudiantes.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
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
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Panel paneltop;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel pnlTotalEstudiantes;
		private System.Windows.Forms.Label lblTotalEstudiantes;
		private System.Windows.Forms.Label lblTotalEstudiantesTitulo;
	}
}