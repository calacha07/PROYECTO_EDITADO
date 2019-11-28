namespace PROYECTO
{
    partial class FrmConceptoMatrices
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConceptoMatrices));
            this.lblTituloNivel6 = new System.Windows.Forms.Label();
            this.lblConcepto = new System.Windows.Forms.Label();
            this.txtContenidoMatriz = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.btnAvanzarNivel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.ptLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloNivel6
            // 
            this.lblTituloNivel6.AutoSize = true;
            this.lblTituloNivel6.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloNivel6.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloNivel6.Location = new System.Drawing.Point(414, 47);
            this.lblTituloNivel6.Name = "lblTituloNivel6";
            this.lblTituloNivel6.Size = new System.Drawing.Size(143, 32);
            this.lblTituloNivel6.TabIndex = 0;
            this.lblTituloNivel6.Text = "Matrices";
            // 
            // lblConcepto
            // 
            this.lblConcepto.AutoSize = true;
            this.lblConcepto.BackColor = System.Drawing.Color.Transparent;
            this.lblConcepto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConcepto.Location = new System.Drawing.Point(78, 107);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(97, 18);
            this.lblConcepto.TabIndex = 1;
            this.lblConcepto.Text = "Concepto:";
            this.lblConcepto.Click += new System.EventHandler(this.lblConcepto_Click);
            // 
            // txtContenidoMatriz
            // 
            this.txtContenidoMatriz.BackColor = System.Drawing.Color.White;
            this.txtContenidoMatriz.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContenidoMatriz.Location = new System.Drawing.Point(216, 107);
            this.txtContenidoMatriz.Multiline = true;
            this.txtContenidoMatriz.Name = "txtContenidoMatriz";
            this.txtContenidoMatriz.ReadOnly = true;
            this.txtContenidoMatriz.Size = new System.Drawing.Size(584, 155);
            this.txtContenidoMatriz.TabIndex = 3;
            this.txtContenidoMatriz.Text = resources.GetString("txtContenidoMatriz.Text");
            this.txtContenidoMatriz.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(216, 289);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(584, 70);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Matriz A de la posición en la fila 1 y columna 2 se debe posicionar A [1][2], den" +
    "otándose que el primer índice indica la posición de la fila y el segundo la posi" +
    "ción de la columna.\r\n";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(78, 292);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(89, 18);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "Ejemplo: ";
            // 
            // btnAvanzarNivel
            // 
            this.btnAvanzarNivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(35)))));
            this.btnAvanzarNivel.FlatAppearance.BorderSize = 0;
            this.btnAvanzarNivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvanzarNivel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvanzarNivel.ForeColor = System.Drawing.Color.White;
            this.btnAvanzarNivel.Location = new System.Drawing.Point(755, 555);
            this.btnAvanzarNivel.Name = "btnAvanzarNivel";
            this.btnAvanzarNivel.Size = new System.Drawing.Size(157, 33);
            this.btnAvanzarNivel.TabIndex = 7;
            this.btnAvanzarNivel.Text = "Empezar prueba";
            this.btnAvanzarNivel.UseVisualStyleBackColor = false;
            this.btnAvanzarNivel.Click += new System.EventHandler(this.btnAvanzarNivel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(189, 379);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(611, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(130)))), ((int)(((byte)(118)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 557);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(924, 34);
            this.panelTitulo.TabIndex = 47;
            // 
            // ptLogo
            // 
            this.ptLogo.BackColor = System.Drawing.Color.Transparent;
            this.ptLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptLogo.Image")));
            this.ptLogo.Location = new System.Drawing.Point(817, 35);
            this.ptLogo.Name = "ptLogo";
            this.ptLogo.Size = new System.Drawing.Size(105, 90);
            this.ptLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptLogo.TabIndex = 46;
            this.ptLogo.TabStop = false;
            // 
            // FrmConceptoMatrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 603);
            this.ControlBox = false;
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.ptLogo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAvanzarNivel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtContenidoMatriz);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblConcepto);
            this.Controls.Add(this.lblTituloNivel6);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConceptoMatrices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Concepto de matriz";
            this.Load += new System.EventHandler(this.FrmConceptoMatrices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloNivel6;
        private System.Windows.Forms.Label lblConcepto;
        private System.Windows.Forms.TextBox txtContenidoMatriz;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAvanzarNivel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.PictureBox ptLogo;
	}
}

