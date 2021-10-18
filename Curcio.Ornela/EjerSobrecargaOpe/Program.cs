using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades; 

namespace EjerSobrecargaOpe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Numero n1 = new Numero(3);
            //Numero n2 = new Numero(3);
            Numero n1 = 5; // de esta forma queda intuitivo y el new se realiza en otra fase;
            Numero n2 = 3; 

            if (n1 == n2)
            {
                Console.WriteLine("son iguales"); 
            }
            if (n1 != n2)
            {
                Console.WriteLine("son distintos"); 
            }
            if (n1 == 5.0)
            {
                Console.WriteLine("son iguales");
            }
            if (n1 != 5d)
            {
                Console.WriteLine("son distintos");
            }
            Numero res = n1 + n2;
            Console.WriteLine((double)res); 

            Console.ReadKey(); 
        }
    }
}
