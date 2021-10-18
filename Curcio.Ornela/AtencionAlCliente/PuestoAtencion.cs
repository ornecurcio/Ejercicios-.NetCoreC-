using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AtencionAlCliente
{
    public class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto; 

        public static int NumeroActual 
        {
            get
            {
                return (numeroActual++); 
            }
        }
        private PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;  
        }
        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto; 
        }
        public bool Atender(Cliente cli)
        {
            if (cli != null)
            {
                Thread.Sleep(3000);
                return true;
            }
            return false;
        }
    }
}
