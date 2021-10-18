using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerClase05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 5";
            int num;
            int sumaSig;
            int sumaPrev;
            int sumaTot; 
            string numString;
            bool flag = false; 

            Console.WriteLine("Ingrese un numero positivo mayor a 1");
            numString = Console.ReadLine();
            while (int.TryParse(numString, out num) == false || num < 1)
            {
                Console.WriteLine("Error, Ingrese un numero mayor a 1");
                numString = Console.ReadLine();
            }

            for (int i = 2; i < num; i++)
            {
                sumaSig = i + 1;
                sumaPrev = 0;
                sumaTot = 0; 
                for (int j= i-1; j>0; j--)
                {
                    sumaPrev += j; 
                }
                while (sumaTot <= sumaPrev)
                {
                    sumaTot += sumaSig;
                    if (sumaTot == sumaPrev)
                    {
                        Console.WriteLine("Centro encontrado: {0}", i);
                        flag = true;
                    }
                    sumaSig += 1; 
                }
            }
            if (flag==false)
            {
                Console.WriteLine("Sin centros numéricos");
            }
            Console.ReadKey();
        }
    }
}
