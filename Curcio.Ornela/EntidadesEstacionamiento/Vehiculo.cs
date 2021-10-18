using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesEstacionamiento
{
    public abstract class Vehiculo
    {
        public enum EVehiculos { Automovil, Moto, };

        #region Atributos
        private DateTime horaEgreso;
        private DateTime horaIngreso;
        private string patente;
        #endregion
        #region Constructor
        public Vehiculo(string patente, DateTime horaIngreso)
        {
            this.Patente = patente;
            this.horaIngreso = horaIngreso; 
        }
        #endregion

        #region Propiedades
        public abstract double CostoEstadia { get; }
        public abstract string Descripcion { get; }
        public DateTime HoraEgreso 
        { 
            get
            { 
                return this.HoraEgreso; 
            }
            set
            {
                if (value > horaIngreso)
                {
                    this.horaEgreso = value;
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
                if(ValidarPatente(value))
                {
                    this.patente = value; 
                }
            }
        }

        #endregion

        #region Metodos
        private bool ValidarPatente(string patente)
        {
            if (!string.IsNullOrWhiteSpace(patente) && patente.Length<8 && patente.Length>5)
            {
                return true; 
            }
            return false; 
        }
        protected virtual double CargoDeEstacionamiento()
        { 
            return (horaEgreso - horaIngreso).TotalHours;
        }
        protected virtual string MostrarDatos()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Patente: {this.patente}");
            stringBuilder.AppendLine($"Hora de Ingreso: {this.horaIngreso}"); 
            return stringBuilder.ToString(); 
        }
        #endregion

        #region Sobrecarga
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            if ((v1 is null) && (v2 is null))
            {
                return true;
            }
            else
            {
                if (!(v1 is null) && !(v2 is null) && v1.patente == v2.patente)
                {
                    return true; 
                }
            }
            return false; 
        }
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2); 
        }
        #endregion
    }
}
