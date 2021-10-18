using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerSobreEscribiendoAdvertencias
{
    abstract class Sobrescrito
    {
        //Sobrescribir el método ToString para que retorne "¡Este es mi método ToString sobrescrito!".
        //Sobrescribir el método Equals para que retorne true si son del mismo tipo(objetos de la misma clase), false caso contrario.
        //Sobrescribir el método GetHashCode para que retorne el número 1142510181.
        /*Agregar a la clase Sobrescrito un atributo miAtributo del tipo string, con visibilidad protected.
        Generar un constructor de instancia que inicialice miAtributo con el valor "Probar abstractos".
        Agregará propiedad abstracta MiPropiedad de sólo lectura. Una vez implementada, retornará el valor de miAtributo.
        Crear un método abstracto MiMetodo que retorne un string. Una vez implementada, retornará el valor de MiPropiedad.
        Agregar una clase llamada SobreSobrescrito que herede de Sobrescrito. 
        Implementar el código necesario para que todo funcione correctamente.
        Modificar el método Main para probar las modificaciones.*/

        protected string miAtributo;

        public Sobrescrito()
        {
            this.miAtributo = "Probar abstractos"; 
        }
        public abstract string MiPropiedad { get; }

        public abstract string MiMetodo(); 
        public override string ToString()
        {
            return "¡Este es mi metodo ToString sobreescrito!";
        }
        public override bool Equals(object obj) // todas posibles opciones 
        {
            // compara tipo en memoria, incluye a las derivadas y evitas usar la sobrecarga ==
            //return obj.GetType() == this.GetType();

           //as, castea, devuelve null si no pudo transformar o el objeto transformado si lo hizo. 
            Sobrescrito aux = obj as Sobrescrito;
            // return aux is Sobrescrito; en la primer linea hago el casteo, en la segunda veo si lo transformo
            if (!(aux is null))
            {
                return true; 
            }
            return false;

            //otra opcion con casteo adentro
            //bool rta = false;
            //if (obj is Instrumento)
            //{
            //    rta = (Instrumento)obj == this;
            //}
            //return rta;

            //return obj.GetType()==typeof(Sobrescrito); 
            
        }
        public override int GetHashCode()
        {
            return 1142510181; 
        }

    }
}
