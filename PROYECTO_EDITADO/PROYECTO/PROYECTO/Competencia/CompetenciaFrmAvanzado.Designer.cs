namespace Competencia
{
    partial class CompetenciaFrmAvanzado
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
            this.grbFacil = new System.Windows.Forms.GroupBox();
            this.lblUno = new System.Windows.Forms.Label();
            this.cboAvanzado = new System.Windows.Forms.ComboBox();
            this.lblDos = new System.Windows.Forms.Label();
            this.cboRespuesta = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblcalificacion = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
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
            // grbFacil
            // 
            this.grbFacil.Controls.Add(this.lblUno);
            this.grbFacil.Controls.Add(this.cboAvanzado);
            this.grbFacil.Controls.Add(this.lblDos);
            this.grbFacil.Controls.Add(this.cboRespuesta);
            this.grbFacil.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFacil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grbFacil.Location = new System.Drawing.Point(102, 82);
            this.grbFacil.Name = "grbFacil";
            this.grbFacil.Size = new System.Drawing.Size(576, 201);
            this.grbFacil.TabIndex = 13;
            this.grbFacil.TabStop = false;
            this.grbFacil.Text = "Avanzado";
            this.grbFacil.Enter += new System.EventHandler(this.grbFacil_Enter);
            // 
            // lblUno
            // 
            this.lblUno.AutoSize = true;
            this.lblUno.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUno.Location = new System.Drawing.Point(14, 16);
            this.lblUno.Name = "lblUno";
            this.lblUno.Size = new System.Drawing.Size(298, 18);
            this.lblUno.TabIndex = 1;
            this.lblUno.Text = "1. Ordenamiento de matrices o arreglo";
            // 
            // cboAvanzado
            // 
            this.cboAvanzado.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAvanzado.FormattingEnabled = true;
            this.cboAvanzado.Items.AddRange(new object[] {
            "Ciclos para",
            "Metodo Burbuja",
            "Condicionales ",
            "Arreglo",
            "Funciones"});
            this.cboAvanzado.Location = new System.Drawing.Point(318, 19);
            this.cboAvanzado.Name = "cboAvanzado";
            this.cboAvanzado.Size = new System.Drawing.Size(121, 26);
            this.cboAvanzado.TabIndex = 2;
            this.cboAvanzado.SelectedIndexChanged += new System.EventHandler(this.cboAvanzado_SelectedIndexChanged);
            // 
            // lblDos
            // 
            this.lblDos.AutoSize = true;
            this.lblDos.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDos.Location = new System.Drawing.Point(14, 68);
            this.lblDos.Name = "lblDos";
            this.lblDos.Size = new System.Drawing.Size(258, 18);
            this.lblDos.TabIndex = 4;
            this.lblDos.Text = "2. Estructuras de filas y columnas";
            // 
            // cboRespuesta
            // 
            this.cboRespuesta.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRespuesta.FormattingEnabled = true;
            this.cboRespuesta.Items.AddRange(new object[] {
            "Matrices",
            "Funciones",
            "Vectores",
            "Arreglos",
            "Procedimientos"});
            this.cboRespuesta.Location = new System.Drawing.Point(318, 67);
            this.cboRespuesta.Name = "cboRespuesta";
            this.cboRespuesta.Size = new System.Drawing.Size(121, 26);
            this.cboRespuesta.TabIndex = 5;
            this.cboRespuesta.SelectedIndexChanged += new System.EventHandler(this.cboRespuesta_SelectedIndexChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotal.Location = new System.Drawing.Point(361, 367);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 18);
            this.lblTotal.TabIndex = 17;
            // 
            // lblcalificacion
            // 
            this.lblcalificacion.AutoSize = true;
            this.lblcalificacion.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcalificacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblcalificacion.Location = new System.Drawing.Point(116, 367);
            this.lblcalificacion.Name = "lblcalificacion";
            this.lblcalificacion.Size = new System.Drawing.Size(96, 18);
            this.lblcalificacion.TabIndex = 16;
            this.lblcalificacion.Text = "Calificación:";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnFinalizar.Location = new System.Drawing.Point(618, 415);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizar.TabIndex = 15;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 65);
            this.panel1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Conceptos básicos matrices";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PROYECTO.Properties.Resources._240px_Sena_Colombia_logo_svg;
            this.pictureBox2.Location = new System.Drawing.Point(684, 71);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(107, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAtras.Location = new System.Drawing.Point(699, 415);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 20;
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
            this.button2.Location = new System.Drawing.Point(725, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 25);
            this.button2.TabIndex = 21;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.UseWaitCursor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CompetenciaFrmAvanzado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblcalificacion);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.grbFacil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CompetenciaFrmAvanzado";
            this.Text = "Avanzado";
            this.Load += new System.EventHandler(this.FrmAvanzado_Load);
            this.grbFacil.ResumeLayout(false);
            this.grbFacil.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbFacil;
        private System.Windows.Forms.Label lblUno;
        private System.Windows.Forms.ComboBox cboAvanzado;
        private System.Windows.Forms.Label lblDos;
        private System.Windows.Forms.ComboBox cboRespuesta;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblcalificacion;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button button2;
    }
}