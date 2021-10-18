using System;
using System.Text; 

namespace EntidadesEstacionamiento
{
    public abstract class Vehiculo
    {
        public enum EVehiculos { Automovil, Moto }

        private DateTime horaEgreso;
        private DateTime horaIngreso;
        private string patente;

        public abstract double CostoEstadia{ get; }
        public abstract string Descripcion { get; }
        public DateTime HoraEgreso 
        {
            get
            {
                return this.horaEgreso;    
            }
            set
            {
                if (value > horaIngreso)
                {
                    this.HoraEgreso = value;
                }
            }
        }
        public DateTime HoraIngreso { get; }
        public string Patente 
        {
            get
            {
                return this.patente; 
            }
            set
            {
                if (ValidarPatente(value))
                {
                    this.patente = value; 
                }
            }
        }

        public Vehiculo(string patente, DateTime horaIngreso)
        {
            this.Patente = patente;
            this.horaIngreso = horaIngreso; 
        }

        private bool ValidarPatente(string patente)
        {
            bool rta = false;
            if (!string.IsNullOrWhiteSpace(patente) && (patente.Length > 7 || patente.Length < 6))
            {
                rta = true; 
            }
            return rta; 
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            bool rta = false; 
            if (!(v1 is null) && !(v2 is null) && v1.patente==v2.patente)
            {
                rta = true; 
            }
            return rta; 
        }
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2); 
        }
        protected virtual string MostrarDatos()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"Patente: {this.Patente}, Hora Ingreso: {this.HoraIngreso}");

            return stringBuilder.ToString(); 
        }
        protected virtual double CargoDeEstacionamiento()
        {
            return (double)(this.HoraEgreso.Hour - this.HoraIngreso.Hour);
        }

    }
}
