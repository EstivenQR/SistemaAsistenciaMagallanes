namespace SistemaAsistenciaMagallanes.Forms
{
	partial class FrmEditarUsuario
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarUsuario));
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.chkEstado = new System.Windows.Forms.CheckBox();
			this.btnmostrar = new System.Windows.Forms.Button();
			this.cmbRol = new System.Windows.Forms.ComboBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
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
			this.panel1.Size = new System.Drawing.Size(800, 100);
			this.panel1.TabIndex = 0;
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
			this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label1.Location = new System.Drawing.Point(179, 25);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.label1.Size = new System.Drawing.Size(478, 47);
			this.label1.TabIndex = 1;
			this.label1.Text = "EDICIÓN DE INFORMACIÓN   ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 100);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new System.Windows.Forms.Padding(20);
			this.panel2.Size = new System.Drawing.Size(800, 350);
			this.panel2.TabIndex = 1;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.btnSalir);
			this.panel3.Controls.Add(this.btnGuardar);
			this.panel3.Controls.Add(this.chkEstado);
			this.panel3.Controls.Add(this.btnmostrar);
			this.panel3.Controls.Add(this.cmbRol);
			this.panel3.Controls.Add(this.txtPassword);
			this.panel3.Controls.Add(this.txtUsuario);
			this.panel3.Controls.Add(this.txtNombre);
			this.panel3.Controls.Add(this.label7);
			this.panel3.Controls.Add(this.label6);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(20, 20);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(760, 310);
			this.panel3.TabIndex = 0;
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.Color.Orange;
			this.btnSalir.FlatAppearance.BorderSize = 0;
			this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.ForeColor = System.Drawing.Color.Transparent;
			this.btnSalir.Location = new System.Drawing.Point(406, 254);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(97, 38);
			this.btnSalir.TabIndex = 23;
			this.btnSalir.Text = "Salir";
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
			this.btnGuardar.Location = new System.Drawing.Point(268, 254);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(97, 38);
			this.btnGuardar.TabIndex = 22;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = false;
			this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
			// 
			// chkEstado
			// 
			this.chkEstado.AutoSize = true;
			this.chkEstado.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkEstado.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.chkEstado.Location = new System.Drawing.Point(341, 210);
			this.chkEstado.Name = "chkEstado";
			this.chkEstado.Size = new System.Drawing.Size(80, 25);
			this.chkEstado.TabIndex = 21;
			this.chkEstado.Text = "Activo";
			this.chkEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.chkEstado.UseVisualStyleBackColor = true;
			// 
			// btnmostrar
			// 
			this.btnmostrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnmostrar.FlatAppearance.BorderSize = 0;
			this.btnmostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnmostrar.Image = ((System.Drawing.Image)(resources.GetObject("btnmostrar.Image")));
			this.btnmostrar.Location = new System.Drawing.Point(574, 141);
			this.btnmostrar.Name = "btnmostrar";
			this.btnmostrar.Size = new System.Drawing.Size(24, 21);
			this.btnmostrar.TabIndex = 20;
			this.btnmostrar.UseVisualStyleBackColor = true;
			this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
			// 
			// cmbRol
			// 
			this.cmbRol.FormattingEnabled = true;
			this.cmbRol.Location = new System.Drawing.Point(268, 174);
			this.cmbRol.Name = "cmbRol";
			this.cmbRol.Size = new System.Drawing.Size(300, 21);
			this.cmbRol.TabIndex = 19;
			this.cmbRol.SelectedIndexChanged += new System.EventHandler(this.cmbRol_SelectedIndexChanged);
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(268, 142);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(300, 20);
			this.txtPassword.TabIndex = 18;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(268, 111);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(300, 20);
			this.txtUsuario.TabIndex = 17;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(268, 80);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(300, 20);
			this.txtNombre.TabIndex = 16;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(103, 174);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(41, 21);
			this.label7.TabIndex = 7;
			this.label7.Text = "Rol:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(103, 139);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(104, 21);
			this.label6.TabIndex = 6;
			this.label6.Text = "Contraseña:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(103, 111);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(76, 21);
			this.label5.TabIndex = 5;
			this.label5.Text = "Usuario:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(103, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(159, 21);
			this.label2.TabIndex = 4;
			this.label2.Text = "Nombre Completo:";
			// 
			// FrmEditarUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "FrmEditarUsuario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmEditarUsuario";
			this.Load += new System.EventHandler(this.FrmEditarUsuario_Load);
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
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnmostrar;
		private System.Windows.Forms.ComboBox cmbRol;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.CheckBox chkEstado;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}