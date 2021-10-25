using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lapiz: IAcciones
    {
        private float tamanioMina; 

        public Lapiz(float tamanioMina)
        {
            this.tamanioMina = tamanioMina; 
        }

        ConsoleColor IAcciones.Color 
        {
            get
            {
                return ConsoleColor.Gray; 
            }
            set
            { 
                throw new NotImplementedException(); 
            } 
        }
        float IAcciones.UnidadesDeEscritura 
        {
            get
            {
                return this.tamanioMina; 
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            if(this.tamanioMina >= texto.Length * 0.1)
            {
                this.tamanioMina -= (texto.Length * 0.1f);

                return new EscrituraWrapper(texto, ((IAcciones)this).Color);
            }
            return null; 
        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"{this.GetType().Name} color {((IAcciones)this).Color} con {this.tamanioMina} tamanio de mina";
        }
    }
}
