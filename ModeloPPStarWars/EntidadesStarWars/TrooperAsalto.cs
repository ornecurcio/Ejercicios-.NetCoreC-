using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesStarWars
{
    public class TrooperAsalto:Trooper
    {
        public override string Tipo
        {
            get
            {
                return "Comando para misiones de infiltracion";
            }
        }
        public TrooperAsalto(Blaster armamento) : base(armamento,true)
        {
        }
    }
}
