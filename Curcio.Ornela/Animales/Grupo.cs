using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    public class Grupo
    {
        #region Atributos
        private List<Mascota> manada;
        private string nombre;
        private static EtipoManada tipo;
        #endregion

        #region Propiedades
        public static EtipoManada Tipo
        {
            set
            {
                Grupo.tipo = value;
            }
        }
        #endregion

        #region Constructores
        private Grupo()
        {
            this.manada = new List<Mascota>();
        }
        static Grupo()
        {
            Grupo.Tipo = EtipoManada.Unica;
        }
        public Grupo(string nombre):this()
        {
            this.nombre = nombre;
        }
        public Grupo(string nombre, EtipoManada tipo) : this(nombre)
        {
            Grupo.Tipo = tipo;
        }
        #endregion

        #region Sobrecargas
        public static bool operator ==(Grupo g, Mascota m)
        {
            bool rta = false; 
            if (!(g is null) && !(m is null))
            {
                foreach (Mascota animal in g.manada)
                {
                    if(m.Equals(animal)) //m==animal NO anda
                    {
                        rta= true;
                        break; 
                    }
                }
            }
            return rta; 
        }
        public static bool operator !=(Grupo g, Mascota m)
        {
            return !(g == m); 
        }
        public static Grupo operator +(Grupo g, Mascota m)
        {
            if (g == m)
            {
                Console.WriteLine($"Ya está el '{m}' en el grupo");
            }
            else 
            {
                g.manada.Add(m); 
            }
            return g; 
        }
        public static Grupo operator -(Grupo g, Mascota m)
        {
            if (g==m)
            {
                g.manada.Remove(m);
                //for (int i = 0; i < g.manada.Count; i++)
                //{
                //    if (g.manada[i] == m)
                //    {
                //        g.manada.RemoveAt(i); 
                //    }
                //}

            }
            else
            {
                Console.WriteLine($"No esta el '{m}' en la lista");
            }
            return g;
        }
        public static implicit operator string(Grupo g)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Grupo: {g.nombre} - tipo:{Grupo.tipo}");
            stringBuilder.AppendLine($"Integrantes({g.manada.Count})");
            foreach (Mascota item in g.manada)
            {
                stringBuilder.AppendLine(item.ToString());
            }
            return stringBuilder.ToString(); 
        }
        #endregion
    }
}
