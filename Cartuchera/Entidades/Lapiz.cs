using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //Lapiz-> color:ConsoleColor(público); trazo:ETipoTrazo(enum {Fino, Grueso, Medio}; público); PreciosCuidados->true; 
    //Reutilizar UtilesToString en ToString() (mostrar TODOS los valores).
    public class Lapiz : Utiles
    {
        public enum ETipoTrazo { Fino, Grueso, Medio};

        public ConsoleColor color;
        public ETipoTrazo trazo; 
       
        public Lapiz (ConsoleColor color, ETipoTrazo trazo, string marca, double precio):base(marca, precio)
        {
            this.color = color;
            this.trazo = trazo; 
        }

        public override bool PreciosCuidados
        {
            get
            {
                return true; 
            }
        }
        
        public override string ToString()
        {
            return UtilesToString()+"\nColor: "+this.color+"\nTrazo: "+this.trazo+"\nPrecios Cuidados: "+this.PreciosCuidados;
        }
    }
}
