namespace Proyecto
{
    partial class FrmPueba
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPueba));
            this.cboTest2 = new System.Windows.Forms.ComboBox();
            this.cbTest1 = new System.Windows.Forms.ComboBox();
            this.lblPregunta1 = new System.Windows.Forms.Label();
            this.lblTest = new System.Windows.Forms.Label();
            this.lblPregunta2 = new System.Windows.Forms.Label();
            this.ptLogo = new System.Windows.Forms.PictureBox();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboTest2
            // 
            this.cboTest2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTest2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTest2.FormattingEnabled = true;
            this.cboTest2.Items.AddRange(new object[] {
            "Función",
            "Procedimiento"});
            this.cboTest2.Location = new System.Drawing.Point(23, 95);
            this.cboTest2.Name = "cboTest2";
            this.cboTest2.Size = new System.Drawing.Size(148, 26);
            this.cboTest2.TabIndex = 17;
            this.cboTest2.SelectedIndexChanged += new System.EventHandler(this.cboEntero_SelectedIndexChanged);
            // 
            // cbTest1
            // 
            this.cbTest1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTest1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTest1.FormattingEnabled = true;
            this.cbTest1.Items.AddRange(new object[] {
            "Verdadero",
            "Falso"});
            this.cbTest1.Location = new System.Drawing.Point(23, 32);
            this.cbTest1.Name = "cbTest1";
            this.cbTest1.Size = new System.Drawing.Size(148, 26);
            this.cbTest1.TabIndex = 5;
            this.cbTest1.SelectedIndexChanged += new System.EventHandler(this.cbTest1_SelectedIndexChanged);
            // 
            // lblPregunta1
            // 
            this.lblPregunta1.AutoSize = true;
            this.lblPregunta1.BackColor = System.Drawing.Color.Transparent;
            this.lblPregunta1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta1.Location = new System.Drawing.Point(23, 32);
            this.lblPregunta1.Name = "lblPregunta1";
            this.lblPregunta1.Size = new System.Drawing.Size(329, 18);
            this.lblPregunta1.TabIndex = 4;
            this.lblPregunta1.Text = "1. ¿Un procedimiento retorna un valor?";
            this.lblPregunta1.Click += new System.EventHandler(this.lblPregunta1_Click);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.BackColor = System.Drawing.Color.Transparent;
            this.lblTest.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest.Location = new System.Drawing.Point(301, 40);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(88, 32);
            this.lblTest.TabIndex = 3;
            this.lblTest.Text = "TEST";
            // 
            // lblPregunta2
            // 
            this.lblPregunta2.AutoSize = true;
            this.lblPregunta2.BackColor = System.Drawing.Color.Transparent;
            this.lblPregunta2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta2.Location = new System.Drawing.Point(23, 67);
            this.lblPregunta2.Name = "lblPregunta2";
            this.lblPregunta2.Size = new System.Drawing.Size(328, 54);
            this.lblPregunta2.TabIndex = 4;
            this.lblPregunta2.Text = "2. Son subprogramas que realizan una\r\n    o más instrucciones que devuelve   \r\n  " +
    "  un solo valor.";
            // 
            // ptLogo
            // 
            this.ptLogo.BackColor = System.Drawing.Color.Transparent;
            this.ptLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptLogo.Image")));
            this.ptLogo.Location = new System.Drawing.Point(587, 40);
            this.ptLogo.Name = "ptLogo";
            this.ptLogo.Size = new System.Drawing.Size(105, 90);
            this.ptLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptLogo.TabIndex = 28;
            this.ptLogo.TabStop = false;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(700, 34);
            this.panelTitulo.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTest1);
            this.groupBox1.Controls.Add(this.cboTest2);
            this.groupBox1.Location = new System.Drawing.Point(424, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 143);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Respuestas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "Seleccione la opción que considere correcta.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPregunta1);
            this.groupBox2.Controls.Add(this.lblPregunta2);
            this.groupBox2.Location = new System.Drawing.Point(32, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 143);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preguntas";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(35)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(587, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 33);
            this.button1.TabIndex = 32;
            this.button1.Text = "Evaluar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmPueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 417);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ptLogo);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.lblTest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPueba";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                                 " +
    "        ";
            this.Load += new System.EventHandler(this.FrmPueba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTest2;
        private System.Windows.Forms.ComboBox cbTest1;
        private System.Windows.Forms.Label lblPregunta1;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Label lblPregunta2;
        private System.Windows.Forms.PictureBox ptLogo;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
	}
}