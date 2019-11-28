namespace Proyecto
{
    partial class frmEntero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntero));
            this.lblEntero = new System.Windows.Forms.Label();
            this.gbEntero = new System.Windows.Forms.GroupBox();
            this.lblConceptoE = new System.Windows.Forms.Label();
            this.lblE = new System.Windows.Forms.Label();
            this.lblEjemploE = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lblInt = new System.Windows.Forms.Label();
            this.gbDE = new System.Windows.Forms.GroupBox();
            this.pbLpp2 = new System.Windows.Forms.PictureBox();
            this.lblEjemplo = new System.Windows.Forms.Label();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.ptLogo = new System.Windows.Forms.PictureBox();
            this.gbEntero.SuspendLayout();
            this.gbDE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLpp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEntero
            // 
            this.lblEntero.AutoSize = true;
            this.lblEntero.BackColor = System.Drawing.Color.Transparent;
            this.lblEntero.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntero.Location = new System.Drawing.Point(303, 32);
            this.lblEntero.Name = "lblEntero";
            this.lblEntero.Size = new System.Drawing.Size(362, 32);
            this.lblEntero.TabIndex = 2;
            this.lblEntero.Text = "Variable de tipo entero";
            // 
            // gbEntero
            // 
            this.gbEntero.BackColor = System.Drawing.Color.Transparent;
            this.gbEntero.Controls.Add(this.lblConceptoE);
            this.gbEntero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEntero.Location = new System.Drawing.Point(17, 74);
            this.gbEntero.Name = "gbEntero";
            this.gbEntero.Size = new System.Drawing.Size(556, 210);
            this.gbEntero.TabIndex = 3;
            this.gbEntero.TabStop = false;
            this.gbEntero.Text = "Concepto";
            // 
            // lblConceptoE
            // 
            this.lblConceptoE.AutoSize = true;
            this.lblConceptoE.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConceptoE.Location = new System.Drawing.Point(17, 46);
            this.lblConceptoE.Name = "lblConceptoE";
            this.lblConceptoE.Size = new System.Drawing.Size(533, 120);
            this.lblConceptoE.TabIndex = 0;
            this.lblConceptoE.Text = resources.GetString("lblConceptoE.Text");
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.BackColor = System.Drawing.Color.Transparent;
            this.lblE.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblE.Location = new System.Drawing.Point(34, 310);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(493, 20);
            this.lblE.TabIndex = 10;
            this.lblE.Text = "En otros lenguajes se denominan de la siguiente forma:";
            // 
            // lblEjemploE
            // 
            this.lblEjemploE.AutoSize = true;
            this.lblEjemploE.BackColor = System.Drawing.Color.Transparent;
            this.lblEjemploE.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjemploE.Location = new System.Drawing.Point(614, 108);
            this.lblEjemploE.Name = "lblEjemploE";
            this.lblEjemploE.Size = new System.Drawing.Size(97, 23);
            this.lblEjemploE.TabIndex = 12;
            this.lblEjemploE.Text = "Ejemplo";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(35)))));
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.Location = new System.Drawing.Point(811, 473);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(101, 33);
            this.btnSiguiente.TabIndex = 15;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(130)))), ((int)(((byte)(118)))));
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(12, 473);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(101, 33);
            this.btnRegresar.TabIndex = 16;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // lblInt
            // 
            this.lblInt.AutoSize = true;
            this.lblInt.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInt.Location = new System.Drawing.Point(17, 24);
            this.lblInt.Name = "lblInt";
            this.lblInt.Size = new System.Drawing.Size(502, 40);
            this.lblInt.TabIndex = 17;
            this.lblInt.Text = "Int: Entero (Representa cualquier número sin decimales,\r\nya sea positivo o negati" +
    "vo)";
            // 
            // gbDE
            // 
            this.gbDE.BackColor = System.Drawing.Color.Transparent;
            this.gbDE.Controls.Add(this.lblInt);
            this.gbDE.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDE.Location = new System.Drawing.Point(17, 345);
            this.gbDE.Name = "gbDE";
            this.gbDE.Size = new System.Drawing.Size(556, 89);
            this.gbDE.TabIndex = 18;
            this.gbDE.TabStop = false;
            this.gbDE.Enter += new System.EventHandler(this.gbDE_Enter);
            // 
            // pbLpp2
            // 
            this.pbLpp2.Image = ((System.Drawing.Image)(resources.GetObject("pbLpp2.Image")));
            this.pbLpp2.Location = new System.Drawing.Point(598, 284);
            this.pbLpp2.Name = "pbLpp2";
            this.pbLpp2.Size = new System.Drawing.Size(274, 169);
            this.pbLpp2.TabIndex = 14;
            this.pbLpp2.TabStop = false;
            // 
            // lblEjemplo
            // 
            this.lblEjemplo.AutoSize = true;
            this.lblEjemplo.BackColor = System.Drawing.Color.Transparent;
            this.lblEjemplo.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjemplo.Location = new System.Drawing.Point(614, 148);
            this.lblEjemplo.Name = "lblEjemplo";
            this.lblEjemplo.Size = new System.Drawing.Size(274, 120);
            this.lblEjemplo.TabIndex = 20;
            this.lblEjemplo.Text = "Lea dos números enteros y\r\nalmacenelos en dos variables \r\nde nombre “a” y “b” ,\r\n" +
    "mostrando que “a” es mayor\r\nque “b” y un mensaje que \r\nmuestre que sea  \"Verdade" +
    "ro\".";
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(924, 34);
            this.panelTitulo.TabIndex = 25;
            // 
            // ptLogo
            // 
            this.ptLogo.BackColor = System.Drawing.Color.Transparent;
            this.ptLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptLogo.Image")));
            this.ptLogo.Location = new System.Drawing.Point(832, 38);
            this.ptLogo.Name = "ptLogo";
            this.ptLogo.Size = new System.Drawing.Size(90, 90);
            this.ptLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptLogo.TabIndex = 26;
            this.ptLogo.TabStop = false;
            // 
            // frmEntero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(924, 518);
            this.ControlBox = false;
            this.Controls.Add(this.ptLogo);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.lblEjemplo);
            this.Controls.Add(this.gbDE);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.pbLpp2);
            this.Controls.Add(this.lblEjemploE);
            this.Controls.Add(this.lblE);
            this.Controls.Add(this.gbEntero);
            this.Controls.Add(this.lblEntero);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEntero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entero";
            this.Load += new System.EventHandler(this.frmEntero_Load);
            this.gbEntero.ResumeLayout(false);
            this.gbEntero.PerformLayout();
            this.gbDE.ResumeLayout(false);
            this.gbDE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLpp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEntero;
        private System.Windows.Forms.GroupBox gbEntero;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.Label lblEjemploE;
        private System.Windows.Forms.PictureBox pbLpp2;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lblInt;
        private System.Windows.Forms.GroupBox gbDE;
        private System.Windows.Forms.Label lblConceptoE;
        private System.Windows.Forms.Label lblEjemplo;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.PictureBox ptLogo;
    }
}