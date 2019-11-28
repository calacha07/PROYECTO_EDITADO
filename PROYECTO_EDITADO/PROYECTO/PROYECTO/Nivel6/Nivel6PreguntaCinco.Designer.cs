namespace PROYECTO
{
    partial class FrmNivel6PreguntaCinco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNivel6PreguntaCinco));
            this.lblQuintaPregunta = new System.Windows.Forms.Label();
            this.pbMatriz = new System.Windows.Forms.PictureBox();
            this.txtPreguntaCinco = new System.Windows.Forms.TextBox();
            this.cmbRespuestaUno = new System.Windows.Forms.ComboBox();
            this.btnFinPrubea = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmbRespuestaDos = new System.Windows.Forms.ComboBox();
            this.cmbRespuestaTres = new System.Windows.Forms.ComboBox();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.ptLogo = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbMatriz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuintaPregunta
            // 
            this.lblQuintaPregunta.AutoSize = true;
            this.lblQuintaPregunta.BackColor = System.Drawing.Color.Transparent;
            this.lblQuintaPregunta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuintaPregunta.Location = new System.Drawing.Point(133, 85);
            this.lblQuintaPregunta.Name = "lblQuintaPregunta";
            this.lblQuintaPregunta.Size = new System.Drawing.Size(152, 18);
            this.lblQuintaPregunta.TabIndex = 0;
            this.lblQuintaPregunta.Text = "Quinta pregunta";
            // 
            // pbMatriz
            // 
            this.pbMatriz.Image = ((System.Drawing.Image)(resources.GetObject("pbMatriz.Image")));
            this.pbMatriz.Location = new System.Drawing.Point(136, 142);
            this.pbMatriz.Name = "pbMatriz";
            this.pbMatriz.Size = new System.Drawing.Size(559, 349);
            this.pbMatriz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMatriz.TabIndex = 1;
            this.pbMatriz.TabStop = false;
            // 
            // txtPreguntaCinco
            // 
            this.txtPreguntaCinco.BackColor = System.Drawing.Color.White;
            this.txtPreguntaCinco.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreguntaCinco.Location = new System.Drawing.Point(136, 106);
            this.txtPreguntaCinco.Name = "txtPreguntaCinco";
            this.txtPreguntaCinco.ReadOnly = true;
            this.txtPreguntaCinco.Size = new System.Drawing.Size(501, 23);
            this.txtPreguntaCinco.TabIndex = 2;
            this.txtPreguntaCinco.Text = "De acuerdo con el  siguiente pseudocódigo, complete los campos vacios:";
            this.txtPreguntaCinco.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmbRespuestaUno
            // 
            this.cmbRespuestaUno.BackColor = System.Drawing.Color.White;
            this.cmbRespuestaUno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRespuestaUno.FormattingEnabled = true;
            this.cmbRespuestaUno.Items.AddRange(new object[] {
            "Entero",
            "Real",
            "Cadena",
            "Caracter"});
            this.cmbRespuestaUno.Location = new System.Drawing.Point(316, 147);
            this.cmbRespuestaUno.Name = "cmbRespuestaUno";
            this.cmbRespuestaUno.Size = new System.Drawing.Size(79, 21);
            this.cmbRespuestaUno.TabIndex = 3;
            this.cmbRespuestaUno.SelectedIndexChanged += new System.EventHandler(this.cmbRespuestaUno_SelectedIndexChanged);
            // 
            // btnFinPrubea
            // 
            this.btnFinPrubea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(130)))), ((int)(((byte)(118)))));
            this.btnFinPrubea.FlatAppearance.BorderSize = 0;
            this.btnFinPrubea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinPrubea.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinPrubea.ForeColor = System.Drawing.Color.White;
            this.btnFinPrubea.Location = new System.Drawing.Point(811, 473);
            this.btnFinPrubea.Name = "btnFinPrubea";
            this.btnFinPrubea.Size = new System.Drawing.Size(101, 33);
            this.btnFinPrubea.TabIndex = 4;
            this.btnFinPrubea.Text = "Terminar";
            this.btnFinPrubea.UseVisualStyleBackColor = false;
            this.btnFinPrubea.Click += new System.EventHandler(this.btnFinPrubea_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(393, 54);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(79, 32);
            this.lblTitulo.TabIndex = 20;
            this.lblTitulo.Text = "Test";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // cmbRespuestaDos
            // 
            this.cmbRespuestaDos.BackColor = System.Drawing.Color.White;
            this.cmbRespuestaDos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRespuestaDos.FormattingEnabled = true;
            this.cmbRespuestaDos.Items.AddRange(new object[] {
            "Entero",
            "Real",
            "Cadena",
            "Caracter"});
            this.cmbRespuestaDos.Location = new System.Drawing.Point(129, 172);
            this.cmbRespuestaDos.Name = "cmbRespuestaDos";
            this.cmbRespuestaDos.Size = new System.Drawing.Size(83, 21);
            this.cmbRespuestaDos.TabIndex = 23;
            // 
            // cmbRespuestaTres
            // 
            this.cmbRespuestaTres.BackColor = System.Drawing.Color.White;
            this.cmbRespuestaTres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRespuestaTres.FormattingEnabled = true;
            this.cmbRespuestaTres.Items.AddRange(new object[] {
            "Escriba",
            "Escribir",
            "Lea",
            "Leer"});
            this.cmbRespuestaTres.Location = new System.Drawing.Point(174, 222);
            this.cmbRespuestaTres.Name = "cmbRespuestaTres";
            this.cmbRespuestaTres.Size = new System.Drawing.Size(95, 21);
            this.cmbRespuestaTres.TabIndex = 24;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(924, 34);
            this.panelTitulo.TabIndex = 49;
            // 
            // ptLogo
            // 
            this.ptLogo.BackColor = System.Drawing.Color.Transparent;
            this.ptLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptLogo.Image")));
            this.ptLogo.Location = new System.Drawing.Point(816, 38);
            this.ptLogo.Name = "ptLogo";
            this.ptLogo.Size = new System.Drawing.Size(105, 90);
            this.ptLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptLogo.TabIndex = 48;
            this.ptLogo.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(35)))));
            this.panel3.Location = new System.Drawing.Point(184, 559);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(433, 16);
            this.panel3.TabIndex = 52;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(130)))), ((int)(((byte)(118)))));
            this.panel2.Location = new System.Drawing.Point(51, 559);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(134, 16);
            this.panel2.TabIndex = 51;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(0, 559);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(51, 16);
            this.panel1.TabIndex = 50;
            // 
            // FrmNivel6PreguntaCinco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 518);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.ptLogo);
            this.Controls.Add(this.cmbRespuestaTres);
            this.Controls.Add(this.cmbRespuestaDos);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnFinPrubea);
            this.Controls.Add(this.cmbRespuestaUno);
            this.Controls.Add(this.txtPreguntaCinco);
            this.Controls.Add(this.pbMatriz);
            this.Controls.Add(this.lblQuintaPregunta);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNivel6PreguntaCinco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.Load += new System.EventHandler(this.FrmNivel6PreguntaCinco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMatriz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuintaPregunta;
        private System.Windows.Forms.PictureBox pbMatriz;
        private System.Windows.Forms.TextBox txtPreguntaCinco;
        private System.Windows.Forms.ComboBox cmbRespuestaUno;
        private System.Windows.Forms.Button btnFinPrubea;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cmbRespuestaDos;
        private System.Windows.Forms.ComboBox cmbRespuestaTres;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.PictureBox ptLogo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}