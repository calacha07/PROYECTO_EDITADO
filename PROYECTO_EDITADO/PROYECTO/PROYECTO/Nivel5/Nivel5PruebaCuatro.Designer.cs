namespace LoginProyecto
{
    partial class FrmNivel5PruebaCuatro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNivel5PruebaCuatro));
            this.btnSiguienteNivel = new System.Windows.Forms.Button();
            this.txtPreguntaCuatro = new System.Windows.Forms.TextBox();
            this.lblPregunta4 = new System.Windows.Forms.Label();
            this.lblTituloNivelCuatro = new System.Windows.Forms.Label();
            this.pbProgramador = new System.Windows.Forms.PictureBox();
            this.cbRespuestaUno = new System.Windows.Forms.ComboBox();
            this.cbRespuestaDos = new System.Windows.Forms.ComboBox();
            this.cbRespuestaTres = new System.Windows.Forms.ComboBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.ptLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbProgramador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSiguienteNivel
            // 
            this.btnSiguienteNivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(35)))));
            this.btnSiguienteNivel.FlatAppearance.BorderSize = 0;
            this.btnSiguienteNivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguienteNivel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteNivel.ForeColor = System.Drawing.Color.White;
            this.btnSiguienteNivel.Location = new System.Drawing.Point(764, 473);
            this.btnSiguienteNivel.Name = "btnSiguienteNivel";
            this.btnSiguienteNivel.Size = new System.Drawing.Size(148, 33);
            this.btnSiguienteNivel.TabIndex = 37;
            this.btnSiguienteNivel.Text = "Siguiente nivel";
            this.btnSiguienteNivel.UseVisualStyleBackColor = false;
            this.btnSiguienteNivel.Click += new System.EventHandler(this.btnSiguientePregunta_Click);
            // 
            // txtPreguntaCuatro
            // 
            this.txtPreguntaCuatro.BackColor = System.Drawing.Color.White;
            this.txtPreguntaCuatro.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreguntaCuatro.Location = new System.Drawing.Point(103, 151);
            this.txtPreguntaCuatro.Multiline = true;
            this.txtPreguntaCuatro.Name = "txtPreguntaCuatro";
            this.txtPreguntaCuatro.ReadOnly = true;
            this.txtPreguntaCuatro.Size = new System.Drawing.Size(682, 28);
            this.txtPreguntaCuatro.TabIndex = 34;
            this.txtPreguntaCuatro.Text = "De acuerdo con el siguiente pseudocódigo, complete los espacios vacios:";
            this.txtPreguntaCuatro.TextChanged += new System.EventHandler(this.txtPreguntaCuatro_TextChanged);
            // 
            // lblPregunta4
            // 
            this.lblPregunta4.AutoSize = true;
            this.lblPregunta4.BackColor = System.Drawing.Color.Transparent;
            this.lblPregunta4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta4.Location = new System.Drawing.Point(102, 121);
            this.lblPregunta4.Name = "lblPregunta4";
            this.lblPregunta4.Size = new System.Drawing.Size(154, 18);
            this.lblPregunta4.TabIndex = 31;
            this.lblPregunta4.Text = "Cuarta pregunta";
            this.lblPregunta4.Click += new System.EventHandler(this.lblPregunta4_Click);
            // 
            // lblTituloNivelCuatro
            // 
            this.lblTituloNivelCuatro.AutoSize = true;
            this.lblTituloNivelCuatro.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloNivelCuatro.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloNivelCuatro.Location = new System.Drawing.Point(417, 57);
            this.lblTituloNivelCuatro.Name = "lblTituloNivelCuatro";
            this.lblTituloNivelCuatro.Size = new System.Drawing.Size(79, 32);
            this.lblTituloNivelCuatro.TabIndex = 30;
            this.lblTituloNivelCuatro.Text = "Test";
            this.lblTituloNivelCuatro.Click += new System.EventHandler(this.lblTituloNivelCuatro_Click);
            // 
            // pbProgramador
            // 
            this.pbProgramador.Image = ((System.Drawing.Image)(resources.GetObject("pbProgramador.Image")));
            this.pbProgramador.Location = new System.Drawing.Point(104, 185);
            this.pbProgramador.Name = "pbProgramador";
            this.pbProgramador.Size = new System.Drawing.Size(574, 260);
            this.pbProgramador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProgramador.TabIndex = 36;
            this.pbProgramador.TabStop = false;
            // 
            // cbRespuestaUno
            // 
            this.cbRespuestaUno.BackColor = System.Drawing.Color.White;
            this.cbRespuestaUno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRespuestaUno.FormattingEnabled = true;
            this.cbRespuestaUno.Items.AddRange(new object[] {
            "Real",
            "Entero",
            "Cadena",
            "Caracter"});
            this.cbRespuestaUno.Location = new System.Drawing.Point(238, 193);
            this.cbRespuestaUno.Name = "cbRespuestaUno";
            this.cbRespuestaUno.Size = new System.Drawing.Size(64, 21);
            this.cbRespuestaUno.TabIndex = 39;
            this.cbRespuestaUno.SelectedIndexChanged += new System.EventHandler(this.cbRespuestaUno_SelectedIndexChanged);
            // 
            // cbRespuestaDos
            // 
            this.cbRespuestaDos.BackColor = System.Drawing.Color.White;
            this.cbRespuestaDos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRespuestaDos.FormattingEnabled = true;
            this.cbRespuestaDos.Items.AddRange(new object[] {
            "Entero",
            "Real",
            "Cadena",
            "Caracter"});
            this.cbRespuestaDos.Location = new System.Drawing.Point(103, 214);
            this.cbRespuestaDos.Name = "cbRespuestaDos";
            this.cbRespuestaDos.Size = new System.Drawing.Size(80, 21);
            this.cbRespuestaDos.TabIndex = 40;
            // 
            // cbRespuestaTres
            // 
            this.cbRespuestaTres.BackColor = System.Drawing.Color.White;
            this.cbRespuestaTres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRespuestaTres.FormattingEnabled = true;
            this.cbRespuestaTres.Items.AddRange(new object[] {
            "Leer",
            "Lea",
            "Escriba"});
            this.cbRespuestaTres.Location = new System.Drawing.Point(159, 273);
            this.cbRespuestaTres.Name = "cbRespuestaTres";
            this.cbRespuestaTres.Size = new System.Drawing.Size(87, 21);
            this.cbRespuestaTres.TabIndex = 41;
            this.cbRespuestaTres.SelectedIndexChanged += new System.EventHandler(this.cbRespuestaTres_SelectedIndexChanged);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(130)))), ((int)(((byte)(118)))));
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(12, 473);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(101, 33);
            this.btnRegresar.TabIndex = 42;
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
            this.panelTitulo.Size = new System.Drawing.Size(924, 34);
            this.panelTitulo.TabIndex = 50;
            // 
            // ptLogo
            // 
            this.ptLogo.BackColor = System.Drawing.Color.Transparent;
            this.ptLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptLogo.Image")));
            this.ptLogo.Location = new System.Drawing.Point(816, 36);
            this.ptLogo.Name = "ptLogo";
            this.ptLogo.Size = new System.Drawing.Size(105, 90);
            this.ptLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptLogo.TabIndex = 49;
            this.ptLogo.TabStop = false;
            // 
            // FrmNivel5PruebaCuatro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 518);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.ptLogo);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.cbRespuestaTres);
            this.Controls.Add(this.cbRespuestaDos);
            this.Controls.Add(this.cbRespuestaUno);
            this.Controls.Add(this.btnSiguienteNivel);
            this.Controls.Add(this.pbProgramador);
            this.Controls.Add(this.txtPreguntaCuatro);
            this.Controls.Add(this.lblPregunta4);
            this.Controls.Add(this.lblTituloNivelCuatro);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNivel5PruebaCuatro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                  ";
            this.Load += new System.EventHandler(this.FrmNivel5PruebaCuatro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProgramador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSiguienteNivel;
        private System.Windows.Forms.TextBox txtPreguntaCuatro;
        private System.Windows.Forms.Label lblPregunta4;
        private System.Windows.Forms.Label lblTituloNivelCuatro;
        private System.Windows.Forms.PictureBox pbProgramador;
        private System.Windows.Forms.ComboBox cbRespuestaUno;
        private System.Windows.Forms.ComboBox cbRespuestaDos;
        private System.Windows.Forms.ComboBox cbRespuestaTres;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.PictureBox ptLogo;
    }
}