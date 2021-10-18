using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesLavaderoAuto
{
    public class Camion: Vehiculo
    {
        protected float tara;

        public Camion(string patente, byte cantRuedas, EMarcas marca, float tara)
                    : base(patente, cantRuedas, marca)
        {
            this.tara = tara;
        }
        public string MostrarMoto()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(base.Mostrar());
            stringBuilder.Append($"Tara: {this.tara}");

            return stringBuilder.ToString();
        }
    }
}
