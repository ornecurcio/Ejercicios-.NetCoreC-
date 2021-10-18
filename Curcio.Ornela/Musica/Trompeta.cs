using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musica
{
    public class Trompeta:Instrumento
    {
        /*--------------
        clase Trompeta--------> Instrumento
        --------------

        -----Atr
        (-) clave:string

        -----Ctor
        (+) Trompeta(string,int,EClasificacion,string)  

        -----Met
        (+) MostrarTrompeta():string -> de instancia*/
        private string clave;

        public Trompeta(string marca, int codigo, EClasificacion clasificacion, string clave) : base(codigo, marca)
        {
            this.clave= clave;
        }
        public string MostrarTrompeta()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(base.Mostrar());
            stringBuilder.Append($"Clave: {this.clave}");

            return stringBuilder.ToString();
        }
        public override string ToString()
        {
            return this.MostrarTrompeta();
        }
    }
}
