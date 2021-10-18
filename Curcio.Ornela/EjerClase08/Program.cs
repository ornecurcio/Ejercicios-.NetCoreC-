using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerClase08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 8";
            string numString;
            int num, auxNum; 
            int[] valor;
            int[] antig;  
            int [] cantidad;
            string[] nombre;
            float[] sueldoBruto;
            float[] descuento;
            float[] sueldoNeto; 
           
            Console.WriteLine("Cuantos empleados va a Ingresar");
            numString = Console.ReadLine();
            while (int.TryParse(numString, out num) == false || num<1)
            {
                Console.WriteLine("Error, ingrese un numero");
                numString = Console.ReadLine();
            }
            nombre = new string[num]; 
            valor= new int[num];
            antig= new int[num]; 
            cantidad= new int[num];
            sueldoBruto = new float[num]; 
            sueldoNeto= new float[num];
            descuento= new float[num];

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Ingrese nombre de empleado {0}", i+1);
                nombre[i] = Console.ReadLine();

                Console.WriteLine("Ingrese valor hora del empleado {0}", i+1);
                numString = Console.ReadLine();
                while (int.TryParse(numString, out auxNum) == false || num < 1)
                {
                    Console.WriteLine("Error, ingrese un numero");
                    numString = Console.ReadLine();
                }
                valor[i] = auxNum;

                Console.WriteLine("Ingrese la antiguedad en años del empleado {0}", i+1);
                numString = Console.ReadLine();
                while (int.TryParse(numString, out auxNum) == false || num < 1)
                {
                    Console.WriteLine("Error, ingrese un numero");
                    numString = Console.ReadLine();
                }
                antig[i] = auxNum;

                Console.WriteLine("Ingrese la cantidad de horas trabajadas del empleado {0}", i+1);
                numString = Console.ReadLine();
                while (int.TryParse(numString, out auxNum) == false || num < 1)
                {
                    Console.WriteLine("Error, ingrese un numero");
                    numString = Console.ReadLine();
                }
                cantidad[i] = auxNum;

                sueldoBruto[i] = (valor[i] * cantidad[i]) + (antig[i] * 150);
                descuento[i] = 13 * sueldoBruto[i] / 100;
                sueldoNeto[i] = sueldoBruto[i] - descuento[i]; 
            }

            Console.Clear();
            Console.WriteLine("---------------Recivos de Sueldo------------");
            Console.WriteLine("Nombre   Antiguedad  ValorHora   Bruto   Descuento   Neto"); 
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("{0,-15} {1,-6} {2,-4} {3,-10:#,#.00} {4,-6:#,#.00} {5,-10:#,#.00}", nombre[i], antig[i], valor[i], sueldoBruto[i], descuento[i],sueldoNeto[i]); 
            }
            Console.ReadKey();
        }
    }
}
