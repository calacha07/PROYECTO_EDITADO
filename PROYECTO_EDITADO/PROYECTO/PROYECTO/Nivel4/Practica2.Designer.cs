namespace PROYECTO.Nivel4
{
    partial class Practica2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Practica2));
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNro1 = new System.Windows.Forms.Label();
            this.ptLogo = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnEvaluar = new System.Windows.Forms.Button();
            this.cmbNro4 = new System.Windows.Forms.ComboBox();
            this.cmbNro2 = new System.Windows.Forms.ComboBox();
            this.cmbNro3 = new System.Windows.Forms.ComboBox();
            this.cmbNro1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(692, 34);
            this.panelTitulo.TabIndex = 39;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(130)))), ((int)(((byte)(118)))));
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(56, 462);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(101, 33);
            this.btnRegresar.TabIndex = 38;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(35)))));
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.Location = new System.Drawing.Point(535, 462);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(101, 33);
            this.btnSiguiente.TabIndex = 37;
            this.btnSiguiente.Text = "Evaluación";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 18);
            this.label1.TabIndex = 36;
            this.label1.Text = "2. Seleccione la opción que considere correcta.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNro1
            // 
            this.lblNro1.AutoSize = true;
            this.lblNro1.BackColor = System.Drawing.Color.Transparent;
            this.lblNro1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNro1.Location = new System.Drawing.Point(50, 37);
            this.lblNro1.Name = "lblNro1";
            this.lblNro1.Size = new System.Drawing.Size(541, 32);
            this.lblNro1.TabIndex = 35;
            this.lblNro1.Text = "Práctica didáctica (Procedimiento)";
            // 
            // ptLogo
            // 
            this.ptLogo.BackColor = System.Drawing.Color.Transparent;
            this.ptLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptLogo.Image")));
            this.ptLogo.Location = new System.Drawing.Point(600, 35);
            this.ptLogo.Name = "ptLogo";
            this.ptLogo.Size = new System.Drawing.Size(90, 90);
            this.ptLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptLogo.TabIndex = 40;
            this.ptLogo.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnEvaluar);
            this.groupBox1.Controls.Add(this.cmbNro4);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(454, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 131);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultado algoritmo.";
            // 
            // BtnEvaluar
            // 
            this.BtnEvaluar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(35)))));
            this.BtnEvaluar.FlatAppearance.BorderSize = 0;
            this.BtnEvaluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEvaluar.ForeColor = System.Drawing.Color.White;
            this.BtnEvaluar.Location = new System.Drawing.Point(39, 80);
            this.BtnEvaluar.Name = "BtnEvaluar";
            this.BtnEvaluar.Size = new System.Drawing.Size(101, 33);
            this.BtnEvaluar.TabIndex = 40;
            this.BtnEvaluar.Text = "Limpiar";
            this.BtnEvaluar.UseVisualStyleBackColor = false;
            this.BtnEvaluar.Click += new System.EventHandler(this.BtnEvaluar_Click);
            // 
            // cmbNro4
            // 
            this.cmbNro4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNro4.FormattingEnabled = true;
            this.cmbNro4.Items.AddRange(new object[] {
            "0",
            "25",
            "50",
            "Ninguna de las anteriores"});
            this.cmbNro4.Location = new System.Drawing.Point(15, 38);
            this.cmbNro4.Name = "cmbNro4";
            this.cmbNro4.Size = new System.Drawing.Size(151, 24);
            this.cmbNro4.TabIndex = 37;
            // 
            // cmbNro2
            // 
            this.cmbNro2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNro2.ForeColor = System.Drawing.Color.Blue;
            this.cmbNro2.FormattingEnabled = true;
            this.cmbNro2.Items.AddRange(new object[] {
            "Fin",
            "i",
            "Inicio",
            "Escriba"});
            this.cmbNro2.Location = new System.Drawing.Point(60, 202);
            this.cmbNro2.Name = "cmbNro2";
            this.cmbNro2.Size = new System.Drawing.Size(60, 21);
            this.cmbNro2.TabIndex = 44;
            // 
            // cmbNro3
            // 
            this.cmbNro3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNro3.ForeColor = System.Drawing.Color.Blue;
            this.cmbNro3.FormattingEnabled = true;
            this.cmbNro3.Items.AddRange(new object[] {
            "Fin",
            "i",
            "Inicio",
            "Escriba"});
            this.cmbNro3.Location = new System.Drawing.Point(60, 399);
            this.cmbNro3.Name = "cmbNro3";
            this.cmbNro3.Size = new System.Drawing.Size(60, 21);
            this.cmbNro3.TabIndex = 43;
            this.cmbNro3.SelectedIndexChanged += new System.EventHandler(this.cmbNro3_SelectedIndexChanged);
            // 
            // cmbNro1
            // 
            this.cmbNro1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNro1.FormattingEnabled = true;
            this.cmbNro1.Items.AddRange(new object[] {
            "Fin",
            "i",
            "Inicio",
            "Escriba"});
            this.cmbNro1.Location = new System.Drawing.Point(153, 146);
            this.cmbNro1.Name = "cmbNro1";
            this.cmbNro1.Size = new System.Drawing.Size(62, 21);
            this.cmbNro1.TabIndex = 42;
            this.cmbNro1.SelectedIndexChanged += new System.EventHandler(this.cmbNro1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 296);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Practica2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(692, 507);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbNro2);
            this.Controls.Add(this.cmbNro3);
            this.Controls.Add(this.cmbNro1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ptLogo);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNro1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Practica2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Practica2";
            this.Load += new System.EventHandler(this.Practica2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptLogo;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNro1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnEvaluar;
        private System.Windows.Forms.ComboBox cmbNro4;
        private System.Windows.Forms.ComboBox cmbNro2;
        private System.Windows.Forms.ComboBox cmbNro3;
        private System.Windows.Forms.ComboBox cmbNro1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}