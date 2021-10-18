using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjerClase13; 

namespace EjerClase22
{
    class NumeroDecimal
    {
        #region Atributo
        public double numero;
        #endregion
        #region Constructor
        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }
        #endregion
        #region Sobrecarga
        public static implicit operator double(NumeroDecimal d)
        {
            return d.numero;
        }
        public static explicit operator NumeroDecimal(NumeroBinario b)
        {
            return new NumeroDecimal(Conversor.BinarioDecimal(b));
        }
        public static implicit operator NumeroDecimal(double number)
        {
            return new NumeroDecimal(number);
        }
       
        public static double operator +(NumeroDecimal d, NumeroBinario b)
        {
            // binario a decimal. sumar decimales y eso parcearlo a binario de nuevo.  
            double bin = Conversor.BinarioDecimal(b);
            double rta = bin + d;
            return rta;
        }
        public static double operator -(NumeroDecimal d, NumeroBinario b)
        {
            // binario a decimal. sumar decimales y eso parcearlo a binario de nuevo.  
            double bin = Conversor.BinarioDecimal(b);
            double rta = d-bin;
            return rta;
        }
        public static bool operator ==(NumeroDecimal d, NumeroBinario b)
        {
            //pasar decimal a binario
            string dec = Conversor.DecimalBinario((int)d);
            return d == b; 
        }
        public static bool operator !=(NumeroDecimal d, NumeroBinario b)
        {
            return !(d == b);
        }
        #endregion
    }
}
