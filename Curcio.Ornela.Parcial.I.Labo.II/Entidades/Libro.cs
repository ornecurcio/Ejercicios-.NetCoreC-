using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Libro
    {
        protected Autor autor;
        protected int cantidadDePaginas;
        protected static Random generadorDePaginas; 
        protected float precio;
        protected string titulo; 

        public int CantidadDePaginas
        {
            get
            {
                if (this.cantidadDePaginas == 0)
                {
                    this.cantidadDePaginas = generadorDePaginas.Next(10, 570);
                }
                return this.cantidadDePaginas;
            }
        }

        static Libro()
        {
            Libro.generadorDePaginas=new Random();
        }
        public Libro(string titulo, float precio, Autor autor)
        {
            this.precio = precio;
            this.titulo = titulo;
            this.autor = autor; 
        }
        public Libro(string titulo, string apellido, string nombre, float precio)
               :this(titulo,precio,new Autor(apellido,nombre))
        { 
        }
        private static string Mostrar(Libro l)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"AUTOR: {l.autor}");
            stringBuilder.AppendLine($"TITULO: {l.titulo}");
            stringBuilder.AppendLine($"CANTIDAD DE PAGINAS: {l.CantidadDePaginas}");
            stringBuilder.AppendLine($"PRECIO: {l.precio}");

            return stringBuilder.ToString();
        }
        public static explicit operator String(Libro l)
        {
            return Libro.Mostrar(l); 
        }
        public static bool operator ==(Libro a, Libro b)
        {
            bool rta = false;
            if (a is null && b is null)
            {
                rta = true;
            }
            else
            {
                if (!(a is null && b is null) &&
                    a.titulo == b.titulo && a.autor == b.autor)
                {
                    rta = true;
                }
            }
            return rta;
        }
        public static bool operator !=(Libro a, Libro b)
        {
            return !(a == b);
        }
    }
}
