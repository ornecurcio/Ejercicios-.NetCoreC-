using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerClase29
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo = new Equipo(3, "utn");
            Jugador j1 = new Jugador(123, "nom1", 5, 20);
            Jugador j2 = new Jugador(485, "nom2", 3, 5);
            Jugador j3 = new Jugador(123, "nom3", 7, 3);
            Jugador j4 = new Jugador(789, "nom4", 3, 5);
            DirectorTecnico dt1 = new DirectorTecnico("Mostaza", DateTime.Parse("12-09-83"));
            DirectorTecnico dt2 = new DirectorTecnico("Mostaza", DateTime.Parse("12-09-83"));
            DirectorTecnico dt3 = new DirectorTecnico("Batistuta", DateTime.Now);  

            if (equipo + j1)
                Console.WriteLine(j1.MostrarDatos());

            if (equipo + j2)
                Console.WriteLine(j2.MostrarDatos());

            if (equipo + j3)
                Console.WriteLine(j3.MostrarDatos());
            else
                Console.WriteLine("NO SE AGREGO " + j3.MostrarDatos());

            if (equipo + j4)
                Console.WriteLine(j4.MostrarDatos());
            else
                Console.WriteLine("NO SE AGREGO " + j4.MostrarDatos());

            if (dt1 == dt2)
            {
                Console.WriteLine("Los directores tecnicos son iguales"); 
                Console.WriteLine(dt1.MostrarDatos());
            }
            if (dt2 != dt3)
            {
                Console.WriteLine("Los directores tecnicos son distintos");
                Console.WriteLine(dt2.MostrarDatos());
                Console.WriteLine(dt3.MostrarDatos());
            }
            Console.ReadKey(); 
        }
    }
}
