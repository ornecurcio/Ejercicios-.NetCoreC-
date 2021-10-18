using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerClase07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 7";
            int day;
            string numString; 
            DateTime fechaNac;
            DateTime now; 
            
            Console.WriteLine("Ingrese fecha de nacimiento");
            numString = Console.ReadLine();
            while (DateTime.TryParse(numString, out fechaNac) == false)
            {
                Console.WriteLine("Error, Ingrese un numero de 1 a 31");
                numString = Console.ReadLine();
            }
            Console.WriteLine("Fecha de nacimiento es: {0:dd/MM/yy}", fechaNac);
            now = DateTime.Now;
            TimeSpan difFecha = now - fechaNac;
            day = difFecha.Days; 

            Console.WriteLine("Llevas {0} de dias vividos, ve por mas!", day);
            /* Console.WriteLine("Ingrese mes de nacimiento (1-12)");
             numString = Console.ReadLine();
             while (int.TryParse(numString, out month) == false || month < 1 && month > 12)
             {
                 Console.WriteLine("Error, Ingrese un numero de 1 a 12");
                 numString = Console.ReadLine();
             }
             Console.WriteLine("Ingrese año de nacimiento (1930-2015)");
             numString = Console.ReadLine();
             while (int.TryParse(numString, out year) == false || year < 1930 && year > 2015)
             {
                 Console.WriteLine("Error, Ingrese un numero de 1930 a 2015");
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
            */
            Console.ReadKey();
        }
    }
}
