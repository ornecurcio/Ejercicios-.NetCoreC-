using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        int anioIngreso;

        public Alumno():this("Sin nombre", 0, 00, false, DateTime.Now.Year)
        { }
        public Alumno(string nombre, int id, int dni, bool asistir, int añoIngreso) 
               : base(nombre, id, dni, asistir)
        {
            this.anioIngreso = anioIngreso; 
        }

        public int AnioIngreso
        {
            get
            {
                return this.anioIngreso;
            }
            set
            {
                if (value > 1960 && value < 2021)
                {
                    this.anioIngreso = value;
                }
            }
        }
        protected override void PrepararParcial()
        {
        }
    }
}
