using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerClase30
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public AutoF1() : this(0, string.Empty)
        {
        }
        private AutoF1(short cantidadCombustible, bool enCompetencia, short vueltasRestantes)
        {
            this.cantidadCombustible = cantidadCombustible;
            this.enCompetencia = enCompetencia;
            this.vueltasRestantes = vueltasRestantes;
        }
        public AutoF1(short numero, string escuderia) : this(0, false, 0)
        {
            this.numero = numero;
            this.escuderia = escuderia;
        }
        public short SetCantidadCombustible
        {
            set
            {
                this.cantidadCombustible = value;
            }
        }
        public bool SetEnCompetencia
        {
            set
            {
                this.enCompetencia = value;
            }
        }
        public short SetVueltasRestantes
        {
            set
            {
                this.vueltasRestantes = value;
            }
        }

        public string MostrarDatos()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Auto {this.numero}");
            stringBuilder.AppendLine($"Escuderia {this.escuderia}");
            stringBuilder.AppendLine($"Vueltas restantes {this.vueltasRestantes}");
            return stringBuilder.ToString(); 
        }
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            if (((object)a1) == null && ((object)a2) == null)
            {
                return true;
            }
            else //a != null y b != null; a != null y b == null; a == null y b != null
            {
                if (((object)a1) != null && ((object)a2) != null
                  && a1.numero == a2.numero && a1.escuderia == a2.escuderia)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2); 
        }
    }
}
