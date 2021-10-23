using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cocina
    {
        private int codigo;
        private bool esIndustrial;
        private double precio; 

        public int Codigo
        {
            get
            {
                return this.codigo; 
            }
        }
        public bool EsIndustrial
        {
            get
            {
                return this.esIndustrial; 
            }
        }
        public double Precio
        {
            get 
            {
                return this.precio; 
            }
        }
        public Cocina(int codigo, double precio, bool esIndustrial)
        {
            this.codigo = codigo;
            this.precio = precio;
            this.esIndustrial = esIndustrial; 
        }
        public static bool operator ==(Cocina a, Cocina b)
        {
            bool rta = false;
            if (a is not null && b is not null &&
               a.codigo == b.codigo && a.precio == b.precio && 
               a.esIndustrial == b.esIndustrial)
            {
                rta = true;
            }
            return rta;
        }
        public static bool operator !=(Cocina a, Cocina b)
        {
            return !(a == b);
        }
        public override bool Equals(object obj)
        {
            bool rta = false;
            if (obj is Cocina)
            {
                rta = (Cocina)obj == this;
            }
            return rta;
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"Codigo: {this.codigo} - Precio: {this.precio} - : Es indrustrial? {this.esIndustrial}");

            return stringBuilder.ToString();
        }
    }
}
