using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Entrenador : Deportista
    {
        private int cantEquiposDirigidos;
        private bool campeonDelMundo;

        public Entrenador(string nombApe, int edad, int cantParti, int cantEqui, bool camp) : base(nombApe, edad, cantParti)
        {
            this.cantEquiposDirigidos = cantEqui;
            this.campeonDelMundo = camp;
        }

        public int CantEquiposDirigidos { get => cantEquiposDirigidos; }
        public bool CampeonDelMundo { get => campeonDelMundo; }



    }
}
