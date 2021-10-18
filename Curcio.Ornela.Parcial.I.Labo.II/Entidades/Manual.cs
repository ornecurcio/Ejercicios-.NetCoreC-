using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Manual : Libro
    {
        public ETipo tipo; 
        
        public Manual(string titulo, string apellido, string nombre, float precio, ETipo tipo)
                      : base(titulo, apellido, nombre, precio)
        {
            this.tipo = tipo; 
        }
        public override bool Equals(object obj)
        {
            bool rta = false;
            if (obj is Manual)
            {
                rta = (Manual)obj == this;
            }
            return rta;
        }
        public static bool operator ==(Manual a, Manual b)
        {
            bool rta = false;
          
                if (a== (Libro)b && a.tipo == b.tipo)
                {
                    rta = true;
                }
          
            return rta;
        }
        
        public static bool operator !=(Manual a, Manual b)
        {
            return !(a == b);
        }
        public static explicit operator Single(Manual m)
        {
            return (Single)m.precio;
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{(string)this}");
            stringBuilder.AppendLine($"{this.tipo}"); 

            return stringBuilder.ToString();
        }
    }
}
