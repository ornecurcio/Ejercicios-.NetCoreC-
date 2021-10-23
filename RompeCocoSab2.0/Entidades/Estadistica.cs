using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estadistica
    {
        int puntos;
        int ganados;
        int perdidos;
        int empatados;
        int golesFavor;
        int golesEnContra;
        int partJugados;


        public int Puntos { get { return puntos; } }
        public int Ganados { get { return ganados; } }
        public int Perdidos { get { return perdidos; } }
        public int Empatados { get { return empatados; } }
        public int GolesFavor { get { return golesFavor; } }
        public int GolesNegativos { get { return golesEnContra; } }
        public int PartJugados { get { return partJugados; } set { partJugados = value; } }

        public void Actualizar(EResultado resu, int golFav, int golNeg)
        {
            partJugados += 1;
            switch (resu)
            {
                case EResultado.Victoria:
                    this.puntos += 3;
                    this.ganados += 1;
                    break;
                case EResultado.Empate:
                    this.puntos += 1;
                    this.empatados += 1;
                    break;
                case EResultado.Derrota:
                    this.perdidos += 1;
                    break;
            }

            this.golesFavor += golFav;
            this.golesEnContra += golNeg;
        }

    }
}
