using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escritura
{
    public class Pluma
    {
        #region Atributos
        private string marca;
        private Tinta tinta;
        private int cantidad;
        #endregion
        #region Constructor
        public Pluma()
        {
            this.marca = "Sin marca";
            this.tinta = null;
            this.cantidad = 1; 
        }
        public Pluma(string marca) : this()
        {
            this.marca = marca;
        }
        public Pluma(string marca, int cantidad): this(marca)
        {
            this.cantidad = cantidad;
        }
        public Pluma(string marca, Tinta tinta):this()
        {
            this.marca = marca;
            this.tinta = tinta;
        }
        public Pluma(Tinta tinta, int cantidad):this()
        {
            this.tinta = tinta;
            this.cantidad = cantidad;
        }
        public Pluma(string marca, Tinta tinta, int cantidad): this(marca,cantidad)
        {
            this.tinta = tinta; 
        }
        #endregion
        #region Metodos
        private string Mostrar()
        {
            return "Marca: "+this.marca+"\n"+(string)this.tinta+ 
                   "\nCantidad: " + this.cantidad.ToString() + "\n";
        } 
        #endregion
        #region Sobrecarga
        public static implicit operator string(Pluma a)
        {
            return a.Mostrar();
        }
        public static bool operator ==(Pluma a, Tinta b)
        {
            return a.tinta == b; 
        }
        public static bool operator !=(Pluma a, Tinta b)
        {
            return !(a == b);
        }
        public static Pluma operator +(Pluma a, Tinta b)
        { 
            if (a == b)
            {
                a.cantidad++;
            }
            return a; 
        }
        public static Pluma operator -(Pluma a, Tinta b)
        {
            if (a == b)
            {
                a.cantidad--;
            }
            return a;
        }
        #endregion
    }
}
