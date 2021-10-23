using System.Collections.Generic;

namespace Entidades
{
    public class Equipo
    {
        private string nombreEquipo;
        private Entrenador entrenador;
        private List<Jugador> listaJugadores;
        private Estadistica estadistica;

        public Equipo(string nombEquipo, Entrenador ent, List<Jugador> listJug)
        {
            this.nombreEquipo = nombEquipo;
            this.entrenador = ent;
            this.listaJugadores = listJug;
            estadistica = new Estadistica();
        }

        public string NombreEquipo { get { return nombreEquipo; } }
        public Entrenador Entrenador
        {
            get { return entrenador; }
            set { entrenador = value; }
        }
        public List<Jugador> ListaJugadores
        {
            get { return listaJugadores; }
            set { listaJugadores = value; }
        }
        public Estadistica Estadistica { get { return estadistica; } set { estadistica = value; } }



    }
}
