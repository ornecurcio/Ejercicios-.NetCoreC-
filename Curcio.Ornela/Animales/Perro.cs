using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    public class Perro : Mascota
    {
        #region Atributos
        private int edad;
        private bool esAlfa;
        #endregion
        #region Constructores
        public Perro(string nombre, string raza) :this(nombre, raza, 0, false) 
        {
        }
        public Perro(string nombre, string raza, int edad, bool esAlfa) : base(nombre, raza)
        {
            this.edad = edad;
            this.esAlfa = esAlfa;
        }
        #endregion

        #region Metodos
        protected override string Ficha()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat($"perro - "); 
            stringBuilder.AppendFormat($"{base.DatosCompletos()}, ");
            if (esAlfa)
            {
                stringBuilder.AppendFormat($"alfa de la manada, ");
            }
            stringBuilder.AppendFormat($"edad {(int)this}");
            
            return stringBuilder.ToString(); 
        }
        #endregion

        #region Sobrecargas
        public static bool operator ==(Perro p1, Perro p2)
        {
            if (p1 is null && p2 is null)
            {
                return true;
            }
            else
            {
                if (!(p1 is null) && !(p2 is null) && 
                    //solo hace falta un casteo
                   p1 == (Mascota)p2 && p1.edad == p2.edad)
                   //((Mascota)p1)==p2)

                // ERROR POR BUCLE INFINITO
                //if (!(p1 is null) && !(p2 is null) &&
                //  p1 == p2 && p1.edad == p2.edad)
                {
                    return true;
                }
            }
            return false; 
        }
        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1 == p2); 
        }
        public static explicit operator int(Perro p)
        {
            return p.edad; 
        }
        public override bool Equals(object obj)
        {
            //bool rta = false;
            //if (obj is Perro)
            //{
            //    rta = (Perro)obj == this;
            //}
            // return rta; 

            //la primer parte es igual al if, despues de ? la rta : la parte que seria del else
            return obj is Perro ? (Perro)obj == this : false;
        }  
        public override string ToString()
        {
            return this.Ficha();
        }
        #endregion
    }

}
