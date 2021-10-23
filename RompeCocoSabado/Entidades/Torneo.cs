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
            fixture = new List<Fecha>();
            listaEquipos = new List<Equipo>(); 
        }
        private static void CargarEquipos()
        {
            foreach (Equipo item in listaEquipos)
            {
                listaEquipos.Add(item); 
            }
            //listaEquipos.Add(new Equipo("", new Entrenador("",0,0,0,false), new List<Jugador>())); 
        }
        private static void CargarPartidos()
        {
            foreach (Fecha item in fixture)
            {
                fixture.Add(item);
            }
            //fixture.Add(new Fecha(0,new Partido()))
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
                }
            }
        }

    }
}
