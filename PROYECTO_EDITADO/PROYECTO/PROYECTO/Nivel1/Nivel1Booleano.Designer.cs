namespace Proyecto
{
    partial class FrmBooleano
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBooleano));
            this.lblbooleano = new System.Windows.Forms.Label();
            this.gbBooleano = new System.Windows.Forms.GroupBox();
            this.lblTB = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblEjercicioB = new System.Windows.Forms.Label();
            this.txtEjemplo1 = new System.Windows.Forms.TextBox();
            this.txtEjemplo2 = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnEvaluacion = new System.Windows.Forms.Button();
            this.lblTrue = new System.Windows.Forms.Label();
            this.gbB = new System.Windows.Forms.GroupBox();
            this.lblFalse = new System.Windows.Forms.Label();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.ptLogo = new System.Windows.Forms.PictureBox();
            this.gbBooleano.SuspendLayout();
            this.gbB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblbooleano
            // 
            this.lblbooleano.AutoSize = true;
            this.lblbooleano.BackColor = System.Drawing.Color.Transparent;
            this.lblbooleano.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbooleano.Location = new System.Drawing.Point(307, 70);
            this.lblbooleano.Name = "lblbooleano";
            this.lblbooleano.Size = new System.Drawing.Size(356, 29);
            this.lblbooleano.TabIndex = 1;
            this.lblbooleano.Text = "Variable de tipo Booleano";
            // 
            // gbBooleano
            // 
            this.gbBooleano.BackColor = System.Drawing.Color.Transparent;
            this.gbBooleano.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbBooleano.Controls.Add(this.lblTB);
            this.gbBooleano.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBooleano.Location = new System.Drawing.Point(39, 157);
            this.gbBooleano.Name = "gbBooleano";
            this.gbBooleano.Size = new System.Drawing.Size(524, 138);
            this.gbBooleano.TabIndex = 2;
            this.gbBooleano.TabStop = false;
            this.gbBooleano.Text = "Concepto";
            // 
            // lblTB
            // 
            this.lblTB.AutoSize = true;
            this.lblTB.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTB.Location = new System.Drawing.Point(10, 44);
            this.lblTB.Name = "lblTB";
            this.lblTB.Size = new System.Drawing.Size(513, 54);
            this.lblTB.TabIndex = 1;
            this.lblTB.Text = "Es un valor lógico representado por el tipo primitivo boolean,\r\nel cual represent" +
    "a que una condición se\r\ncumpla o no.";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.BackColor = System.Drawing.Color.Transparent;
            this.lblB.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(49, 313);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(465, 18);
            this.lblB.TabIndex = 10;
            this.lblB.Text = "En otros lenguajes se denominan de la siguiente forma";
            // 
            // lblEjercicioB
            // 
            this.lblEjercicioB.AutoSize = true;
            this.lblEjercicioB.BackColor = System.Drawing.Color.Transparent;
            this.lblEjercicioB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjercicioB.Location = new System.Drawing.Point(657, 157);
            this.lblEjercicioB.Name = "lblEjercicioB";
            this.lblEjercicioB.Size = new System.Drawing.Size(73, 20);
            this.lblEjercicioB.TabIndex = 12;
            this.lblEjercicioB.Text = "Ejemplo";
            // 
            // txtEjemplo1
            // 
            this.txtEjemplo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEjemplo1.Location = new System.Drawing.Point(595, 198);
            this.txtEjemplo1.Multiline = true;
            this.txtEjemplo1.Name = "txtEjemplo1";
            this.txtEjemplo1.ReadOnly = true;
            this.txtEjemplo1.Size = new System.Drawing.Size(227, 32);
            this.txtEjemplo1.TabIndex = 13;
            this.txtEjemplo1.Text = "MaximaPuntuacion= true";
            // 
            // txtEjemplo2
            // 
            this.txtEjemplo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEjemplo2.Location = new System.Drawing.Point(595, 242);
            this.txtEjemplo2.Multiline = true;
            this.txtEjemplo2.Name = "txtEjemplo2";
            this.txtEjemplo2.ReadOnly = true;
            this.txtEjemplo2.Size = new System.Drawing.Size(227, 32);
            this.txtEjemplo2.TabIndex = 14;
            this.txtEjemplo2.Text = "MaximaPuntuacion = false";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(130)))), ((int)(((byte)(118)))));
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(12, 473);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(101, 33);
            this.btnRegresar.TabIndex = 15;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnEvaluacion
            // 
            this.btnEvaluacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(35)))));
            this.btnEvaluacion.FlatAppearance.BorderSize = 0;
            this.btnEvaluacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvaluacion.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvaluacion.ForeColor = System.Drawing.Color.White;
            this.btnEvaluacion.Location = new System.Drawing.Point(811, 473);
            this.btnEvaluacion.Name = "btnEvaluacion";
            this.btnEvaluacion.Size = new System.Drawing.Size(101, 33);
            this.btnEvaluacion.TabIndex = 16;
            this.btnEvaluacion.Text = "Siguiente";
            this.btnEvaluacion.UseVisualStyleBackColor = false;
            this.btnEvaluacion.Click += new System.EventHandler(this.btnEvaluacion_Click);
            // 
            // lblTrue
            // 
            this.lblTrue.AutoSize = true;
            this.lblTrue.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrue.Location = new System.Drawing.Point(10, 16);
            this.lblTrue.Name = "lblTrue";
            this.lblTrue.Size = new System.Drawing.Size(142, 18);
            this.lblTrue.TabIndex = 17;
            this.lblTrue.Text = "true (verdadero)";
            // 
            // gbB
            // 
            this.gbB.BackColor = System.Drawing.Color.Transparent;
            this.gbB.Controls.Add(this.lblFalse);
            this.gbB.Controls.Add(this.lblTrue);
            this.gbB.Location = new System.Drawing.Point(39, 341);
            this.gbB.Name = "gbB";
            this.gbB.Size = new System.Drawing.Size(474, 66);
            this.gbB.TabIndex = 18;
            this.gbB.TabStop = false;
            this.gbB.Enter += new System.EventHandler(this.gbB_Enter);
            // 
            // lblFalse
            // 
            this.lblFalse.AutoSize = true;
            this.lblFalse.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFalse.Location = new System.Drawing.Point(10, 45);
            this.lblFalse.Name = "lblFalse";
            this.lblFalse.Size = new System.Drawing.Size(108, 18);
            this.lblFalse.TabIndex = 18;
            this.lblFalse.Text = "false (falso)";
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(924, 34);
            this.panelTitulo.TabIndex = 19;
            // 
            // ptLogo
            // 
            this.ptLogo.BackColor = System.Drawing.Color.Transparent;
            this.ptLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptLogo.Image")));
            this.ptLogo.Location = new System.Drawing.Point(833, 34);
            this.ptLogo.Name = "ptLogo";
            this.ptLogo.Size = new System.Drawing.Size(90, 90);
            this.ptLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptLogo.TabIndex = 20;
            this.ptLogo.TabStop = false;
            // 
            // FrmBooleano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(924, 518);
            this.ControlBox = false;
            this.Controls.Add(this.ptLogo);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.gbB);
            this.Controls.Add(this.btnEvaluacion);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.txtEjemplo2);
            this.Controls.Add(this.txtEjemplo1);
            this.Controls.Add(this.lblEjercicioB);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.gbBooleano);
            this.Controls.Add(this.lblbooleano);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBooleano";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booleano";
            this.Load += new System.EventHandler(this.frmBooleano_Load);
            this.gbBooleano.ResumeLayout(false);
            this.gbBooleano.PerformLayout();
            this.gbB.ResumeLayout(false);
            this.gbB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbooleano;
        private System.Windows.Forms.GroupBox gbBooleano;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblEjercicioB;
        private System.Windows.Forms.TextBox txtEjemplo1;
        private System.Windows.Forms.TextBox txtEjemplo2;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnEvaluacion;
        private System.Windows.Forms.Label lblTrue;
        private System.Windows.Forms.GroupBox gbB;
        private System.Windows.Forms.Label lblFalse;
        private System.Windows.Forms.Label lblTB;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.PictureBox ptLogo;
    }
}