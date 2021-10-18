using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escritura; 

namespace EjerTinta_Pluma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Pluma y Tinta"; 

            Tinta tinta1 = new Tinta(ConsoleColor.Red, ETipoTintas.ConBrillito);
            Tinta tinta2 = new Tinta(ConsoleColor.DarkGreen);

            Pluma pluma1 = new Pluma("Bic",tinta2,100);
            Pluma pluma2 = new Pluma("Filgo", tinta1, 50);
            //Pluma pluma3 = new Pluma(); 
            Console.WriteLine(Tinta.Mostrar(tinta1));
            Console.WriteLine(Tinta.Mostrar(tinta2));
            Console.WriteLine(pluma1);
            Console.WriteLine(pluma2);
           // Console.WriteLine((string)pluma3);

            pluma2 = pluma2 + tinta1;
            Console.WriteLine(pluma2);
            //pluma3 -= tinta2;
            //Console.WriteLine((string)pluma3);
            pluma1 += tinta1;
            Console.WriteLine(pluma1);
            pluma1 = pluma1 + tinta2;  
            Console.WriteLine(pluma1);

            pluma2-=tinta2;
            Console.WriteLine((string)pluma2);
            pluma2-=tinta1; 
            Console.WriteLine((string)pluma2);

            Console.ReadKey(); 
        }
    }
}
