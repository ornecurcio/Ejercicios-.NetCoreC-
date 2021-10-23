using System;
using Entidades;

namespace PruebaTorneo
{
    class Program
    {
        static void Main(string[] args)
        {

            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("torneo de Basquet");
            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("torneo de Futbol");
            ​
            EquipoBasquet bsquet1 = new EquipoBasquet("basquet1", DateTime.Now);
            EquipoBasquet bsquet2 = new EquipoBasquet("basquet2", DateTime.Now);
            EquipoBasquet bsquet3 = new EquipoBasquet("basquet3", DateTime.Now);
​
            EquipoFutbol futbol1 = new EquipoFutbol("futbol1", DateTime.Now);
            EquipoFutbol futbol2 = new EquipoFutbol("futbol2", DateTime.Now);
            EquipoFutbol futbol3 = new EquipoFutbol("futbol3", DateTime.Now);
​
            _ = torneoBasquet + bsquet1;
            _ = torneoBasquet + bsquet2;
            _ = torneoBasquet + bsquet3;
​
         
​
            _ = torneoFutbol + futbol1;
            _ = torneoFutbol + futbol2;
            _ = torneoFutbol + futbol3;
            Console.WriteLine(torneoBasquet.Mostrar());
            Console.WriteLine("------------------------");
​
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine("------------------------");
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);
        }
    }
}
