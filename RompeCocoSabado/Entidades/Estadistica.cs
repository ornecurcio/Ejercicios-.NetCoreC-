using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estadistica
    {
        private int empatados;
        private int ganados;
        private int golesEnContra;
        private int golesFavor;
        private int partJugados;
        private int perdidos;
        private int puntos;

        public int Empatados 
        { 
            get
            {
                return this.empatados; 
            } 
        }
        public int Ganados 
        {
            get
            {
                return this.ganados;
            }
        }
        public int GolesNegativos 
        {
            get
            {
                return this.golesEnContra;
            }
        }
        public int GolesFavor 
        {
            get
            {
                return this.golesFavor;
            }
        }
        public int PartJugados 
        {
            get
            {
                return this.partJugados;
            }
            set 
            {
                if(value>-1)
                {
                    this.partJugados = value; 
                }
            }
        }
        public int Perdidos 
        {
            get
            {
                return this.perdidos;
            }
        }
        public int Puntos 
        {
            get
            {
                return this.puntos;
            }
        }

        public Estadistica()
        { }
        public void Actualizar(EResultado resu, int golFav, int golNeg)
        {
            switch (resu)
            {
                case EResultado.Victoria:
                    this.ganados++;
                    this.puntos += 3; 
                    break;
                case EResultado.Empate:
                    this.empatados++;
                    this.puntos += 1; 
                    break;
                case EResultado.Derrota:
                    this.perdidos++;
                    this.puntos += 0; 
                    break;
            }
            this.golesFavor += golFav;
            this.golesEnContra += golNeg;
            this.partJugados++; 
        }

    }
}
