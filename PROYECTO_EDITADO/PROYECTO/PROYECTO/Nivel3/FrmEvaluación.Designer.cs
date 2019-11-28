namespace FrmNivelTres
{
    partial class Evaluacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Evaluacion));
            this.cmbRespuesta = new System.Windows.Forms.ComboBox();
            this.lblNro2 = new System.Windows.Forms.Label();
            this.lblNro1 = new System.Windows.Forms.Label();
            this.pntNro1 = new System.Windows.Forms.PictureBox();
            this.btnResultado = new System.Windows.Forms.Button();
            this.ptLogo = new System.Windows.Forms.PictureBox();
            this.panelTitulo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pntNro1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbRespuesta
            // 
            this.cmbRespuesta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRespuesta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRespuesta.FormattingEnabled = true;
            this.cmbRespuesta.Items.AddRange(new object[] {
            "11111 22222 33333 44444 55555",
            "55555 44444 33333 22222 11111",
            "11111 22222 33333 44444",
            "44444 33333 22222 11111",
            "Ninguna de las anteriores"});
            this.cmbRespuesta.Location = new System.Drawing.Point(612, 284);
            this.cmbRespuesta.Name = "cmbRespuesta";
            this.cmbRespuesta.Size = new System.Drawing.Size(230, 26);
            this.cmbRespuesta.TabIndex = 8;
            this.cmbRespuesta.SelectedIndexChanged += new System.EventHandler(this.cmbRespuesta_SelectedIndexChanged);
            // 
            // lblNro2
            // 
            this.lblNro2.AutoSize = true;
            this.lblNro2.BackColor = System.Drawing.Color.Transparent;
            this.lblNro2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNro2.Location = new System.Drawing.Point(103, 120);
            this.lblNro2.Name = "lblNro2";
            this.lblNro2.Size = new System.Drawing.Size(507, 18);
            this.lblNro2.TabIndex = 7;
            this.lblNro2.Text = "¿Cuál es el resultado en pantalla del algoritmo expuesto?\r\n";
            this.lblNro2.Click += new System.EventHandler(this.lblNro2_Click);
            // 
            // lblNro1
            // 
            this.lblNro1.AutoSize = true;
            this.lblNro1.BackColor = System.Drawing.Color.Transparent;
            this.lblNro1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNro1.Location = new System.Drawing.Point(440, 49);
            this.lblNro1.Name = "lblNro1";
            this.lblNro1.Size = new System.Drawing.Size(79, 32);
            this.lblNro1.TabIndex = 6;
            this.lblNro1.Text = "Test";
            // 
            // pntNro1
            // 
            this.pntNro1.Image = ((System.Drawing.Image)(resources.GetObject("pntNro1.Image")));
            this.pntNro1.Location = new System.Drawing.Point(137, 181);
            this.pntNro1.Name = "pntNro1";
            this.pntNro1.Size = new System.Drawing.Size(469, 294);
            this.pntNro1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pntNro1.TabIndex = 5;
            this.pntNro1.TabStop = false;
            this.pntNro1.Click += new System.EventHandler(this.pntNro1_Click);
            // 
            // btnResultado
            // 
            this.btnResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(35)))));
            this.btnResultado.FlatAppearance.BorderSize = 0;
            this.btnResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResultado.ForeColor = System.Drawing.Color.White;
            this.btnResultado.Location = new System.Drawing.Point(811, 473);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(101, 33);
            this.btnResultado.TabIndex = 9;
            this.btnResultado.Text = "Evaluar";
            this.btnResultado.UseVisualStyleBackColor = false;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // ptLogo
            // 
            this.ptLogo.BackColor = System.Drawing.Color.Transparent;
            this.ptLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptLogo.Image")));
            this.ptLogo.Location = new System.Drawing.Point(819, 34);
            this.ptLogo.Name = "ptLogo";
            this.ptLogo.Size = new System.Drawing.Size(105, 90);
            this.ptLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptLogo.TabIndex = 61;
            this.ptLogo.TabStop = false;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(924, 34);
            this.panelTitulo.TabIndex = 60;
            // 
            // Evaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 518);
            this.Controls.Add(this.ptLogo);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.cmbRespuesta);
            this.Controls.Add(this.lblNro2);
            this.Controls.Add(this.lblNro1);
            this.Controls.Add(this.pntNro1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Evaluacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evaluacion";
            this.Load += new System.EventHandler(this.Evaluacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pntNro1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRespuesta;
        private System.Windows.Forms.Label lblNro2;
        private System.Windows.Forms.Label lblNro1;
        private System.Windows.Forms.PictureBox pntNro1;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.PictureBox ptLogo;
        private System.Windows.Forms.Panel panelTitulo;
    }
}