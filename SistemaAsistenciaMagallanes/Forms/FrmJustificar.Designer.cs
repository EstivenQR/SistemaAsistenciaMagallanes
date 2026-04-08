namespace SistemaAsistenciaMagallanes.Forms
{
	partial class FrmJustificar
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJustificar));
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblEstudiante = new System.Windows.Forms.Label();
			this.lblFecha = new System.Windows.Forms.Label();
			this.txtMotivo = new System.Windows.Forms.TextBox();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
			this.panel1.Size = new System.Drawing.Size(682, 100);
			this.panel1.TabIndex = 3;
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
			this.label1.Location = new System.Drawing.Point(197, 20);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.label1.Size = new System.Drawing.Size(371, 67);
			this.label1.TabIndex = 1;
			this.label1.Text = "JUSTIFICAR     ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblEstudiante
			// 
			this.lblEstudiante.AutoSize = true;
			this.lblEstudiante.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEstudiante.Location = new System.Drawing.Point(271, 121);
			this.lblEstudiante.Name = "lblEstudiante";
			this.lblEstudiante.Size = new System.Drawing.Size(45, 17);
			this.lblEstudiante.TabIndex = 4;
			this.lblEstudiante.Text = "label2";
			// 
			// lblFecha
			// 
			this.lblFecha.AutoSize = true;
			this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFecha.Location = new System.Drawing.Point(271, 157);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(45, 17);
			this.lblFecha.TabIndex = 5;
			this.lblFecha.Text = "label2";
			// 
			// txtMotivo
			// 
			this.txtMotivo.Location = new System.Drawing.Point(208, 187);
			this.txtMotivo.Multiline = true;
			this.txtMotivo.Name = "txtMotivo";
			this.txtMotivo.Size = new System.Drawing.Size(287, 45);
			this.txtMotivo.TabIndex = 6;
			this.txtMotivo.Enter += new System.EventHandler(this.txtMotivo_Enter);
			this.txtMotivo.Leave += new System.EventHandler(this.txtMotivo_Leave_1);
			// 
			// btnGuardar
			// 
			this.btnGuardar.BackColor = System.Drawing.Color.YellowGreen;
			this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardar.ForeColor = System.Drawing.Color.White;
			this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
			this.btnGuardar.Location = new System.Drawing.Point(208, 254);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(118, 49);
			this.btnGuardar.TabIndex = 7;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnGuardar.UseVisualStyleBackColor = false;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.Color.DarkOrange;
			this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.ForeColor = System.Drawing.Color.White;
			this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
			this.btnSalir.Location = new System.Drawing.Point(377, 254);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(118, 49);
			this.btnSalir.TabIndex = 8;
			this.btnSalir.Text = "Salir";
			this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSalir.UseVisualStyleBackColor = false;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// FrmJustificar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(682, 336);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.txtMotivo);
			this.Controls.Add(this.lblFecha);
			this.Controls.Add(this.lblEstudiante);
			this.Controls.Add(this.panel1);
			this.Name = "FrmJustificar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmJustificar";
			this.Load += new System.EventHandler(this.FrmJustificar_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblEstudiante;
		private System.Windows.Forms.Label lblFecha;
		private System.Windows.Forms.TextBox txtMotivo;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Button btnSalir;
	}
}