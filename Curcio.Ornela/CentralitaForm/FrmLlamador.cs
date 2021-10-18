using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Centralita; 

namespace CentralitaForm
{
    public partial class FrmLlamador : Form
    {
        Central laCentralita;
        public FrmLlamador()
        {
            InitializeComponent();
        }
        public FrmLlamador(Central laCentralita) : this()
        {
            this.laCentralita = laCentralita;
        }
        public Central LaCentralita
        {
            get
            {
                return this.laCentralita;
            }
        }
        private void btnLlamar_Click(object sender, EventArgs e)
        {
            Random randomNumber = new Random();
            float duracion;
            float costo;
            if (!String.IsNullOrWhiteSpace(txtNroDestino.Text) && !String.IsNullOrWhiteSpace(txtNroOrigen.Text))
            {
                duracion = randomNumber.Next(1, 51);
                if (txtNroDestino.Text.StartsWith("#"))
                {
                    Franja franja;
                    Enum.TryParse<Franja>(cbxFranja.SelectedValue.ToString(), out franja);
                    Provincial llamadaProv = new Provincial(franja, duracion, txtNroDestino.Text, txtNroOrigen.Text); 
                    laCentralita += llamadaProv;
                    MessageBox.Show("Llamada Provincial Generada con exito!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    costo = (randomNumber.Next(5, 56) / 10);
                    Local llamadaLocal = new Local(duracion, txtNroDestino.Text, txtNroOrigen.Text, costo);
                    laCentralita += llamadaLocal;
                    MessageBox.Show("Llamada Local Generada con exito!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                btnLimpiar_Click(sender, e);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNroDestino.Clear();
            txtNroOrigen.Clear();
            cbxFranja.SelectedIndex = -1; 
            cbxFranja.Enabled = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += btn1.Text; 
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += btn9.Text;
        }

        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += btnAsterisco.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += btn0.Text;
        }

        private void btn1Hastagh_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += btn1Hastagh.Text;
            if (txtNroDestino.Text.StartsWith("#"))
            {
                cbxFranja.Enabled = true;
            }
            else
            {
                cbxFranja.Enabled = false;
            }
        }
        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            // Carga
            cbxFranja.DataSource = Enum.GetValues(typeof(Franja));
            cbxFranja.Enabled = false; 

            //// Lectura
            //Franja franjas;
            //Enum.TryParse<Franja>(cbxFranja.SelectedValue.ToString(), out franjas); 
        }

        private void FrmLlamador_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea salir del llamador?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
