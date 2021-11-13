
namespace UIClinica
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_noatender = new System.Windows.Forms.Button();
            this.btn_Atender = new System.Windows.Forms.Button();
            this.btnPacienteHardcodeado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(744, 526);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_noatender
            // 
            this.btn_noatender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_noatender.Location = new System.Drawing.Point(861, 178);
            this.btn_noatender.Name = "btn_noatender";
            this.btn_noatender.Size = new System.Drawing.Size(363, 138);
            this.btn_noatender.TabIndex = 1;
            this.btn_noatender.Text = "Dejar de atender";
            this.btn_noatender.UseVisualStyleBackColor = false;
            this.btn_noatender.Click += new System.EventHandler(this.btn_noatender_Click);
            // 
            // btn_Atender
            // 
            this.btn_Atender.BackColor = System.Drawing.Color.Lime;
            this.btn_Atender.Location = new System.Drawing.Point(861, 12);
            this.btn_Atender.Name = "btn_Atender";
            this.btn_Atender.Size = new System.Drawing.Size(363, 130);
            this.btn_Atender.TabIndex = 2;
            this.btn_Atender.Text = "Atender pacientes";
            this.btn_Atender.UseVisualStyleBackColor = false;
            this.btn_Atender.Click += new System.EventHandler(this.btn_Atender_Click);
            // 
            // btnPacienteHardcodeado
            // 
            this.btnPacienteHardcodeado.BackColor = System.Drawing.Color.Yellow;
            this.btnPacienteHardcodeado.Location = new System.Drawing.Point(861, 356);
            this.btnPacienteHardcodeado.Name = "btnPacienteHardcodeado";
            this.btnPacienteHardcodeado.Size = new System.Drawing.Size(346, 152);
            this.btnPacienteHardcodeado.TabIndex = 3;
            this.btnPacienteHardcodeado.Text = "Agregar Paciente Hardcodeado";
            this.btnPacienteHardcodeado.UseVisualStyleBackColor = false;
            this.btnPacienteHardcodeado.Click += new System.EventHandler(this.btnPacienteHardcodeado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1513, 611);
            this.Controls.Add(this.btnPacienteHardcodeado);
            this.Controls.Add(this.btn_Atender);
            this.Controls.Add(this.btn_noatender);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_noatender;
        private System.Windows.Forms.Button btn_Atender;
        private System.Windows.Forms.Button btnPacienteHardcodeado;
    }
}

