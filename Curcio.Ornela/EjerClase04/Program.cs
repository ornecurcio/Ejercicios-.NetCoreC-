using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerClase04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 4";
            double num; 
            double divisor;
            double sumaDivisores;
            int contador = 0;

            for (num = 1; contador < 6; num++)
            {
                sumaDivisores = 0; 
                for (divisor= 1; divisor <= (num/2); divisor ++)
                {

                    if ((num % divisor) == 0)
                    {
                        sumaDivisores += divisor;
                    }
                }
                if (sumaDivisores == num)
                {
                    Console.WriteLine("El numero {0} es perfecto " , num);
                    contador++;
                    Console.WriteLine("El contador es {0} ", contador);
                }
            }
            Console.ReadKey();
        }
    }
}
