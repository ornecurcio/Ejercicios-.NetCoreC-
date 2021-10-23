using System;

namespace Entidades
{
    public enum EResultado 
    {
        Victoria,
        Empate,
        Derrota
    }
    public class Partido
    {
        static Random random;

        bool partidoJugado;
        Equipo equipoLocal;
        Equipo equipoVisitante;
        EResultado resultadoEquipoLocal;
        int golesLocal;
        int golesVisitante;

        static Partido()
        {
            random = new Random();
        }

        public Partido(Equipo local, Equipo visitante)
        {
            this.equipoLocal = local;
            this.equipoVisitante = visitante;
        }

        public void SimularPartido()
        {
            golesLocal= random.Next(0,5);
            golesVisitante = random.Next(0,5);
            
            if (golesLocal > golesVisitante)
            {
                equipoLocal.Estadistica.Actualizar(EResultado.Victoria, golesLocal, golesVisitante);
                equipoVisitante.Estadistica.Actualizar(EResultado.Derrota, golesVisitante, golesLocal);
            }
            else if(golesVisitante > golesLocal)
            {
                equipoLocal.Estadistica.Actualizar(EResultado.Derrota, golesLocal, golesVisitante);
                equipoVisitante.Estadistica.Actualizar(EResultado.Victoria, golesVisitante, golesLocal);
            }
            else
            {
                equipoVisitante.Estadistica.Actualizar(EResultado.Empate, golesLocal, golesLocal);
                equipoLocal.Estadistica.Actualizar(EResultado.Empate, golesLocal, golesLocal);
            }
        }


    }
}