using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesStarWars
{
    public class EjercitoImperial
    {
        private int capacidad;
        private List<Trooper> troopers;

        public List<Trooper> Troopers
        {
            get
            {
                return troopers; 
            }
        }
        private EjercitoImperial()
        {
            this.troopers = new List<Trooper>(); 
        }
        public EjercitoImperial(int capacidad):this()
        {
            this.capacidad = capacidad; 
        }
        public static EjercitoImperial operator +(EjercitoImperial ejercito, Trooper soldado)
        {
            if (ejercito is not null && soldado is not null && ejercito.Troopers.Count < ejercito.capacidad)
            {
                ejercito.Troopers.Add(soldado); 
            }
            return ejercito; 
        }
        public static EjercitoImperial operator -(EjercitoImperial ejercito, Trooper soldado)
        {
            if (ejercito is not null && soldado is not null)
            {
                foreach (Trooper item in ejercito.troopers)
                {
                    if (item.Equals(soldado))
                    {
                        ejercito.troopers.Remove(soldado);
                        break; 
                    }
                }
            }
            return ejercito; 
        }
    }
}
