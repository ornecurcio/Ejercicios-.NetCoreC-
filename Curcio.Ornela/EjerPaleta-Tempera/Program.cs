using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escritura;


namespace EjerPaleta_Tempera
{
    class Program
    {
        static void Main(string[] args)
        {

            Tempera t1 = new Tempera(ConsoleColor.Red, "Alba", 15);
            Tempera t2 = new Tempera(ConsoleColor.White, "Faber", 50);
            Tempera t3 = new Tempera(ConsoleColor.Blue, "Faber", 18);
            Tempera t4 = new Tempera(ConsoleColor.Red, "Alba", 45);
            Tempera t5 = new Tempera(ConsoleColor.Green, "Alba", 60);
            Tempera t6 = new Tempera(ConsoleColor.Green, "Alba", 15);

            //if (t1 == t4)
            //{
            //    Console.WriteLine("Temperas iguales");
            //    Console.WriteLine($"{Tempera.Mostrar(t1)}{Tempera.Mostrar(t4)}");
            //}

            //if (t1 != t2)
            //{
            //    Console.WriteLine("Temperas distintas");
            //    Console.WriteLine($"{Tempera.Mostrar(t1)}{Tempera.Mostrar(t4)}");
            //}

            ////comparo contra null

            //if (null != t2) //// ESTO NO ANDA
            //{
            //    Console.WriteLine("Distinto de Null");
            //    Console.WriteLine(Tempera.Mostrar(t2));
            //}
            //if (t1 != null)
            //{
            //    Console.WriteLine("Distinto de Null");
            //    Console.WriteLine(Tempera.Mostrar(t1));
            //}
            //t1 += t2;
            //Console.WriteLine("Temperas distintas suma");
            //Console.WriteLine(Tempera.Mostrar(t1));
            //t1 += t4;
            //Console.WriteLine("Temperas == suma");
            //Console.WriteLine(Tempera.Mostrar(t2));

            Paleta paleta = 3;
            Paleta paleta2 = 2;

            paleta += t1;

            //verifico el buen funcionamiento del Mostrar.
            Console.WriteLine((string)paleta);
            Console.WriteLine((string)paleta2);
            paleta += t2;
            paleta += t3;

            Console.WriteLine($"Paleta1: {(string)paleta}");

            paleta += t4; // agrego un color que ya hay. 
            Console.WriteLine($"Paleta1: {(string)paleta}");

            paleta2 += t5;
            paleta2 += t3;
            paleta2 += t2; // sobrecargo la paleta 
            Console.WriteLine($"Paleta2: {(string)paleta2}");
            paleta2 -= t6; // resto 
            Console.WriteLine((string)paleta2);
            paleta2 += t6;

            Paleta paleta3 = paleta + paleta2;
            Console.WriteLine($"Paleta3: {(string)paleta}");
            Console.ReadLine();
        }
    }
}
