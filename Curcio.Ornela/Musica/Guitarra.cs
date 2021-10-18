using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musica
{
    public class Guitarra: Instrumento
    {
        /*--------------
        clase Guitarra--------> Instrumento
        --------------

        -----Atr
        (-) cantidadDeCuerdas:int

        -----Ctor
        (+) Guitarra(string,int,EClasificacion,ETipoGuitarra)  

        -----Prop
        (+) Tipo: ETipoGuitarra (lectura y escritura).

        -----Met
        (+) MostrarGuitarra():string -> de instancia*/
  
        private int cantidadDeCuerdas;
        public Guitarra(string marca, int codigo, EClasificacion clasificacion, EtipoGuitarra tipo, int cantidadCuerdas)
                        : base(codigo, marca, clasificacion)
        {
            this.cantidadDeCuerdas = cantidadCuerdas;
            this.Tipo = tipo;
        }
        public Guitarra(string marca, int codigo, EClasificacion clasificacion, EtipoGuitarra tipo)
                        : this(marca, codigo, clasificacion, tipo,6)
        {   
        }
        public EtipoGuitarra Tipo { set; get; }
        public string MostrarGuitarra()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(base.Mostrar()); 
            stringBuilder.Append($"Tipo: {this.Tipo}, Cantidad de Cuerdas: {this.cantidadDeCuerdas}");

            return stringBuilder.ToString();
        }
        public override string ToString()
        {
            return this.MostrarGuitarra();
        }
    }
}
