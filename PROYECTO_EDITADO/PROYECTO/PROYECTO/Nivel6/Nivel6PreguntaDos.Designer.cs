namespace PROYECTO
{
    partial class FrmNivel6PreguntaDos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNivel6PreguntaDos));
            this.lblSegundaPregunta = new System.Windows.Forms.Label();
            this.txtPreguntaDos = new System.Windows.Forms.TextBox();
            this.btnSiguienteDos = new System.Windows.Forms.Button();
            this.pbMatrcies = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pbMatrcies)).BeginInit();
            this.gpRespuestas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSegundaPregunta
            // 
            this.lblSegundaPregunta.AutoSize = true;
            this.lblSegundaPregunta.BackColor = System.Drawing.Color.Transparent;
            this.lblSegundaPregunta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundaPregunta.Location = new System.Drawing.Point(18, 82);
            this.lblSegundaPregunta.Name = "lblSegundaPregunta";
            this.lblSegundaPregunta.Size = new System.Drawing.Size(171, 18);
            this.lblSegundaPregunta.TabIndex = 0;
            this.lblSegundaPregunta.Text = "Segunda pregunta";
            // 
            // txtPreguntaDos
            // 
            this.txtPreguntaDos.BackColor = System.Drawing.Color.White;
            this.txtPreguntaDos.Enabled = false;
            this.txtPreguntaDos.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreguntaDos.Location = new System.Drawing.Point(21, 107);
            this.txtPreguntaDos.Name = "txtPreguntaDos";
            this.txtPreguntaDos.ReadOnly = true;
            this.txtPreguntaDos.Size = new System.Drawing.Size(383, 26);
            this.txtPreguntaDos.TabIndex = 1;
            this.txtPreguntaDos.Text = "Del siguiente pseudocódigo podemos deducir que:";
            this.txtPreguntaDos.TextChanged += new System.EventHandler(this.txtPreguntaDos_TextChanged);
            // 
            // btnSiguienteDos
            // 
            this.btnSiguienteDos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(130)))), ((int)(((byte)(118)))));
            this.btnSiguienteDos.FlatAppearance.BorderSize = 0;
            this.btnSiguienteDos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguienteDos.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteDos.ForeColor = System.Drawing.Color.White;
            this.btnSiguienteDos.Location = new System.Drawing.Point(793, 473);
            this.btnSiguienteDos.Name = "btnSiguienteDos";
            this.btnSiguienteDos.Size = new System.Drawing.Size(146, 33);
            this.btnSiguienteDos.TabIndex = 2;
            this.btnSiguienteDos.Text = "Siguiente";
            this.btnSiguienteDos.UseVisualStyleBackColor = false;
            this.btnSiguienteDos.Click += new System.EventHandler(this.btnSiguienteDos_Click);
            // 
            // pbMatrcies
            // 
            this.pbMatrcies.Image = ((System.Drawing.Image)(resources.GetObject("pbMatrcies.Image")));
            this.pbMatrcies.Location = new System.Drawing.Point(21, 144);
            this.pbMatrcies.Name = "pbMatrcies";
            this.pbMatrcies.Size = new System.Drawing.Size(447, 331);
            this.pbMatrcies.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMatrcies.TabIndex = 7;
            this.pbMatrcies.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(431, 46);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(79, 32);
            this.lblTitulo.TabIndex = 11;
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
            this.gpRespuestas.Location = new System.Drawing.Point(474, 144);
            this.gpRespuestas.Name = "gpRespuestas";
            this.gpRespuestas.Size = new System.Drawing.Size(469, 181);
            this.gpRespuestas.TabIndex = 14;
            this.gpRespuestas.TabStop = false;
            this.gpRespuestas.Text = "Única respuesta";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.BackColor = System.Drawing.Color.Transparent;
            this.lblD.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD.Location = new System.Drawing.Point(17, 140);
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
            this.lblC.Location = new System.Drawing.Point(17, 98);
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
            this.lblB.Location = new System.Drawing.Point(17, 59);
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
            this.lblA.Location = new System.Drawing.Point(17, 25);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(20, 18);
            this.lblA.TabIndex = 33;
            this.lblA.Text = "a.";
            // 
            // rbRespuestaDos
            // 
            this.rbRespuestaDos.AutoSize = true;
            this.rbRespuestaDos.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRespuestaDos.Location = new System.Drawing.Point(44, 55);
            this.rbRespuestaDos.Name = "rbRespuestaDos";
            this.rbRespuestaDos.Size = new System.Drawing.Size(252, 22);
            this.rbRespuestaDos.TabIndex = 3;
            this.rbRespuestaDos.TabStop = true;
            this.rbRespuestaDos.Text = "Imprime los valores del vector";
            this.rbRespuestaDos.UseVisualStyleBackColor = true;
            // 
            // rbRespuestaTres
            // 
            this.rbRespuestaTres.AutoSize = true;
            this.rbRespuestaTres.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRespuestaTres.Location = new System.Drawing.Point(44, 95);
            this.rbRespuestaTres.Name = "rbRespuestaTres";
            this.rbRespuestaTres.Size = new System.Drawing.Size(409, 22);
            this.rbRespuestaTres.TabIndex = 2;
            this.rbRespuestaTres.TabStop = true;
            this.rbRespuestaTres.Text = " Imprime la matriz 5*4 con sus respectivos valores";
            this.rbRespuestaTres.UseVisualStyleBackColor = true;
            // 
            // rbRespuestaCuatro
            // 
            this.rbRespuestaCuatro.AutoSize = true;
            this.rbRespuestaCuatro.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRespuestaCuatro.Location = new System.Drawing.Point(44, 128);
            this.rbRespuestaCuatro.Name = "rbRespuestaCuatro";
            this.rbRespuestaCuatro.Size = new System.Drawing.Size(393, 40);
            this.rbRespuestaCuatro.TabIndex = 1;
            this.rbRespuestaCuatro.TabStop = true;
            this.rbRespuestaCuatro.Text = "No imprime la matriz debido a que tiene un error \r\nen el código.";
            this.rbRespuestaCuatro.UseVisualStyleBackColor = true;
            // 
            // rbRespuestaUno
            // 
            this.rbRespuestaUno.AutoSize = true;
            this.rbRespuestaUno.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRespuestaUno.Location = new System.Drawing.Point(44, 23);
            this.rbRespuestaUno.Name = "rbRespuestaUno";
            this.rbRespuestaUno.Size = new System.Drawing.Size(304, 22);
            this.rbRespuestaUno.TabIndex = 0;
            this.rbRespuestaUno.TabStop = true;
            this.rbRespuestaUno.Text = "Imprime una matriz cuadrada de 2*2";
            this.rbRespuestaUno.UseVisualStyleBackColor = true;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(951, 34);
            this.panelTitulo.TabIndex = 53;
            // 
            // ptLogo
            // 
            this.ptLogo.BackColor = System.Drawing.Color.Transparent;
            this.ptLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptLogo.Image")));
            this.ptLogo.Location = new System.Drawing.Point(860, 36);
            this.ptLogo.Name = "ptLogo";
            this.ptLogo.Size = new System.Drawing.Size(90, 90);
            this.ptLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptLogo.TabIndex = 52;
            this.ptLogo.TabStop = false;
            // 
            // FrmNivel6PreguntaDos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(951, 518);
            this.ControlBox = false;
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.ptLogo);
            this.Controls.Add(this.gpRespuestas);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pbMatrcies);
            this.Controls.Add(this.btnSiguienteDos);
            this.Controls.Add(this.txtPreguntaDos);
            this.Controls.Add(this.lblSegundaPregunta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNivel6PreguntaDos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                             ";
            this.Load += new System.EventHandler(this.Segunda_Pregunta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMatrcies)).EndInit();
            this.gpRespuestas.ResumeLayout(false);
            this.gpRespuestas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSegundaPregunta;
        private System.Windows.Forms.TextBox txtPreguntaDos;
        private System.Windows.Forms.Button btnSiguienteDos;
        private System.Windows.Forms.PictureBox pbMatrcies;
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