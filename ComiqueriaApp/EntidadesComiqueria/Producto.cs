using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesComiqueria
{
    public abstract class Producto
    {
        private Guid codigo;
        private string descripcion;
        private int stock;
        private double precio;

        public string Descripcion
        {
            get
            {
                return this.descripcion; 
            }
        }

        public int Stock
        {
            get
            {
                return this.stock; 
            }
            set
            {
                if (value >= 0)
                {
                    this.stock = value; 
                }
            }
        }
        public double Precio
        {
            get 
            {
                return this.precio; 
            }
            set 
            {
                if (value > 0)
                {
                    this.precio = value; 
                }
            }
        }
        protected Producto(string descripcion, int stock, double precio)
        {
            this.codigo = Guid.NewGuid();
            this.descripcion = descripcion;
            this.stock = stock;
            this.precio = precio; 
        }

        public static explicit operator Guid(Producto p)
        {
            return p.codigo; 
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Descripcion: {this.Descripcion}");
            stringBuilder.AppendLine($"Codigo: {(Guid)this}");
            stringBuilder.AppendLine($"Precio: ${this.Precio}");
            stringBuilder.AppendLine($"Stock: {this.Stock} unidades");

            return stringBuilder.ToString(); 
        }
    }
}
