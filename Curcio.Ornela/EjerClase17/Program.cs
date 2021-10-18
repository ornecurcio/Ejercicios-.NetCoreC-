using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerClase17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 17";
            Boligrafo bic = new Boligrafo(100, ConsoleColor.Green);
            Boligrafo paper = new Boligrafo(50, ConsoleColor.Red);
            Boligrafo faberCastell = new Boligrafo(); 

            string pintura1;
            string pintura2;

            // Mostar color y nivel tinta
            Console.WriteLine("El color de faberCastell es " + faberCastell.GetColor());
            Console.WriteLine("El color de bic es "+bic.GetColor());
            Console.WriteLine("El color de paper es "+paper.GetColor());
            Console.WriteLine("El nivel de tinta de bic es "+bic.GetTinta());
            Console.WriteLine("El nivel de tinta de paper es "+paper.GetTinta());

            Console.WriteLine("----------------------");

            // Pintar1
            bic.Pintar(10, out pintura1);
            Console.WriteLine("El nuevo nivel de tinta de bic es "+bic.GetTinta());
            bic.Pintar(35, out pintura1);
            Console.WriteLine("El nuevo nivel de tinta de bic es " + bic.GetTinta());
            Console.WriteLine("-----------------------");

            paper.Pintar(60, out pintura2);
            Console.WriteLine("El nuevo nivel de tinta de paper es " + paper.GetTinta()); // #0

            Console.WriteLine("-----------------------");

            paper.Pintar(15, out pintura2); // No puede no hay mas
            Console.WriteLine("El nivel de tinta de paper es " + paper.GetTinta());

            Console.WriteLine("-----------------------");
            paper.Recargar();
            Console.WriteLine("El nuevo nivel de tinta de paper es " + paper.GetTinta());


            Console.ReadKey(true);

        }
    }
}
