using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreClinica
{
    public class Doctor
    {
        int idDoctor;
        string nombre;

        public Doctor(int idDoctor, string nombre)
        {
            this.idDoctor = idDoctor;
            this.nombre = nombre;
        }

        public int IdDoctor { get => idDoctor; set => idDoctor = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
