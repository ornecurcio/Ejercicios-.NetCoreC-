using System;
using System.Text; 

namespace Entidades
{
    public abstract class Equipo
    {
        private string nombre;
        private DateTime fechaCreacion;

        public Equipo(string nombre, DateTime fechaCreacion)
        {
            this.nombre = nombre;
            this.fechaCreacion = fechaCreacion; 
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        public static bool operator ==(Equipo a, Equipo b)
        {
            if(a is not null && b is not null && 
               a.nombre == b.nombre && a.fechaCreacion == b.fechaCreacion)
            {
                return true; 
            }
            return false; 
        }
        public static bool operator !=(Equipo a, Equipo b)
        {
            return !(a == b); 
        }

        public string Ficha()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"{this.nombre} fundado el {this.fechaCreacion}");

            return stringBuilder.ToString(); 
        }
    }
}
