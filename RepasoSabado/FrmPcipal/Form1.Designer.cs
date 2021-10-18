
namespace FrmPcipal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstProfesores = new System.Windows.Forms.ListBox();
            this.lstAlumnos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cbkProfesor = new System.Windows.Forms.CheckBox();
            this.cbkAlumno = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lstProfesores
            // 
            this.lstProfesores.FormattingEnabled = true;
            this.lstProfesores.ItemHeight = 15;
            this.lstProfesores.Location = new System.Drawing.Point(151, 35);
            this.lstProfesores.Name = "lstProfesores";
            this.lstProfesores.Size = new System.Drawing.Size(348, 364);
            this.lstProfesores.TabIndex = 0;
            // 
            // lstAlumnos
            // 
            this.lstAlumnos.FormattingEnabled = true;
            this.lstAlumnos.ItemHeight = 15;
            this.lstAlumnos.Location = new System.Drawing.Point(515, 35);
            this.lstAlumnos.Name = "lstAlumnos";
            this.lstAlumnos.Size = new System.Drawing.Size(377, 364);
            this.lstAlumnos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Profesor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(515, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Alumno";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(48, 234);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cbkProfesor
            // 
            this.cbkProfesor.AutoSize = true;
            this.cbkProfesor.Location = new System.Drawing.Point(40, 163);
            this.cbkProfesor.Name = "cbkProfesor";
            this.cbkProfesor.Size = new System.Drawing.Size(70, 19);
            this.cbkProfesor.TabIndex = 5;
            this.cbkProfesor.Text = "Profesor";
            this.cbkProfesor.UseVisualStyleBackColor = true;
            this.cbkProfesor.CheckedChanged += new System.EventHandler(this.cbkProfesor_CheckedChanged);
            // 
            // cbkAlumno
            // 
            this.cbkAlumno.AutoSize = true;
            this.cbkAlumno.Location = new System.Drawing.Point(40, 113);
            this.cbkAlumno.Name = "cbkAlumno";
            this.cbkAlumno.Size = new System.Drawing.Size(69, 19);
            this.cbkAlumno.TabIndex = 6;
            this.cbkAlumno.Text = "Alumno";
            this.cbkAlumno.UseVisualStyleBackColor = true;
            this.cbkAlumno.CheckedChanged += new System.EventHandler(this.cbkAlumno_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 415);
            this.Controls.Add(this.cbkAlumno);
            this.Controls.Add(this.cbkProfesor);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstAlumnos);
            this.Controls.Add(this.lstProfesores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstProfesores;
        private System.Windows.Forms.ListBox lstAlumnos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.CheckBox cbkProfesor;
        private System.Windows.Forms.CheckBox cbkAlumno;
    }
}

