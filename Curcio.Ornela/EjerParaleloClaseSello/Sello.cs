using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerParaleloClaseSello
{
    class Sello
    {
        public static string mensaje; // llega desde el main. 
        public static ConsoleColor color;
        //public static string formato; 
        private static string ArmarForamatoMensaje()
        {
            string formato = "";
            int len = Sello.mensaje.Length; 
            if (len > 0) //& que no aparezca espacios. Buscar. 
            {
                string asteriscos = "*";
                for (int i = 0; i <= len; i++)
                {
                    asteriscos = "*" + asteriscos;
                }
                formato = asteriscos + "\n" + "*" + Sello.mensaje + "*" + "\n" + asteriscos;
            }
            return formato; 
        }
        public static string Imprimir()
        {
            return ArmarForamatoMensaje();
        }
        public static void Borrar()
        {
            Sello.mensaje= ""; 
        }
        public static void ImprimirEnColor()
        {
            Console.ForegroundColor =  Sello.color;
            Console.WriteLine(Sello.Imprimir());
            Console.ResetColor(); 
        }
        

    }
}
