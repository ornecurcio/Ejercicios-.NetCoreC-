using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesLavaderoAuto
{
    public class Lavadero
    {
        private List<Vehiculo> vehiculos;
        private float precioAuto;
        private float precioCamion;
        private float precioMoto;

        private Lavadero()
        {
            this.vehiculos = new List<Vehiculo>();
        }
        public Lavadero(float precioAuto, float precioCamion, float precioMoto) : this()
        {
            this.precioAuto = precioAuto;
            this.precioCamion = precioCamion;
            this.precioMoto = precioMoto;
        }
        public string Lavaderos
        {
            get 
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine($"Precios: auto {this.precioAuto} - camion {this.precioCamion} - " +
                                         $"moto {precioMoto}");
                stringBuilder.AppendLine($"Cantidad de Vehiculos:{this.vehiculos.Count}");
                foreach (Vehiculo item in this.vehiculos)
                {
                    if (item is Moto)
                        stringBuilder.AppendLine(((Moto)item).MostrarMoto()); 
                    if(item is Auto)
                        stringBuilder.AppendLine(((Auto)item).MostrarMoto());
                    if(item is Camion)
                        stringBuilder.AppendLine(((Camion)item).MostrarMoto());
                }
                return stringBuilder.ToString();
            }
        }
        public double MostrarValorFacturado()
        {
            return 0;
        }
        public double MostrarValorFacturado(EVehiculos vehiculo)
        {
            return 0; 
        }

        public static bool operator ==(Lavadero l, Vehiculo v)
        {
            bool rta = false;
            if (!(l is null) && !(v is null))
            {
                foreach (Vehiculo item in l.vehiculos)
                {
                    if (v==item)
                    {
                        rta = true;
                        break;
                    }
                }
            }
            return rta;
        }
        public static bool operator !=(Lavadero l, Vehiculo v)
        {
            return !(l == v); 
        }
        public static Lavadero operator +(Lavadero l, Vehiculo v)
        {
            if (l == v)
            {
                Console.WriteLine($"Ya está el '{v}' en el lavadero");
            }
            else
            {
                l.vehiculos.Add(v);
            }
            return l;
        }
        public static Lavadero operator -(Lavadero l, Vehiculo v)
        {
            if (l == v)
            {
                l.vehiculos.Remove(v);
            }
            else
            {
                Console.WriteLine($"No esta el '{v}' en la lista");
            }
            return l;
        }

        
    }
}
