using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesStarWars
{
    public class TrooperExplorador: Trooper
    {
        public string vehiculo;

        public override string Tipo
        {
            get 
            {
                return "Soldado de exploracion"; 
            }
        }
        public string Vehiculo
        {
            get 
            {
                return this.vehiculo; 
            }
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    this.vehiculo = "Indefinido";
                }
                else
                {
                    this.vehiculo = value; 
                }
            }
        }
        public TrooperExplorador(string vehiculo):base(Blaster.EC17)
        {
            this.vehiculo = vehiculo; 
        }

        public override string InfoTrooper()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(base.InfoTrooper());
            stringBuilder.Append($"- Vehiculo: {this.Vehiculo}");

            return stringBuilder.ToString(); 
        }
        public override string ToString()
        {
            return this.InfoTrooper();
        }
    }
}
