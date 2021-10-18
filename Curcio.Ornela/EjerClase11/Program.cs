using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerClase11
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = -100;
            int max = 100;

            Validacion.Validar10Num(min, max);
            Console.ReadKey();
        }
    }
}
