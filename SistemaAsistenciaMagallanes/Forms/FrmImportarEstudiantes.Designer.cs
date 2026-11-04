namespace SistemaAsistenciaMagallanes.Forms
{
	partial class FrmImportarEstudiantes
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImportarEstudiantes));
			this.panelHead = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnSeleccionarExcel = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbSeccion = new System.Windows.Forms.ComboBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lblTotalRegistros = new System.Windows.Forms.Label();
			this.lblArchivo = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.dgvPreview = new System.Windows.Forms.DataGridView();
			this.panel4 = new System.Windows.Forms.Panel();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnImportar = new System.Windows.Forms.Button();
			this.panelHead.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).BeginInit();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelHead
			// 
			this.panelHead.BackColor = System.Drawing.Color.Orange;
			this.panelHead.Controls.Add(this.pictureBox1);
			this.panelHead.Controls.Add(this.label1);
			this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelHead.Location = new System.Drawing.Point(0, 0);
			this.panelHead.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.panelHead.Name = "panelHead";
			this.panelHead.Size = new System.Drawing.Size(1170, 100);
			this.panelHead.TabIndex = 10;
			this.panelHead.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHead_Paint);
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
			this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label1.Location = new System.Drawing.Point(295, 18);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.label1.Size = new System.Drawing.Size(638, 67);
			this.label1.TabIndex = 1;
			this.label1.Text = "IMPORTAR ESTUDIANTES";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.btnSeleccionarExcel);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.cmbSeccion);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 100);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1170, 121);
			this.panel1.TabIndex = 11;
			// 
			// btnSeleccionarExcel
			// 
			this.btnSeleccionarExcel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSeleccionarExcel.Location = new System.Drawing.Point(407, 66);
			this.btnSeleccionarExcel.Name = "btnSeleccionarExcel";
			this.btnSeleccionarExcel.Size = new System.Drawing.Size(340, 31);
			this.btnSeleccionarExcel.TabIndex = 2;
			this.btnSeleccionarExcel.Text = "[ Seleccionar Excel ]";
			this.btnSeleccionarExcel.UseVisualStyleBackColor = true;
			this.btnSeleccionarExcel.Click += new System.EventHandler(this.btnSeleccionarExcel_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(404, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(126, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "SECCIÓN DESTINO:";
			// 
			// cmbSeccion
			// 
			this.cmbSeccion.FormattingEnabled = true;
			this.cmbSeccion.Location = new System.Drawing.Point(536, 17);
			this.cmbSeccion.Name = "cmbSeccion";
			this.cmbSeccion.Size = new System.Drawing.Size(211, 21);
			this.cmbSeccion.TabIndex = 0;
			this.cmbSeccion.SelectedIndexChanged += new System.EventHandler(this.cmbSeccion_SelectedIndexChanged);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.lblTotalRegistros);
			this.panel2.Controls.Add(this.lblArchivo);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 221);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1170, 66);
			this.panel2.TabIndex = 12;
			// 
			// lblTotalRegistros
			// 
			this.lblTotalRegistros.AutoSize = true;
			this.lblTotalRegistros.Location = new System.Drawing.Point(534, 38);
			this.lblTotalRegistros.Name = "lblTotalRegistros";
			this.lblTotalRegistros.Size = new System.Drawing.Size(35, 13);
			this.lblTotalRegistros.TabIndex = 1;
			this.lblTotalRegistros.Text = "label3";
			// 
			// lblArchivo
			// 
			this.lblArchivo.AutoSize = true;
			this.lblArchivo.Location = new System.Drawing.Point(534, 15);
			this.lblArchivo.Name = "lblArchivo";
			this.lblArchivo.Size = new System.Drawing.Size(35, 13);
			this.lblArchivo.TabIndex = 0;
			this.lblArchivo.Text = "label3";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.dgvPreview);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(0, 287);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1170, 412);
			this.panel3.TabIndex = 13;
			// 
			// dgvPreview
			// 
			this.dgvPreview.AllowUserToAddRows = false;
			this.dgvPreview.AllowUserToDeleteRows = false;
			this.dgvPreview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPreview.Dock = System.Windows.Forms.DockStyle.Top;
			this.dgvPreview.Location = new System.Drawing.Point(0, 0);
			this.dgvPreview.MultiSelect = false;
			this.dgvPreview.Name = "dgvPreview";
			this.dgvPreview.ReadOnly = true;
			this.dgvPreview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvPreview.Size = new System.Drawing.Size(1170, 248);
			this.dgvPreview.TabIndex = 0;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.btnCancelar);
			this.panel4.Controls.Add(this.btnImportar);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel4.Location = new System.Drawing.Point(0, 602);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(1170, 97);
			this.panel4.TabIndex = 14;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(408, 48);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(340, 30);
			this.btnCancelar.TabIndex = 1;
			this.btnCancelar.Text = "[ Cancelar ]";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnImportar
			// 
			this.btnImportar.Location = new System.Drawing.Point(408, 14);
			this.btnImportar.Name = "btnImportar";
			this.btnImportar.Size = new System.Drawing.Size(340, 30);
			this.btnImportar.TabIndex = 0;
			this.btnImportar.Text = "[ Importar estudiantes ]";
			this.btnImportar.UseVisualStyleBackColor = true;
			this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
			// 
			// FrmImportarEstudiantes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1170, 699);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panelHead);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmImportarEstudiantes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmImportarEstudiantes";
			this.Load += new System.EventHandler(this.FrmImportarEstudiantes_Load);
			this.panelHead.ResumeLayout(false);
			this.panelHead.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).EndInit();
			this.panel4.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelHead;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnSeleccionarExcel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbSeccion;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lblTotalRegistros;
		private System.Windows.Forms.Label lblArchivo;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.DataGridView dgvPreview;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnImportar;
	}
}