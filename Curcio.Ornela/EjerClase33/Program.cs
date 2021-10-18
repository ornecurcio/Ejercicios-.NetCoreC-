using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerClase33
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro = new Libro();
            libro[0] = "Jon I";
            libro[1] = "Daenerys II";
            libro[5] = "Winter is comming V"; 
            for (int i = 0; i < libro.TotalPaginas(); i++)
            {
                Console.WriteLine($"La pagina {i}, titulo {libro[i]}");
            }
            Console.WriteLine("--------------------------------------"); 
            libro[1] = "Tyrion III";
            for (int i = 0; i < libro.TotalPaginas(); i++)
            {
                Console.WriteLine($"La pagina {i}, titulo {libro[i]}");
            }

            Console.ReadKey(); 

        }
    }
}
