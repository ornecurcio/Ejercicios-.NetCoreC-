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
using CoreClinica;


namespace UIClinica
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void ActualizarDatagrid(CancellationToken cts)
        {
            while (true)
            {
                if (cts.IsCancellationRequested)
                    return;


                else if (this.dataGridView1.InvokeRequired) // DA TRUE CUANDO NO ES DEL HILO PRINCIPAL 
                {
                    this.dataGridView1.BeginInvoke((MethodInvoker)delegate ()
                    {
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = ConexionDB.TraerPacientes().ToList();
                    });

                    Thread.Sleep(2000);
                }
                else
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = ConexionDB.TraerPacientes().ToList();
                }
            }
        }

        private void btn_noatender_Click(object sender, EventArgs e)
        {
            Hospital.Cts.Cancel();
            btn_Atender.Enabled = true;
        }

        private void btn_Atender_Click(object sender, EventArgs e)
        {

            Task.Run(() => ActualizarDatagrid(Hospital.Cts.Token));
           
            btn_Atender.Enabled = false;
        }

        private void btnPacienteHardcodeado_Click(object sender, EventArgs e)
        {
            Paciente aux = Hardcodeo.SimularCargaPaciente();
            if (aux != null)
                Hospital.PacientesNuevos.Add(aux);

        }
    }
}
