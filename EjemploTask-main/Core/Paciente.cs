using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public enum EDolencia
    {
        Fractura=1,
        Esguince,
        Resfrio,
        Anginas,
        Alergia
    }


    public class Paciente
    {

        int dni;
        string nombre;
        EDolencia dolencia;
        bool atendido;

        public Paciente(int dni, string nombre, EDolencia dolencia, bool atendido)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.dolencia = dolencia;
            this.atendido = atendido;
        }

        public int Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public EDolencia Dolencia { get => dolencia; set => dolencia = value; }
        public bool Atendido { get => atendido; set => atendido = value; }


    }

}
