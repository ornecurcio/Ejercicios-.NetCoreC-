using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesEstacionamiento
{
    public class Estacionamiento
    {
        private int capacidadEstacionamiento; 
        private static Estacionamiento estacionamiento;
        private List<Vehiculo> listadoVehiculos;
        private string nombre; 

        public string Nombre
        {
            get 
            {
                return this.nombre; 
            }
        }
        public List<Vehiculo> ListadoVehiculos
        {
            get
            {
                return this.listadoVehiculos; 
            }
        }
        private Estacionamiento(string nombre, int capacidad)
        {
            this.listadoVehiculos = new List<Vehiculo>();
            this.nombre = nombre;
            this.capacidadEstacionamiento = capacidad; 
        }
        public static Estacionamiento GetEstacionamiento(string nombre, int capacidad)
        {
            //i.Si la variable estacionamiento es null, instanciar el objeto.
            if (estacionamiento is null)
            {
                Estacionamiento.estacionamiento = new Estacionamiento(nombre, capacidad);
            }
            else
            {
                // ii.Si no es null, modificara la capacidad del estacionamiento.
                Estacionamiento.estacionamiento.capacidadEstacionamiento = capacidad;
            }
            //iii.En ambos casos, su última acción será retornar el objeto estacionamiento.
            return Estacionamiento.estacionamiento;
        }
        public string InformarSalida(Vehiculo vehiculo)
        {
            StringBuilder stringbuilder = new StringBuilder();
            stringbuilder.Append(this.Nombre);
            stringbuilder.Append(vehiculo.ToString());
            stringbuilder.Append(vehiculo.HoraEgreso);
            stringbuilder.Append(vehiculo.CostoEstadia);

            return stringbuilder.ToString(); 
        }
        public static bool operator ==(Estacionamiento estacionamiento, Vehiculo v1)
        {
            bool rta = false; 
            if (!(estacionamiento is null) && !(v1 is null))
            {
                foreach (Vehiculo item in estacionamiento.ListadoVehiculos)
                {
                    if (item == v1)
                    {
                        rta = true;
                        break; 
                    }
                }
            }
            return rta; 
        }
        public static bool operator !=(Estacionamiento estacionamiento, Vehiculo v1)
        {
            return !(estacionamiento == v1); 
        }
        public static bool operator +(Estacionamiento estacionamiento, Vehiculo v1)
        {
            bool rta = false; 
            if(!(estacionamiento is null) && !(v1 is null) 
               && estacionamiento.listadoVehiculos.Count < estacionamiento.capacidadEstacionamiento)
            {
                if (estacionamiento != v1)
                {
                    estacionamiento.listadoVehiculos.Add(v1);
                    rta = true; 
                }
            }
            return rta; 
        }
        public static bool operator -(Estacionamiento estacionamiento, Vehiculo v1)
        {
            bool rta = false;
            if (!(estacionamiento is null) && !(v1 is null))
            {
                if (estacionamiento == v1)
                {
                    estacionamiento.listadoVehiculos.Remove(v1);
                    rta = true;
                }
            }
            return rta;
        }
    }
}
