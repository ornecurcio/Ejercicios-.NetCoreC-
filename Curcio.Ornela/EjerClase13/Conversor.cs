using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerClase13
{
    public class Conversor
    {
        public static string DecimalBinario(int num)
        {
            string rta="";
            while (num > 0)
            {
                if (num % 2 == 0)
                {
                    rta = rta+ "0";
                }
                else
                {
                    rta = "1" + rta; 
                }
                num = num / 2;
            }
            return rta;
        }
        public static int BinarioDecimal(string numString)
        {
            double auxPotencias = numString.Length - 1; //las potencias q manejo
            double auxDigito;
            double ret = 0;
            string auxChar;
            foreach (char letra in numString)
            {
                auxChar = letra.ToString();
                double.TryParse(auxChar, out auxDigito);
                ret += (auxDigito * Math.Pow(2, auxPotencias));
                auxPotencias--;
            }
            return (int)ret;
        }
    }
}
