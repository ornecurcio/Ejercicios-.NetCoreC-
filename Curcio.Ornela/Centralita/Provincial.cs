using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public enum Franja { Franja_1, Franja_2, Franja_3 }
    public class Provincial : Llamada
    {
        Franja franjaHoraria;
        public Provincial(Franja miFranja, Llamada llamada) :
                            this(miFranja, llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        { }
        public Provincial(Franja miFranja, float duracion, string nroDestino, string nroOrigen) 
                   : base(duracion, nroDestino, nroOrigen)
        {
            this.franjaHoraria = miFranja; 
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
            float precio=0; 
            switch(this.franjaHoraria)
            {
                case Franja.Franja_1:
                     precio = 0.99F;
                    break;
                case Franja.Franja_2:
                    precio = 1.25F;
                    break;
                case Franja.Franja_3:
                    precio = 0.66F;
                    break; 
            }
            return  precio* this.Duracion;
        }
        public override bool Equals(object obj)
        {
            return (obj is Local);
        }
        protected override string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"{base.Mostrar()}, Franja Horaria: {this.franjaHoraria}, Costo: {this.CostoLlamada}");

            return stringBuilder.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

    }
}
