namespace PROYECTO
{
    partial class FrmNivel6PreguntaTres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNivel6PreguntaTres));
            this.lblTerceraPregunta = new System.Windows.Forms.Label();
            this.txtPreguntaTres = new System.Windows.Forms.TextBox();
            this.btnTres = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gpRespuestas = new System.Windows.Forms.GroupBox();
            this.lblD = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.rbRespuestaDos = new System.Windows.Forms.RadioButton();
            this.rbRespuestaTres = new System.Windows.Forms.RadioButton();
            this.rbRespuestaCuatro = new System.Windows.Forms.RadioButton();
            this.rbRespuestaUno = new System.Windows.Forms.RadioButton();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.ptLogo = new System.Windows.Forms.PictureBox();
            this.gpRespuestas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTerceraPregunta
            // 
            this.lblTerceraPregunta.AutoSize = true;
            this.lblTerceraPregunta.BackColor = System.Drawing.Color.Transparent;
            this.lblTerceraPregunta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerceraPregunta.Location = new System.Drawing.Point(216, 101);
            this.lblTerceraPregunta.Name = "lblTerceraPregunta";
            this.lblTerceraPregunta.Size = new System.Drawing.Size(164, 18);
            this.lblTerceraPregunta.TabIndex = 0;
            this.lblTerceraPregunta.Text = "Tercera pregunta";
            // 
            // txtPreguntaTres
            // 
            this.txtPreguntaTres.BackColor = System.Drawing.Color.White;
            this.txtPreguntaTres.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreguntaTres.Location = new System.Drawing.Point(219, 132);
            this.txtPreguntaTres.Name = "txtPreguntaTres";
            this.txtPreguntaTres.ReadOnly = true;
            this.txtPreguntaTres.Size = new System.Drawing.Size(562, 27);
            this.txtPreguntaTres.TabIndex = 1;
            this.txtPreguntaTres.Text = "De las siguientes opciones. ¿Cómo se declara una matriz en LPP?";
            this.txtPreguntaTres.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnTres
            // 
            this.btnTres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(130)))), ((int)(((byte)(118)))));
            this.btnTres.FlatAppearance.BorderSize = 0;
            this.btnTres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTres.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTres.ForeColor = System.Drawing.Color.White;
            this.btnTres.Location = new System.Drawing.Point(758, 473);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(154, 33);
            this.btnTres.TabIndex = 7;
            this.btnTres.Text = "Siguiente";
            this.btnTres.UseVisualStyleBackColor = false;
            this.btnTres.Click += new System.EventHandler(this.btnTres_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(447, 54);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(79, 32);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "Test";
            // 
            // gpRespuestas
            // 
            this.gpRespuestas.BackColor = System.Drawing.Color.Transparent;
            this.gpRespuestas.Controls.Add(this.lblD);
            this.gpRespuestas.Controls.Add(this.lblC);
            this.gpRespuestas.Controls.Add(this.lblB);
            this.gpRespuestas.Controls.Add(this.lblA);
            this.gpRespuestas.Controls.Add(this.rbRespuestaDos);
            this.gpRespuestas.Controls.Add(this.rbRespuestaTres);
            this.gpRespuestas.Controls.Add(this.rbRespuestaCuatro);
            this.gpRespuestas.Controls.Add(this.rbRespuestaUno);
            this.gpRespuestas.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpRespuestas.Location = new System.Drawing.Point(219, 184);
            this.gpRespuestas.Name = "gpRespuestas";
            this.gpRespuestas.Size = new System.Drawing.Size(441, 214);
            this.gpRespuestas.TabIndex = 17;
            this.gpRespuestas.TabStop = false;
            this.gpRespuestas.Text = "Única respuesta";
            this.gpRespuestas.Enter += new System.EventHandler(this.gpRespuestas_Enter);
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.BackColor = System.Drawing.Color.Transparent;
            this.lblD.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD.Location = new System.Drawing.Point(12, 173);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(21, 18);
            this.lblD.TabIndex = 36;
            this.lblD.Text = "d.";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.BackColor = System.Drawing.Color.Transparent;
            this.lblC.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(12, 122);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(20, 18);
            this.lblC.TabIndex = 35;
            this.lblC.Text = "c.";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.BackColor = System.Drawing.Color.Transparent;
            this.lblB.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(12, 72);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(21, 18);
            this.lblB.TabIndex = 34;
            this.lblB.Text = "b.";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.BackColor = System.Drawing.Color.Transparent;
            this.lblA.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(12, 24);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(20, 18);
            this.lblA.TabIndex = 33;
            this.lblA.Text = "a.";
            // 
            // rbRespuestaDos
            // 
            this.rbRespuestaDos.AutoSize = true;
            this.rbRespuestaDos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRespuestaDos.Location = new System.Drawing.Point(44, 69);
            this.rbRespuestaDos.Name = "rbRespuestaDos";
            this.rbRespuestaDos.Size = new System.Drawing.Size(290, 22);
            this.rbRespuestaDos.TabIndex = 3;
            this.rbRespuestaDos.TabStop = true;
            this.rbRespuestaDos.Text = "Arreglo [3,3] de Cadena nombre";
            this.rbRespuestaDos.UseVisualStyleBackColor = true;
            // 
            // rbRespuestaTres
            // 
            this.rbRespuestaTres.AutoSize = true;
            this.rbRespuestaTres.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRespuestaTres.Location = new System.Drawing.Point(44, 122);
            this.rbRespuestaTres.Name = "rbRespuestaTres";
            this.rbRespuestaTres.Size = new System.Drawing.Size(274, 22);
            this.rbRespuestaTres.TabIndex = 2;
            this.rbRespuestaTres.TabStop = true;
            this.rbRespuestaTres.Text = "Arreglo (5,4) de Caracter letra";
            this.rbRespuestaTres.UseVisualStyleBackColor = true;
            // 
            // rbRespuestaCuatro
            // 
            this.rbRespuestaCuatro.AutoSize = true;
            this.rbRespuestaCuatro.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRespuestaCuatro.Location = new System.Drawing.Point(44, 173);
            this.rbRespuestaCuatro.Name = "rbRespuestaCuatro";
            this.rbRespuestaCuatro.Size = new System.Drawing.Size(225, 22);
            this.rbRespuestaCuatro.TabIndex = 1;
            this.rbRespuestaCuatro.TabStop = true;
            this.rbRespuestaCuatro.Text = "Arreglo [5] de Real dato";
            this.rbRespuestaCuatro.UseVisualStyleBackColor = true;
            // 
            // rbRespuestaUno
            // 
            this.rbRespuestaUno.AutoSize = true;
            this.rbRespuestaUno.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRespuestaUno.Location = new System.Drawing.Point(44, 20);
            this.rbRespuestaUno.Name = "rbRespuestaUno";
            this.rbRespuestaUno.Size = new System.Drawing.Size(282, 22);
            this.rbRespuestaUno.TabIndex = 0;
            this.rbRespuestaUno.TabStop = true;
            this.rbRespuestaUno.Text = "Arreglo [5,4] de Entero numero";
            this.rbRespuestaUno.UseVisualStyleBackColor = true;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(924, 34);
            this.panelTitulo.TabIndex = 53;
            // 
            // ptLogo
            // 
            this.ptLogo.BackColor = System.Drawing.Color.Transparent;
            this.ptLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptLogo.Image")));
            this.ptLogo.Location = new System.Drawing.Point(831, 36);
            this.ptLogo.Name = "ptLogo";
            this.ptLogo.Size = new System.Drawing.Size(90, 90);
            this.ptLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptLogo.TabIndex = 52;
            this.ptLogo.TabStop = false;
            // 
            // FrmNivel6PreguntaTres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 518);
            this.ControlBox = false;
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.ptLogo);
            this.Controls.Add(this.gpRespuestas);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.txtPreguntaTres);
            this.Controls.Add(this.lblTerceraPregunta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNivel6PreguntaTres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                     ";
            this.Load += new System.EventHandler(this.FrmNivel6PreguntaTres_Load);
            this.gpRespuestas.ResumeLayout(false);
            this.gpRespuestas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTerceraPregunta;
        private System.Windows.Forms.TextBox txtPreguntaTres;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gpRespuestas;
        private System.Windows.Forms.RadioButton rbRespuestaDos;
        private System.Windows.Forms.RadioButton rbRespuestaTres;
        private System.Windows.Forms.RadioButton rbRespuestaCuatro;
        private System.Windows.Forms.RadioButton rbRespuestaUno;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.PictureBox ptLogo;
    }
}