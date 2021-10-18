using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Materia
    {
        private string nombre;
        private int cargaHoraria;
        private bool cuatrimestral;
        private bool finalObligatorio;
        private bool correlativa;

        public Materia(string nombre, int cargaHoraria, bool cuatrimestral, bool finalObligatorio, bool correlativa)
        {
            this.nombre = nombre;
            this.cargaHoraria = cargaHoraria;
            this.cuatrimestral = cuatrimestral;
            this.finalObligatorio = finalObligatorio;
            this.correlativa = correlativa; 
        }
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    this.nombre = value;
                }
            }
        }

        public int CargaHoraria
        {
            get { return cargaHoraria; }
            set
            {
                if (value > 0)
                {
                    this.cargaHoraria = value;
                }
            }
        }

        public bool Cuatrimestral
        {
            get { return cuatrimestral; }
            set
            {
                if (value is true)
                {
                    this.cuatrimestral = value;
                }
            }
        }
        public bool FinalObligatorio
        {
            get { return finalObligatorio; }
            set
            {
                if (value is true)
                {
                    this.finalObligatorio = value;
                }
            }
        }
        public bool Correlativa
        {
            get { return correlativa; }
            set
            {
                if (value is true)
                {
                    this.correlativa = value;
                }
            }
        }

    }
}
