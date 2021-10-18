using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjerClase12; 

namespace EjerClase15
{
    class Program
    {
        static void Main(string[] args)
        {
            char rta;
            double num1, num2, resultado;
            char operador; 
            do
            {
                Console.WriteLine("Ingrese 1°numero");
                while (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Error, ingrese 1°numero");
                }
                Console.WriteLine("Ingrese 2°numero");
                while (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Error, ingrese 2°numero");
                }
                Console.WriteLine("Ingrese operador: +, -, *, /");
                while (!char.TryParse(Console.ReadLine(), out operador) 
                    || operador != '+' && operador != '-' 
                    && operador != '*' && operador != '/') 
                {
                    Console.WriteLine("Ingrese operador: +, -, *, /");
                }
                resultado=Calculadora.Calcular(num1, num2, operador);
                Console.WriteLine("{0}", resultado); 
                Console.WriteLine("Desea continuar S/N");
                char.TryParse(Console.ReadLine(), out rta); 
            } while (ValidarRespuesta.ValidarS_N(rta));
        }
    }
}
