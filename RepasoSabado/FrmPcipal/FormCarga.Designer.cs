
namespace FrmPcipal
{
    partial class FormCarga
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.gbxMaterias = new System.Windows.Forms.GroupBox();
            this.cbkSPD = new System.Windows.Forms.CheckBox();
            this.cbkArq = new System.Windows.Forms.CheckBox();
            this.cbkLaboratorio = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.cbkProgramacionII = new System.Windows.Forms.CheckBox();
            this.cbkProgramacionI = new System.Windows.Forms.CheckBox();
            this.txtAntiguedad = new System.Windows.Forms.TextBox();
            this.cbxAnioIngreso = new System.Windows.Forms.ComboBox();
            this.lblAnio = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gbxMaterias.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(31, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(199, 12);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 23);
            this.txtDni.TabIndex = 1;
            this.txtDni.Text = "DNI";
            this.txtDni.TextChanged += new System.EventHandler(this.txtDni_TextChanged);
            // 
            // gbxMaterias
            // 
            this.gbxMaterias.Controls.Add(this.cbkSPD);
            this.gbxMaterias.Controls.Add(this.cbkArq);
            this.gbxMaterias.Controls.Add(this.cbkLaboratorio);
            this.gbxMaterias.Controls.Add(this.checkBox3);
            this.gbxMaterias.Controls.Add(this.cbkProgramacionII);
            this.gbxMaterias.Controls.Add(this.cbkProgramacionI);
            this.gbxMaterias.Location = new System.Drawing.Point(12, 90);
            this.gbxMaterias.Name = "gbxMaterias";
            this.gbxMaterias.Size = new System.Drawing.Size(339, 172);
            this.gbxMaterias.TabIndex = 2;
            this.gbxMaterias.TabStop = false;
            this.gbxMaterias.Text = "Materias";
            // 
            // cbkSPD
            // 
            this.cbkSPD.AutoSize = true;
            this.cbkSPD.Location = new System.Drawing.Point(187, 32);
            this.cbkSPD.Name = "cbkSPD";
            this.cbkSPD.Size = new System.Drawing.Size(127, 19);
            this.cbkSPD.TabIndex = 5;
            this.cbkSPD.Text = "Sistema Proc Datos";
            this.cbkSPD.UseVisualStyleBackColor = true;
            // 
            // cbkArq
            // 
            this.cbkArq.AutoSize = true;
            this.cbkArq.Location = new System.Drawing.Point(187, 69);
            this.cbkArq.Name = "cbkArq";
            this.cbkArq.Size = new System.Drawing.Size(135, 19);
            this.cbkArq.TabIndex = 4;
            this.cbkArq.Text = "Arq y Sist Operativos";
            this.cbkArq.UseVisualStyleBackColor = true;
            // 
            // cbkLaboratorio
            // 
            this.cbkLaboratorio.AutoSize = true;
            this.cbkLaboratorio.Location = new System.Drawing.Point(187, 111);
            this.cbkLaboratorio.Name = "cbkLaboratorio";
            this.cbkLaboratorio.Size = new System.Drawing.Size(87, 19);
            this.cbkLaboratorio.TabIndex = 3;
            this.cbkLaboratorio.Text = "Laboratorio";
            this.cbkLaboratorio.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(19, 111);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(57, 19);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Ingles";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // cbkProgramacionII
            // 
            this.cbkProgramacionII.AutoSize = true;
            this.cbkProgramacionII.Location = new System.Drawing.Point(19, 69);
            this.cbkProgramacionII.Name = "cbkProgramacionII";
            this.cbkProgramacionII.Size = new System.Drawing.Size(110, 19);
            this.cbkProgramacionII.TabIndex = 1;
            this.cbkProgramacionII.Text = "Programacion II";
            this.cbkProgramacionII.UseVisualStyleBackColor = true;
            // 
            // cbkProgramacionI
            // 
            this.cbkProgramacionI.AutoSize = true;
            this.cbkProgramacionI.Location = new System.Drawing.Point(19, 32);
            this.cbkProgramacionI.Name = "cbkProgramacionI";
            this.cbkProgramacionI.Size = new System.Drawing.Size(107, 19);
            this.cbkProgramacionI.TabIndex = 0;
            this.cbkProgramacionI.Text = "Programacion I";
            this.cbkProgramacionI.UseVisualStyleBackColor = true;
            // 
            // txtAntiguedad
            // 
            this.txtAntiguedad.Location = new System.Drawing.Point(145, 61);
            this.txtAntiguedad.Name = "txtAntiguedad";
            this.txtAntiguedad.Size = new System.Drawing.Size(100, 23);
            this.txtAntiguedad.TabIndex = 3;
            this.txtAntiguedad.TextChanged += new System.EventHandler(this.txtAntiguedad_TextChanged);
            // 
            // cbxAnioIngreso
            // 
            this.cbxAnioIngreso.FormattingEnabled = true;
            this.cbxAnioIngreso.Items.AddRange(new object[] {
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988"});
            this.cbxAnioIngreso.Location = new System.Drawing.Point(113, 61);
            this.cbxAnioIngreso.Name = "cbxAnioIngreso";
            this.cbxAnioIngreso.Size = new System.Drawing.Size(121, 23);
            this.cbxAnioIngreso.TabIndex = 4;
            this.cbxAnioIngreso.SelectedIndexChanged += new System.EventHandler(this.cbxAnioIngreso_SelectedIndexChanged);
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(31, 64);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(71, 15);
            this.lblAnio.TabIndex = 5;
            this.lblAnio.Text = "Año Ingreso";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(322, 272);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // FormCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 307);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.cbxAnioIngreso);
            this.Controls.Add(this.txtAntiguedad);
            this.Controls.Add(this.gbxMaterias);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtNombre);
            this.Name = "FormCarga";
            this.Text = "FormCarga";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCarga_FormClosing);
            this.Load += new System.EventHandler(this.FormCarga_Load);
            this.gbxMaterias.ResumeLayout(false);
            this.gbxMaterias.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.GroupBox gbxMaterias;
        private System.Windows.Forms.CheckBox cbkSPD;
        private System.Windows.Forms.CheckBox cbkArq;
        private System.Windows.Forms.CheckBox cbkLaboratorio;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox cbkProgramacionII;
        private System.Windows.Forms.CheckBox cbkProgramacionI;
        private System.Windows.Forms.TextBox txtAntiguedad;
        private System.Windows.Forms.ComboBox cbxAnioIngreso;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Button btnAceptar;
    }
}