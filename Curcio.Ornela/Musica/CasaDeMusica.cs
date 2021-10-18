using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musica
{
    public class CasaDeMusica
    {
        /*-----Atr
        (-) lista:List<Instrumento>
        (-) cantidadMaxima:int

        -----Ctor
        (+) CasaDeMusica() -> (inicializa la lista)
        (+) CasaDeMusica(int)  

        -----Met
        (+) Mostrar():string -> de instancia           (Muestra todos los instrumentos con sus datos)



        -----Sobrecarga == (CasaDeMusica,Instrumento)    (verifica si está en la lista)
                        != (CasaDeMusica,Instrumento)    (reutilizar)
		        +  (CasaDeMusica,Instrumento)    (Agrega instrumento a la lista si no está y 
					                  si la lista es menor a la cantidad Máxima)
                        - (CasaDeMusica, Instrumento)    (recorre la lista y si está, elimina por 
					                  indice->RemoveAt())*/
        private List<Instrumento> lista;
        private int cantidadMaxima;

        public CasaDeMusica()
        {
            this.lista = new List<Instrumento>();
            this.cantidadMaxima = 5;
        }
        public CasaDeMusica(int cantidadMaxima) : this()
        {
            this.cantidadMaxima = cantidadMaxima;
        }
        public string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (Instrumento item in this.lista)
            {
                if (item is Guitarra)
                {
                    stringBuilder.AppendLine(((Guitarra)item).MostrarGuitarra());
                }
                if (item is Bateria)
                {
                    stringBuilder.AppendLine(((Bateria)item).MostrarBateria());
                }
                if (item is Trompeta)
                {
                    stringBuilder.AppendLine(((Trompeta)item).MostrarTrompeta());
                }
            }
            return stringBuilder.ToString();
        }
        public static bool operator ==(CasaDeMusica a, Instrumento i)
        {
            bool retorno = false; 
            if (!(a is null) && !(i is null))
            {
                foreach (Instrumento item in a.lista)
                {
                    if (item == i)
                    {
                        retorno = true;
                        break; 
                    }
                }
            }
            return retorno;
        }
        public static bool operator !=(CasaDeMusica a, Instrumento i)
        {
            return !(a == i); 
        }
        public static CasaDeMusica operator +(CasaDeMusica a, Instrumento i)
        {
            if (a.lista.Count() < a.cantidadMaxima && a != i)
            {
                a.lista.Add(i); 
            }
            return a; 
        }
        public static CasaDeMusica operator -(CasaDeMusica a, Instrumento instrumento)
        {
            if (a == instrumento)
            {
                for (int i = 0; i < a.lista.Count; i++)
                {
                    if (a.lista[i] == instrumento)
                    {
                        a.lista.RemoveAt(i); 
                    }
                }
            }
            return a; 
        }
    }
}
