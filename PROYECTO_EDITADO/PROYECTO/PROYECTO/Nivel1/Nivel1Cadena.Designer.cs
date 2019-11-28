namespace Proyecto
{
    partial class frmCadena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadena));
            this.lblCadena = new System.Windows.Forms.Label();
            this.gbCadena = new System.Windows.Forms.GroupBox();
            this.lblTC = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblEjemploC = new System.Windows.Forms.Label();
            this.txtE1 = new System.Windows.Forms.TextBox();
            this.txtE2 = new System.Windows.Forms.TextBox();
            this.txtE3 = new System.Windows.Forms.TextBox();
            this.txtE4 = new System.Windows.Forms.TextBox();
            this.gbDc = new System.Windows.Forms.GroupBox();
            this.lblString = new System.Windows.Forms.Label();
            this.lblChar = new System.Windows.Forms.Label();
            this.ptLogo = new System.Windows.Forms.PictureBox();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.gbCadena.SuspendLayout();
            this.gbDc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCadena
            // 
            this.lblCadena.AutoSize = true;
            this.lblCadena.BackColor = System.Drawing.Color.Transparent;
            this.lblCadena.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadena.Location = new System.Drawing.Point(267, 44);
            this.lblCadena.Name = "lblCadena";
            this.lblCadena.Size = new System.Drawing.Size(320, 32);
            this.lblCadena.TabIndex = 1;
            this.lblCadena.Text = "Tipo de dato cadena";
            // 
            // gbCadena
            // 
            this.gbCadena.BackColor = System.Drawing.Color.Transparent;
            this.gbCadena.Controls.Add(this.lblTC);
            this.gbCadena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCadena.Location = new System.Drawing.Point(43, 122);
            this.gbCadena.Name = "gbCadena";
            this.gbCadena.Size = new System.Drawing.Size(544, 113);
            this.gbCadena.TabIndex = 2;
            this.gbCadena.TabStop = false;
            this.gbCadena.Text = "Concepto";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTC.Location = new System.Drawing.Point(18, 49);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(436, 40);
            this.lblTC.TabIndex = 3;
            this.lblTC.Text = "Son variables empleadas para almacenar valores \r\nalfanuméricos\r\n";
            this.lblTC.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.BackColor = System.Drawing.Color.Transparent;
            this.lblC.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(62, 258);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(465, 18);
            this.lblC.TabIndex = 9;
            this.lblC.Text = "En otros lenguajes se denominan de la siguiente forma";
            // 
            // lblEjemploC
            // 
            this.lblEjemploC.AutoSize = true;
            this.lblEjemploC.BackColor = System.Drawing.Color.Transparent;
            this.lblEjemploC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjemploC.Location = new System.Drawing.Point(612, 122);
            this.lblEjemploC.Name = "lblEjemploC";
            this.lblEjemploC.Size = new System.Drawing.Size(73, 20);
            this.lblEjemploC.TabIndex = 11;
            this.lblEjemploC.Text = "Ejemplo";
            // 
            // txtE1
            // 
            this.txtE1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtE1.Location = new System.Drawing.Point(616, 171);
            this.txtE1.Multiline = true;
            this.txtE1.Name = "txtE1";
            this.txtE1.ReadOnly = true;
            this.txtE1.Size = new System.Drawing.Size(227, 32);
            this.txtE1.TabIndex = 12;
            this.txtE1.Text = "String  nif = \"12332112W\"";
            // 
            // txtE2
            // 
            this.txtE2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtE2.Location = new System.Drawing.Point(616, 235);
            this.txtE2.Multiline = true;
            this.txtE2.Name = "txtE2";
            this.txtE2.ReadOnly = true;
            this.txtE2.Size = new System.Drawing.Size(227, 32);
            this.txtE2.TabIndex = 13;
            this.txtE2.Text = "Ciudad= \"Cali \"";
            // 
            // txtE3
            // 
            this.txtE3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtE3.Location = new System.Drawing.Point(616, 304);
            this.txtE3.Multiline = true;
            this.txtE3.Name = "txtE3";
            this.txtE3.ReadOnly = true;
            this.txtE3.Size = new System.Drawing.Size(227, 32);
            this.txtE3.TabIndex = 14;
            this.txtE3.Text = "codigoPostal = \"28001\"";
            // 
            // txtE4
            // 
            this.txtE4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtE4.Location = new System.Drawing.Point(616, 369);
            this.txtE4.Multiline = true;
            this.txtE4.Name = "txtE4";
            this.txtE4.ReadOnly = true;
            this.txtE4.Size = new System.Drawing.Size(227, 32);
            this.txtE4.TabIndex = 15;
            this.txtE4.Text = "Telefono =\"003423145627\"";
            // 
            // gbDc
            // 
            this.gbDc.BackColor = System.Drawing.Color.Transparent;
            this.gbDc.Controls.Add(this.lblString);
            this.gbDc.Controls.Add(this.lblChar);
            this.gbDc.Location = new System.Drawing.Point(43, 304);
            this.gbDc.Name = "gbDc";
            this.gbDc.Size = new System.Drawing.Size(544, 139);
            this.gbDc.TabIndex = 18;
            this.gbDc.TabStop = false;
            // 
            // lblString
            // 
            this.lblString.AutoSize = true;
            this.lblString.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblString.Location = new System.Drawing.Point(19, 68);
            this.lblString.Name = "lblString";
            this.lblString.Size = new System.Drawing.Size(488, 36);
            this.lblString.TabIndex = 18;
            this.lblString.Text = "String: Su asignación del valor debe estar contenido entre\r\ncomillas (\" \").";
            // 
            // lblChar
            // 
            this.lblChar.AutoSize = true;
            this.lblChar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChar.Location = new System.Drawing.Point(19, 16);
            this.lblChar.Name = "lblChar";
            this.lblChar.Size = new System.Drawing.Size(508, 36);
            this.lblChar.TabIndex = 0;
            this.lblChar.Text = "Char: Es un carácter Unicode, y su asignación de valor debe \r\nestar contenido ent" +
    "re comillas simples (\' \').\r\n";
            // 
            // ptLogo
            // 
            this.ptLogo.BackColor = System.Drawing.Color.Transparent;
            this.ptLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptLogo.Image")));
            this.ptLogo.Location = new System.Drawing.Point(832, 34);
            this.ptLogo.Name = "ptLogo";
            this.ptLogo.Size = new System.Drawing.Size(90, 90);
            this.ptLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptLogo.TabIndex = 24;
            this.ptLogo.TabStop = false;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(924, 34);
            this.panelTitulo.TabIndex = 23;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(35)))));
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.Location = new System.Drawing.Point(811, 473);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(101, 33);
            this.btnSiguiente.TabIndex = 22;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click_2);
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
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // frmCadena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(924, 518);
            this.ControlBox = false;
            this.Controls.Add(this.ptLogo);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.gbDc);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.txtE4);
            this.Controls.Add(this.txtE3);
            this.Controls.Add(this.txtE2);
            this.Controls.Add(this.txtE1);
            this.Controls.Add(this.lblEjemploC);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.gbCadena);
            this.Controls.Add(this.lblCadena);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadena";
            this.Load += new System.EventHandler(this.frmCadena_Load);
            this.gbCadena.ResumeLayout(false);
            this.gbCadena.PerformLayout();
            this.gbDc.ResumeLayout(false);
            this.gbDc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCadena;
        private System.Windows.Forms.GroupBox gbCadena;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblEjemploC;
        private System.Windows.Forms.TextBox txtE1;
        private System.Windows.Forms.TextBox txtE2;
        private System.Windows.Forms.TextBox txtE3;
        private System.Windows.Forms.TextBox txtE4;
        private System.Windows.Forms.GroupBox gbDc;
        private System.Windows.Forms.Label lblString;
        private System.Windows.Forms.Label lblChar;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.PictureBox ptLogo;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnSiguiente;
    }
}