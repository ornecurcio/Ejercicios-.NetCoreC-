using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades; 

namespace FrmPcipal
{
    public partial class FormCarga : Form
    {
        Persona thisPersona;
        bool anioingreso = false; 
        public FormCarga()
        {
            InitializeComponent();
        }
        public FormCarga(Persona persona):this()
        {
            this.thisPersona = persona; 
        }

        private void FormCarga_Load(object sender, EventArgs e)
        {
            if (thisPersona is Profesor)
            {
                lblAnio.Text = "Antiguedad";
                cbxAnioIngreso.Visible = false;
                txtAntiguedad.Visible = true; 
            }
            if (thisPersona is Alumno)
            {
                lblAnio.Text = "Año de Ingreso";
                cbxAnioIngreso.Visible = true;
                txtAntiguedad.Visible = false; 
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text.All(char.IsLetter) && !string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                thisPersona.Nombre = txtNombre.Text; 
            }
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            if (txtDni.Text.All(char.IsDigit) && !string.IsNullOrWhiteSpace(txtDni.Text))
            {
                thisPersona.Dni = int.Parse(txtDni.Text); 
            }
        }

        private void cbxAnioIngreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            ((Alumno)thisPersona).AnioIngreso = int.Parse(cbxAnioIngreso.Text);
            anioingreso = true; 
        }

        private void txtAntiguedad_TextChanged(object sender, EventArgs e)
        {
            if (txtAntiguedad.Text.All(char.IsDigit) && !string.IsNullOrWhiteSpace(txtAntiguedad.Text))
            {
                ((Profesor)thisPersona).Antiguedad = int.Parse(txtAntiguedad.Text);
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Materia aux; 
            foreach (Control item in this.gbxMaterias.Controls)
            {
                if (item is CheckBox)
                {
                    if (((CheckBox)item).Checked == true)
                    {
                        switch (item.Text)
                        {
                            case "Programacion I":
                                aux = new Materia("Programacion I", 450, true, false, true);
                                thisPersona.Materias.Add(aux);
                                break;
                            case "Programacion II":
                                aux = new Materia("Programacion II", 600, true, false, true);
                                thisPersona.Materias.Add(aux);
                                break;
                            case "Laboratorio":
                                aux = new Materia("Laboratorio", 1000, false, true, false);
                                thisPersona.Materias.Add(aux);
                                break;
                            case "Ingles":
                                aux = new Materia("Ingles", 750, false, true, false);
                                thisPersona.Materias.Add(aux);
                                break;
                            case "Sistema Proc Datos":
                                aux = new Materia("Sistema Proc Datos", 350, true, false, true);
                                thisPersona.Materias.Add(aux);
                                break;
                            case "Arq y Sist Operativos":
                                aux = new Materia("Arq y Sist Operativos", 350, true, false, true);
                                thisPersona.Materias.Add(aux);
                                break;
                        }
                       
                    }

                }
            }
            if (txtNombre.Text.All(char.IsLetter) && !string.IsNullOrWhiteSpace(txtNombre.Text) &&
                txtDni.Text.All(char.IsDigit) && !string.IsNullOrWhiteSpace(txtDni.Text) &&
              (txtAntiguedad.Text.All(char.IsDigit) && !string.IsNullOrWhiteSpace(txtAntiguedad.Text) || anioingreso)
                )
            {
                this.Close(); 
            }

        }

        private void FormCarga_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thisPersona is Profesor)
            {
                if(MessageBox.Show($"Estos son los datos:\n{thisPersona.Nombre}\n{thisPersona.Dni}\n{((Profesor)thisPersona).Antiguedad}", 
                                    "Datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
            if (thisPersona is Alumno)
            {
                if (MessageBox.Show($"Estos son los datos:\n{thisPersona.Nombre}\n{thisPersona.Dni}\n{((Alumno)thisPersona).AnioIngreso}",
                                    "Datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }

        }
    }
}
