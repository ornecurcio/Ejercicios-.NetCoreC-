using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesLavaderoAuto
{
    public class Vehiculo
    {
        protected string patente;
        protected byte cantRuedas;
        protected EMarcas marca;  

        protected EMarcas Marca
        {
            get 
            {
                return this.marca; 
            }
        }
        public Vehiculo(string patente, byte cantRuedas, EMarcas marca)
        {
            this.patente = patente;
            this.cantRuedas = cantRuedas;
            this.marca = marca; 
        }
        protected string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{this.GetType().Name.ToUpper()}: ");
            stringBuilder.Append($"Patente: {this.patente} - ");
            stringBuilder.Append($"Marca: {this.Marca} - ");
            stringBuilder.Append($"Cant Ruedas: {this.cantRuedas} - "); 

            return stringBuilder.ToString(); 
        }
        public static int OrdenarVehiculosPorPatente(Vehiculo a, Vehiculo b)
        {
            return String.Compare(a.patente, b.patente);
        }
        public int OrdenarVehiculosPorMarca(Vehiculo a, Vehiculo b)
        {
            int retorno = 0;

            if (a.marca > b.marca)
            {
                retorno = 1;
            }
            else
            {
                retorno = -1;
            }

            return retorno;
        }
    }
}
