using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerHolaWindowsForm
{
    public partial class FrmIngreso : Form
    {
        public FrmIngreso()
        {
            InitializeComponent();
        }
        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string materia = cmbMateria.SelectedItem.ToString();
            bool datosOk = true; 
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Se deben completar los siguientes campos:");
            if (string.IsNullOrWhiteSpace(nombre))
            {
                stringBuilder.AppendLine("Nombre");
                datosOk = false;
            }
            if (string.IsNullOrWhiteSpace(apellido))
            {
                stringBuilder.AppendLine("Apellido");
                datosOk = false;
            }
            if (!datosOk)
            {
                MessageBox.Show(stringBuilder.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                string titulo = "¡Hola, Windows Forms!";
                string mensaje = $"Soy {nombre} {apellido} y mi materia favorita es {materia}.";
                Saludo saludo = new Saludo(titulo, mensaje);
                saludo.ShowDialog();
            }
        }
        private void FrmIngreso_Load(object sender, EventArgs e)
        {
            cmbMateria.SelectedIndex = 0; 
        }

        private void FrmIngreso_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esta seguro desea salir", "Pregunta", MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
