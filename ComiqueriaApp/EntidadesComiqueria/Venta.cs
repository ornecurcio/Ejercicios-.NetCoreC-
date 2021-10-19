using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesComiqueria
{
    public sealed class Venta
    {
        private DateTime fecha;
        private static int porcentajeIva;
        private double precioFinal;
        private Producto producto; 

        public DateTime Fecha
        {
            get
            {
                return this.fecha; 
            }
        }

        static Venta()
        {
            Venta.porcentajeIva = 21; 
        }
        internal Venta(Producto producto, int cantidad)
        {
            this.producto = producto;
            this.Vender(cantidad);  
        }
        private void Vender(int cantidad)
        {
            producto.Stock = producto.Stock - cantidad;
            this.fecha = DateTime.Now;
            precioFinal = CalcularPrecioFinal(producto.Precio, cantidad); 
        }
        public static double CalcularPrecioFinal(double precioUnidad, int cantidad)
        {
            double rta;
            double precioAux = precioUnidad * cantidad; 
            rta = (100+porcentajeIva)*precioAux/100;
            return rta; 
        }
        public string ObtenerDescripcionBreve()
        {
            return string.Format("{0:dd-MM-yy} – {1} – {2:0.00}", 
                                  this.fecha, producto.Descripcion, this.precioFinal); 
        }

    }
}
