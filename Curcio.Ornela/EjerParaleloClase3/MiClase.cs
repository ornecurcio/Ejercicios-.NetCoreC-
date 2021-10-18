using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerParaleloClase3
{
    class MiClase
    {
        #region atributos
        public static int estatico; 
        public int no_estatico;
        #endregion
        #region metodos
        public static void MostrarEstatico()
        {
            Console.WriteLine(MiClase.estatico);
            Console.WriteLine(estatico); 
        }

        public void MostrarNoEstatico()
        {
            Console.WriteLine(this.no_estatico); // this representa al objeto que se esta ejecuntado en 
                                                 // este preciso momento. xq el objeto se construye en ejecucion
        }
        #endregion
    }
}
