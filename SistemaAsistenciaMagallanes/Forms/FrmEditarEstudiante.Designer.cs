namespace SistemaAsistenciaMagallanes.Forms
{
	partial class FrmEditarEstudiante
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarEstudiante));
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.chkReligion = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
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
			this.btnGuardar = new System.Windows.Forms.Button();
			this.chkEstado = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
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
			this.panel1.Size = new System.Drawing.Size(910, 100);
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
			this.label1.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
			this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label1.Location = new System.Drawing.Point(263, 21);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.label1.Size = new System.Drawing.Size(478, 47);
			this.label1.TabIndex = 1;
			this.label1.Text = "EDICIÓN DE INFORMACIÓN   ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 100);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new System.Windows.Forms.Padding(20);
			this.panel2.Size = new System.Drawing.Size(910, 388);
			this.panel2.TabIndex = 2;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.label9);
			this.panel3.Controls.Add(this.chkReligion);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.dtpFechaNacimiento);
			this.panel3.Controls.Add(this.cmbSeccion);
			this.panel3.Controls.Add(this.label8);
			this.panel3.Controls.Add(this.txtNumeroEncargado);
			this.panel3.Controls.Add(this.label7);
			this.panel3.Controls.Add(this.txtCedula);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.label6);
			this.panel3.Controls.Add(this.txtApellido);
			this.panel3.Controls.Add(this.txtNombre);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.btnSalir);
			this.panel3.Controls.Add(this.btnGuardar);
			this.panel3.Controls.Add(this.chkEstado);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(20, 20);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(870, 348);
			this.panel3.TabIndex = 0;
			this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(496, 181);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(68, 21);
			this.label9.TabIndex = 41;
			this.label9.Text = "Estado:";
			// 
			// chkReligion
			// 
			this.chkReligion.AutoSize = true;
			this.chkReligion.Location = new System.Drawing.Point(216, 186);
			this.chkReligion.Name = "chkReligion";
			this.chkReligion.Size = new System.Drawing.Size(15, 14);
			this.chkReligion.TabIndex = 40;
			this.chkReligion.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(49, 181);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(136, 21);
			this.label2.TabIndex = 39;
			this.label2.Text = "Recibe Religion:";
			// 
			// dtpFechaNacimiento
			// 
			this.dtpFechaNacimiento.Cursor = System.Windows.Forms.Cursors.Hand;
			this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFechaNacimiento.Location = new System.Drawing.Point(624, 89);
			this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
			this.dtpFechaNacimiento.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.dtpFechaNacimiento.Size = new System.Drawing.Size(227, 20);
			this.dtpFechaNacimiento.TabIndex = 38;
			this.dtpFechaNacimiento.Value = new System.DateTime(2026, 3, 11, 0, 0, 0, 0);
			// 
			// cmbSeccion
			// 
			this.cmbSeccion.FormattingEnabled = true;
			this.cmbSeccion.Location = new System.Drawing.Point(624, 153);
			this.cmbSeccion.Name = "cmbSeccion";
			this.cmbSeccion.Size = new System.Drawing.Size(227, 21);
			this.cmbSeccion.TabIndex = 37;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(490, 150);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(74, 21);
			this.label8.TabIndex = 36;
			this.label8.Text = "Sección:";
			// 
			// txtNumeroEncargado
			// 
			this.txtNumeroEncargado.Location = new System.Drawing.Point(624, 123);
			this.txtNumeroEncargado.Name = "txtNumeroEncargado";
			this.txtNumeroEncargado.Size = new System.Drawing.Size(227, 20);
			this.txtNumeroEncargado.TabIndex = 35;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(459, 120);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(165, 21);
			this.label7.TabIndex = 34;
			this.label7.Text = "Número Encargado:";
			// 
			// txtCedula
			// 
			this.txtCedula.Location = new System.Drawing.Point(216, 150);
			this.txtCedula.Name = "txtCedula";
			this.txtCedula.Size = new System.Drawing.Size(227, 20);
			this.txtCedula.TabIndex = 33;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(459, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(155, 21);
			this.label4.TabIndex = 32;
			this.label4.Text = "Fecha Nacimineto:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(51, 147);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(68, 21);
			this.label6.TabIndex = 31;
			this.label6.Text = "Cedula:";
			// 
			// txtApellido
			// 
			this.txtApellido.Location = new System.Drawing.Point(216, 119);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(227, 20);
			this.txtApellido.TabIndex = 30;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(216, 88);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(227, 20);
			this.txtNombre.TabIndex = 29;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(51, 116);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(89, 21);
			this.label5.TabIndex = 28;
			this.label5.Text = "Apellidos:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(51, 85);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 21);
			this.label3.TabIndex = 27;
			this.label3.Text = "Nombre:";
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.Color.Orange;
			this.btnSalir.FlatAppearance.BorderSize = 0;
			this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.ForeColor = System.Drawing.Color.Transparent;
			this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
			this.btnSalir.Location = new System.Drawing.Point(463, 259);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(134, 47);
			this.btnSalir.TabIndex = 23;
			this.btnSalir.Text = "Salir";
			this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSalir.UseVisualStyleBackColor = false;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.AccessibleName = "btnGuardar";
			this.btnGuardar.BackColor = System.Drawing.Color.Orange;
			this.btnGuardar.FlatAppearance.BorderSize = 0;
			this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardar.ForeColor = System.Drawing.SystemColors.Control;
			this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
			this.btnGuardar.Location = new System.Drawing.Point(273, 259);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(134, 47);
			this.btnGuardar.TabIndex = 22;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnGuardar.UseVisualStyleBackColor = false;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// chkEstado
			// 
			this.chkEstado.AutoSize = true;
			this.chkEstado.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkEstado.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.chkEstado.Location = new System.Drawing.Point(624, 189);
			this.chkEstado.Name = "chkEstado";
			this.chkEstado.Size = new System.Drawing.Size(15, 14);
			this.chkEstado.TabIndex = 21;
			this.chkEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.chkEstado.UseVisualStyleBackColor = true;
			// 
			// FrmEditarEstudiante
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(910, 488);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "FrmEditarEstudiante";
			this.Text = "EditarEstudiante";
			this.Load += new System.EventHandler(this.EditarEstudiante_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.CheckBox chkEstado;
		private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
		private System.Windows.Forms.ComboBox cmbSeccion;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtNumeroEncargado;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtCedula;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtApellido;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.CheckBox chkReligion;
		private System.Windows.Forms.Label label2;
	}
}