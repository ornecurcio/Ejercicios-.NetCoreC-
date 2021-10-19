using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesComiqueria
{
    public class Comiqueria
    {
        private List<Producto> productos;
        private List<Venta> ventas;

        public Comiqueria()
        {
            this.productos = new List<Producto>();
            this.ventas = new List<Venta>();
        }
        public Producto this[Guid codigo]
        {
            get
            {
                foreach (Producto item in this.productos)
                {
                    if ((Guid)item == codigo)
                    {
                        return item;
                    }
                }
                return null;
            }
        }
        public Dictionary<Guid, string> ListarProductos()
        {
            Dictionary<Guid, string> listadoDeProductos= new Dictionary<Guid, string>();
            foreach (Producto item in this.productos)
            {
                listadoDeProductos[(Guid)item] = item.Descripcion;
            }
            return listadoDeProductos;
        }
        public string ListarVentas()
        {
            this.ventas.Sort(OrdenarPorFechas);
            StringBuilder stringBuilder = new StringBuilder(); 
            foreach (Venta item in this.ventas)
            {
                stringBuilder.AppendLine(item.ObtenerDescripcionBreve()); 
            }
            return stringBuilder.ToString(); 
        }
        public void Vender(Producto producto)
        {
            this.Vender(producto, 1); 
        }
        public void Vender(Producto producto, int cantidad)
        {
            this.ventas.Add(new Venta(producto, cantidad));  
        }
        public static bool operator ==(Comiqueria comiqueria, Producto producto)
        {
            bool rta = false;
            if (!(comiqueria is null) && !(producto is null))
            {
                foreach (Producto item in comiqueria.productos)
                {
                    if (item.Descripcion == producto.Descripcion)
                    {
                        rta = true;
                        break; 
                    }
                }
            }
            return rta; 
        }
        public static bool operator !=(Comiqueria comiqueria, Producto producto)
        {
            return !(comiqueria == producto); 
        }
        public static Comiqueria operator +(Comiqueria comiqueria, Producto producto)
        {
            if (comiqueria != producto)
            {
                comiqueria.productos.Add(producto); 
            }
            return comiqueria; 
        }
        private int OrdenarPorFechas(Venta v1, Venta v2)
        {
            return v1.Fecha.CompareTo(v2.Fecha); 
        }

    }
}
