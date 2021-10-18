using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerClase15
{
    class Calculadora
    {
        public static double Calcular(double num1, double num2, char operacion)
        {
            double resultado=0; 
            if (operacion == '+')
            {
                resultado = num1 + num2; 
            }
            else
            {
                if (operacion == '-')
                {
                    resultado = num1 - num2; 
                }
                else
                {
                    if (operacion == '*')
                    {
                        resultado = num1 * num2; 
                    }
                    else 
                    {
                        if (operacion == '/' && Calculadora.Validar(num2) == true)
                        {
                            resultado = num1 / num2;
                        }
                        else {
                            Console.WriteLine("No existe la division por 0"); 
                        }
                    } 
                        
                }
            }
            return resultado;   
        }
        private static bool Validar(double num2)
        {
            bool esValido = false;
            if (num2 != 0)
            {
                esValido = true; 
            }
            return esValido; 
        }
    }
}
