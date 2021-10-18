using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerClase29
{
    class Jugador :Persona
    {
        private int partidosJugados;
        private int totalGoles;

        public Jugador(int dni, string nombre) : base(dni, nombre)
        {
        }
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }
        public int PartidosJugados
        {
            get 
            {
                return this.partidosJugados; 
            } 
        }
        public float PromedioGoles
        {
            get
            {
                if (PartidosJugados > 0)
                {
                    return (float)this.totalGoles / this.partidosJugados;
                }
                else
                {
                    return 0; 
                }
            }
        }
        public int TotalGoles
        {
            get
            {
                return this.totalGoles;
            }
            set 
            {
                if (value > 0)
                {
                    this.totalGoles = value; 
                }
            }
        }
       
        public new string MostrarDatos()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(base.MostrarDatos());
            stringBuilder.AppendLine($": {PartidosJugados}");
            stringBuilder.AppendLine($": {TotalGoles}");
            stringBuilder.AppendLine($": {PromedioGoles}");
            return stringBuilder.ToString();

            return stringBuilder.ToString(); 
        }
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            if (j1 is null && j2 is null)
            {
                return true;
            }
            else
            {
                if (((object)j1) != null && ((object)j2) != null && j1.Dni == j2.Dni)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2); 
        }

    }
}
