namespace FrmNivelTres
{
    partial class JuegoCicloRepita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JuegoCicloRepita));
            this.lblNro1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNro2 = new System.Windows.Forms.Label();
            this.btnRespuestas = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEvaluacion = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.cmbNro1 = new System.Windows.Forms.ComboBox();
            this.cmbNro3 = new System.Windows.Forms.ComboBox();
            this.cmbNro2 = new System.Windows.Forms.ComboBox();
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
            this.lblNro1.Location = new System.Drawing.Point(197, 53);
            this.lblNro1.Name = "lblNro1";
            this.lblNro1.Size = new System.Drawing.Size(500, 32);
            this.lblNro1.TabIndex = 0;
            this.lblNro1.Text = "Práctica didáctica (Ciclo Repita)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(203, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(457, 319);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblNro2
            // 
            this.lblNro2.AutoSize = true;
            this.lblNro2.BackColor = System.Drawing.Color.Transparent;
            this.lblNro2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNro2.Location = new System.Drawing.Point(200, 98);
            this.lblNro2.Name = "lblNro2";
            this.lblNro2.Size = new System.Drawing.Size(314, 36);
            this.lblNro2.TabIndex = 2;
            this.lblNro2.Text = "Complete el siguiente pseudocódigo:\r\n\r\n";
            this.lblNro2.Click += new System.EventHandler(this.lblNro2_Click);
            // 
            // btnRespuestas
            // 
            this.btnRespuestas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRespuestas.FlatAppearance.BorderSize = 2;
            this.btnRespuestas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRespuestas.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRespuestas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRespuestas.Location = new System.Drawing.Point(725, 258);
            this.btnRespuestas.Name = "btnRespuestas";
            this.btnRespuestas.Size = new System.Drawing.Size(87, 33);
            this.btnRespuestas.TabIndex = 6;
            this.btnRespuestas.Text = "Evaluar ";
            this.btnRespuestas.UseVisualStyleBackColor = true;
            this.btnRespuestas.Click += new System.EventHandler(this.btnRespuestas_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(35)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 2;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(35)))));
            this.btnLimpiar.Location = new System.Drawing.Point(725, 311);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(87, 33);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEvaluacion
            // 
            this.btnEvaluacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(35)))));
            this.btnEvaluacion.FlatAppearance.BorderSize = 0;
            this.btnEvaluacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvaluacion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvaluacion.ForeColor = System.Drawing.Color.White;
            this.btnEvaluacion.Location = new System.Drawing.Point(825, 473);
            this.btnEvaluacion.Name = "btnEvaluacion";
            this.btnEvaluacion.Size = new System.Drawing.Size(87, 33);
            this.btnEvaluacion.TabIndex = 12;
            this.btnEvaluacion.Text = "Siguiente";
            this.btnEvaluacion.UseVisualStyleBackColor = false;
            this.btnEvaluacion.Click += new System.EventHandler(this.btnEvaluacion_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(130)))), ((int)(((byte)(118)))));
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(12, 473);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(87, 33);
            this.btnRegresar.TabIndex = 11;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // cmbNro1
            // 
            this.cmbNro1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNro1.Font = new System.Drawing.Font("Garamond", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNro1.ForeColor = System.Drawing.Color.Black;
            this.cmbNro1.FormattingEnabled = true;
            this.cmbNro1.Items.AddRange(new object[] {
            "contador",
            "Escriba",
            "acumulador",
            "Ninguna de las anteriores"});
            this.cmbNro1.Location = new System.Drawing.Point(315, 137);
            this.cmbNro1.Name = "cmbNro1";
            this.cmbNro1.Size = new System.Drawing.Size(111, 27);
            this.cmbNro1.TabIndex = 13;
            // 
            // cmbNro3
            // 
            this.cmbNro3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNro3.Font = new System.Drawing.Font("Garamond", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNro3.ForeColor = System.Drawing.Color.Blue;
            this.cmbNro3.FormattingEnabled = true;
            this.cmbNro3.Items.AddRange(new object[] {
            "o",
            "10",
            "y",
            "1",
            ""});
            this.cmbNro3.Location = new System.Drawing.Point(467, 380);
            this.cmbNro3.Name = "cmbNro3";
            this.cmbNro3.Size = new System.Drawing.Size(37, 27);
            this.cmbNro3.TabIndex = 14;
            this.cmbNro3.SelectedIndexChanged += new System.EventHandler(this.cmbNro3_SelectedIndexChanged);
            // 
            // cmbNro2
            // 
            this.cmbNro2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNro2.Font = new System.Drawing.Font("Garamond", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNro2.ForeColor = System.Drawing.Color.Blue;
            this.cmbNro2.FormattingEnabled = true;
            this.cmbNro2.Items.AddRange(new object[] {
            "Para",
            "Mientras",
            "Repita",
            "Ninguna de las anteriores"});
            this.cmbNro2.Location = new System.Drawing.Point(246, 234);
            this.cmbNro2.Name = "cmbNro2";
            this.cmbNro2.Size = new System.Drawing.Size(100, 27);
            this.cmbNro2.TabIndex = 15;
            this.cmbNro2.SelectedIndexChanged += new System.EventHandler(this.cmbNro2_SelectedIndexChanged);
            // 
            // ptLogo
            // 
            this.ptLogo.BackColor = System.Drawing.Color.Transparent;
            this.ptLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptLogo.Image")));
            this.ptLogo.Location = new System.Drawing.Point(807, 40);
            this.ptLogo.Name = "ptLogo";
            this.ptLogo.Size = new System.Drawing.Size(105, 90);
            this.ptLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptLogo.TabIndex = 76;
            this.ptLogo.TabStop = false;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(924, 34);
            this.panelTitulo.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(578, 493);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 13);
            this.label2.TabIndex = 77;
            this.label2.Text = "Debe evaluar la prueba  para ir al siguiente nivel";
            // 
            // JuegoCicloRepita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 518);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRespuestas);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.ptLogo);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.cmbNro2);
            this.Controls.Add(this.cmbNro3);
            this.Controls.Add(this.cmbNro1);
            this.Controls.Add(this.btnEvaluacion);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lblNro2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNro1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JuegoCicloRepita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JuegoCicloRepita";
            this.Load += new System.EventHandler(this.JuegoCicloRepita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNro1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNro2;
        private System.Windows.Forms.Button btnRespuestas;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEvaluacion;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.ComboBox cmbNro1;
        private System.Windows.Forms.ComboBox cmbNro3;
        private System.Windows.Forms.ComboBox cmbNro2;
        private System.Windows.Forms.PictureBox ptLogo;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label label2;
    }
}