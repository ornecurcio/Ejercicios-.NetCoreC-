using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Local : Llamada
    {
        protected float costo;

        public Local(Llamada llamada, float costo):this(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen, costo)
        {
        }
        public Local(float duracion, string nroDestino, string nroOrigen, float costo) 
                    : base(duracion, nroDestino, nroOrigen)
        {
            this.costo = costo; 
        }

        public override float CostoLlamada
        {
            get 
            {
                return this.CalcularCosto(); 
            }
        }

        private float CalcularCosto()
        {
            return this.costo * this.Duracion; 
        }
        public override bool Equals(object obj)
        {
            return (obj is Local);
        }
        protected override string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"{base.Mostrar()}, Costo: {this.CostoLlamada}");
            
            return stringBuilder.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

    }
}
