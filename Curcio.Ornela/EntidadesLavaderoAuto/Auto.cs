using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesLavaderoAuto
{
    public class Auto: Vehiculo
    {
        protected int cantidadDeAsientos;

        public Auto(string patente, byte cantRuedas, EMarcas marca, int cantidadDeAsientos)
                    : base(patente, cantRuedas, marca)
        {
            this.cantidadDeAsientos = cantidadDeAsientos;
        }
        public string MostrarMoto()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(base.Mostrar());
            stringBuilder.Append($"Cant de asientos: {this.cantidadDeAsientos}");

            return stringBuilder.ToString();
        }
    }
}
