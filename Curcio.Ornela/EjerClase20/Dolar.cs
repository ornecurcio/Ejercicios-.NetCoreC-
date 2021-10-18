using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes 
{
    class Dolar
    {
        #region Atributos
        private double cantidad;
        private static double cotizRespectoDolar;
        #endregion

        #region Constructor
        private Dolar()
        {
            Dolar.cotizRespectoDolar = 1; 
        }
        public Dolar(double cantidad)
        {
            this.cantidad = cantidad; 
        }
        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.cantidad * Euro.GetCotizacion());
        }
        public static explicit operator Pesos(Dolar d)
        {
            return new Pesos(d.cantidad * Pesos.GetCotizacion());
        }
        public static implicit operator Dolar(double d)
        {
            return new Dolar(d); 
        }
        #endregion
        #region Metodo
        public double GetCantidad()
        {
            return this.cantidad; 
        }
        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }
        #endregion
        #region Sobrecarga
        public static bool operator ==(Dolar d, Euro e)
        {
            if (d.cantidad == ((Dolar)e).GetCantidad())
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }
        public static bool operator ==(Dolar d, Pesos p)
        {
            if (d.cantidad == ((Dolar)p).GetCantidad())
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(d == p);
        }
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            if (d1.cantidad == d2.cantidad)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }
        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar(d.cantidad - ((Dolar)e).cantidad);
        }
        public static Dolar operator -(Dolar d, Pesos p)
        {
            return new Dolar(d.cantidad - ((Dolar)p).cantidad);
        }
        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar(d.cantidad + ((Dolar)e).cantidad);
        }
        public static Dolar operator +(Dolar d, Pesos p)
        {
            return new Dolar(d.cantidad + ((Dolar)p).cantidad);
        }
        #endregion
    }
}
