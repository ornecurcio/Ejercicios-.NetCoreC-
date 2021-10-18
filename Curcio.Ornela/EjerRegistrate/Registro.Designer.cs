
namespace EjerRegistrate
{
    partial class Registro
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
            this.grbUsuario = new System.Windows.Forms.GroupBox();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.updbEdad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gpbGenero = new System.Windows.Forms.GroupBox();
            this.rdbNoBinario = new System.Windows.Forms.RadioButton();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.gpbCursos = new System.Windows.Forms.GroupBox();
            this.ckbJavaScrip = new System.Windows.Forms.CheckBox();
            this.ckbCmasMas = new System.Windows.Forms.CheckBox();
            this.ckbCSharp = new System.Windows.Forms.CheckBox();
            this.ltbPais = new System.Windows.Forms.ListBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.grbUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.gpbGenero.SuspendLayout();
            this.gpbCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbUsuario
            // 
            this.grbUsuario.Controls.Add(this.nudEdad);
            this.grbUsuario.Controls.Add(this.txtDireccion);
            this.grbUsuario.Controls.Add(this.txtNombre);
            this.grbUsuario.Controls.Add(this.updbEdad);
            this.grbUsuario.Controls.Add(this.lblDireccion);
            this.grbUsuario.Controls.Add(this.lblNombre);
            this.grbUsuario.Location = new System.Drawing.Point(24, 12);
            this.grbUsuario.Name = "grbUsuario";
            this.grbUsuario.Size = new System.Drawing.Size(268, 250);
            this.grbUsuario.TabIndex = 0;
            this.grbUsuario.TabStop = false;
            this.grbUsuario.Text = "Detalles del Usuario";
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(96, 193);
            this.nudEdad.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(120, 20);
            this.nudEdad.TabIndex = 7;
            this.nudEdad.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(116, 120);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(116, 48);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // updbEdad
            // 
            this.updbEdad.AutoSize = true;
            this.updbEdad.Location = new System.Drawing.Point(37, 195);
            this.updbEdad.Name = "updbEdad";
            this.updbEdad.Size = new System.Drawing.Size(32, 13);
            this.updbEdad.TabIndex = 6;
            this.updbEdad.Text = "Edad";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(37, 123);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(37, 48);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // gpbGenero
            // 
            this.gpbGenero.Controls.Add(this.rdbNoBinario);
            this.gpbGenero.Controls.Add(this.rdbFemenino);
            this.gpbGenero.Controls.Add(this.rdbMasculino);
            this.gpbGenero.Location = new System.Drawing.Point(328, 21);
            this.gpbGenero.Name = "gpbGenero";
            this.gpbGenero.Size = new System.Drawing.Size(200, 100);
            this.gpbGenero.TabIndex = 1;
            this.gpbGenero.TabStop = false;
            this.gpbGenero.Text = "Genero";
            // 
            // rdbNoBinario
            // 
            this.rdbNoBinario.AutoSize = true;
            this.rdbNoBinario.Location = new System.Drawing.Point(18, 65);
            this.rdbNoBinario.Name = "rdbNoBinario";
            this.rdbNoBinario.Size = new System.Drawing.Size(74, 17);
            this.rdbNoBinario.TabIndex = 2;
            this.rdbNoBinario.TabStop = true;
            this.rdbNoBinario.Text = "No Binario";
            this.rdbNoBinario.UseVisualStyleBackColor = true;
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Location = new System.Drawing.Point(18, 42);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(71, 17);
            this.rdbFemenino.TabIndex = 1;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(18, 19);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdbMasculino.TabIndex = 0;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // gpbCursos
            // 
            this.gpbCursos.Controls.Add(this.ckbJavaScrip);
            this.gpbCursos.Controls.Add(this.ckbCmasMas);
            this.gpbCursos.Controls.Add(this.ckbCSharp);
            this.gpbCursos.Location = new System.Drawing.Point(328, 162);
            this.gpbCursos.Name = "gpbCursos";
            this.gpbCursos.Size = new System.Drawing.Size(200, 100);
            this.gpbCursos.TabIndex = 2;
            this.gpbCursos.TabStop = false;
            this.gpbCursos.Text = "Cursos ";
            // 
            // ckbJavaScrip
            // 
            this.ckbJavaScrip.AutoSize = true;
            this.ckbJavaScrip.Location = new System.Drawing.Point(18, 77);
            this.ckbJavaScrip.Name = "ckbJavaScrip";
            this.ckbJavaScrip.Size = new System.Drawing.Size(79, 17);
            this.ckbJavaScrip.TabIndex = 2;
            this.ckbJavaScrip.Text = "Java Script";
            this.ckbJavaScrip.UseVisualStyleBackColor = true;
            // 
            // ckbCmasMas
            // 
            this.ckbCmasMas.AutoSize = true;
            this.ckbCmasMas.Location = new System.Drawing.Point(18, 54);
            this.ckbCmasMas.Name = "ckbCmasMas";
            this.ckbCmasMas.Size = new System.Drawing.Size(45, 17);
            this.ckbCmasMas.TabIndex = 1;
            this.ckbCmasMas.Text = "C++";
            this.ckbCmasMas.UseVisualStyleBackColor = true;
            // 
            // ckbCSharp
            // 
            this.ckbCSharp.AutoSize = true;
            this.ckbCSharp.Location = new System.Drawing.Point(18, 31);
            this.ckbCSharp.Name = "ckbCSharp";
            this.ckbCSharp.Size = new System.Drawing.Size(40, 17);
            this.ckbCSharp.TabIndex = 0;
            this.ckbCSharp.Text = "C#";
            this.ckbCSharp.UseVisualStyleBackColor = true;
            // 
            // ltbPais
            // 
            this.ltbPais.FormattingEnabled = true;
            this.ltbPais.Items.AddRange(new object[] {
            "Argentina",
            "Chile",
            "Uruguay"});
            this.ltbPais.Location = new System.Drawing.Point(24, 290);
            this.ltbPais.Name = "ltbPais";
            this.ltbPais.Size = new System.Drawing.Size(268, 69);
            this.ltbPais.TabIndex = 3;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(420, 308);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(108, 39);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 375);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.ltbPais);
            this.Controls.Add(this.gpbCursos);
            this.Controls.Add(this.gpbGenero);
            this.Controls.Add(this.grbUsuario);
            this.Name = "Registro";
            this.Text = "Form1";
            this.grbUsuario.ResumeLayout(false);
            this.grbUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.gpbGenero.ResumeLayout(false);
            this.gpbGenero.PerformLayout();
            this.gpbCursos.ResumeLayout(false);
            this.gpbCursos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbUsuario;
        private System.Windows.Forms.GroupBox gpbGenero;
        private System.Windows.Forms.GroupBox gpbCursos;
        private System.Windows.Forms.ListBox ltbPais;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label updbEdad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.RadioButton rdbNoBinario;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.CheckBox ckbJavaScrip;
        private System.Windows.Forms.CheckBox ckbCmasMas;
        private System.Windows.Forms.CheckBox ckbCSharp;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
    }
}

