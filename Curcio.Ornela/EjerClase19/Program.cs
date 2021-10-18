using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerClase19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio - 18";

            Sumador operacion = new Sumador(10);
            Sumador operacion2 = new Sumador(12);

            long rta = operacion.Sumar(3, 5);
            string rta1 = operacion.Sumar("oracion 1, ", "oracion 2");

            Console.WriteLine("{0}", rta);
            Console.WriteLine(rta1);

            long longSum = operacion.Sumar(10, 15);
            string stringSum = operacion.Sumar("10", "15");
            //Console.WriteLine($"Long: {longSum} - String: {stringSum}.");
            Console.WriteLine("La suma es {0} y el string es {1}", longSum, stringSum);
            Console.WriteLine("El sumador 1 es{0}",(int)operacion);

            int amount = (int)operacion2;
            //Console.WriteLine($"Explicit cast: {amount}.");
            Console.WriteLine("El sumador 2 es{0}", amount);

            long overloadSum = operacion + operacion2;
            bool overloadEquals = operacion | operacion2;
            Console.WriteLine($"Suma de sumadores: {overloadSum} - Igualdad entre sumador: {overloadEquals}.");
            Console.ReadKey(); 
        }
    }
}
