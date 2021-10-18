using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerParaleloEnum
{
    class Alfajor
    {
        private Alfajores nombre;
        private int precio;

        public Alfajor(Alfajores nombre, int precio)
        {
            this.nombre = nombre;
            this.precio = precio; 
        }
        public static void Mostrar(Alfajor a)
        {
            Console.WriteLine("nombre: " + a.nombre);
            Console.WriteLine("nombre: " + a.precio);
            Console.WriteLine("");
        }
        enum otroEnum { valor1}; // para acceder es Alfajor.otroEnum; esto es menos comun. 

    }
}
