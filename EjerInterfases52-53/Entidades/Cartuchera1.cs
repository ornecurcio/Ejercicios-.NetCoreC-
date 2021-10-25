using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cartuchera1
    {
        private List<IAcciones> acciones; 

        public Cartuchera1()
        {
            this.acciones = new List<IAcciones>(); 
        }
        public List<IAcciones> Acciones
        {
            get
            {
                return this.acciones; 
            }
        }

        public static Cartuchera1 operator +(Cartuchera1 cartuchera1, object obj)
        {
            if (obj is Lapiz || obj is Boligrafo)
                cartuchera1.acciones.Add((IAcciones)obj);

            return cartuchera1;
        }

        public bool ProbarElementos()
        {
            bool rta = false;
            foreach (IAcciones item in this.acciones)
            {
                if(item.UnidadesDeEscritura<=0)
                {
                    rta = false;
                    item.Recargar(20); 
                    break; 
                }
                else
                {
                    item.Escribir("O");
                    Console.WriteLine(item);
                    rta = true;
                    item.Recargar(1); 
                }
            }
            return rta; 
        }
    }
}
