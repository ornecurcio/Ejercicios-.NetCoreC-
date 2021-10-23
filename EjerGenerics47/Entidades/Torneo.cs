using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Torneo<T> where T:Equipo
    {
        private List<T> equipos;
        private string nombre;

        //T atributo; 

        private Torneo()
        {
            this.equipos = new List<T>();
        }
        public Torneo(string nombre):this()
        {
            this.nombre = nombre; 
            //atributo = default(T); // esto instancia por defecta el objeto si no se que va a llegar
        }
        
        public static bool operator ==(Torneo<T> torneo, T equipo)
        {
            foreach (T item in torneo.equipos)
            {
                if(item == equipo)
                {
                    return true; 
                }
            }
            return false; 
        }
        public static bool operator !=(Torneo<T> torneo, T equipo)
        {
            return !(torneo == equipo); 
        }

        public static bool operator +(Torneo<T> torneo, T equipo)
        {
            if(torneo is not null && equipo is not null && torneo != equipo)
            {
                torneo.equipos.Add(equipo);
                return true; 
            }
            return false; 
        }

        public string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Nombre del torneo: {this.nombre}"); 
            foreach  (T item in this.equipos)
            {
                stringBuilder.AppendLine(item.Ficha()); 
            }
            return stringBuilder.ToString(); 
        }
        private string CalcularPartido(T a, T b)
        {
            Random random = new Random();
            return $"{a.Nombre} {random.Next(0, 10)} - {b.Nombre} {random.Next(0, 10)}"; 
        }
        public string JugarPartido
        {
            get
            {
                Random random = new Random();
                T equipoA;
                T equipoB;
                do
                {
                    equipoA = this.equipos[random.Next(0, equipos.Count())];
                    equipoB = this.equipos[random.Next(0, equipos.Count())];
                } while (equipoA == equipoB); 

                return CalcularPartido(equipoA, equipoB); 
            }
        }
    }
}
