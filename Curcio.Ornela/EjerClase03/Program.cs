using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerClase03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 3";
            int num; 
            string numString;

            Console.WriteLine("Ingrese un numero");
            numString = Console.ReadLine();
            while (int.TryParse(numString, out num)==false || num<=0)
            {
                Console.WriteLine("Error, Ingrese un numero");
                numString = Console.ReadLine();
            }
            for (int i = 2; i < num; i++)
            {
                int divisor = 0; 
           
                for (int j = 2; j < i+1 ; j++)
                {
                   
                    if (i % j == 0)
                    {
                        divisor++; 
                    }
                }
                if(divisor==1)
                {
                    Console.WriteLine("{0:#,#}", i);
                }
           
            }


            Console.ReadKey();

        }
    }
}
