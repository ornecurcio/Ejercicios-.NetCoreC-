using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Botellas; 

namespace Entidades.Establecimiento
{
    public class Bar
    {
        private List<Botella> botellas;
        int capacidadMaximaBotellas;
        string nombre;
        double recaudacion; 

        public List<Botella> Botellas 
        { 
            get
            {
                return this.botellas; 
            } 
        }

        public string MostrarBar
        {
            get
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append($"Bar {this.nombre}, cantidad Max Botellas {this.capacidadMaximaBotellas}, " +
                    $"cantidad actual: {Botellas.Count}, recaudacion: {this.recaudacion}");
                return stringBuilder.ToString(); 
            }
        }

        public Bar():this(5)
        {
        }
        public Bar(int capacidad): this(capacidad, "Sin Nombre")
        { 
        }
        public Bar(int capacidad, string nombre)
        {
            this.botellas = new List<Botella>();
            this.nombre = nombre;
            this.capacidadMaximaBotellas = capacidad;
        }

        private string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(this.MostrarBar);
            foreach (Botella item in Botellas)
            {
                stringBuilder.AppendLine(item.ToString()); 
            }
            return stringBuilder.ToString(); 
        }
        public static explicit operator Double(Bar b)
        {
            return b.recaudacion;
        }
        public static bool operator ==(Bar a, Botella b)
        {
            bool rta = false;
            foreach (Botella item in a.Botellas)
            {
                if (b.Equals(item))
                {
                    rta = true;
                    break; 
                }
            }
            return rta; 
        }
        public static bool operator !=(Bar a, Botella b)
        {
            return !(a == b); 
        }
        public static Bar operator +(Bar a, Botella b)
        {
            if (a.botellas.Count < a.capacidadMaximaBotellas)
            {
                a.botellas.Add(b); 
            }
            return a; 
        }
        public static Bar operator -(Bar a, Botella b)
        {
            if (a == b)
            {
                b--;
                a += b.Ganancia;
                if (b.PorcentajeContenido == 0)
                {
                    a.botellas.Remove(b); 
                }
            }
            return a; 
        }
        public static Bar operator +(Bar a, double g)
        {
            a.recaudacion = a.recaudacion + g; 
            return a; 
        }
        public void OrdenarBotellas(Ordenamiento o)
        {
            switch (o)
            {
                case Ordenamiento.Marca:
                    this.Botellas.Sort(OrdenarPorMarca); 
                    break;
                case Ordenamiento.Ganancia:
                    this.Botellas.Sort(OrdenarPorGanancia); 
                    break;
                case Ordenamiento.PorcentanjeContenido:
                    this.Botellas.Sort(OrdenarPorContenido); 
                    break;
                default:
                    break;
            }
        }
        private static int OrdenarPorContenido(Botella a, Botella b)
        {
            return (int)(a.PorcentajeContenido - b.PorcentajeContenido); 
        }
        private int OrdenarPorGanancia(Botella a, Botella b)
        {
            return (int)(a.Ganancia - b.Ganancia);
        }
        private static int OrdenarPorMarca(Botella a, Botella b)
        {
           return ((string)a).CompareTo((string)b); 
        }
    }
}
