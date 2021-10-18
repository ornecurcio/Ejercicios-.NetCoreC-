using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad; 

namespace EjerParaleloSobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear una instancia de 'Cosa'
            Cosa algo = new Cosa();
            //Establecer valor a sus atributos
            algo.EstablecerValor(10);
            algo.EstablecerValor("Cosa 1");
            algo.EstablecerValor(DateTime.Now);
            //Mostrar valores de los atributos
         
            Console.WriteLine(Cosa.Mostrar(algo)); 
               
            Console.ReadKey(); 
        }
    }
}
