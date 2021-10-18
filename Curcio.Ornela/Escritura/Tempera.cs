using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escritura
{
    public class Tempera
    {
        #region Atributos
        private ConsoleColor color;
        private string marca;
        private int cantidad;
        #endregion
        #region Constructor
        //constructor 3 parametros
        public Tempera(ConsoleColor color, string marca, int cantidad)
        {
            this.color = color;
            this.marca = marca;
            this.cantidad = cantidad; 
        }
        #endregion
        #region Metodos
        //(-)Mostrar() :string//instancia
        private string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("Tempera: ");
            stringBuilder.AppendLine($"Color: {this.color.ToString()}");
            stringBuilder.AppendLine($"Marca: {this.marca}");
            stringBuilder.AppendLine($"Cantidad: {this.cantidad.ToString()}");

            return stringBuilder.ToString();
        }
        //(+)Mostrar(Tempera) :string//clase
        public static string Mostrar(Tempera tempera)
        {
            return tempera.Mostrar(); 
        }
        #endregion
        #region Sobrecargas
        // implicit (tempera): int // cantidad
        public static implicit operator int(Tempera a)
        {
            return a.cantidad;
        }
        //== (tempera, tempera) //marca y color
        public static bool operator ==(Tempera a, Tempera b)
        {
            //Si ambos parámetros son null, no comparo por atributos
            if (((object)a) == null && ((object)b) == null)
            {
                return true;
            }
            else //a != null y b != null; a != null y b == null; a == null y b != null
            {
                if (((object)a) != null && ((object)b) != null)
                {
                    if (a.color == b.color && a.marca == b.marca)
                    {
                        return true;
                    }
                }
                //si alguno de los parámetros es != null y el otro no, retorno false
            }
            return false; 
        }
        public static bool operator !=(Tempera a, Tempera b)
        {
            return !(a == b); 
        }
        //+ (tempera, tempera) : tempera
        //-> si temperas iguales, acumula cantidad
        public static Tempera operator +(Tempera a, Tempera b)
        {
            if (a == b)
            {
                //cantidad = a.cantidad + b.cantidad;
                a.cantidad += b;
            }
            return a ; 
        }
        //+ (tempera, int) : tempera
        //-> acumula cantidad
        public static Tempera operator +(Tempera a, int b)
        {
            Tempera suma = new Tempera(a.color, a.marca, a.cantidad+b);
            return suma ;
        }
        #endregion

    }
}
