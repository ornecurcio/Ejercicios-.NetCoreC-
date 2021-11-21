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
    public partial class FrmEstadisticaHospital : Form
    {
        public FrmEstadisticaHospital()
        {
            InitializeComponent();
        }

        private void FrmEstadisticaHospital_Load(object sender, EventArgs e)
        {
            this.rchInfoHospital.Text += Hospital.CargarInfoPacientes();
            CargarInfoCirujanos();
            CargarPatologiaPrevalente();
            CargarProcedimientoPrevalente();
            this.rchInfoHospital.Text += Hospital.PocentajeCirugiasCadaMedico(); 
        }


        //TODO: MOVER LOS METODOS A HOSPITAL

        private void CargarInfoCirujanos()
        {
            float cantCirujanos = 0;
            foreach (Cirujano item in Hospital.Cirujanos)
            {
                if (item.Rol == ERol.Ayudante)
                {
                    cantCirujanos++;
                } 
            }
            float porcentaje = cantCirujanos / Hospital.Cirujanos.Count;

            this.rchInfoHospital.Text += $"Los ayudantes representan el {Math.Round(porcentaje, 2)*100}% de los medicos ";
            this.rchInfoHospital.Text += $"(Cantidad ayudantes: {cantCirujanos} de {Hospital.Cirujanos.Count}) \n\n";
        }
        private void CargarPatologiaPrevalente()
        {
            EPatologia aux = Hospital.Estadistica.PatologiaPrevalente();
            int auxCant = Hospital.Estadistica.CantPatologiaPrevalente();

            float porcentaje = (float)auxCant / Hospital.CirugiasRealizadas.Count; 

            this.rchInfoHospital.Text += $"La patologia mas operada es {aux} con un porcentaje de {Math.Round(porcentaje, 2)*100}% ";
            this.rchInfoHospital.Text += $"(Cantidad {aux}: {auxCant} de {Hospital.CirugiasRealizadas.Count}) \n\n";
        }
        private void CargarProcedimientoPrevalente()
        {
            EProcedimiento aux = Hospital.Estadistica.ProcedimientoPrevalente();
            int auxCant = Hospital.Estadistica.CantProcedimientoPrevalente();

            float porcentaje = (float)auxCant / Hospital.CirugiasRealizadas.Count;

            this.rchInfoHospital.Text += $"El procedimiento mas realizado es {aux} con un porcentaje de {Math.Round(porcentaje, 2) * 100}% ";
            this.rchInfoHospital.Text += $"(Cantidad {aux}: {auxCant} de {Hospital.CirugiasRealizadas.Count}) \n\n";
        }
        
    }
}
