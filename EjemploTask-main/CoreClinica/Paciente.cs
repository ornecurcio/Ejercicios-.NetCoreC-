using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreClinica
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
        public Paciente() { }

        public Paciente(int dni, string nombre, int dolencia, bool atendido)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.dolencia = (EDolencia)dolencia;
            this.atendido = atendido;
        } 
        public Paciente(int dni, string nombre, EDolencia dolencia, bool atendido)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.dolencia = dolencia;
            this.atendido = atendido;
        }

        public int Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Dolencia { get => int.Parse(dolencia.ToString()); set => dolencia = (EDolencia)value; }
        public bool Atendido { get => atendido; set => atendido = value; }


    }

}
