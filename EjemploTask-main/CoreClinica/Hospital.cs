using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CoreClinica
{
    public static class Hospital
    {
        static Random rnd;
        static Queue<Paciente> pacientesEnEspera;
        static List<Doctor> doctores;
        static List<Paciente> pacientesAtendidos;
        static CancellationTokenSource cts;
        static List<Paciente> pacientesNuevos;

        public static CancellationTokenSource Cts
        {

            get
            {
                if (cts is null || cts.IsCancellationRequested)
                {
                    cts = new CancellationTokenSource();
                }

                return cts;
            }

        }

        public static List<Paciente> PacientesNuevos { get => pacientesNuevos; set => pacientesNuevos = value; }

        static Hospital()
        {
            rnd = new Random();
            pacientesAtendidos = new List<Paciente>();
            doctores = new List<Doctor>();
            pacientesEnEspera = new Queue<Paciente>();
            pacientesNuevos = new List<Paciente>();
            cts = new CancellationTokenSource();
            Task.Run(() => CheckearPacientesNuevos(), cts.Token);
        }


        public static Queue<Paciente> ActualizarPacientesEnEspera()
        {
            return ConexionDB.TraerPacientes();
        }


        public static void CheckearPacientesNuevos()
        {
            while (true)
            {
                if (pacientesNuevos.Count > 0)
                    InsertarPacientes();

                Thread.Sleep(5000);
            }

        }


        public static void InsertarPacientes()
        {
            ConexionDB.InsertarNuevosPacientes(pacientesNuevos);
        }



        public static void LlamarProximoPaciente(CancellationToken token)
        {
            while (true)
            {
                if (token.IsCancellationRequested)
                {
                    return;
                }
                else if (ConsultorioLibre())
                {
                    Atender(pacientesEnEspera.Dequeue());
                }
            }
        }


        private static void Atender(Paciente p)
        {
            p.Atendido = true;
            pacientesAtendidos.Add(p);

            Thread.Sleep(rnd.Next(2000, 6000));
        }


        public static bool ConsultorioLibre()
        {
            return true;
        }

    }
}
