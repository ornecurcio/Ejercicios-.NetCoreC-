using System;
using Entidades;

namespace PruebaTorneo
{
    class Program
    {
        static void Main(string[] args)
        {

            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("Basquet");
            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("Futbol");

            EquipoBasquet basquetA = new EquipoBasquet("CSI", DateTime.Today);
            EquipoBasquet basquetB = new EquipoBasquet("Olimpia", DateTime.Now);

            _ = torneoBasquet + basquetA;
            _ = torneoBasquet + basquetB;

            Console.WriteLine(torneoBasquet.Mostrar()); 
        }
    }
}
