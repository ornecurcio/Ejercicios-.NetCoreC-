using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Pesos
    {
        private static double cotizRespectoDolar;
        private double cantidad;
        #region Constructores
        static Pesos()
        {
            cotizRespectoDolar = 1 / 66;
        }
        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }
        #endregion
        #region Getters
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }
        #endregion
        public static implicit operator Pesos(double d)
        {
            return new Pesos(d);
        }
        //public static bool operator nombre Tipo()     

        #region Pesos>>>Euro & Pesos>>>Dolar
        public static explicit operator Euro(Pesos d)
        {
            return new Euro(d.cantidad / Euro.GetCotizacion());
        }
        public static explicit operator Dolar(Pesos d)
        {
            //return new Dolar(d.cantidad / Pesos.cotizRespectoDolar);
            //return (Pesos)((Dolar)d);
            return new Dolar(d.cantidad / Pesos.cotizRespectoDolar);
        }
        #endregion
        #region Dolar == Euro
        public static bool operator ==(Pesos d, Euro e)
        {
            if (d.cantidad == ((Pesos)e).GetCantidad())
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Pesos d, Euro e)
        {
            return !(d == e);
        }

        #endregion
        #region Dolar == Pesos
        public static bool operator ==(Pesos d, Dolar e)
        {
            if (d.cantidad == ((Pesos)e).GetCantidad())
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Pesos d, Dolar e)
        {
            return !(d == e);
        }
        #endregion
        #region Pesos == Pesos
        public static bool operator ==(Pesos d, Pesos e)
        {
            if (d.cantidad == e.cantidad)
            {
                return false;
            }
            return true;
        }
        public static bool operator !=(Pesos d, Pesos e)
        {
            return !(d == e);
        }
        #endregion
        #region Sobrecarga -
        public static Pesos operator -(Pesos d, Euro e)
        {
            return new Pesos(d.cantidad - ((Pesos)e).cantidad);
        }
        public static Pesos operator -(Pesos d, Dolar e)
        {
            return new Pesos(d.cantidad - ((Pesos)e).cantidad);
        }
        #endregion
        #region Sobrecarga +
        public static Pesos operator +(Pesos d, Euro e)
        {
            return new Pesos(d.cantidad + ((Pesos)e).cantidad);
        }
        public static Pesos operator +(Pesos d, Pesos e)
        {
            return new Pesos(d.cantidad + ((Pesos)e).cantidad);
        }
        #endregion
    }
}
