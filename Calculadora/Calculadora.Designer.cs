namespace EjerciciosITLA
{
    partial class frmCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadora));
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.btnPotencia = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lblCalculadora = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSuma
            // 
            this.btnSuma.AutoSize = true;
            this.btnSuma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuma.Location = new System.Drawing.Point(12, 193);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(117, 26);
            this.btnSuma.TabIndex = 4;
            this.btnSuma.Text = "S&uma";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Location = new System.Drawing.Point(137, 257);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(117, 26);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.AutoSize = true;
            this.btnDivision.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDivision.Location = new System.Drawing.Point(135, 225);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(117, 26);
            this.btnDivision.TabIndex = 7;
            this.btnDivision.Text = "&División";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.AutoSize = true;
            this.btnMultiplicacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMultiplicacion.Location = new System.Drawing.Point(12, 225);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(117, 26);
            this.btnMultiplicacion.TabIndex = 6;
            this.btnMultiplicacion.Text = "&Multiplicación";
            this.btnMultiplicacion.UseVisualStyleBackColor = true;
            this.btnMultiplicacion.Click += new System.EventHandler(this.btnMultiplicacion_Click);
            // 
            // btnPotencia
            // 
            this.btnPotencia.AutoSize = true;
            this.btnPotencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPotencia.Location = new System.Drawing.Point(12, 257);
            this.btnPotencia.Name = "btnPotencia";
            this.btnPotencia.Size = new System.Drawing.Size(117, 26);
            this.btnPotencia.TabIndex = 8;
            this.btnPotencia.Text = "&Potencia";
            this.btnPotencia.UseVisualStyleBackColor = true;
            this.btnPotencia.Click += new System.EventHandler(this.btnPotencia_Click);
            // 
            // btnResta
            // 
            this.btnResta.AutoSize = true;
            this.btnResta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResta.Location = new System.Drawing.Point(137, 193);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(117, 26);
            this.btnResta.TabIndex = 5;
            this.btnResta.Text = "&Resta";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(83, 94);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(169, 22);
            this.txtNum1.TabIndex = 0;
            this.txtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(83, 122);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(171, 22);
            this.txtNum2.TabIndex = 1;
            this.txtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCalculadora
            // 
            this.lblCalculadora.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCalculadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculadora.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblCalculadora.Location = new System.Drawing.Point(0, 0);
            this.lblCalculadora.Name = "lblCalculadora";
            this.lblCalculadora.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCalculadora.Size = new System.Drawing.Size(272, 36);
            this.lblCalculadora.TabIndex = 8;
            this.lblCalculadora.Text = "CALCULADORA";
            this.lblCalculadora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(83, 150);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(171, 22);
            this.txtResultado.TabIndex = 3;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(12, 94);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(68, 16);
            this.lblNum1.TabIndex = 10;
            this.lblNum1.Text = "Número &1:";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(12, 128);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(68, 16);
            this.lblNum2.TabIndex = 11;
            this.lblNum2.Text = "Número &2:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(12, 156);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(72, 16);
            this.lblResultado.TabIndex = 12;
            this.lblResultado.Text = "Resultado:";
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(0, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Leonardi Alonzo Chireno";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 302);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblCalculadora);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnPotencia);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnSuma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalculadora";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button btnPotencia;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lblCalculadora;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label4;
    }
}

