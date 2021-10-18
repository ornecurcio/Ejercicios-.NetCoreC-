using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerClase16
{
    public class Alumno
    {
        public static int contadorAlumno; 
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        public Alumno(string apellido, string nombre, int legajo)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.legajo = legajo;
        }
        public void CalcularFinal()
        {
            int auxFinal = -1; 
            if (this.nota1 > 3 && this.nota2 > 3)
            {
                Random score = new Random();
                auxFinal = score.Next(4, 10); 
            }
            this.notaFinal = auxFinal; 
        }
        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos; 
        }
        public string Mostrar()
        {
            string auxString;
            if (this.notaFinal != -1)
            {
                auxString = this.legajo + "--" + this.apellido + ", " + this.nombre + ": \n\t" + "1°Nota: " + this.nota1
                    + "\n\t2°Nota: " + this.nota2 + "\n\tNota Final: " + this.notaFinal;
            }
            else 
            { 
                auxString= auxString = this.legajo + "--" + this.apellido + ", " + this.nombre + ": \n\t" + "1°Nota: " + this.nota1
                    + "\n\t2°Nota: " + this.nota2 + "\n\tNota Final: Alumno Desaprobado";
            }
            return auxString;   
        }

        public static int Contador()
        {
           return contadorAlumno++; 
        }


    }
}
