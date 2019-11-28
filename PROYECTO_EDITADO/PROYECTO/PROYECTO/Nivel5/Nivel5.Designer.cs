namespace LoginProyecto
{
	partial class FrmNivel5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNivel5));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblConcepto = new System.Windows.Forms.Label();
            this.txtConceptos = new System.Windows.Forms.TextBox();
            this.txtBurbuja = new System.Windows.Forms.TextBox();
            this.lblBurbuja = new System.Windows.Forms.Label();
            this.pbImagen1 = new System.Windows.Forms.PictureBox();
            this.btnPrueba = new System.Windows.Forms.Button();
            this.pbImagen2 = new System.Windows.Forms.PictureBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.ptLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(473, 37);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(157, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = " Vectores";
            // 
            // lblConcepto
            // 
            this.lblConcepto.AutoSize = true;
            this.lblConcepto.BackColor = System.Drawing.Color.Transparent;
            this.lblConcepto.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConcepto.Location = new System.Drawing.Point(37, 63);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(78, 18);
            this.lblConcepto.TabIndex = 1;
            this.lblConcepto.Text = "Concepto:";
            this.lblConcepto.Click += new System.EventHandler(this.lblConcepto_Click);
            // 
            // txtConceptos
            // 
            this.txtConceptos.BackColor = System.Drawing.Color.White;
            this.txtConceptos.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConceptos.Location = new System.Drawing.Point(40, 94);
            this.txtConceptos.Multiline = true;
            this.txtConceptos.Name = "txtConceptos";
            this.txtConceptos.ReadOnly = true;
            this.txtConceptos.Size = new System.Drawing.Size(464, 95);
            this.txtConceptos.TabIndex = 3;
            this.txtConceptos.Text = resources.GetString("txtConceptos.Text");
            this.txtConceptos.TextChanged += new System.EventHandler(this.txtConceptos_TextChanged);
            // 
            // txtBurbuja
            // 
            this.txtBurbuja.BackColor = System.Drawing.Color.White;
            this.txtBurbuja.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBurbuja.Location = new System.Drawing.Point(40, 445);
            this.txtBurbuja.Multiline = true;
            this.txtBurbuja.Name = "txtBurbuja";
            this.txtBurbuja.ReadOnly = true;
            this.txtBurbuja.Size = new System.Drawing.Size(492, 125);
            this.txtBurbuja.TabIndex = 4;
            this.txtBurbuja.Text = resources.GetString("txtBurbuja.Text");
            // 
            // lblBurbuja
            // 
            this.lblBurbuja.AutoSize = true;
            this.lblBurbuja.BackColor = System.Drawing.Color.Transparent;
            this.lblBurbuja.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBurbuja.Location = new System.Drawing.Point(37, 408);
            this.lblBurbuja.Name = "lblBurbuja";
            this.lblBurbuja.Size = new System.Drawing.Size(171, 18);
            this.lblBurbuja.TabIndex = 5;
            this.lblBurbuja.Text = "Ordenamiento burbuja:";
            // 
            // pbImagen1
            // 
            this.pbImagen1.BackColor = System.Drawing.Color.Transparent;
            this.pbImagen1.Image = ((System.Drawing.Image)(resources.GetObject("pbImagen1.Image")));
            this.pbImagen1.Location = new System.Drawing.Point(40, 210);
            this.pbImagen1.Name = "pbImagen1";
            this.pbImagen1.Size = new System.Drawing.Size(400, 169);
            this.pbImagen1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen1.TabIndex = 7;
            this.pbImagen1.TabStop = false;
            // 
            // btnPrueba
            // 
            this.btnPrueba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(35)))));
            this.btnPrueba.FlatAppearance.BorderSize = 0;
            this.btnPrueba.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrueba.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrueba.ForeColor = System.Drawing.Color.White;
            this.btnPrueba.Location = new System.Drawing.Point(1033, 653);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(101, 33);
            this.btnPrueba.TabIndex = 9;
            this.btnPrueba.Text = "Evaluar";
            this.btnPrueba.UseVisualStyleBackColor = false;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // pbImagen2
            // 
            this.pbImagen2.Image = ((System.Drawing.Image)(resources.GetObject("pbImagen2.Image")));
            this.pbImagen2.Location = new System.Drawing.Point(554, 133);
            this.pbImagen2.Name = "pbImagen2";
            this.pbImagen2.Size = new System.Drawing.Size(513, 511);
            this.pbImagen2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen2.TabIndex = 10;
            this.pbImagen2.TabStop = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(130)))), ((int)(((byte)(118)))));
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(40, 653);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(101, 33);
            this.btnRegresar.TabIndex = 11;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1146, 34);
            this.panelTitulo.TabIndex = 20;
            // 
            // ptLogo
            // 
            this.ptLogo.BackColor = System.Drawing.Color.Transparent;
            this.ptLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptLogo.Image")));
            this.ptLogo.Location = new System.Drawing.Point(1037, 37);
            this.ptLogo.Name = "ptLogo";
            this.ptLogo.Size = new System.Drawing.Size(105, 90);
            this.ptLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptLogo.TabIndex = 46;
            this.ptLogo.TabStop = false;
            // 
            // FrmNivel5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1146, 698);
            this.Controls.Add(this.ptLogo);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.pbImagen2);
            this.Controls.Add(this.btnPrueba);
            this.Controls.Add(this.pbImagen1);
            this.Controls.Add(this.lblBurbuja);
            this.Controls.Add(this.txtBurbuja);
            this.Controls.Add(this.txtConceptos);
            this.Controls.Add(this.lblConcepto);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNivel5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nivel5";
            this.Load += new System.EventHandler(this.FrmNivel5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblConcepto;
		private System.Windows.Forms.TextBox txtConceptos;
		private System.Windows.Forms.TextBox txtBurbuja;
		private System.Windows.Forms.Label lblBurbuja;
		private System.Windows.Forms.PictureBox pbImagen1;
		private System.Windows.Forms.Button btnPrueba;
		private System.Windows.Forms.PictureBox pbImagen2;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.PictureBox ptLogo;
	}
}