using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes; 

namespace PruebaCotizacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 20"; 
            Dolar cliente1 = 5;
            Dolar cliente4 = 1;
            Pesos cliente2 = 600;
            Pesos cliente5 = 66;
            Euro cliente3 = 12;

            Dolar transaccion1 = cliente1 + cliente2;//5$+(600AR$/66) = 14.09$
            Console.WriteLine("transaccion1 Dolares = {0}", transaccion1.GetCantidad());
            Dolar transaccion2 = cliente1 + cliente3;//5$+(12€/1.08) =16.1$
            Console.WriteLine("transaccion2 Dolares= {0}", transaccion2.GetCantidad());
            Dolar transaccion3 = (cliente1 + cliente3) - cliente2;//5$+(12€/1.08)-(600AR$/66)=7.02$
            Console.WriteLine("transaccion3  Dolares = {0}", transaccion3.GetCantidad());
            Dolar transaccion4 = (Dolar)cliente2 - cliente3;//(600/66)-(12€/1.08) =-2.02 $
            Console.WriteLine("transaccion4 Pesos= {0}", transaccion4.GetCantidad());
            bool esIgual = (cliente4 == cliente5);
            //if(esIgual = cliente4== cliente5)
            Console.WriteLine("transaccion5 = {0}", esIgual);
        }
    }
}
