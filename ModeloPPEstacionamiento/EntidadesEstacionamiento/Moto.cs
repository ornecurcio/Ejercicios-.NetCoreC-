using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesEstacionamiento
{
    public sealed class Moto : Vehiculo
    {
        public enum ETipo { Ciclomotor, Scooter, Sport }

        private ETipo tipo;
        private static double valorHora;
        public override double CostoEstadia
        {
            get
            {
                return CargoDeEstacionamiento();
            }
        }
        public override string Descripcion
        {
            get
            {
                return this.tipo.ToString();
            }
        }

        public double ValorHora
        {
            set 
            {
                if(value > 0)
                {
                    valorHora = value;   
                }
            }
        }
        static Moto()
        {
            Moto.valorHora = 100;
        }
        public Moto(string patente, DateTime horaIngreso, ETipo tipo) : base(patente, horaIngreso)
        {
            this.tipo = tipo; 
        }
        protected override double CargoDeEstacionamiento()
        {
            return base.CargoDeEstacionamiento() * Moto.valorHora;
        }
        protected override string MostrarDatos()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("******MOTO******");
            stringBuilder.Append($"Tipo: {this.Descripcion}, {base.MostrarDatos()}, " +
                                 $"Hora Egreso: {this.HoraEgreso}, Costo: {this.CostoEstadia}");

            return stringBuilder.ToString();
        }
        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}
