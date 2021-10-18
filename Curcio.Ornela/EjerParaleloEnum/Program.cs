using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerParaleloEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            //miEnum emun1 = miEnum.valor2;

            //Console.WriteLine(emun1);
            //Console.WriteLine((int)emun1); 

            //Alfajor a1 = new Alfajor(Alfajores.capitanDelEspacio, (int)Alfajores.capitanDelEspacio);
            //Alfajor a2 = new Alfajor(Alfajores.fulbito, (int)Alfajores.fulbito); 
            //Alfajor.Mostrar(a1);
            //Alfajor.Mostrar(a2); 

            //recorrer 
            //foreach (Alfajores item in Enum.GetValues(typeof(Alfajores))) // getvalue obtiene el valor del enum. retorna un array
            //{                                                             //getname obtiene el nombre, tmb devuelve un array para recorrer
            //    Console.WriteLine("nombre: " + item);
            //    Console.WriteLine("nombre: " + (int)item);
            //    Console.WriteLine("");
            //}

            //string variable = "CapitanDelaGalaxia"; //si es un nombre distinto a lo que tengo en la declaracion de enum, rompe
            string variable = "capitanDelEspacio";
            Alfajores alfajor = (Alfajores)Enum.Parse(typeof(Alfajores), variable);
            Console.WriteLine(alfajor);

            //ConsoleColor color;
            //switch (color)
            //{
            //    case ConsoleColor.Black:
            //        break;
            //    case ConsoleColor.DarkBlue:
            //        break;
            //    case ConsoleColor.DarkGreen:
            //        break;
            //    case ConsoleColor.DarkCyan:
            //        break;
            //    case ConsoleColor.DarkRed:
            //        break;
            //    case ConsoleColor.DarkMagenta:
            //        break;
            //    case ConsoleColor.DarkYellow:
            //        break;
            //    case ConsoleColor.Gray:
            //        break;
            //    case ConsoleColor.DarkGray:
            //        break;
            //    case ConsoleColor.Blue:
            //        break;
            //    case ConsoleColor.Green:
            //        break;
            //    case ConsoleColor.Cyan:
            //        break;
            //    case ConsoleColor.Red:
            //        break;
            //    case ConsoleColor.Magenta:
            //        break;
            //    case ConsoleColor.Yellow:
            //        break;
            //    case ConsoleColor.White:
            //        break;
            //    default:
            //        break;
            //}
            Console.ReadKey(); 

        }

        //enum miEnum { valor1, valor2=10, valor3}; 
    }
}
