using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Billetes;

namespace EjerClase23
{
    public partial class FrmMonedas : Form
    { 
        public FrmMonedas()
        {
            InitializeComponent();
        }
        private void btnLockCotizacion_Click(object sender, EventArgs e)
        {
            if (btnLockCotizacion.ImageIndex == 1)
            {
                btnLockCotizacion.ImageIndex = 0;
                txtCotizacionEuro.Enabled = false;
                txtCotizacionPeso.Enabled = false;
                txtCotizacionPeso.Enabled = false;
            }
            else
            {
                btnLockCotizacion.ImageIndex = 1;
                txtCotizacionEuro.Enabled = true;
                txtCotizacionPeso.Enabled = true;
                txtCotizacionPeso.Enabled = true;
            }
        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            double aux;
            double auxCotEuro;
            double auxCotPesos;
            if (!double.TryParse(txtDolar.Text, out aux))
            {
                MessageBox.Show("Ingrese solo numeros");
            }
            else
            {
                if (!double.TryParse(txtCotizacionEuro.Text, out auxCotEuro) ||
                    !double.TryParse(txtCotizacionPeso.Text, out auxCotPesos))
                {
                    MessageBox.Show("Ingrese solo numeros en la cotizacion");
                }
                else
                {
                    Euro.SetCotizacion(auxCotEuro);
                    Pesos.SetCotizacion(auxCotPesos);
                    Dolar montoUsuarioDolar = aux;
                    Pesos montoUsuarioPeso = (Pesos)montoUsuarioDolar;
                    Euro montoUsuarioEuro = (Euro)montoUsuarioDolar;
                    txtDolarADolar.Text = montoUsuarioDolar.GetCantidad().ToString();
                    txtDolarAEuro.Text = montoUsuarioEuro.GetCantidad().ToString();
                    txtDolarAPeso.Text = montoUsuarioPeso.GetCantidad().ToString();
                }
            }
        }
        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            double aux;
            double auxCotEuro;
            double auxCotPesos;
            if (!double.TryParse(txtEuro.Text, out aux))
            {
                MessageBox.Show("Ingrese solo numeros");
            }
            else 
            {
                if (!double.TryParse(txtCotizacionEuro.Text, out auxCotEuro) ||
                    !double.TryParse(txtCotizacionPeso.Text, out auxCotPesos))
                {
                    MessageBox.Show("Ingrese solo numeros");
                }
                else 
                {
                    Euro.SetCotizacion(auxCotEuro);
                    Pesos.SetCotizacion(auxCotPesos);
                    Euro montoUsuarioEuro = aux;
                    Dolar montoUsuarioDolar= (Dolar)montoUsuarioEuro;
                    Pesos montoUsuarioPesos = (Pesos)montoUsuarioDolar;
                    txtEuroADolar.Text = montoUsuarioDolar.GetCantidad().ToString();
                    txtEuroAEuro.Text = montoUsuarioEuro.GetCantidad().ToString();
                    txtEuroAPeso.Text = montoUsuarioPesos.GetCantidad().ToString();
                }
            }

        }

        private void btnConvertPeso_Click(object sender, EventArgs e)
        {
            double aux;
            double auxCotEuro;
            double auxCotPesos;
            if (!double.TryParse(txtPeso.Text, out aux))
            {
                MessageBox.Show("Ingrese solo numeros");
            }
            else
            {
                if (!double.TryParse(txtCotizacionEuro.Text, out auxCotEuro) ||
                    !double.TryParse(txtCotizacionPeso.Text, out auxCotPesos))
                {
                    MessageBox.Show("Ingrese solo numeros en la cotizacion");
                }
                else
                {
                    Euro.SetCotizacion(auxCotEuro);
                    Pesos.SetCotizacion(auxCotPesos);
                    Pesos montoUsuarioPeso = aux;
                    Euro montoUsuarioEuro = (Euro)montoUsuarioPeso;
                    Dolar montoUsuarioDolar = (Dolar)montoUsuarioEuro;
                    txtPesoADolar.Text = montoUsuarioDolar.GetCantidad().ToString();
                    txtPesoAEuro.Text = montoUsuarioEuro.GetCantidad().ToString();
                    txtPesoAPeso.Text = montoUsuarioPeso.GetCantidad().ToString();
                }
            }
        }
        private void FrmMonedas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esta seguro desea salir", "Pregunta", MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true; 
            }
        }
    }
}
