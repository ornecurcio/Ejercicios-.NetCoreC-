using System;

namespace Entidades
{
    public enum EPuesto { Arquero, Defensor, Delantero }
    public class Jugador : Deportista
    {
        private EPuesto puesto;
       

        public Jugador(string nombApe, int edad, int cantPart, EPuesto puesto) : base(nombApe, edad, cantPart)
        {
            this.puesto = puesto;
        }

        public EPuesto Puesto { get => puesto; }
    }
}
