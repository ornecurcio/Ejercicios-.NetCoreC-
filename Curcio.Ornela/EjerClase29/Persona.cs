using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerClase29
{
    public class Persona
    {
        private long dni;
        private string nombre;
        #region Constructores
        public Persona(long dni, string nombre):this(nombre)
        {
            this.dni = dni; 
        }
        public Persona(string nombre)
        {
            this.nombre = nombre; 
        }
        #endregion
        #region Propiedades
        public long Dni
        { 
            get 
            {
                return this.dni; 
            }
            set 
            {
                if (value > 0 && value < 99999999)
                {
                    this.dni = value;
                }
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this.nombre = value;
                }
            }
        }
        #endregion
        #region Metodos
        public string MostrarDatos()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Nombre: {Nombre}");
            stringBuilder.AppendLine($"Dni: {Dni},");
           
            return stringBuilder.ToString(); 
        }
        #endregion

    }
}
