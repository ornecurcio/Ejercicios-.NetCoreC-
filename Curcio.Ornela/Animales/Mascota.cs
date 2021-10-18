using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    public abstract class Mascota
    {
        #region Atributos
        private string nombre;
        private string raza;
        #endregion
        #region Constructor
        public Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }
        #endregion
        #region Propiedades
        public string Nombre
        {
            get 
            {
                return this.nombre; 
            }
        }
        public string Raza
        {
            get
            {
                return this.raza; 
            }
        }
        #endregion

        #region Metodos
        protected virtual string DatosCompletos()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"{Nombre} - {Raza}");

            return stringBuilder.ToString(); 
        }
        protected abstract string Ficha();
        #endregion

        #region Sobrecargas
        public static bool operator ==(Mascota m1, Mascota m2)
        {
            bool rta=false; 
            if (m1 is null && m2 is null)
            {
                rta= true;
            }
            else
            {
                if (!(m1 is null) && !(m2 is null) &&
                    m1.nombre == m2.nombre && m1.raza == m2.raza)
                {
                    rta= true; 
                }
            }
            return rta; 
        }
        public static bool operator !=(Mascota m1, Mascota m2)
        {
            return !(m1 == m2); 
        }
        #endregion

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
