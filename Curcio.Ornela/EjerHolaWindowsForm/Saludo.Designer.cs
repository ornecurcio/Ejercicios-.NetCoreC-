
namespace EjerHolaWindowsForm
{
    partial class Saludo
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
            this.lblTituloMensaje = new System.Windows.Forms.Label();
            this.lblDatos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTituloMensaje
            // 
            this.lblTituloMensaje.AutoSize = true;
            this.lblTituloMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMensaje.Location = new System.Drawing.Point(12, 18);
            this.lblTituloMensaje.Name = "lblTituloMensaje";
            this.lblTituloMensaje.Size = new System.Drawing.Size(63, 25);
            this.lblTituloMensaje.TabIndex = 0;
            this.lblTituloMensaje.Text = "label";
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Location = new System.Drawing.Point(24, 98);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(35, 13);
            this.lblDatos.TabIndex = 1;
            this.lblDatos.Text = "label2";
            // 
            // Saludo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 174);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.lblTituloMensaje);
            this.Name = "Saludo";
            this.Text = "Saludo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloMensaje;
        private System.Windows.Forms.Label lblDatos;
    }
}