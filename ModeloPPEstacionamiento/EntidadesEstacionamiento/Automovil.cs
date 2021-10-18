using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesEstacionamiento
{
    public sealed class Automovil : Vehiculo
    {
        private string marca;
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
               return this.marca; 
            }
        }
        static double ValorHora
        {
            set
            {
                if (value > 0)
                {
                    Automovil.valorHora = value; 
                }
            }
        }
        static Automovil()
        {
            Automovil.valorHora = 120; 
        }
        public Automovil(string patente, DateTime horaIngreso, string marca): base(patente, horaIngreso)
        {
            this.marca = marca; 
        }
        protected override double CargoDeEstacionamiento()
        {
            return base.CargoDeEstacionamiento() * Automovil.valorHora; 
        }
        protected override string MostrarDatos()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("******AUTOMOVIL******"); 
            stringBuilder.Append($"Marca: {this.Descripcion}, {base.MostrarDatos()}, " +
                                 $"Hora Egreso: {this.HoraEgreso}, Costo: {this.CostoEstadia}");

            return stringBuilder.ToString();
        }
        public override string ToString()
        {
            return this.MostrarDatos(); 
        }
    }
}
