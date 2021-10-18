using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesEstacionamiento
{
    public class Automovil: Vehiculo
    {
        private string marca;
        private static double valorHora;

        static Automovil()
        {
            Moto.ValorHora = 120;
        }
        private Automovil(string patetente, DateTime horaIngreso, string marca) : base(patetente, horaIngreso)
        {
            this.marca = marca;
        }
        public override double CostoEstadia
        {
            get
            {
                return this.CargoDeEstacionamiento();
            }
        }
        public static double ValorHora
        {
            set
            {
                if (value > 0)
                {
                    ValorHora = value;
                }
            }
        }
        public override string Descripcion
        {
            get
            {
                return this.marca; 
            }
        }
        protected override double CargoDeEstacionamiento()
        {
            return base.CargoDeEstacionamiento() * valorHora;
        }
        protected override string MostrarDatos()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"*****AUTOMOVIL*****");
            stringBuilder.AppendLine($"Marca: {Descripcion}"); 
            stringBuilder.AppendLine(base.MostrarDatos());
            stringBuilder.AppendLine($"Hora Egreso: {HoraEgreso}");
            stringBuilder.AppendLine($"Costo Estadia: {CostoEstadia}");
            stringBuilder.AppendLine("--------------------");

            return stringBuilder.ToString();
        }
        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}
