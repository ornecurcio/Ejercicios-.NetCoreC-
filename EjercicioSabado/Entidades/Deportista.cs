using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Deportista
    {
        private string nombreApellido;
        private int edad;
        private int cantidadPartidos;

        public string NombreApellido { get { return nombreApellido; } }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public int CantidadPartidos
        {
            get { return cantidadPartidos; }
            set { cantidadPartidos = value; }
        }

        protected Deportista(string nombApe, int edad, int cantPart)
        {
            this.nombreApellido = nombApe;
            this.edad = edad;
            this.cantidadPartidos = cantPart;
        }


    }
}
