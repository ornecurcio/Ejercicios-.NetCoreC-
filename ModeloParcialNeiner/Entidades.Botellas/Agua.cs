using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Botellas
{
    public class Agua:Botella
    {
        public TipoAgua tipo; 

        public override double Ganancia 
        {
            get
            {
                if (this.precio > 0)
                {
                    return precio + (precio * 25 / 100);
                }
                else
                {
                    return 0; 
                }
            } 
        }

        public Agua(string marca, double precio, int capacidad, TipoAgua tipo):
                    base(marca, precio, capacidad)
        {
            this.tipo = tipo; 
        }
        public Agua(string marca, double precio, TipoAgua tipo) :
                    this(marca, precio, 500, tipo)
        {
        }
        public override bool Equals(object obj)
        {
            bool rta = false;
            if (obj is Agua)
            {
                rta = (Agua)obj == this;
            }
            return rta;
        }
        public static bool operator ==(Agua a, Agua b)
        {
            bool rta = false; 
            if (a is not null && b is not null &&
                a == (Botella)b && a.tipo == b.tipo)
            {
                rta = true; 
            }
            return rta; 
        }
        public static bool operator !=(Agua a, Agua b)
        {
            return !(a == b); 
        }
        protected override void ServirMedida()
        {
            this.contenido = 0; 
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"Agua tipo {this.tipo}, ");
            stringBuilder.Append(base.ToString()); 
            
            return stringBuilder.ToString();
        }

    }
}
