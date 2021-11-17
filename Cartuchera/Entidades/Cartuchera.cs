using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //Crear, en class library, la clase Cartuchera<T> -> restringir para que sólo lo pueda usar Utiles 
    //o clases que deriven de Utiles.
    //atributos: capacidad:int y elementos:List<T> (TODOS protegidos)        
    //Propiedades:
    //Elementos:(sólo lectura) expone al atributo de tipo List<T>.
    //PrecioTotal:(sólo lectura) retorna el precio total de la cartuchera (la suma de los precios de sus elementos).
    //Constructor
    //Cartuchera(), Cartuchera(int); 
    //El constructor por default es el único que se encargará de inicializar la lista.
    //Métodos:
    //ToString: Mostrará en formato de tipo string: 
    //el tipo de cartuchera, la capacidad, la cantidad actual de elementos, el precio total y el listado completo 
    //de todos los elementos contenidos en la misma. Reutilizar código.
    //Sobrecarga de operadores:
    //(+) Será el encargado de agregar elementos a la cartuchera, 
    //siempre y cuando no supere la capacidad máxima de la misma.
    public class Cartuchera<T> where T:Utiles
    {
        protected int capacidad;
        protected List<T> elementos;
        public delegate void DelegadoEventoPrecio(object sender);
        public event DelegadoEventoPrecio EventoPrecio;
        public Cartuchera()
        {
            this.elementos = new List<T>(); 
        }
        public Cartuchera(int capacidad):this()
        {
            this.capacidad = capacidad; 
        }
        public List<T> Elementos
        {
            get
            {
                return this.elementos; 
            }
        }
        public double PrecioTotal
        {
            get
            {
                double precioTotal = 0;
                foreach (T item in this.Elementos)
                {
                    precioTotal += item.precio;

                }
                return precioTotal;
            }
        }
        public override string ToString()
        {
            StringBuilder cadena = new StringBuilder();

            cadena.AppendLine("Tipo: " + typeof(T).Name);
            cadena.AppendLine("Capacidad: " + this.capacidad);
            cadena.AppendLine("Cantidad total: " + this.elementos.Count);
            cadena.AppendLine("Precio Total: " + this.PrecioTotal);
            cadena.AppendLine("\nLista de utiles: ");

            foreach (T item in this.elementos)
            {
                cadena.AppendLine(item.ToString() + "\n");

            }
            return cadena.ToString();
        }
        
        public static Cartuchera<T> operator +(Cartuchera<T> c, T u)
        {
            if(!(c is null && u is null) && c.elementos.Count < c.capacidad)
            {
                c.elementos.Add(u);
            }
            if (c is Cartuchera<Goma>)
            {
                
            }
            if (c.PrecioTotal > 85)
            {
                c.EventoPrecio(c);
            }
            return c; 
        }
    }
}
