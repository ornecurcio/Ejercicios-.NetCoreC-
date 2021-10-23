using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Deposito<T>
    {
        private int capacidadMaxima;
        private List<T> lista;

        public Deposito(int capacidad)
        {
            this.capacidadMaxima = capacidad;
            this.lista = new List<T>();
        }
        private int GetIndice(T a)
        {
            //int index = -1;
            //int i = 0;
            //foreach (Auto item in this.lista)
            //{
            //    if(item==a)
            //    {
            //        index = i; 
            //    }
            //    i++; 
            //}
            //return index; 
            return this.lista.IndexOf(a);
        }
        public bool Agregar(T a)
        {
            return (this + a);
        }
        public bool Remover(T a)
        {
            return (this - a);
        }
        public static bool operator +(Deposito<T> d, T a)
        {
            bool rta = false;

            if (d.lista.Count < d.capacidadMaxima)
            {
                d.lista.Add(a);
                rta = true;
            }
            return rta;
        }
        public static bool operator -(Deposito<T> d, T a)
        {
            bool rta = false;
            int index = d.GetIndice(a);
            if (index != -1)
            {
                d.lista.RemoveAt(index);
                rta = true;
            }
            return rta;
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Capacidad: {this.capacidadMaxima}");
            foreach (T item in this.lista)
            {
                stringBuilder.AppendLine(item.ToString());
            }
            return stringBuilder.ToString();
        }
    }
}
