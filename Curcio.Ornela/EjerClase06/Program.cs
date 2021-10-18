using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerClase06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 6";
            int year1, year2;
            string numString;
            bool flag = false;

            Console.WriteLine("Año Bisiesto entre rango");
            Console.WriteLine("Ingrese un año de inicio");
            numString = Console.ReadLine();
            while (int.TryParse(numString, out year1) == false || year1 < 1)
            {
                Console.WriteLine("Error, Ingrese un numero mayor a 1");
                numString = Console.ReadLine();
            }
            Console.WriteLine("Ingrese un año de finalizacion");
            numString = Console.ReadLine();
            while (int.TryParse(numString, out year2) == false || year2 < 1 || year2<year1)
            {
                Console.WriteLine("Error, Ingrese un numero mayor a 1");
                numString = Console.ReadLine();
            }
            for (int i = year1; i < year2; i++)
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine("El año {0} es bisiesto", i);
                    flag = true; 
                }
            }
            if (flag == false)
            {
                Console.WriteLine("Sin año bisiesto");
            }
            Console.ReadKey();
        }
    }
}
