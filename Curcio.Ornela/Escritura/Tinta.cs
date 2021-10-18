using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escritura
{
    public class Tinta
    {
        #region atributos
        private ConsoleColor color;
        private ETipoTintas tipo;
        #endregion

        #region constructores
        public Tinta()
        {
            this.color = ConsoleColor.Black;
            this.tipo = ETipoTintas.Comun; 
        }
        public Tinta(ConsoleColor color) : this()
        {
            this.color = color; 
        }
        //public Tinta(ETipoTintas tipo) : this()
        //{
        //    this.tipo = tipo;
        //}
        public Tinta(ConsoleColor color, ETipoTintas tipo):this(color)
        {
            this.tipo = tipo; 
            // this.color=color; 
        }
        #endregion

        #region metodos
        private string Mostrar()
        {
            return "Tinta: "+ this.tipo.ToString() + "\nColor: "+ this.color.ToString(); 
            // 
        }
        public static string Mostrar(Tinta a)
        {
            return (string)a;
            // a.Mostrar(); 
        }
        #endregion

        #region Sobrecarga Operadores

        public static explicit operator string(Tinta a)
        {
            //if (a != null)
                return a.Mostrar();
            //else
            //    return new Tinta().Mostrar();
        }
        public static bool operator ==(Tinta a1, Tinta a2)
        {
            //bool rta = false;
            //if (a1.color == a2.color && a1.tipo == a2.tipo)
            //{
            //    rta = true;
            //}
            //return rta;
            return (a1.color == a2.color && a1.tipo == a2.tipo);
        }
        public static bool operator !=(Tinta a1, Tinta a2)
        {
            return !(a1==a2);
        }
        #endregion
    }
}
