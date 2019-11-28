namespace Competencia
{
    partial class CompetenciaFrmFacil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompetenciaFrmFacil));
            this.lblUno = new System.Windows.Forms.Label();
            this.cboFacil = new System.Windows.Forms.ComboBox();
            this.cboC = new System.Windows.Forms.ComboBox();
            this.lblCuatro = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.grbFacil = new System.Windows.Forms.GroupBox();
            this.lblDos = new System.Windows.Forms.Label();
            this.cboRespuesta = new System.Windows.Forms.ComboBox();
            this.cboCondicional = new System.Windows.Forms.ComboBox();
            this.lblTres = new System.Windows.Forms.Label();
            this.lblcalificacion = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grbFacil.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUno
            // 
            this.lblUno.AutoSize = true;
            this.lblUno.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUno.Location = new System.Drawing.Point(14, 16);
            this.lblUno.Name = "lblUno";
            this.lblUno.Size = new System.Drawing.Size(743, 54);
            this.lblUno.TabIndex = 1;
            this.lblUno.Text = resources.GetString("lblUno.Text");
            // 
            // cboFacil
            // 
            this.cboFacil.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFacil.FormattingEnabled = true;
            this.cboFacil.Items.AddRange(new object[] {
            "Ciclos para",
            "Secuenciales",
            "Condicionales ",
            "Matrices",
            "Funciones"});
            this.cboFacil.Location = new System.Drawing.Point(177, 92);
            this.cboFacil.Name = "cboFacil";
            this.cboFacil.Size = new System.Drawing.Size(121, 26);
            this.cboFacil.TabIndex = 2;
            this.cboFacil.SelectedIndexChanged += new System.EventHandler(this.cboFacil_SelectedIndexChanged);
            // 
            // cboC
            // 
            this.cboC.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboC.FormattingEnabled = true;
            this.cboC.Items.AddRange(new object[] {
            "Signos Operacionales",
            "Condicionales",
            "Tipos de Variables",
            "Arreglos",
            "Procedimientos"});
            this.cboC.Location = new System.Drawing.Point(177, 255);
            this.cboC.Name = "cboC";
            this.cboC.Size = new System.Drawing.Size(121, 26);
            this.cboC.TabIndex = 9;
            this.cboC.SelectedIndexChanged += new System.EventHandler(this.cboC_SelectedIndexChanged);
            // 
            // lblCuatro
            // 
            this.lblCuatro.AutoSize = true;
            this.lblCuatro.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuatro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCuatro.Location = new System.Drawing.Point(6, 219);
            this.lblCuatro.Name = "lblCuatro";
            this.lblCuatro.Size = new System.Drawing.Size(589, 36);
            this.lblCuatro.TabIndex = 8;
            this.lblCuatro.Text = "4.  Son un grupo de instrucciones que se pueden \"ejecutar\" o \"no\" en función \r\nde" +
    "l valor de una condición.";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnFinalizar.Location = new System.Drawing.Point(701, 457);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizar.TabIndex = 10;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // grbFacil
            // 
            this.grbFacil.Controls.Add(this.lblUno);
            this.grbFacil.Controls.Add(this.cboFacil);
            this.grbFacil.Controls.Add(this.cboC);
            this.grbFacil.Controls.Add(this.lblDos);
            this.grbFacil.Controls.Add(this.lblCuatro);
            this.grbFacil.Controls.Add(this.cboRespuesta);
            this.grbFacil.Controls.Add(this.cboCondicional);
            this.grbFacil.Controls.Add(this.lblTres);
            this.grbFacil.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFacil.ForeColor = System.Drawing.Color.Black;
            this.grbFacil.Location = new System.Drawing.Point(80, 147);
            this.grbFacil.Name = "grbFacil";
            this.grbFacil.Size = new System.Drawing.Size(761, 304);
            this.grbFacil.TabIndex = 11;
            this.grbFacil.TabStop = false;
            this.grbFacil.Text = "Fácil";
            this.grbFacil.Enter += new System.EventHandler(this.grbFacil_Enter);
            // 
            // lblDos
            // 
            this.lblDos.AutoSize = true;
            this.lblDos.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDos.Location = new System.Drawing.Point(14, 116);
            this.lblDos.Name = "lblDos";
            this.lblDos.Size = new System.Drawing.Size(325, 18);
            this.lblDos.TabIndex = 4;
            this.lblDos.Text = "2. Entero, real, cadena, carácter, booleano";
            // 
            // cboRespuesta
            // 
            this.cboRespuesta.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRespuesta.FormattingEnabled = true;
            this.cboRespuesta.Items.AddRange(new object[] {
            "Lpp",
            "Secuenciales",
            "Tipos de Variables",
            "Arreglos",
            "Funciones"});
            this.cboRespuesta.Location = new System.Drawing.Point(177, 139);
            this.cboRespuesta.Name = "cboRespuesta";
            this.cboRespuesta.Size = new System.Drawing.Size(121, 26);
            this.cboRespuesta.TabIndex = 5;
            this.cboRespuesta.SelectedIndexChanged += new System.EventHandler(this.cboRespuesta_SelectedIndexChanged);
            // 
            // cboCondicional
            // 
            this.cboCondicional.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCondicional.FormattingEnabled = true;
            this.cboCondicional.Items.AddRange(new object[] {
            "Ciclos Repita",
            "Cilos Mientras",
            "Condicionales",
            "Matrices",
            "Arreglos"});
            this.cboCondicional.Location = new System.Drawing.Point(177, 184);
            this.cboCondicional.Name = "cboCondicional";
            this.cboCondicional.Size = new System.Drawing.Size(121, 26);
            this.cboCondicional.TabIndex = 7;
            this.cboCondicional.SelectedIndexChanged += new System.EventHandler(this.cboCondicional_SelectedIndexChanged);
            // 
            // lblTres
            // 
            this.lblTres.AutoSize = true;
            this.lblTres.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTres.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTres.Location = new System.Drawing.Point(14, 161);
            this.lblTres.Name = "lblTres";
            this.lblTres.Size = new System.Drawing.Size(237, 18);
            this.lblTres.TabIndex = 6;
            this.lblTres.Text = "3. Se útiliza \" si entonces\"  en:";
            // 
            // lblcalificacion
            // 
            this.lblcalificacion.AutoSize = true;
            this.lblcalificacion.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcalificacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblcalificacion.Location = new System.Drawing.Point(76, 462);
            this.lblcalificacion.Name = "lblcalificacion";
            this.lblcalificacion.Size = new System.Drawing.Size(96, 18);
            this.lblcalificacion.TabIndex = 12;
            this.lblcalificacion.Text = "Calificación:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotal.Location = new System.Drawing.Point(214, 460);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 18);
            this.lblTotal.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 65);
            this.panel1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(392, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Conceptos básicos secuenciales y condicionales";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PROYECTO.Properties.Resources._240px_Sena_Colombia_logo_svg;
            this.pictureBox2.Location = new System.Drawing.Point(760, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(107, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAtras.Location = new System.Drawing.Point(792, 455);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 18;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(792, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 25);
            this.button2.TabIndex = 19;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.UseWaitCursor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CompetenciaFrmFacil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(867, 573);
            this.ControlBox = false;
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grbFacil);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblcalificacion);
            this.Controls.Add(this.btnFinalizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CompetenciaFrmFacil";
            this.Text = "Facil";
            this.Load += new System.EventHandler(this.FrmCompetencia_Load);
            this.grbFacil.ResumeLayout(false);
            this.grbFacil.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUno;
        private System.Windows.Forms.ComboBox cboFacil;
        private System.Windows.Forms.ComboBox cboC;
        private System.Windows.Forms.Label lblCuatro;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.GroupBox grbFacil;
        private System.Windows.Forms.Label lblcalificacion;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDos;
        private System.Windows.Forms.ComboBox cboRespuesta;
        private System.Windows.Forms.ComboBox cboCondicional;
        private System.Windows.Forms.Label lblTres;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button button2;
    }
}

