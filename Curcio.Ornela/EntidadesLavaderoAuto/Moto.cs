using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesLavaderoAuto
{
    public class Moto: Vehiculo
    {
        protected float cilindrada;

        public Moto(string patente, byte cantRuedas, EMarcas marca, float cilindrada) 
                    :base(patente, cantRuedas, marca)
        {
            this.cilindrada = cilindrada; 
        }
        public string MostrarMoto()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(base.Mostrar()); 
            stringBuilder.Append($"Cilindrada: {this.cilindrada}");

            return stringBuilder.ToString(); 
        }
    }
}
