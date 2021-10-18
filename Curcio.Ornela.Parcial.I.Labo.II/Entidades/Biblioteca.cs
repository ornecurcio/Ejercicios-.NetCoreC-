using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Biblioteca
    {
        private int capacidad;
        private List<Libro> libros;

        private Biblioteca()
        {
            this.libros = new List<Libro>();
        }
       
        private Biblioteca(int capacidad):this()
        {
            this.capacidad = capacidad; 
        }
        public double PrecioDeManuales
        {
            get
            {
                double precio = 0; 
                foreach (Libro item in this.libros)
                {
                    if(item is Manual)
                    precio =+ (Single)(Manual)item;
                }
                return precio;
            }
        }
        public double PrecioDeNovelas
        {
            get
            {
                double precio = 0;
                foreach (Libro item in this.libros)
                {
                    if(item is Novela)
                    precio =+ (Novela)item;
                }
                return precio;
                
            }
        }
        public double PrecioDeTotal
        {
            get
            {
                double precio = 0;
                precio = this.PrecioDeManuales + this.PrecioDeNovelas;
                return precio; 
            }
        }
        
        public static string Mostrar(Biblioteca b)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Capacidad: {b.capacidad}");
            foreach (Libro item in b.libros)
            {
                stringBuilder.AppendLine(item.ToString()); 
            }
            return stringBuilder.ToString(); 

        }
        public static implicit operator Biblioteca(int capacidad)
        {
            return new Biblioteca(capacidad);
        }
        public static bool operator ==(Biblioteca b, Libro l)
        {
            bool rta = false;
            if (!(b is null) && !(l is null))
            {
                foreach (Libro item in b.libros)
                {
                    if (l is Novela && item==(Novela)l)
                    {
                        rta = true;
                        break; 
                    }
                    if (l is Manual && item == (Manual)l)
                    {
                        rta = true;
                        break;
                    }
                }
            }
            return rta;
        }
        public static bool operator !=(Biblioteca b, Libro l)
        {
            return !(b == l);
        }
        public static Biblioteca operator +(Biblioteca b, Libro l)
        {
            
            if (b == l)
            {
                Console.WriteLine($"Ya está el libro en el biblioteca");
            }
            else
            {
                if (b.libros.Count < b.capacidad && b != l)
                {
                    b.libros.Add(l);
                }
                else
                {
                    Console.WriteLine($"Ya no hay mas lugar en la biblioteca");
                }
               
            }
            return b;
        }

        private double ObtenerPrecio(ELibro tipoLibro)
        {
            double precio=0;
            
            {
                switch (tipoLibro)
                {
                    case ELibro.PrecioDeManuales:
                        
                        break;
                    case ELibro.PrecioDeNovelas:
                        
                        break;
                    case ELibro.PrecioTotal:

                        break;
                }
            }
              
            
            return precio; 
        }
    }
}
