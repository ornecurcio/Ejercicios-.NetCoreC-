
namespace EjerClase28
{
    partial class FormContadorPalabras
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.rtxtContadorPalabras = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalcular.Location = new System.Drawing.Point(374, 248);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // rtxtContadorPalabras
            // 
            this.rtxtContadorPalabras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtContadorPalabras.Location = new System.Drawing.Point(1, 0);
            this.rtxtContadorPalabras.Name = "rtxtContadorPalabras";
            this.rtxtContadorPalabras.Size = new System.Drawing.Size(460, 242);
            this.rtxtContadorPalabras.TabIndex = 1;
            this.rtxtContadorPalabras.Text = "";
            // 
            // FormContadorPalabras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 283);
            this.Controls.Add(this.rtxtContadorPalabras);
            this.Controls.Add(this.btnCalcular);
            this.Name = "FormContadorPalabras";
            this.Text = "Contador de Palabras";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.RichTextBox rtxtContadorPalabras;
    }
}

