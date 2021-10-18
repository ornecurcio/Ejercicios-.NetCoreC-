using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estudiantes; 

namespace EjerRegistrate
{
    public partial class Registro : Form
    {
         //recorrer la coleccion de controles del formulario, chequear el grupbox,
         //recorrer el grupbox. 
         //chear el cheked. 
        public Registro()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int edad = (int)nudEdad.Value;
            string genero = "";
            string[] cursos = new string[3];
            foreach (Control item in this.gpbGenero.Controls)
            {
                if (item is RadioButton)
                {
                    if (((RadioButton)item).Checked == true)
                    {
                        genero = item.Text;
                    }
                }
            }
            foreach (Control item in this.gpbCursos.Controls)
            {
                int i = 0;
                if (item is CheckBox)
                {
                    if (((CheckBox)item).Checked == true)
                    {
                        cursos[i] = item.Text;
                    }
                    i++;
                }
            }
            //foreach (Control item in this.Controls)
            //{
            //    if (item is GroupBox)
            //    {
            //        foreach (Control c in item.Controls)
            //        {

            //            if (c is CheckBox)
            //            {
            //                int i = 0;
            //                if (((CheckBox)c).Checked == true)
            //                {
            //                    cursos[i] = c.Text;

            //                }
            //                i++;
            //            }
            //            if (c is RadioButton)
            //            {
            //                if (((RadioButton)c).Checked == true)
            //                {
            //                    genero = c.Text;
            //                }
            //            }
            //        }
            //    }
            //}

            Ingresante estudiante = new Ingresante(txtNombre.Text, txtDireccion.Text, genero, 
                                                    ltbPais.Text, cursos, edad);
            MessageBox.Show(estudiante.Mostrar(), "Datos", MessageBoxButtons.OK);      
        } 
    }   
}
