namespace Proyecto
{
    partial class FrmVariables
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVariables));
            this.lblVariable = new System.Windows.Forms.Label();
            this.gbConcepto = new System.Windows.Forms.GroupBox();
            this.lblConcepto = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.gbVariables = new System.Windows.Forms.GroupBox();
            this.lblBooleano = new System.Windows.Forms.Label();
            this.lblCaracter = new System.Windows.Forms.Label();
            this.lblCadena = new System.Windows.Forms.Label();
            this.lblReal = new System.Windows.Forms.Label();
            this.lblEntero = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.gbOperadores = new System.Windows.Forms.GroupBox();
            this.lblOperadores = new System.Windows.Forms.Label();
            this.ptLogo = new System.Windows.Forms.PictureBox();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.gbConcepto.SuspendLayout();
            this.gbVariables.SuspendLayout();
            this.gbOperadores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVariable
            // 
            this.lblVariable.AutoSize = true;
            this.lblVariable.BackColor = System.Drawing.Color.Transparent;
            this.lblVariable.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariable.Location = new System.Drawing.Point(403, 36);
            this.lblVariable.Name = "lblVariable";
            this.lblVariable.Size = new System.Drawing.Size(156, 32);
            this.lblVariable.TabIndex = 1;
            this.lblVariable.Text = "Variables";
            // 
            // gbConcepto
            // 
            this.gbConcepto.BackColor = System.Drawing.Color.Transparent;
            this.gbConcepto.Controls.Add(this.lblConcepto);
            this.gbConcepto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConcepto.Location = new System.Drawing.Point(48, 71);
            this.gbConcepto.Name = "gbConcepto";
            this.gbConcepto.Size = new System.Drawing.Size(619, 124);
            this.gbConcepto.TabIndex = 10;
            this.gbConcepto.TabStop = false;
            this.gbConcepto.Text = "Concepto";
            // 
            // lblConcepto
            // 
            this.lblConcepto.AutoSize = true;
            this.lblConcepto.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConcepto.Location = new System.Drawing.Point(20, 27);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(502, 80);
            this.lblConcepto.TabIndex = 11;
            this.lblConcepto.Text = resources.GetString("lblConcepto.Text");
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.Transparent;
            this.lblTipo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(694, 160);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(166, 18);
            this.lblTipo.TabIndex = 14;
            this.lblTipo.Text = "Tipos de variables";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(35)))));
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.Location = new System.Drawing.Point(841, 478);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(101, 33);
            this.btnSiguiente.TabIndex = 17;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // gbVariables
            // 
            this.gbVariables.BackColor = System.Drawing.Color.Transparent;
            this.gbVariables.Controls.Add(this.lblBooleano);
            this.gbVariables.Controls.Add(this.lblCaracter);
            this.gbVariables.Controls.Add(this.lblCadena);
            this.gbVariables.Controls.Add(this.lblReal);
            this.gbVariables.Controls.Add(this.lblEntero);
            this.gbVariables.Location = new System.Drawing.Point(694, 196);
            this.gbVariables.Name = "gbVariables";
            this.gbVariables.Size = new System.Drawing.Size(184, 148);
            this.gbVariables.TabIndex = 18;
            this.gbVariables.TabStop = false;
            // 
            // lblBooleano
            // 
            this.lblBooleano.AutoSize = true;
            this.lblBooleano.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooleano.Location = new System.Drawing.Point(23, 116);
            this.lblBooleano.Name = "lblBooleano";
            this.lblBooleano.Size = new System.Drawing.Size(67, 16);
            this.lblBooleano.TabIndex = 4;
            this.lblBooleano.Text = "Booleano";
            // 
            // lblCaracter
            // 
            this.lblCaracter.AutoSize = true;
            this.lblCaracter.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaracter.Location = new System.Drawing.Point(23, 90);
            this.lblCaracter.Name = "lblCaracter";
            this.lblCaracter.Size = new System.Drawing.Size(67, 16);
            this.lblCaracter.TabIndex = 3;
            this.lblCaracter.Text = "Caracter";
            // 
            // lblCadena
            // 
            this.lblCadena.AutoSize = true;
            this.lblCadena.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadena.Location = new System.Drawing.Point(23, 64);
            this.lblCadena.Name = "lblCadena";
            this.lblCadena.Size = new System.Drawing.Size(57, 16);
            this.lblCadena.TabIndex = 2;
            this.lblCadena.Text = "Cadena";
            // 
            // lblReal
            // 
            this.lblReal.AutoSize = true;
            this.lblReal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReal.Location = new System.Drawing.Point(23, 39);
            this.lblReal.Name = "lblReal";
            this.lblReal.Size = new System.Drawing.Size(35, 16);
            this.lblReal.TabIndex = 1;
            this.lblReal.Text = "Real";
            // 
            // lblEntero
            // 
            this.lblEntero.AutoSize = true;
            this.lblEntero.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntero.Location = new System.Drawing.Point(23, 16);
            this.lblEntero.Name = "lblEntero";
            this.lblEntero.Size = new System.Drawing.Size(52, 16);
            this.lblEntero.TabIndex = 0;
            this.lblEntero.Text = "Entero";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(130)))), ((int)(((byte)(118)))));
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(12, 478);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(101, 33);
            this.btnRegresar.TabIndex = 21;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // gbOperadores
            // 
            this.gbOperadores.BackColor = System.Drawing.Color.Transparent;
            this.gbOperadores.Controls.Add(this.lblOperadores);
            this.gbOperadores.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOperadores.Location = new System.Drawing.Point(48, 206);
            this.gbOperadores.Name = "gbOperadores";
            this.gbOperadores.Size = new System.Drawing.Size(619, 244);
            this.gbOperadores.TabIndex = 22;
            this.gbOperadores.TabStop = false;
            this.gbOperadores.Text = "Operadores";
            // 
            // lblOperadores
            // 
            this.lblOperadores.AutoSize = true;
            this.lblOperadores.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperadores.Location = new System.Drawing.Point(20, 29);
            this.lblOperadores.Name = "lblOperadores";
            this.lblOperadores.Size = new System.Drawing.Size(334, 200);
            this.lblOperadores.TabIndex = 11;
            this.lblOperadores.Text = resources.GetString("lblOperadores.Text");
            // 
            // ptLogo
            // 
            this.ptLogo.BackColor = System.Drawing.Color.Transparent;
            this.ptLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptLogo.Image")));
            this.ptLogo.Location = new System.Drawing.Point(861, 36);
            this.ptLogo.Name = "ptLogo";
            this.ptLogo.Size = new System.Drawing.Size(90, 90);
            this.ptLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptLogo.TabIndex = 30;
            this.ptLogo.TabStop = false;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(954, 34);
            this.panelTitulo.TabIndex = 29;
            // 
            // FrmVariables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(954, 523);
            this.Controls.Add(this.ptLogo);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.gbOperadores);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.gbVariables);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.gbConcepto);
            this.Controls.Add(this.lblVariable);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVariables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Variables";
            this.Load += new System.EventHandler(this.FrmVariables_Load);
            this.gbConcepto.ResumeLayout(false);
            this.gbConcepto.PerformLayout();
            this.gbVariables.ResumeLayout(false);
            this.gbVariables.PerformLayout();
            this.gbOperadores.ResumeLayout(false);
            this.gbOperadores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVariable;
        private System.Windows.Forms.GroupBox gbConcepto;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.GroupBox gbVariables;
        private System.Windows.Forms.Label lblBooleano;
        private System.Windows.Forms.Label lblCaracter;
        private System.Windows.Forms.Label lblCadena;
        private System.Windows.Forms.Label lblReal;
        private System.Windows.Forms.Label lblEntero;
        private System.Windows.Forms.Label lblConcepto;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.GroupBox gbOperadores;
        private System.Windows.Forms.Label lblOperadores;
        private System.Windows.Forms.PictureBox ptLogo;
        private System.Windows.Forms.Panel panelTitulo;
    }
}

