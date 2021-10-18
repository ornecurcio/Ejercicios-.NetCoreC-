using System;
using System.Collections.Generic; 

namespace Entidades
{
    public abstract class Persona
    {
        protected string nombre;
        protected int id;
        protected int dni;
        protected bool asistir;
        protected List<Materia> materias;

        private Persona()
        {
            this.materias = new List<Materia>();
        }
        protected Persona(string nombre, int id, int dni, bool asistir) : this()
        {
            this.nombre = nombre;
            this.id = id;
            this.dni = dni;
            this.asistir = asistir;
        }
        public string Nombre
        {
            get
            {
                return this.nombre; 
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this.nombre = value; 
                }
            }
        }
        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                if (value>0 && value<99999999)
                {
                    this.dni = value;
                }
            }
        }
        public List<Materia> Materias
        {
            get
            {
                return this.materias;
            }
            
        }
        protected bool AsistirClase()
        {
            return asistir = true; 
        }
        protected abstract void PrepararParcial(); 

    }

}
