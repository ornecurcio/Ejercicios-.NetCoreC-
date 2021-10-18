using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerClase16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title="Ejercicio 16";

            Alumno.contadorAlumno = 0; 
            Alumno.Contador();

            Alumno pedro = new Alumno("Geraghty", "Pedro", 111115);
            Alumno lucas = new Alumno("Bayon", "Lucas", 111120);
            Alumno ornela = new Alumno("Curcio", "Ornela", 111100);

            pedro.Estudiar(8, 9);
            lucas.Estudiar(7, 10);
            ornela.Estudiar(10, 2);
            
            pedro.CalcularFinal();
            lucas.CalcularFinal();
            ornela.CalcularFinal();

            Console.WriteLine(pedro.Mostrar());
            Console.WriteLine(lucas.Mostrar());
            Console.WriteLine(ornela.Mostrar());

            Console.ReadKey(); 

        }
    }
}
