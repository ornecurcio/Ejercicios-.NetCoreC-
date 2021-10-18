using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiantes
{
    public class Ingresante
    {
        private string[] cursos; 
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;

        public Ingresante(string nombre, string direccion, string genero,
                            string pais, string[] cursos, int edad)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.genero = genero;
            this.pais = pais;
            this.cursos = cursos;
            this.edad = edad; 
        }
        public string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"Nombre: {this.nombre}\n");
            stringBuilder.AppendLine($"Direccion: {this.direccion}");
            stringBuilder.AppendLine($"Edad: {this.edad}"); 
            stringBuilder.AppendLine($"Genero: {this.genero}");                
            stringBuilder.AppendLine($"Pais: {this.pais}");
            stringBuilder.AppendLine($"Cursos: "); 
            foreach (string item in this.cursos)
            {
                if(item!=null)
                {
                    stringBuilder.AppendLine(item); 
                }
            }
            return stringBuilder.ToString(); 
        }
    }
}
