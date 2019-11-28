namespace Proyecto
{
    partial class FrmNivel4Principio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNivel4Principio));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblConcepto = new System.Windows.Forms.Label();
            this.cboConcepto = new System.Windows.Forms.ComboBox();
            this.txtConceptos = new System.Windows.Forms.TextBox();
            this.lblEjemplo = new System.Windows.Forms.Label();
            this.lnlFuncion = new System.Windows.Forms.Label();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ptLogo = new System.Windows.Forms.PictureBox();
            this.ptb2 = new System.Windows.Forms.PictureBox();
            this.ptb1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            resources.ApplyResources(this.lblTitulo, "lblTitulo");
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Name = "lblTitulo";
            // 
            // lblConcepto
            // 
            resources.ApplyResources(this.lblConcepto, "lblConcepto");
            this.lblConcepto.BackColor = System.Drawing.Color.Transparent;
            this.lblConcepto.Name = "lblConcepto";
            // 
            // cboConcepto
            // 
            resources.ApplyResources(this.cboConcepto, "cboConcepto");
            this.cboConcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConcepto.FormattingEnabled = true;
            this.cboConcepto.Items.AddRange(new object[] {
            resources.GetString("cboConcepto.Items"),
            resources.GetString("cboConcepto.Items1")});
            this.cboConcepto.Name = "cboConcepto";
            this.cboConcepto.SelectedIndexChanged += new System.EventHandler(this.cboConcepto_SelectedIndexChanged);
            // 
            // txtConceptos
            // 
            resources.ApplyResources(this.txtConceptos, "txtConceptos");
            this.txtConceptos.Name = "txtConceptos";
            this.txtConceptos.ReadOnly = true;
            this.txtConceptos.TextChanged += new System.EventHandler(this.txtConceptos_TextChanged);
            // 
            // lblEjemplo
            // 
            resources.ApplyResources(this.lblEjemplo, "lblEjemplo");
            this.lblEjemplo.BackColor = System.Drawing.Color.Transparent;
            this.lblEjemplo.Name = "lblEjemplo";
            // 
            // lnlFuncion
            // 
            resources.ApplyResources(this.lnlFuncion, "lnlFuncion");
            this.lnlFuncion.BackColor = System.Drawing.Color.Transparent;
            this.lnlFuncion.Name = "lnlFuncion";
            // 
            // panelTitulo
            // 
            resources.ApplyResources(this.panelTitulo, "panelTitulo");
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelTitulo.Name = "panelTitulo";
            // 
            // btnSiguiente
            // 
            resources.ApplyResources(this.btnSiguiente, "btnSiguiente");
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(35)))));
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(130)))), ((int)(((byte)(118)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ptLogo
            // 
            resources.ApplyResources(this.ptLogo, "ptLogo");
            this.ptLogo.BackColor = System.Drawing.Color.Transparent;
            this.ptLogo.Name = "ptLogo";
            this.ptLogo.TabStop = false;
            // 
            // ptb2
            // 
            resources.ApplyResources(this.ptb2, "ptb2");
            this.ptb2.Name = "ptb2";
            this.ptb2.TabStop = false;
            // 
            // ptb1
            // 
            resources.ApplyResources(this.ptb1, "ptb1");
            this.ptb1.Name = "ptb1";
            this.ptb1.TabStop = false;
            // 
            // FrmNivel4Principio
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ControlBox = false;
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ptLogo);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.ptb2);
            this.Controls.Add(this.ptb1);
            this.Controls.Add(this.lnlFuncion);
            this.Controls.Add(this.lblEjemplo);
            this.Controls.Add(this.txtConceptos);
            this.Controls.Add(this.cboConcepto);
            this.Controls.Add(this.lblConcepto);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNivel4Principio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblConcepto;
        private System.Windows.Forms.ComboBox cboConcepto;
        private System.Windows.Forms.TextBox txtConceptos;
        private System.Windows.Forms.Label lblEjemplo;
        private System.Windows.Forms.Label lnlFuncion;
        private System.Windows.Forms.PictureBox ptb1;
        private System.Windows.Forms.PictureBox ptb2;
        private System.Windows.Forms.PictureBox ptLogo;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button button1;
	}
}