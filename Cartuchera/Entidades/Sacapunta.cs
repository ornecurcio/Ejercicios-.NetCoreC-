using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //Sacapunta-> deMetal:bool(público); 
    //Reutilizar UtilesToString en ToString() (mostrar TODOS los valores).sdfrg
    public class Sacapunta: Utiles
    {
        public bool deMetal;

        public Sacapunta(bool deMetal, string marca, double precio) : base(marca, precio)
        {
            this.deMetal = deMetal;
        }

        public override bool PreciosCuidados
        {
            get
            {
                return false;
            }
        }

        public override string ToString()
        {
            return UtilesToString() + "\nDe metal: " + this.deMetal + "\nPrecios Cuidados: " + this.PreciosCuidados;
        }
    }
}
