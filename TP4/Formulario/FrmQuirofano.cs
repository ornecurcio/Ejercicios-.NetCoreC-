using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades; 

namespace Formulario
{
    public partial class FrmQuirofano : Form
    {
        List<Cirugia> cirugias = new List<Cirugia>();
        CancellationTokenSource ctsSource;
        CancellationToken cstToken; 
        public FrmQuirofano()
        {
            InitializeComponent();
            foreach(Cirugia item in Hospital.Cirugias)
            {
                this.cirugias.Add(item); 
            }
        }
        //TODO ACTUALIZAR DATA PARA SACAR CIRUGIAS 
        private void btnRealizarCirugias_Click(object sender, EventArgs e)
        {
            // Task tsk = new Task(() => 
            //{ 

            //});
            // tsk.Start(Hospital.Cts.Token);
        
            Task.Run(() => ActualizarLista(Hospital.Cts.Token));
            btnDetenerQuirofano.Enabled = true;
            btnRealizarCirugias.Enabled = false; 
        }

        private void btnDetenerQuirofano_Click(object sender, EventArgs e)
        {
            Hospital.Cts.Cancel();
            btnRealizarCirugias.Enabled = true;
            btnDetenerQuirofano.Enabled = false; 
        }

        private void btnCerrarQuirofano_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
        
        private void FrmQuirofano_Load(object sender, EventArgs e)
        {
            lstPacientes.DataSource = cirugias;
            btnDetenerQuirofano.Enabled = false; 
        }
        private void ActualizarLista(CancellationToken cts)
        {
            foreach (Cirugia item in Hospital.Cirugias)
            {
                if (cts.IsCancellationRequested)
                    return;

                if (item.Paciente.Patologia is not null)
                {
                    item.RealizarOperacion();
                    cirugias.Remove(item);
                }
                
                if (this.lstPacientes.InvokeRequired) // DA TRUE CUANDO NO ES DEL HILO PRINCIPAL 
                {
                    this.lstPacientes.BeginInvoke((MethodInvoker)delegate ()
                    {
                        lstPacientes.DataSource = null;
                        lstPacientes.DataSource = cirugias;
                    });
                    Thread.Sleep(2000);
                }
                else
                {
                    lstPacientes.DataSource = null;
                    lstPacientes.DataSource = cirugias;
                }
            }
        }
    }
}
