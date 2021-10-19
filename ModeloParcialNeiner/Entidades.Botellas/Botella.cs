using System;
using System.Text;

namespace Entidades.Botellas
{
    public abstract class Botella
    {
        protected int capacidad;
        protected int contenido;
        protected string marca;
        protected double precio;

        public abstract double Ganancia { get; }
        
        public double PorcentajeContenido
        {
            get
            { 
                double rta = (double)this.contenido / this.capacidad * 100;
                return (int)rta; 
            }
        }

        public Botella(string marca, double precio):this(marca, precio, 1000)
        { 
        }
        public Botella(string marca, double precio, int capacidad)
        {
            this.marca = marca;
            this.precio = precio;
            this.capacidad = capacidad;
            this.contenido = capacidad; 
        }
        private static string ObtenerDatos(Botella b)
        {
            return b.ToString();
        }
        public static explicit operator String(Botella a)
        {
            return a.marca; 
        }
        public static bool operator ==(Botella a, Botella b)
        {
            bool rta = false;
            if (a is not null && b is not null && 
                a.marca == b.marca && a.capacidad == b.capacidad)
            {
                rta = true; 
            }
            return rta; 
        }
        public static bool operator !=(Botella a, Botella b)
        {
            return !(a == b); 
        }
        public static Botella operator --(Botella a)
        {
            if (a is not null)
            {
                a.ServirMedida(); 
            }
            return a;
        }
        protected abstract void ServirMedida();

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"Marca: {this.marca}, Capacidad: {this.capacidad}cc, " +
                $"Contanido: {this.PorcentajeContenido}%, Precio: {this.precio}");

            return stringBuilder.ToString();
        }
    }
}
