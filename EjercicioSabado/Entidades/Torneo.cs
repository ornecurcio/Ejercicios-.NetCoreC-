using System.Collections.Generic;
using System.Linq;

namespace Entidades
{
    public static class Torneo
    {
        static string nombreTorneo;
        static Equipo campeon;
        static List<Equipo> listaEquipos;
        static List<Fecha> fixture;

        public static List<Equipo> ListaEquipos { get { return listaEquipos; } set { listaEquipos = value; } }

        static Torneo()
        {
            listaEquipos = new List<Equipo>();
            fixture = new List<Fecha>();
            CargarEquipos();
            CargarPartidos();
        }

        private static void CargarEquipos()
        {
            listaEquipos.Add(new Equipo("Los tutuques",
                                         new Entrenador("Pepe Peposo",
                                                         55,
                                                         200,
                                                         1,
                                                         true),
                                         new List<Jugador>()
                                         {
                                             new Jugador("Romeo Gatuso",
                                                         20,
                                                         10,
                                                         EPuesto.Arquero),
                                             new Jugador("Carola Perrosa",
                                                         23,
                                                         15,
                                                         EPuesto.Defensor),
                                             new Jugador("Jazmin Perrosa",
                                                        33,
                                                        3,
                                                         EPuesto.Defensor),
                                             new Jugador("Juana Canina",
                                                         21,
                                                         11,
                                                         EPuesto.Delantero),
                                             new Jugador("Chimichurri Bizcocho",
                                                         25,
                                                         10,
                                                         EPuesto.Delantero)
                                         }));

            listaEquipos.Add(new Equipo("Los Avengers",
                                         new Entrenador("Nick Fury",
                                                         45,
                                                         455,
                                                         5,
                                                         true),
                                         new List<Jugador>()
                                         {
                                             new Jugador("Tony Stark",
                                                         20,
                                                         10,
                                                         EPuesto.Arquero),
                                             new Jugador("Thor",
                                                         23,
                                                         15,
                                                         EPuesto.Defensor),
                                             new Jugador("Bruce Banner",
                                                        33,
                                                        3,
                                                         EPuesto.Defensor),
                                             new Jugador("Black Widow",
                                                         21,
                                                         11,
                                                         EPuesto.Delantero),
                                             new Jugador("Capitan America",
                                                         25,
                                                         10,
                                                         EPuesto.Delantero)
                                         }));
            listaEquipos.Add(new Equipo("Los tranquilos",
                                         new Entrenador("Doctor Bruno",
                                                         60,
                                                         11,
                                                         1,
                                                         false),
                                         new List<Jugador>()
                                         {
                                             new Jugador("Horacio Pagani",
                                                         20,
                                                         10,
                                                         EPuesto.Arquero),
                                             new Jugador("Tano Pasman",
                                                         23,
                                                         15,
                                                         EPuesto.Defensor),
                                             new Jugador("Alejandro Fantino",
                                                        33,
                                                        3,
                                                         EPuesto.Defensor),
                                             new Jugador("El de las empanadas",
                                                         21,
                                                         11,
                                                         EPuesto.Delantero),
                                             new Jugador("El atiendo bolu2",
                                                         25,
                                                         10,
                                                         EPuesto.Delantero)
                                         }));

            listaEquipos.Add(new Equipo("Las tortus",
                                         new Entrenador("El maestro Splinter",
                                                         60,
                                                         200,
                                                         1,
                                                         true),
                                         new List<Jugador>()
                                         {
                                             new Jugador("Donatello",
                                                         20,
                                                         10,
                                                         EPuesto.Arquero),
                                             new Jugador("Miguel Angel",
                                                         23,
                                                         15,
                                                         EPuesto.Defensor),
                                             new Jugador("Leonardo",
                                                        33,
                                                        3,
                                                         EPuesto.Defensor),
                                             new Jugador("Rafael",
                                                         21,
                                                         11,
                                                         EPuesto.Delantero),
                                             new Jugador("El repartidor de las pizzas",
                                                         25,
                                                         10,
                                                         EPuesto.Delantero)
                                         })
                );

        }
        private static void CargarPartidos()
        {

            fixture.Add(new Fecha(1,
                                    new List<Partido>()
                                    {
                                        new Partido(listaEquipos[0],listaEquipos[1]),
                                       new Partido(listaEquipos[2], listaEquipos[3])
                                    }));


            fixture.Add(new Fecha(2,
                              new List<Partido>()
                              {
                                     new Partido(listaEquipos[1], listaEquipos[0]),
                                     new Partido(listaEquipos[3], listaEquipos[2])
                              }));

            fixture.Add(new Fecha(3,
                              new List<Partido>()
                              {
                                        new Partido(listaEquipos[0], listaEquipos[2]),
                                        new Partido(listaEquipos[1], listaEquipos[3])
                              }));

            fixture.Add(new Fecha(4,
                                    new List<Partido>()
                                    {
                                        new Partido(listaEquipos[2], listaEquipos[0]),
                                        new Partido(listaEquipos[3], listaEquipos[1])

                                    }));

            fixture.Add(new Fecha(5,
                                    new List<Partido>()
                                    {
                                    new Partido(listaEquipos[0], listaEquipos[3]),
                                    new Partido(listaEquipos[2], listaEquipos[1])
                                    }));

            fixture.Add(new Fecha(6,
                                  new List<Partido>()
                                  {
                                              new Partido(listaEquipos[3], listaEquipos[0]),
                                              new Partido(listaEquipos[1], listaEquipos[2])
                                  }));
        }

        public static void JugarPartido(int nroFecha)
        {

            if (nroFecha > 0)
            {
                foreach (Fecha fecha in fixture)
                {
                    if (fecha.Id == nroFecha)
                    {
                        foreach (Partido partido in fecha.Partidos)
                        {
                            partido.SimularPartido();
                        }

                        break;
                    }
                }
            }
            else
            {
                throw new ExcepcionPersonalizada("FECHA NO VALIDA");
            }

        }

    }
}
