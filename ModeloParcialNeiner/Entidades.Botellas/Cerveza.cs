using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Botellas
{
    public class Cerveza:Botella
    {
        public TipoCerveza tipo;
        public int medida; 

        public override double Ganancia
        {
            get
            {
                if (this.precio > 0)
                {
                    return precio + (precio * 50 / 100);
                }
                else
                {
                    return 0;
                }
            }
        }

        public Cerveza(string marca, double precio, int capacidad, TipoCerveza tipo, int medida) :
                    base(marca, precio, capacidad)
        {
            this.marca = marca;
            this.precio = precio;
            this.capacidad = capacidad;
            this.contenido = capacidad;
            this.tipo = tipo;
            this.medida = medida; 
        }
        public Cerveza(string marca, double precio,int capacidad, TipoCerveza tipo) : 
            this(marca, precio, capacidad, tipo, capacidad/ 3) 
        { 
        }
        public override bool Equals(object obj)
        {
            bool rta = false;
            if (obj is Cerveza)
            {
                rta = (Cerveza)obj == this;
            }
            return rta;
        }
        public static bool operator ==(Cerveza a, Cerveza b)
        {
            bool rta = false;
            if (a is not null && b is not null &&
                a == (Botella)b && a.tipo == b.tipo)
            {
                rta = true;
            }
            return rta;
        }
        public static bool operator !=(Cerveza a, Cerveza b)
        {
            return !(a == b);
        }
        protected override void ServirMedida()
        {
            if (this.contenido > this.medida)
            {
                this.contenido = this.contenido - medida;
            }
            else 
            {
                this.contenido = 0; 
            }
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"Cerveza tipo {this.tipo}, ");
            stringBuilder.Append(base.ToString());

            return stringBuilder.ToString();
        }
    }
}
