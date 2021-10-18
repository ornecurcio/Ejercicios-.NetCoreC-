using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerClase02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 2";
            int num;
            double cuadrado;
            double cubo;  
            string numString;
           
                Console.WriteLine("Ingrese un numero");
                numString = Console.ReadLine();
                while (int.TryParse(numString, out num)==false || num<=0)
                {
                    Console.WriteLine("Error, Ingrese un numero mayor a cero");
                    numString = Console.ReadLine();
                }
                cuadrado = Math.Pow(num, 2);
                cubo = Math.Pow(num, 3); 

            Console.WriteLine("El valor del numero es: {0:#,#}", num);
            Console.WriteLine("El valor de {0} al cuadrado es: {1:#,#}", num, cuadrado);
            Console.WriteLine("El valor de {0} al cubo es: {1:#,#}", num, cubo);

            Console.ReadKey(); 

        }
    }
}
