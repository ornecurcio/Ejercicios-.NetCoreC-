using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Torneo
    {
        private static Equipo campeon;
        private static List<Fecha> fixture;
        private static List<Equipo> listaEquipos;
        private static string nombreTorneo; 

        public static List<Equipo> ListaEquipos 
        { 
            get
            {
                return Torneo.listaEquipos; 
            }
            set
            {
                if(value is not null)
                {
                    listaEquipos = value; 
                }
            }
        }

        static Torneo()
        {
            Torneo.nombreTorneo = "Copa Angular"; 
            fixture = new List<Fecha>();
            listaEquipos = new List<Equipo>();
            CargarEquipos();
            CargarPartidos(); 
        }
        private static void CargarEquipos()
        {
            //foreach (Equipo item in listaEquipos)
            //{
            //    listaEquipos.Add(item); 
            //}
            listaEquipos.Add(new Equipo("CSI", 
                             new Entrenador("Pacu",37,100,5,false), 
                             new List<Jugador> { new Jugador("Leduc", 38, 150, EPuesto.Delantero),
                                                 new Jugador("Garcia", 28, 50, EPuesto.Arquero),
                                                 new Jugador("Perez", 25, 150, EPuesto.Defensor),
                                                 new Jugador("Rodriguez", 38, 150, EPuesto.Defensor),
                                                 new Jugador("Bayon", 38, 100, EPuesto.Delantero),})
                             );
            listaEquipos.Add(new Equipo("PFC",
                             new Entrenador("Pichu", 37, 100, 5, false),
                             new List<Jugador> { new Jugador("Suarez", 38, 150, EPuesto.Delantero),
                                                 new Jugador("Gimenez ", 28, 50, EPuesto.Arquero),
                                                 new Jugador("Barbuto", 38, 150, EPuesto.Defensor),
                                                 new Jugador("Briceño", 38, 150, EPuesto.Defensor),
                                                 new Jugador("Neimar", 38, 150, EPuesto.Delantero),})
                             );

        }
        private static void CargarPartidos()
        {
            //foreach (Fecha item in fixture)
            //{
            //    fixture.Add(item);
            //}
            //fixture.Add(new Fecha()
        }
        public static void JugarPartido(int nroFecha)
        {
            foreach (Fecha item in fixture)
            {
               if(item.Id==nroFecha)
                {
                    foreach (Partido auxItem in item.Partidos)
                    {
                        auxItem.SimularPartido(); 
                    }
                    break; 
                }
            }
        }

    }
}
