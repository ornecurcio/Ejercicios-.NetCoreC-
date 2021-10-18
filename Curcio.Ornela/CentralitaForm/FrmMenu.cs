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
    public partial class FrmMenu : Form
    {
        Central miCentralita; 
        public FrmMenu()
        {
            miCentralita = new Central("Nicolau");
            InitializeComponent();
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador formLlamada = new FrmLlamador(miCentralita);
            formLlamada.Location = this.Location;
            formLlamada.ShowDialog(); 
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            FrmMostrar showForm = new FrmMostrar(miCentralita);
            showForm.TipoLlamada = TipoLlamada.Todas;

            showForm.Location = this.Location;
            showForm.ShowDialog();
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            FrmMostrar showForm = new FrmMostrar(miCentralita);
            showForm.TipoLlamada = TipoLlamada.Local;

            showForm.Location = this.Location;
            showForm.ShowDialog();
        }

        private void btnFacturacionProvincial_Click(object sender, EventArgs e)
        {
            FrmMostrar showForm = new FrmMostrar(miCentralita);
            showForm.TipoLlamada = TipoLlamada.Provincial;

            showForm.Location = this.Location;
            showForm.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
