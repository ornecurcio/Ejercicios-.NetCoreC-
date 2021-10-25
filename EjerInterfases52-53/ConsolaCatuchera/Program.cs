using System;
using Entidades; 


namespace ConsolaCatuchera
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor colorOriginal = Console.ForegroundColor;

            Lapiz miLapiz = new Lapiz(10);
            Boligrafo miBoligrafo = new Boligrafo(ConsoleColor.Green, 20);

            EscrituraWrapper eLapiz = ((IAcciones)miLapiz).Escribir("Hola");
            Console.ForegroundColor = eLapiz.color;
            Console.WriteLine(eLapiz.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miLapiz);

            EscrituraWrapper eBoligrafo = miBoligrafo.Escribir("Hola");
            Console.ForegroundColor = eBoligrafo.color;
            Console.WriteLine(eBoligrafo.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miBoligrafo);

            Console.WriteLine("----------------------------------------");

            Cartuchera1 cartuchera1 = new Cartuchera1();
            Cartuchera2 cartuchera2 = new Cartuchera2();

            Boligrafo lapicera1 = new Boligrafo(ConsoleColor.Blue, 10);
            Boligrafo lapicera2 = new Boligrafo(ConsoleColor.Green, 15);
            Boligrafo lapicera3 = new Boligrafo(ConsoleColor.Red, 20);

            Lapiz lapiz1 = new Lapiz(10);
            Lapiz lapiz2 = new Lapiz(15);
            Lapiz lapiz3 = new Lapiz(20);
            bool cartu1 = true;
            bool cartu2 = true;

            cartuchera1 += lapicera1;
            cartuchera1 += lapicera2;
            cartuchera1 += lapicera3;
            cartuchera1 += lapiz1;
            cartuchera1 += lapiz2;
            cartuchera1 += lapiz3;

            while (cartu1)
            {
                cartu1 = cartuchera1.ProbarElementos();
            }

            cartuchera2 += lapicera1;
            cartuchera2 += lapicera2;
            cartuchera2 += lapicera3;
            cartuchera2 += lapiz1;
            cartuchera2 += lapiz2;
            cartuchera2 += lapiz3;

            while (cartu2)
            {
                cartu2 = cartuchera2.ProbarElementos();
            }

        }
    }
}
