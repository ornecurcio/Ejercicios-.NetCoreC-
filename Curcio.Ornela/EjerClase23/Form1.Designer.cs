
namespace EjerClase23
{
    partial class FrmMonedas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMonedas));
            this.btnLockCotizacion = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnConvertEuro = new System.Windows.Forms.Button();
            this.btnConvertDolar = new System.Windows.Forms.Button();
            this.btnConvertPeso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPesoA = new System.Windows.Forms.Label();
            this.lblDolarA = new System.Windows.Forms.Label();
            this.lblEuroA = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblDolar = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtCotizacionEuro = new System.Windows.Forms.TextBox();
            this.txtDolarAEuro = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.txtPesoAPeso = new System.Windows.Forms.TextBox();
            this.txtPesoADolar = new System.Windows.Forms.TextBox();
            this.txtPesoAEuro = new System.Windows.Forms.TextBox();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.txtDolarADolar = new System.Windows.Forms.TextBox();
            this.txtDolarAPeso = new System.Windows.Forms.TextBox();
            this.txtEuroAPeso = new System.Windows.Forms.TextBox();
            this.txtEuroADolar = new System.Windows.Forms.TextBox();
            this.txtEuroAEuro = new System.Windows.Forms.TextBox();
            this.txtCotizacionPeso = new System.Windows.Forms.TextBox();
            this.txtCotizacionDolar = new System.Windows.Forms.TextBox();
            this.lblPesos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLockCotizacion
            // 
            this.btnLockCotizacion.ImageIndex = 1;
            this.btnLockCotizacion.ImageList = this.imageList1;
            this.btnLockCotizacion.Location = new System.Drawing.Point(276, 12);
            this.btnLockCotizacion.Name = "btnLockCotizacion";
            this.btnLockCotizacion.Size = new System.Drawing.Size(124, 89);
            this.btnLockCotizacion.TabIndex = 0;
            this.btnLockCotizacion.UseVisualStyleBackColor = true;
            this.btnLockCotizacion.Click += new System.EventHandler(this.btnLockCotizacion_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "5633.jpg");
            this.imageList1.Images.SetKeyName(1, "5832.jpg");
            // 
            // btnConvertEuro
            // 
            this.btnConvertEuro.Location = new System.Drawing.Point(276, 157);
            this.btnConvertEuro.Name = "btnConvertEuro";
            this.btnConvertEuro.Size = new System.Drawing.Size(75, 23);
            this.btnConvertEuro.TabIndex = 1;
            this.btnConvertEuro.Text = "->";
            this.btnConvertEuro.UseVisualStyleBackColor = true;
            this.btnConvertEuro.Click += new System.EventHandler(this.btnConvertEuro_Click);
            // 
            // btnConvertDolar
            // 
            this.btnConvertDolar.Location = new System.Drawing.Point(276, 212);
            this.btnConvertDolar.Name = "btnConvertDolar";
            this.btnConvertDolar.Size = new System.Drawing.Size(75, 23);
            this.btnConvertDolar.TabIndex = 2;
            this.btnConvertDolar.Text = "->";
            this.btnConvertDolar.UseVisualStyleBackColor = true;
            this.btnConvertDolar.Click += new System.EventHandler(this.btnConvertDolar_Click);
            // 
            // btnConvertPeso
            // 
            this.btnConvertPeso.Location = new System.Drawing.Point(276, 278);
            this.btnConvertPeso.Name = "btnConvertPeso";
            this.btnConvertPeso.Size = new System.Drawing.Size(75, 23);
            this.btnConvertPeso.TabIndex = 3;
            this.btnConvertPeso.Text = "->";
            this.btnConvertPeso.UseVisualStyleBackColor = true;
            this.btnConvertPeso.Click += new System.EventHandler(this.btnConvertPeso_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cotización";
            // 
            // lblPesoA
            // 
            this.lblPesoA.AutoSize = true;
            this.lblPesoA.Location = new System.Drawing.Point(707, 115);
            this.lblPesoA.Name = "lblPesoA";
            this.lblPesoA.Size = new System.Drawing.Size(31, 13);
            this.lblPesoA.TabIndex = 4;
            this.lblPesoA.Text = "Peso";
            // 
            // lblDolarA
            // 
            this.lblDolarA.AutoSize = true;
            this.lblDolarA.Location = new System.Drawing.Point(601, 115);
            this.lblDolarA.Name = "lblDolarA";
            this.lblDolarA.Size = new System.Drawing.Size(32, 13);
            this.lblDolarA.TabIndex = 5;
            this.lblDolarA.Text = "Dolar";
            // 
            // lblEuroA
            // 
            this.lblEuroA.AutoSize = true;
            this.lblEuroA.Location = new System.Drawing.Point(442, 105);
            this.lblEuroA.Name = "lblEuroA";
            this.lblEuroA.Size = new System.Drawing.Size(29, 13);
            this.lblEuroA.TabIndex = 6;
            this.lblEuroA.Text = "Euro";
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Location = new System.Drawing.Point(83, 157);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(29, 13);
            this.lblEuro.TabIndex = 7;
            this.lblEuro.Text = "Euro";
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Location = new System.Drawing.Point(83, 212);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(32, 13);
            this.lblDolar.TabIndex = 8;
            this.lblDolar.Text = "Dolar";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(77, 348);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 9;
            this.lblPeso.Text = "Peso";
            // 
            // txtCotizacionEuro
            // 
            this.txtCotizacionEuro.Location = new System.Drawing.Point(406, 12);
            this.txtCotizacionEuro.Name = "txtCotizacionEuro";
            this.txtCotizacionEuro.Size = new System.Drawing.Size(100, 20);
            this.txtCotizacionEuro.TabIndex = 10;
            // 
            // txtDolarAEuro
            // 
            this.txtDolarAEuro.Enabled = false;
            this.txtDolarAEuro.Location = new System.Drawing.Point(414, 231);
            this.txtDolarAEuro.Name = "txtDolarAEuro";
            this.txtDolarAEuro.ReadOnly = true;
            this.txtDolarAEuro.Size = new System.Drawing.Size(100, 20);
            this.txtDolarAEuro.TabIndex = 12;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(148, 278);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 13;
            // 
            // txtDolar
            // 
            this.txtDolar.Location = new System.Drawing.Point(148, 212);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(100, 20);
            this.txtDolar.TabIndex = 14;
            // 
            // txtPesoAPeso
            // 
            this.txtPesoAPeso.Enabled = false;
            this.txtPesoAPeso.Location = new System.Drawing.Point(676, 299);
            this.txtPesoAPeso.Name = "txtPesoAPeso";
            this.txtPesoAPeso.ReadOnly = true;
            this.txtPesoAPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPesoAPeso.TabIndex = 15;
            // 
            // txtPesoADolar
            // 
            this.txtPesoADolar.Enabled = false;
            this.txtPesoADolar.Location = new System.Drawing.Point(557, 299);
            this.txtPesoADolar.Name = "txtPesoADolar";
            this.txtPesoADolar.ReadOnly = true;
            this.txtPesoADolar.Size = new System.Drawing.Size(100, 20);
            this.txtPesoADolar.TabIndex = 16;
            // 
            // txtPesoAEuro
            // 
            this.txtPesoAEuro.Enabled = false;
            this.txtPesoAEuro.Location = new System.Drawing.Point(414, 299);
            this.txtPesoAEuro.Name = "txtPesoAEuro";
            this.txtPesoAEuro.ReadOnly = true;
            this.txtPesoAEuro.Size = new System.Drawing.Size(100, 20);
            this.txtPesoAEuro.TabIndex = 17;
            // 
            // txtEuro
            // 
            this.txtEuro.Location = new System.Drawing.Point(148, 157);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(100, 20);
            this.txtEuro.TabIndex = 18;
            // 
            // txtDolarADolar
            // 
            this.txtDolarADolar.Enabled = false;
            this.txtDolarADolar.Location = new System.Drawing.Point(557, 231);
            this.txtDolarADolar.Name = "txtDolarADolar";
            this.txtDolarADolar.ReadOnly = true;
            this.txtDolarADolar.Size = new System.Drawing.Size(100, 20);
            this.txtDolarADolar.TabIndex = 19;
            // 
            // txtDolarAPeso
            // 
            this.txtDolarAPeso.Enabled = false;
            this.txtDolarAPeso.Location = new System.Drawing.Point(676, 231);
            this.txtDolarAPeso.Name = "txtDolarAPeso";
            this.txtDolarAPeso.ReadOnly = true;
            this.txtDolarAPeso.Size = new System.Drawing.Size(100, 20);
            this.txtDolarAPeso.TabIndex = 20;
            // 
            // txtEuroAPeso
            // 
            this.txtEuroAPeso.Enabled = false;
            this.txtEuroAPeso.Location = new System.Drawing.Point(676, 157);
            this.txtEuroAPeso.Name = "txtEuroAPeso";
            this.txtEuroAPeso.ReadOnly = true;
            this.txtEuroAPeso.Size = new System.Drawing.Size(100, 20);
            this.txtEuroAPeso.TabIndex = 21;
            // 
            // txtEuroADolar
            // 
            this.txtEuroADolar.Enabled = false;
            this.txtEuroADolar.Location = new System.Drawing.Point(557, 157);
            this.txtEuroADolar.Name = "txtEuroADolar";
            this.txtEuroADolar.ReadOnly = true;
            this.txtEuroADolar.Size = new System.Drawing.Size(100, 20);
            this.txtEuroADolar.TabIndex = 22;
            // 
            // txtEuroAEuro
            // 
            this.txtEuroAEuro.Enabled = false;
            this.txtEuroAEuro.Location = new System.Drawing.Point(414, 157);
            this.txtEuroAEuro.Name = "txtEuroAEuro";
            this.txtEuroAEuro.ReadOnly = true;
            this.txtEuroAEuro.Size = new System.Drawing.Size(100, 20);
            this.txtEuroAEuro.TabIndex = 23;
            // 
            // txtCotizacionPeso
            // 
            this.txtCotizacionPeso.BackColor = System.Drawing.Color.White;
            this.txtCotizacionPeso.Location = new System.Drawing.Point(662, 12);
            this.txtCotizacionPeso.Name = "txtCotizacionPeso";
            this.txtCotizacionPeso.Size = new System.Drawing.Size(100, 20);
            this.txtCotizacionPeso.TabIndex = 24;
            // 
            // txtCotizacionDolar
            // 
            this.txtCotizacionDolar.Enabled = false;
            this.txtCotizacionDolar.Location = new System.Drawing.Point(536, 12);
            this.txtCotizacionDolar.Name = "txtCotizacionDolar";
            this.txtCotizacionDolar.Size = new System.Drawing.Size(100, 20);
            this.txtCotizacionDolar.TabIndex = 25;
            this.txtCotizacionDolar.Text = "1";
            this.txtCotizacionDolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPesos
            // 
            this.lblPesos.AutoSize = true;
            this.lblPesos.Location = new System.Drawing.Point(83, 281);
            this.lblPesos.Name = "lblPesos";
            this.lblPesos.Size = new System.Drawing.Size(36, 13);
            this.lblPesos.TabIndex = 26;
            this.lblPesos.Text = "Pesos";
            // 
            // FrmMonedas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPesos);
            this.Controls.Add(this.txtCotizacionDolar);
            this.Controls.Add(this.txtCotizacionPeso);
            this.Controls.Add(this.txtEuroAEuro);
            this.Controls.Add(this.txtEuroADolar);
            this.Controls.Add(this.txtEuroAPeso);
            this.Controls.Add(this.txtDolarAPeso);
            this.Controls.Add(this.txtDolarADolar);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.txtPesoAEuro);
            this.Controls.Add(this.txtPesoADolar);
            this.Controls.Add(this.txtPesoAPeso);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtDolarAEuro);
            this.Controls.Add(this.txtCotizacionEuro);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.lblEuroA);
            this.Controls.Add(this.lblDolarA);
            this.Controls.Add(this.lblPesoA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConvertPeso);
            this.Controls.Add(this.btnConvertDolar);
            this.Controls.Add(this.btnConvertEuro);
            this.Controls.Add(this.btnLockCotizacion);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMonedas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMonedas_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLockCotizacion;
        private System.Windows.Forms.Button btnConvertEuro;
        private System.Windows.Forms.Button btnConvertDolar;
        private System.Windows.Forms.Button btnConvertPeso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPesoA;
        private System.Windows.Forms.Label lblDolarA;
        private System.Windows.Forms.Label lblEuroA;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtCotizacionEuro;
        private System.Windows.Forms.TextBox txtDolarAEuro;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.TextBox txtPesoAPeso;
        private System.Windows.Forms.TextBox txtPesoADolar;
        private System.Windows.Forms.TextBox txtPesoAEuro;
        private System.Windows.Forms.TextBox txtEuro;
        private System.Windows.Forms.TextBox txtDolarADolar;
        private System.Windows.Forms.TextBox txtDolarAPeso;
        private System.Windows.Forms.TextBox txtEuroAPeso;
        private System.Windows.Forms.TextBox txtEuroADolar;
        private System.Windows.Forms.TextBox txtEuroAEuro;
        private System.Windows.Forms.TextBox txtCotizacionPeso;
        private System.Windows.Forms.TextBox txtCotizacionDolar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblPesos;
    }
}

