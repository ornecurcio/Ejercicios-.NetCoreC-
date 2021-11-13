using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Core
{
    public static class Hospital
    {
        static Random rnd;
        static Queue<Paciente> pacientesEnEspera;
        static List<Doctor> doctores;
        static List<Paciente> pacientesAtendidos;

        static Hospital()
        {
            rnd = new Random();
            pacientesAtendidos = new List<Paciente>();
            doctores = new List<Doctor>();
            pacientesEnEspera = new Queue<Paciente>();
        }


        public static void ActualizarPacientesEnEspera()
        {
            ConexionDB.TraerPacientes("Select * from pacientes where atendidos = 0");
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

            Thread.Sleep(rnd.Next(2000,6000));

        }


        public static bool ConsultorioLibre()
        {
            return true;
        }

    }
}
