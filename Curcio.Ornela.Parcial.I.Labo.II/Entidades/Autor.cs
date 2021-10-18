using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Autor
    {
        private string apellido;
        private string nombre;

        public Autor(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido; 
        }
        public static implicit operator string(Autor a)
        {
            return a.nombre + a.apellido;        
        }
        public static bool operator ==(Autor a, Autor b)
        {
            bool rta = false;
            if (a is null && b is null)
            {
                rta = true;
            }
            else
            {
                if (!(a is null && b is null) &&
                    a.nombre == b.nombre && a.apellido == b.apellido)
                {
                    rta = true;
                }
            }
            return rta;
        }
        public static bool operator !=(Autor a, Autor b)
        {
            return !(a == b);
        }
    }
}
