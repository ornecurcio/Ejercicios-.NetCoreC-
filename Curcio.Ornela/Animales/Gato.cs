using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    public class Gato: Mascota
    {
        #region Constructores
        public Gato(string nombre, string raza) : base(nombre, raza)
        { }
        #endregion

        #region Metodos
        protected override string Ficha()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat($"gato - ");
            stringBuilder.AppendFormat($"{base.DatosCompletos()}");

            return stringBuilder.ToString();
        }
        #endregion
        #region Sobrecargas
        public static bool operator ==(Gato g1, Gato g2)
        {
            if (g1 is null && g2 is null)
            {
                return true;
            }
            else
            {
                if (!(g1 is null) && !(g2 is null) && g1==(Mascota)g2) // g1==g2 NO 
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Gato g1, Gato g2)
        {
            return !(g1 == g2);
        }
        public override bool Equals(object obj)
        {
            bool rta = false; 
            if (obj is Gato)
            {
                rta = (Gato)obj == this; 
            }
            return rta;
        }
        public override string ToString()
        {
            return this.Ficha();
        }
        #endregion
    }
}
