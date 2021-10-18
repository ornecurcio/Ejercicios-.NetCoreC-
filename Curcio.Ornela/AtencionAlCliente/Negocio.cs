using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtencionAlCliente
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre; 

        public Cliente Cliente 
        {
            get { return clientes.Dequeue(); }
            set { _ = this + value; }
        }
        public int ClientesPendientes
        {
            get { return this.clientes.Count; }
        }
        private Negocio()
        {
            this.caja = new PuestoAtencion(Puesto.Caja1);
            this.clientes = new Queue<Cliente>(); 
        }
        public Negocio(string nombre): this()
        {
            this.nombre = nombre; 
        }
        public static bool operator ==(Negocio n, Cliente c)
        {
            foreach (Cliente item in n.clientes)
            {
                if (c == item)
                    return true;
            }
            return false;
        }
        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c); 
        }
        public static bool operator ~(Negocio n)
        {
            if (n.clientes.Count > 0)
            {
                return n.caja.Atender(n.Cliente);
            }
            return false;
        }
        public static bool operator +(Negocio n, Cliente c)
        {
            if (n != c)
            {
                n.clientes.Enqueue(c); 
                return true;
            }
            return false; 
        }

    }
}
