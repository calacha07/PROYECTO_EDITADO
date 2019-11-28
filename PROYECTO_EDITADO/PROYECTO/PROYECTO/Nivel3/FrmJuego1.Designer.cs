namespace FrmNivelTres
{
    partial class JuegoCiclosPara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JuegoCiclosPara));
            this.lblNro1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbNro2 = new System.Windows.Forms.ComboBox();
            this.cmbNro1 = new System.Windows.Forms.ComboBox();
            this.cmbNro3 = new System.Windows.Forms.ComboBox();
            this.btnRespuestas = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.ptLogo = new System.Windows.Forms.PictureBox();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNro1
            // 
            this.lblNro1.AutoSize = true;
            this.lblNro1.BackColor = System.Drawing.Color.Transparent;
            this.lblNro1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNro1.Location = new System.Drawing.Point(200, 56);
            this.lblNro1.Name = "lblNro1";
            this.lblNro1.Size = new System.Drawing.Size(472, 32);
            this.lblNro1.TabIndex = 0;
            this.lblNro1.Text = "Práctica didáctica (Ciclo Para)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Complete el siguiente pseudocódigo:\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(206, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(482, 334);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // cmbNro2
            // 
            this.cmbNro2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNro2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNro2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbNro2.FormattingEnabled = true;
            this.cmbNro2.Items.AddRange(new object[] {
            "Lea",
            "Para",
            "n3",
            "Hasta"});
            this.cmbNro2.Location = new System.Drawing.Point(261, 354);
            this.cmbNro2.Name = "cmbNro2";
            this.cmbNro2.Size = new System.Drawing.Size(90, 26);
            this.cmbNro2.TabIndex = 3;
            this.cmbNro2.SelectedIndexChanged += new System.EventHandler(this.cmbNro2_SelectedIndexChanged);
            // 
            // cmbNro1
            // 
            this.cmbNro1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNro1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNro1.ForeColor = System.Drawing.Color.Black;
            this.cmbNro1.FormattingEnabled = true;
            this.cmbNro1.Items.AddRange(new object[] {
            "Lea",
            "Para",
            "Escriba",
            "Hasta"});
            this.cmbNro1.Location = new System.Drawing.Point(252, 217);
            this.cmbNro1.Name = "cmbNro1";
            this.cmbNro1.Size = new System.Drawing.Size(116, 26);
            this.cmbNro1.TabIndex = 4;
            this.cmbNro1.SelectedIndexChanged += new System.EventHandler(this.cmbNro1_SelectedIndexChanged);
            // 
            // cmbNro3
            // 
            this.cmbNro3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNro3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNro3.ForeColor = System.Drawing.Color.Blue;
            this.cmbNro3.FormattingEnabled = true;
            this.cmbNro3.Items.AddRange(new object[] {
            "Lea",
            "Para",
            "Escriba",
            "Hasta"});
            this.cmbNro3.Location = new System.Drawing.Point(311, 386);
            this.cmbNro3.Name = "cmbNro3";
            this.cmbNro3.Size = new System.Drawing.Size(102, 26);
            this.cmbNro3.TabIndex = 5;
            this.cmbNro3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // btnRespuestas
            // 
            this.btnRespuestas.BackColor = System.Drawing.Color.White;
            this.btnRespuestas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRespuestas.FlatAppearance.BorderSize = 2;
            this.btnRespuestas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRespuestas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRespuestas.Location = new System.Drawing.Point(755, 226);
            this.btnRespuestas.Name = "btnRespuestas";
            this.btnRespuestas.Size = new System.Drawing.Size(101, 33);
            this.btnRespuestas.TabIndex = 6;
            this.btnRespuestas.Text = "Evaluar ";
            this.btnRespuestas.UseVisualStyleBackColor = false;
            this.btnRespuestas.Click += new System.EventHandler(this.btnRespuestas_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(35)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 2;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(35)))));
            this.btnLimpiar.Location = new System.Drawing.Point(755, 280);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(101, 33);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
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
            this.btnRegresar.TabIndex = 8;
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
            this.btnSiguiente.Location = new System.Drawing.Point(811, 473);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(101, 33);
            this.btnSiguiente.TabIndex = 10;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // ptLogo
            // 
            this.ptLogo.BackColor = System.Drawing.Color.Transparent;
            this.ptLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptLogo.Image")));
            this.ptLogo.Location = new System.Drawing.Point(811, 40);
            this.ptLogo.Name = "ptLogo";
            this.ptLogo.Size = new System.Drawing.Size(105, 90);
            this.ptLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptLogo.TabIndex = 72;
            this.ptLogo.TabStop = false;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(924, 34);
            this.panelTitulo.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(517, 483);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Debe evaluar la prueba  para ir al siguiente nivel";
            // 
            // JuegoCiclosPara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 518);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRespuestas);
            this.Controls.Add(this.ptLogo);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.cmbNro3);
            this.Controls.Add(this.cmbNro1);
            this.Controls.Add(this.cmbNro2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNro1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JuegoCiclosPara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego 1";
            this.Load += new System.EventHandler(this.Juegos_Ciclos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNro1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbNro2;
        private System.Windows.Forms.ComboBox cmbNro1;
        private System.Windows.Forms.ComboBox cmbNro3;
        private System.Windows.Forms.Button btnRespuestas;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.PictureBox ptLogo;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label label2;
    }
}