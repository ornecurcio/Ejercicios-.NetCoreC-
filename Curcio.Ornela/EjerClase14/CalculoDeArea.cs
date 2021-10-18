using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerClase14
{
    class CalculoDeArea
    {
        public static double CalcularCuadrado(double lado)
        {
            double resultado = lado * lado; 
            return resultado; 
        }
        public static double CalcularTriangulo(double lado, double altura)
        {
            double resultado = (lado * altura) / 2; 
            return resultado; 
        }
        public static double CalcularCirculo(double radio)
        {
            double resultado = Math.PI * Math.Pow(radio,2); 
            return resultado; 
        }
    }
}
