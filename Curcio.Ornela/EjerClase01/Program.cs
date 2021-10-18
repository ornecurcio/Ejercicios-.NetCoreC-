using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerClase01
{
    class Ejercicio_02
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 1";
            int num;
            int acumulador = 0;
            int maximo = 0;
            int minimo = 0;
            float promedio;
            string numString;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero");
                numString = Console.ReadLine();
                while (!int.TryParse(numString, out num))
                {
                    Console.WriteLine("Error, Ingrese un numero");
                    numString = Console.ReadLine();
                }
                if (i == 0)
                {
                    maximo = num;
                    minimo = num;
                }
                if (num > maximo)
                {
                    maximo = num;
                }
                if (num < minimo)
                {
                    minimo = num;
                }
                acumulador += num;
            }
            promedio = acumulador / 5;

            Console.WriteLine("El valor Maximo es: {0:#,#}", maximo);
            Console.WriteLine("El valor Minimo es: {0:#,#}", minimo);
            Console.WriteLine("El valor Promedio es: {0:#,###.00}", promedio);

            Console.ReadKey();

        }
    }
}
