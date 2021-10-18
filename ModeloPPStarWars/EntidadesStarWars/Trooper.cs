using System;
using System.Text; 

namespace EntidadesStarWars
{
    public abstract class Trooper
    {
        protected Blaster armamento;
        protected bool esClon; 

        public Blaster Armamento
        {
            get 
            {
                return this.armamento; 
            }
        }

        public bool EsClon
        {
            get 
            {
                return this.esClon; 
            }
            set 
            {
                this.esClon = value; 
            }
        }
        public abstract string Tipo { get; }

        public Trooper(Blaster armamento, bool esClon)
        {
            this.armamento = armamento;
            this.esClon = esClon; 
        }
        public Trooper(Blaster armamento):this(armamento, false)
        {
        }
        public virtual string InfoTrooper()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"{this.Tipo} armado con {this.Armamento}, ");
            if (this.EsClon)
            {
                stringBuilder.Append($"es clone."); 
            }
            else
            {
                stringBuilder.Append($"NO es clone.");
            }
            return stringBuilder.ToString(); 
        }
        public override bool Equals(object obj)
        {
            return this.GetType() == obj.GetType(); 
        }
    }
}
