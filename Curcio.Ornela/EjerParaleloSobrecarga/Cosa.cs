using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    class Cosa
    {
        private int entero;
        private string cadena;
        private DateTime fecha;

        public void EstablecerValor(int a)
        {
            this.entero = a; 
        }
        public void EstablecerValor(string a)
        {
            this.cadena = a; 
        }
        public void EstablecerValor(DateTime a)
        {
            this.fecha = a; 
        }
        //        (+) Cosa(DateTime, int, string)
        //        (+) Cosa(int, string)
        //        (+) Cosa(string)
        //        (+) Cosa()

        
        private string Mostrar()
        {
            //string rta = this.entero.ToString()+", \n" + this.cadena + ", \n" 
            //    + this.fecha.ToShortDateString();
            return this.entero.ToString() + ", \n" + this.cadena + ", \n"
                 + this.fecha.ToShortDateString();
        }
        public static string Mostrar(Cosa a)
        {
           //string rta= a.Mostrar();
            return a.Mostrar(); 
        }
   
        //        clase Cosa
        //*-*-*-*-*-*-
        //(-) entero:int
        //(-) cadena:string
        //(-) fecha:DateTime
        //*-*-*-*-*-*-*-*-*-*-*
        //(+) EstablecerValor(int) :void
        //(+) EstablecerValor(string) :void
        //(+) EstablecerValor(DateTime) :void
        // *-*-*-*-*-*-*-*-*-*
        //(-) Mostrar() :string -> de instancia
        // (+) Mostrar(Cosa) :string -> de clase
        //*-*-*-*-*-*-*-*-*-*

    }
}
