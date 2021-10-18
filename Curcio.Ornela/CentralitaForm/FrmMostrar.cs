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
    public partial class FrmMostrar : Form
    {
        Central laCentralita;
        TipoLlamada tipoLlamada; 
        public FrmMostrar()
        {
            InitializeComponent();
        }
        public FrmMostrar(Central laCentralita):this()
        {
            this.laCentralita = laCentralita; 
        }
        public TipoLlamada TipoLlamada
        {
            set
            {
                this.tipoLlamada = value; 
            }
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            if (tipoLlamada is TipoLlamada.Local)
            {
                rtxFacturacion.Text = "Local: $ " + (Math.Round(laCentralita.GananciaPorLocal, 2)).ToString();
            }
            else if (tipoLlamada is TipoLlamada.Provincial)
            {
                rtxFacturacion.Text = "Prov: $ " + (Math.Round(laCentralita.GananciaPorProvincial, 2)).ToString();
            }
            else
            {
                rtxFacturacion.Text = "All: $ " + (Math.Round(laCentralita.GananciaPorTotal, 2)).ToString();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
