using System;
using System.Text; 

namespace Entidades
{
    public class Auto
    {
        private string color;
        private string marca;

        public string Color
        {
            get
            {
                return this.color;
            }
        }
        public string Marca
        {
            get
            {
                return this.marca;
            }
        }
        public Auto(string color, string marca)
        {
            this.color = color;
            this.marca = marca;
        }
        public static bool operator ==(Auto a, Auto b)
        {
           bool rta = false; 
           if(a is not null && b is not null &&
              a.marca == b.marca && a.color == b.color)
            {
                rta = true; 
            }
            return rta; 
        }
        public static bool operator !=(Auto a, Auto b)
        {
            return !(a == b); 
        }
        public override bool Equals(object obj)
        {
            bool rta=false; 
            if(obj is Auto)
            {
                rta = (Auto)obj == this; 
            }
            return rta; 
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"Marca: {this.Marca} - Color: {this.Color}"); 

            return stringBuilder.ToString();
        }
    }
}
