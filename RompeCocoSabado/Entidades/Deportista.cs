using System;

namespace Entidades
{
    public abstract class Deportista
    {
        private int cantidadPartidos;
        private int edad;
        private string nombreApellido; 

        public int CantidadPartidos 
        {
            get 
            {
                return this.cantidadPartidos; 
            }
            set
            {
                if(value>-1&& value<80)
                {
                    this.cantidadPartidos = value; 
                }
            }
        }
        public int Edad 
        { 
            get
            {
                return this.edad; 
            }
            set
            {
                if (value > 8)
                {
                    this.edad = value; 
                }
            }
        }
        public string NombreApellido 
        { 
            get
            {
                return this.nombreApellido; 
            }
        }

        public Deportista(string nombreApe, int edad, int cantPart)
        {
            this.cantidadPartidos = cantPart;
            this.edad = edad;
            this.nombreApellido = nombreApe; 
        }
    }
}
