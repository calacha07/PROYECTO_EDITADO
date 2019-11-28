namespace Proyecto
{
    partial class frmEvaluacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEvaluacion));
            this.lblEvaluacion = new System.Windows.Forms.Label();
            this.lblPregunta2 = new System.Windows.Forms.Label();
            this.grpbTest = new System.Windows.Forms.GroupBox();
            this.cbTest2 = new System.Windows.Forms.ComboBox();
            this.cboTextt = new System.Windows.Forms.ComboBox();
            this.cbTest3 = new System.Windows.Forms.ComboBox();
            this.lblPregunta3 = new System.Windows.Forms.Label();
            this.cbTest1 = new System.Windows.Forms.ComboBox();
            this.lblTest = new System.Windows.Forms.Label();
            this.lblPregunta1 = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.ptLogo = new System.Windows.Forms.PictureBox();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.grpbTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEvaluacion
            // 
            this.lblEvaluacion.AutoSize = true;
            this.lblEvaluacion.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvaluacion.Location = new System.Drawing.Point(404, 45);
            this.lblEvaluacion.Name = "lblEvaluacion";
            this.lblEvaluacion.Size = new System.Drawing.Size(79, 32);
            this.lblEvaluacion.TabIndex = 3;
            this.lblEvaluacion.Text = "Test";
            // 
            // lblPregunta2
            // 
            this.lblPregunta2.AutoSize = true;
            this.lblPregunta2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta2.Location = new System.Drawing.Point(6, 109);
            this.lblPregunta2.Name = "lblPregunta2";
            this.lblPregunta2.Size = new System.Drawing.Size(430, 36);
            this.lblPregunta2.TabIndex = 4;
            this.lblPregunta2.Text = "2) ¿Qué tipo de dato se utiliza para almacenar los \r\n     siguientes valores? “1," +
    " 2, 3, 4, 5, 6”\r\n";
            this.lblPregunta2.Click += new System.EventHandler(this.lblPregunta2_Click);
            // 
            // grpbTest
            // 
            this.grpbTest.BackColor = System.Drawing.Color.Transparent;
            this.grpbTest.Controls.Add(this.cbTest2);
            this.grpbTest.Controls.Add(this.cboTextt);
            this.grpbTest.Controls.Add(this.cbTest3);
            this.grpbTest.Controls.Add(this.lblPregunta3);
            this.grpbTest.Controls.Add(this.cbTest1);
            this.grpbTest.Controls.Add(this.lblTest);
            this.grpbTest.Controls.Add(this.lblPregunta1);
            this.grpbTest.Controls.Add(this.lblPregunta2);
            this.grpbTest.Location = new System.Drawing.Point(28, 92);
            this.grpbTest.Name = "grpbTest";
            this.grpbTest.Size = new System.Drawing.Size(796, 312);
            this.grpbTest.TabIndex = 12;
            this.grpbTest.TabStop = false;
            this.grpbTest.Text = "Preguntas ";
            this.grpbTest.Enter += new System.EventHandler(this.grpbTest_Enter);
            // 
            // cbTest2
            // 
            this.cbTest2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTest2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTest2.FormattingEnabled = true;
            this.cbTest2.Items.AddRange(new object[] {
            "Tipo de dato booleano",
            "Tipo de dato real",
            "Tipo de dato cadena",
            "Tipo de dato entero"});
            this.cbTest2.Location = new System.Drawing.Point(517, 106);
            this.cbTest2.Name = "cbTest2";
            this.cbTest2.Size = new System.Drawing.Size(228, 26);
            this.cbTest2.TabIndex = 17;
            this.cbTest2.SelectedIndexChanged += new System.EventHandler(this.cboEntero_SelectedIndexChanged);
            // 
            // cboTextt
            // 
            this.cboTextt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTextt.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTextt.FormattingEnabled = true;
            this.cboTextt.Items.AddRange(new object[] {
            "Tipo de dato entero",
            "Tipo de dato real",
            "Tipo de dato booleano",
            "Tipo de dato cadena"});
            this.cboTextt.Location = new System.Drawing.Point(518, 233);
            this.cboTextt.Name = "cboTextt";
            this.cboTextt.Size = new System.Drawing.Size(228, 26);
            this.cboTextt.TabIndex = 16;
            this.cboTextt.SelectedIndexChanged += new System.EventHandler(this.cboTextt_SelectedIndexChanged);
            // 
            // cbTest3
            // 
            this.cbTest3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTest3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTest3.FormattingEnabled = true;
            this.cbTest3.Items.AddRange(new object[] {
            "Tipo de dato booleano",
            "Tipo de dato real",
            "Tipo de dato cadena",
            "Tipo de dato entero"});
            this.cbTest3.Location = new System.Drawing.Point(517, 164);
            this.cbTest3.Name = "cbTest3";
            this.cbTest3.Size = new System.Drawing.Size(228, 26);
            this.cbTest3.TabIndex = 9;
            this.cbTest3.SelectedIndexChanged += new System.EventHandler(this.cbTest2_SelectedIndexChanged);
            // 
            // lblPregunta3
            // 
            this.lblPregunta3.AutoSize = true;
            this.lblPregunta3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta3.Location = new System.Drawing.Point(7, 172);
            this.lblPregunta3.Name = "lblPregunta3";
            this.lblPregunta3.Size = new System.Drawing.Size(480, 18);
            this.lblPregunta3.TabIndex = 8;
            this.lblPregunta3.Text = "3) ¿Qué tipo de variable se utiliza para almacenar texto?";
            // 
            // cbTest1
            // 
            this.cbTest1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTest1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTest1.FormattingEnabled = true;
            this.cbTest1.Items.AddRange(new object[] {
            "Tipo de dato booleano",
            "Tipo de dato cadena",
            "Tipo de dato entero",
            "Tipo de dato real"});
            this.cbTest1.Location = new System.Drawing.Point(517, 44);
            this.cbTest1.Name = "cbTest1";
            this.cbTest1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbTest1.Size = new System.Drawing.Size(228, 26);
            this.cbTest1.TabIndex = 5;
            this.cbTest1.SelectedIndexChanged += new System.EventHandler(this.cbTest1_SelectedIndexChanged);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest.Location = new System.Drawing.Point(2, 223);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(420, 54);
            this.lblTest.TabIndex = 13;
            this.lblTest.Text = " 4) Es un tipo de dato en programas informáticos \r\n     que representa números de" +
    "cimales.\r\n\r\n";
            this.lblTest.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPregunta1
            // 
            this.lblPregunta1.AutoSize = true;
            this.lblPregunta1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta1.Location = new System.Drawing.Point(6, 47);
            this.lblPregunta1.Name = "lblPregunta1";
            this.lblPregunta1.Size = new System.Drawing.Size(493, 36);
            this.lblPregunta1.TabIndex = 4;
            this.lblPregunta1.Text = "1) ¿Qué tipo de variable utilizamos para identificar cuando\r\n    una condición es" +
    " verdadera o falsa?";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(35)))));
            this.btnFinalizar.FlatAppearance.BorderSize = 0;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar.Location = new System.Drawing.Point(841, 478);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(101, 33);
            this.btnFinalizar.TabIndex = 18;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // ptLogo
            // 
            this.ptLogo.BackColor = System.Drawing.Color.Transparent;
            this.ptLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptLogo.Image")));
            this.ptLogo.Location = new System.Drawing.Point(863, 36);
            this.ptLogo.Name = "ptLogo";
            this.ptLogo.Size = new System.Drawing.Size(90, 90);
            this.ptLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptLogo.TabIndex = 28;
            this.ptLogo.TabStop = false;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(954, 34);
            this.panelTitulo.TabIndex = 27;
            // 
            // frmEvaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(954, 523);
            this.ControlBox = false;
            this.Controls.Add(this.ptLogo);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.grpbTest);
            this.Controls.Add(this.lblEvaluacion);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEvaluacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evaluacion";
            this.Load += new System.EventHandler(this.frmEvaluacion_Load);
            this.grpbTest.ResumeLayout(false);
            this.grpbTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEvaluacion;
        private System.Windows.Forms.Label lblPregunta2;
        private System.Windows.Forms.GroupBox grpbTest;
        private System.Windows.Forms.ComboBox cbTest3;
        private System.Windows.Forms.Label lblPregunta3;
        private System.Windows.Forms.ComboBox cbTest1;
        private System.Windows.Forms.Label lblPregunta1;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.ComboBox cboTextt;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.ComboBox cbTest2;
        private System.Windows.Forms.PictureBox ptLogo;
        private System.Windows.Forms.Panel panelTitulo;
    }
}