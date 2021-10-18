using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EjerClase12
{
    public class ValidarRespuesta
    {
        public static bool ValidarS_N(char c)
        {
            bool valido=false;
            if (c == 'S' || c == 's')
            {
                valido = true; 
            }
            return valido; 

        }
    }
}
