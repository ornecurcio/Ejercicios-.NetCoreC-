
namespace CentralitaForm
{
    partial class FrmMostrar
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.rtxFacturacion = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(223, 255);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(171, 44);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // rtxFacturacion
            // 
            this.rtxFacturacion.Location = new System.Drawing.Point(12, 12);
            this.rtxFacturacion.Name = "rtxFacturacion";
            this.rtxFacturacion.Size = new System.Drawing.Size(382, 237);
            this.rtxFacturacion.TabIndex = 2;
            this.rtxFacturacion.Text = "";
            // 
            // FrmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 311);
            this.Controls.Add(this.rtxFacturacion);
            this.Controls.Add(this.btnAceptar);
            this.Name = "FrmMostrar";
            this.Text = "FrmMostrar";
            this.Load += new System.EventHandler(this.FrmMostrar_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.RichTextBox rtxFacturacion;
    }
}