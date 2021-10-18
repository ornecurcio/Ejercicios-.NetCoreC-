using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjerClase13;

namespace EjerClase22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 22";

            NumeroBinario objBinario = "0001";
            NumeroDecimal objDecimal = 8;
            NumeroDecimal sumaResultadoDecimal;
            NumeroBinario sumaResultadoBinario;
            sumaResultadoDecimal = (NumeroDecimal)objBinario + objDecimal;
            sumaResultadoBinario = objBinario + (NumeroBinario)objDecimal;
            Console.WriteLine(Conversor.DecimalBinario(4));
            Console.WriteLine("La suma 1 es: {0}", sumaResultadoDecimal.numero);
            double resta = (NumeroDecimal)objBinario - objDecimal;

            Console.WriteLine("a respecto a b es : {0}", objBinario == objDecimal);
            Console.WriteLine("a+b en binario es : {0}", sumaResultadoBinario.numero);
            Console.WriteLine("a-b en decimal es {0}", resta);

            Console.ReadKey();
        }
    }
}
