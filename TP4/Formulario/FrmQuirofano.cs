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

namespace Formulario
{
    public partial class FrmQuirofano : Form
    {
        public FrmQuirofano()
        {
            InitializeComponent();
            lstPacientes.DataSource = Hospital.Pacientes; 
        }

        private void btnRealizarCirugias_Click(object sender, EventArgs e)
        {
            DelegadoCirugia delegadoCirugia = RealizarCirugiaColumna;
            delegadoCirugia += RealizarCirugiaMiembros;
            delegadoCirugia += RealizarCirugiaPelvis; 
        }

        private void btnDetenerQuirofano_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarQuirofano_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
        private EProcedimiento RealizarCirugiaColumna(EPatologia patologia)
        {
            Random random = new Random();
            random.Next(4, 6);
            return (EProcedimiento)Enum.Parse(typeof(EProcedimiento), random.Next(4, 6).ToString()); 
        }
        private EProcedimiento RealizarCirugiaMiembros(EPatologia patologia)
        {
            Random random = new Random();
            random.Next(1, 6);
            return (EProcedimiento)Enum.Parse(typeof(EProcedimiento), random.Next(4, 6).ToString());
        }
        private EProcedimiento RealizarCirugiaPelvis(EPatologia patologia)
        {
            Random random = new Random();
            random.Next(3, 4);
            return (EProcedimiento)Enum.Parse(typeof(EProcedimiento), random.Next(4, 6).ToString());
        }
    }
}
