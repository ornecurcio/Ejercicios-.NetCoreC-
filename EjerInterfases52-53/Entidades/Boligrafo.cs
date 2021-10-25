using System;

namespace Entidades
{
    public class Boligrafo: IAcciones
    {
        private ConsoleColor color;
        private float tinta;

        public Boligrafo(ConsoleColor color, float tinta)
        {
            this.color = color;
            this.tinta = tinta; 
        }

        ConsoleColor IAcciones.Color
        {
            get
            {
                return this.color;
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        public float UnidadesDeEscritura
        {
            get
            {
                return this.tinta;
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        public EscrituraWrapper Escribir(string texto)
        {
            if (this.tinta >= texto.Length * 0.3)
            {
                this.tinta -= (texto.Length * 0.1f);

                return new EscrituraWrapper(texto, ((IAcciones)this).Color);
            }
            return null;
        }

        public bool Recargar(int unidades)
        {
            bool rta = false;
            if (tinta < 100)
            {
                this.tinta += unidades;
                rta = true; 
            }
            return rta; 
        }
        public override string ToString()
        {
            return $"{this.GetType().Name} tinta {this.color}, {(this.tinta)} de tinta"; 
        }
    }
}
