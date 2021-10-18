using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerClase29
{
    class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>(); 
        }
        public Equipo(short cantidad, string nombre):this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre; 
        }
        public static bool operator +(Equipo e, Jugador j)
        {
            if (e.jugadores.Count < e.cantidadDeJugadores)
            {
                foreach (Jugador item in e.jugadores)
                {
                    if (item == j)
                    {
                        return false;
                    }
                }
                e.jugadores.Add(j);
                return true; 
            }
            return false;
        }
    }
}
