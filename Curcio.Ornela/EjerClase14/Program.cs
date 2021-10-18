using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerClase14
{
    class Program
    {
        static void Main(string[] args)
        {
            double radio = 10;
            double lado = 15;
            double altura = 8;

            Console.WriteLine("El area del Circulo es: {0:.00} cm2", CalculoDeArea.CalcularCirculo(radio));
            Console.WriteLine("El area del Cuadrado es: {0:.00} cm2", CalculoDeArea.CalcularCuadrado(lado));
            Console.WriteLine("El area del Triangulo es: {0:.00} cm2", CalculoDeArea.CalcularTriangulo(lado, altura));

            Console.ReadKey(); 
        }
    }
}
