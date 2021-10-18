using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Novela:Libro
    {
        public EGenero genero;

        public Novela(string titulo, float precio, Autor autor, EGenero genero)
            :base(titulo, precio, autor)
        {
            this.genero = genero;
        }
       
        public override bool Equals(object obj)
        {
            bool rta = false;
            if (obj is Novela)
            {
                rta = (Novela)obj == this;
            }
            return rta;
        }
        public static bool operator ==(Novela a, Novela b)
        {
            bool rta = false;

            if (a == (Libro)b && a.genero == b.genero)
            {
                rta = true;
            }

            return rta;
        }

        public static bool operator !=(Novela a, Novela b)
        {
            return !(a == b);
        }
        public static implicit operator Single(Novela n)
        {
            return (Single)n.precio;
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{(string)this}");
            stringBuilder.AppendLine($"{this.genero}");

            return stringBuilder.ToString();
        }
    }
}
