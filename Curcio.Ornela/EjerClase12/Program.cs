using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerClase12
{
    class Program
    {
        static void Main(string[] args)
        {
            char rta;
            string numString, rtaString;
            int num;
            int acumulador = 0;
            do
            {
                Console.WriteLine("Ingrese numero");
                numString = Console.ReadLine();
                if (int.TryParse(numString, out num) == true)
                {
                    acumulador = acumulador + num;
                }
                Console.WriteLine("¿Continuar?(S/N)");
                rtaString = Console.ReadLine();
                char.TryParse(rtaString, out rta);        
            } while(ValidarRespuesta.ValidarS_N(rta));
            Console.WriteLine("El resultado de la suma es {0}", acumulador);
            Console.ReadKey(); 
        }
    }
}
