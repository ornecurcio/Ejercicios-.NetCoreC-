using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Fecha
    {
        int id;
        List<Partido> partidos;

        public Fecha(int id, List<Partido> partidos)
        {
            this.id = id;
            this.partidos = partidos;
        }

        public int Id { get { return id; } set { id = value; } }
        public List<Partido> Partidos
        {
            get { return partidos; }
            set { partidos = value; }
        }
    }
}
