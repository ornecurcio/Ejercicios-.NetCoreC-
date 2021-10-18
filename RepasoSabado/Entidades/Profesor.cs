using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor : Persona
    {
        protected int antigueadad;
        protected bool esDocente;
        protected float sueldo;

        public Profesor() : this("sin nombre", 0, 00, false, 0, 0)
        { }

        public Profesor(string nombre, int id, int dni, bool asistir, int antiguedad, float sueldo) 
                 : base(nombre, id, dni, asistir)
        {
            this.antigueadad = antigueadad;
            this.sueldo = sueldo; 
        }

        public int Antiguedad
        {
            get
            {
                return this.antigueadad;
            }
            set
            {
                if (value > 0 && value < 60)
                {
                    this.antigueadad = value;
                }
            }
        }
        protected override void PrepararParcial()
        {
            
        }

        protected float CalcularSueldo()
        {
            float aux = 0; 
            foreach (Materia item in this.materias)
            {
                aux += item.CargaHoraria; 
            }
            return aux; 
        }
    }
}
