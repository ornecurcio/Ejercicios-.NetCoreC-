using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CartucheraLlenaException:Exception
    {
        public CartucheraLlenaException()
            : base("La cartuchera esta llena")
        {
        }

        public CartucheraLlenaException(string mensaje)
            : base(mensaje)
        {
        }

        public CartucheraLlenaException(string mensaje, Exception innerException)
            : base(mensaje, innerException)
        {
        }

        public CartucheraLlenaException(string mensaje, Exception innerException, string origenError)
            : base(mensaje, innerException)
        {
            base.Source = origenError;
        }

        public override string ToString()
        {
            return "Mensaje de error: " + base.Message + "\nOrigen: " + base.Source;
        }
    }
}
