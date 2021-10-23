using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Entrenador : Deportista
    {
        private bool campeonDelMundo;
        private int cantidadEquiposDirigidos; 

        public bool CampeonDelMundo 
        {
            get
            {
                return this.campeonDelMundo; 
            }
        }
        public int CantidadEquiposDirigidos 
        { 
            get
            {
                return this.cantidadEquiposDirigidos; 
            }
        }
        public Entrenador(string nombreApe, int edad, int cantPart, int cantEqui, bool camp) : base(nombreApe, edad, cantPart)
        {
            this.campeonDelMundo = camp;
            this.cantidadEquiposDirigidos = cantEqui; 
        }

        
    }
}
