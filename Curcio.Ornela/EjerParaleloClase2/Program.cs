using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Clase02
{

    class Program
    {
        static void Main(string[] args)
        {

            MiClase.Mostrar();

            MiClase.entero = 88;
            MiClase.cadena = "hola";

            MiClase.Mostrar();

            MiClase.Guardar(9, "chau");

            Console.ForegroundColor = ConsoleColor.Cyan;

            MiClase.Mostrar();


            #region tryparse

            int num;
            bool rta = int.TryParse("5", out num);

            if (rta == true)
            {
                Console.Write(num);
            }
            else
            {
                Console.Write("error");
            }


            while (!int.TryParse("5sdfghdfghdfghdfgh", out num))
            {
                Console.WriteLine("ERROR. Ingrese un valor numérico!!!");
            }

            Console.WriteLine("Su número es {0}", num);

            #endregion

        }
    }



}
