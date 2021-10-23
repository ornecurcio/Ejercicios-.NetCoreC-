using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Fecha
    {
        private int id;
        private List<Partido> partidos; 

        public int Id 
        { 
            get
            {
                return this.id; 
            }
            set
            {
                if (value > 0)
                {
                    this.id = value; 
                }
            }
        }
        public List<Partido> Partidos 
        { 
            get
            {
                return this.partidos; 
            }
            set
            {
                if(value is not null)
                {
                    this.partidos = value; 
                }
            }
        }

        public Fecha(int id, List<Partido> partidos)
        {
            this.id = id;
            this.partidos = partidos; 
        }
    }
}
