using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musica
{
    public class Instrumento
    {
        /*-----------------
        clase Instrumento
        -----------------

        -----Atr
        (*prot) codigo:int
        (*prot) marca:string
        -----Ctor
        (+) Instrumento(int,string)  
        (+) Instrumento(int,string,EClasificacion)    (reutilizar) 
        -----Prop
        (*prot) Clasificacion: EClasificacion (lectura y escritura)
        -----Met
        (+) Mostrar():string -> de instancia
        -----Sobrecarga == (Instrumento,Instrumento)     (verifica por codigo)
                        != (Instrumento,Instrumento)     (reutilizar)*/
        protected int codigo;
        protected string marca;

        public Instrumento(int codigo, string marca)
        {
            this.codigo = codigo;
            this.marca = marca; 
        }
        public Instrumento(int codigo, string marca, EClasificacion clasificacion):this(codigo, marca)
        {
            this.Clasificacion = clasificacion; 
        }
        protected EClasificacion Clasificacion { set; get; }

        public string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Codigo: {this.codigo}, Marca: {this.marca}, " +
                                     $"Clasificacion: {Clasificacion}, ");

            return stringBuilder.ToString(); 
        }
        public static bool operator ==(Instrumento a, Instrumento b)
        {
            if (a is null && b is null)
            {
                return true;
            }
            else
            {
                if (!(a is null) && !(b is null) && a.codigo==b.codigo)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Instrumento a, Instrumento b)
        {
            return !(a == b); 
        }
        public override bool Equals(object obj)
        {
            bool rta = false;
            if (obj is Instrumento)
            {
                rta = (Instrumento)obj == this;
            }
            return rta;
        }
    }
}
