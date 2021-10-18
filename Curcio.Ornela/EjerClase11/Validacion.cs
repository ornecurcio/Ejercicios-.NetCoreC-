using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerClase11
{
    public class Validacion
    {
        private static bool Validar(int valor, int min, int max)
        {
            bool numValido = false;
            if (valor >= min && valor <= max)
            {
                numValido = true;
            }
            return numValido;
        }
        public static void Validar10Num(int min, int max)
        {
            int minimo = int.MaxValue;
            int maximo = int.MinValue;
            string numString; 
            int contador = 0;
            int acumulador = 0;
            float promedio;  
            do
            {
                Console.Write("Ingrese el {0}° numero: ", contador + 1);
                numString = Console.ReadLine(); 
                if (int.TryParse(numString, out int valorNum) == true)
                {
                    if (Validar(valorNum, min, max))
                    {
                        if (contador == 0 || valorNum < minimo)
                        {
                            minimo = valorNum;

                        }
                        else
                        {
                            if (contador == 0 || valorNum > maximo)
                            {
                                maximo = valorNum;
                            }
                        }
                        contador++;
                        acumulador +=(valorNum);
                    }
                    else
                    {
                        Console.WriteLine("Error! El numero {0} esta fuera del rango. Ingrese numero entre {1} y {2}", valorNum, min, max);
                    }
                }
                else {
                    Console.WriteLine("Error! El numero {0} no es un numero, verifique el ingreso", numString); 
                }
            } while (contador < 4);
            
            promedio = acumulador / contador;
            
            Console.WriteLine("Numero Minimo: {0}.\nNumero Maximo: {1}.\nPromedio: {2:.00}", minimo, maximo, promedio);
        }
    }
}
