using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesEstacionamiento
{
    public class Moto: Vehiculo
    {
        public enum ETipo { Ciclomotor, Scooter, Sport };

        private ETipo tipo;
        private static double valorHora;

        static Moto()
        {
            Moto.ValorHora = 100; 
        }
        private Moto(string patetente, DateTime horaIngreso, ETipo tipo):base(patetente, horaIngreso)
        {
            this.tipo = tipo; 
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
                return this.tipo.ToString(); 
            }
        }
        protected override double CargoDeEstacionamiento()
        {
            return base.CargoDeEstacionamiento() * valorHora; 
        }
        protected override string MostrarDatos()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"*****MOTO*****");
            stringBuilder.AppendLine($"Tipo: {Descripcion}"); 
            stringBuilder.AppendLine(base.MostrarDatos());
            stringBuilder.AppendLine($"Hora Egreso: {HoraEgreso}");
            stringBuilder.AppendLine($"Costo Estadia: {CostoEstadia}");
            stringBuilder.AppendLine("-----------------");

            return stringBuilder.ToString(); 
        }
        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}
