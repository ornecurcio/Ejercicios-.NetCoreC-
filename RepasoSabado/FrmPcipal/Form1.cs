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
    public partial class Form1 : Form
    {
        Persona persona;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            cbkProfesor.Enabled = true;
            cbkAlumno.Enabled = true; 
        }

        private void cbkAlumno_CheckedChanged(object sender, EventArgs e)
        {
            if (cbkAlumno.Checked)
            {
                cbkProfesor.Enabled = false;
                btnAgregar.Enabled = true;
            }
            else
            {
                cbkProfesor.Enabled = true;
                btnAgregar.Enabled = false; 
            }
        }

        private void cbkProfesor_CheckedChanged(object sender, EventArgs e)
        {
            if (cbkProfesor.Checked)
            {
                cbkAlumno.Enabled = false;
                btnAgregar.Enabled = true;
            }
            else
            {
                cbkAlumno.Enabled = true;
                btnAgregar.Enabled = false; 
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cbkAlumno.Checked)
            {
                persona = new Alumno();
                FormCarga datos = new FormCarga(persona);
                datos.ShowDialog();
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append($"{persona.Nombre},{persona.Dni},{((Alumno)persona).AnioIngreso},");
                foreach (Materia item in persona.Materias)
                {
                    stringBuilder.Append($"{item.Nombre}");
                }
                lstAlumnos.Items.Add(stringBuilder.ToString());
            }

            if (cbkProfesor.Checked)
            {
                persona = new Profesor();
                FormCarga datos = new FormCarga(persona);
                datos.ShowDialog();
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append($"{persona.Nombre},{persona.Dni},{((Profesor)persona).Antiguedad},");
                foreach (Materia item in persona.Materias) 
            {
                    stringBuilder.Append($"{item.Nombre},");
                }
                lstProfesores.Items.Add(stringBuilder.ToString());
            }
        }

       
    }
}
