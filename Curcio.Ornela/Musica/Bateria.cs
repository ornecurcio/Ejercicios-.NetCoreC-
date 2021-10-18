using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musica
{
    public class Bateria : Instrumento
    {
        /*--------------
        clase Bateria---------> Instrumento
        --------------

        -----Atr
        (-) cuerpos:int

        -----Ctor
        (+) Bateria(string,int,EClasificacion,int)  

        -----Met
        (+) MostrarBateria():string -> de instancia
        */
        private int cuerpos;

        public Bateria(string marca, int codigo, EClasificacion clasificacion, int cuerpos) : base(codigo, marca, clasificacion)
        {
            this.cuerpos = cuerpos; 
        }
        public string MostrarBateria()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(base.Mostrar());
            stringBuilder.Append($"Cuerpos: {this.cuerpos}");

            return stringBuilder.ToString();
        }
        public override string ToString()
        {
            return this.MostrarBateria();
        }
    }
}
