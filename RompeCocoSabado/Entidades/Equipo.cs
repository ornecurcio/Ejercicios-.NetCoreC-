using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private Entrenador entrenador;
        private Estadistica estadistica;
        private List<Jugador> listaJugadores;
        private string nombreEquipo;

        public Entrenador Entrenador 
        { 
            get
            {
                return this.entrenador; 
            }
            set
            {
                if(value is not null)
                {
                    this.entrenador = value; 
                }
            }
        }
        public Estadistica Estadistica 
        {
            get
            {
                return this.estadistica;
            }
            set
            {
                if (value is not null)
                {
                    
                }
            }
        }
        public List<Jugador> ListaJugadores 
        {
            get
            {
                return this.listaJugadores;
            }
            set
            {
                if (value is not null && value.Count>0)
                {
                    this.listaJugadores = value;
                }
            }
        }
        public string NombreEquipo 
        { 
            get
            {
                return this.nombreEquipo; 
            }
        }

        public Equipo(string nombreEquipo, Entrenador ent, List<Jugador> listJug)
        {
            this.nombreEquipo = nombreEquipo;
            this.entrenador = ent;
            this.listaJugadores = listJug; 
        }
    }
}
