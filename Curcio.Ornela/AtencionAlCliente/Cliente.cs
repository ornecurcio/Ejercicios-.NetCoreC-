using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtencionAlCliente
{
    public class Cliente
    {
        #region Atributo
        private string nombre;
        private int numero;
        #endregion
        #region Propiedades
        public string Nombre
        {
            get 
            {
                return this.nombre; 
            }
            set
            {
                this.nombre = value; 
            }
        }
        public int Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }
        #endregion
        #region Constructores
        public Cliente(int numero)
        {
            this.numero = numero; 
        }
        public Cliente(int numero, string nombre): this(numero)
        {
            this.nombre = nombre; 
        }
        #endregion
        #region Sobrecargas
        public static bool operator ==(Cliente c1, Cliente c2)
        {
            if (((object)c1) == null && ((object)c2) == null)
            {
                return true;
            }
            else
            {
                if (((object)c1) != null && ((object)c2) != null && c1.numero == c2.numero)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2); 
        }
        #endregion
    }
}
