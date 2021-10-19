using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesComiqueria; 

namespace ComiqueriaApp
{
    public partial class VentasForm : Form
    {
        private Comiqueria actualComiqueria;
        private Producto elProductoSeleccionado;
        
        public VentasForm()
        {
            InitializeComponent();
        }
        public VentasForm(Comiqueria comiqueria, Producto producto) : this()
        {
            this.actualComiqueria = comiqueria;
            this.elProductoSeleccionado = producto; 
        }
        private void VentasForm_Load(object sender, EventArgs e)
        {
            lblDescripcion.Text = elProductoSeleccionado.Descripcion;
            this.ActualizarPrecio(); 
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if ((int.Parse(numCantidad.Text)) <= elProductoSeleccionado.Stock)
            {
                actualComiqueria.Vender(elProductoSeleccionado, int.Parse(numCantidad.Text));
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Cantidad fuera de stock", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea cancelar?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void numCantidad_ValueChanged(object sender, EventArgs e)
        {
            this.ActualizarPrecio(); 
        }
        private void ActualizarPrecio()
        {
            double finalPrice = Venta.CalcularPrecioFinal(elProductoSeleccionado.Precio, (int)numCantidad.Value);
            lblPrecioFinal.Text = $"Precio Final: ${Math.Round(finalPrice, 2)}";
        }
    }
}
