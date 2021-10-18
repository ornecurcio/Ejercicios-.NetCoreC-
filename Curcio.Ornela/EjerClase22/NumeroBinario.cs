using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjerClase13; 

namespace EjerClase22
{
    class NumeroBinario
    {
        public string numero;

        private NumeroBinario(string numero)
        {
            this.numero = numero; 
        }
        public static implicit operator NumeroBinario(string n)
        {
            return new NumeroBinario(n); //NumeroBinario= "1001";
        }
        public static implicit operator string(NumeroBinario nB)
        {
            return nB.numero;
        }
        public static explicit operator NumeroBinario(NumeroDecimal d)
        {
            return new NumeroBinario(Conversor.DecimalBinario((int)d));
        }
        public static string operator +(NumeroBinario b, NumeroDecimal d)
        {
            string rta;
            // binario a decimal. sumar decimales y eso parcearlo a binario de nuevo.  
            double bin = Conversor.BinarioDecimal(b);
            bin = bin + d;
            rta = Conversor.DecimalBinario((int)bin); 
            return rta; 
        }
        public static string operator -(NumeroBinario b, NumeroDecimal d)
        {
            string rta;
            // binario a decimal. restar decimales y eso parcearlo a binario de nuevo.  
            double bin = Conversor.BinarioDecimal(b);
            bin = bin - d;
            rta = Conversor.DecimalBinario((int)bin);
            return rta;
        }
        public static bool operator ==(NumeroBinario b, NumeroDecimal d)
        {
            // pasar decimal a binario 
            string bin = Conversor.DecimalBinario((int)d);
            return (bin == b); 
        }
        public static bool operator !=(NumeroBinario b, NumeroDecimal d)
        {
            return !(b == d);
        }

    }
}
