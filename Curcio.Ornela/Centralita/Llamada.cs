using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public enum TipoLlamada { Local, Provincial, Todas }
    public abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        #region Propiedades
        public abstract float CostoLlamada { get; }

        public float Duracion 
        {
            get
            {
                return this.duracion; 
            }
        }
        public string NroDestino { get; }

        public string NroOrigen { get; }

        #endregion

        #region Constructores 
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroOrigen = nroOrigen;
            this.nroDestino = nroDestino; 
        }
        #endregion

        #region Metodos
        protected virtual string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Origen: {this.NroOrigen}, Destino: {this.NroDestino}, " +
                                 $"Duracion: {this.Duracion}"); 
            return stringBuilder.ToString();
        }
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            return (int)(llamada1.Duracion-llamada2.Duracion); 
        }
        #endregion

        #region Sobrecarga
        public static bool operator ==(Llamada llamada1, Llamada llamada2)
        {
            bool rta = false; 
            if (!(llamada1 is null) && !(llamada2 is null) &&
                llamada1.nroOrigen == llamada2.nroOrigen &&
                llamada1.nroDestino == llamada2.nroDestino)
            {
                rta = true;  
            }
            return rta; 
        }
        public static bool operator !=(Llamada llamada1, Llamada llamada2)
        {
            return !(llamada1 == llamada2); 
        }

        #endregion
    }
}
