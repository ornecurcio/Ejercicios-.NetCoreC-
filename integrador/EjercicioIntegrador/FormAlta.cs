using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades; 

namespace EjercicioIntegrador
{
    public partial class FormAlta : Form
    {
        List<Planeta> planetas;
        Planeta planeta;
        bool eliminarPlaneta; 
        
        public List<Planeta> Planetas
        {
            get
            {
                return this.planetas; 
            }
        }
        public FormAlta()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public FormAlta(Planeta planetaAux) : this()
        {
            this.txtNombre.Text = planeta.nombre;
            this.txtSatelites.Text = planeta.satelites.ToString();
            this.txtGravedad.Text = planeta.gravedad.ToString();
        }
        public FormAlta(Planeta planeta, bool eliminarPlaneta) : this(planeta)
        {
            this.eliminarPlaneta = eliminarPlaneta; 
        }

        //Recupera los datos de los txtBox y carga el atributo.
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(this.planeta is null)
            {
                AgregarPlaneta(); 
            }
            else if(eliminarPlaneta)
            {
                EliminarPlaneta();    
            }
            else
            {
                ModificarPlaneta();
            }
        }
        private void AgregarPlaneta()
        {
            if (!string.IsNullOrWhiteSpace(txtNombre.Text) && txtNombre.Text.All(char.IsLetter)
                    && txtGravedad.Text.All(char.IsDigit) && txtSatelites.Text.All(char.IsDigit))
            {
                Planeta planeta = new Planeta(0, txtNombre.Text, int.Parse(txtSatelites.Text), double.Parse(txtGravedad.Text));
                AccesoDatos listaPlanetas = new AccesoDatos();
                if (listaPlanetas.AgregarPlaneta(planeta))
                {
                    this.planetas = listaPlanetas.ObtenerListaPlaneta();
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
        private void ModificarPlaneta()
        {
            if (!string.IsNullOrWhiteSpace(txtNombre.Text) && txtNombre.Text.All(char.IsLetter)
                    && txtGravedad.Text.All(char.IsDigit) && txtSatelites.Text.All(char.IsDigit))
            {
                AccesoDatos listaPlanetas = new AccesoDatos();
                if (listaPlanetas.ModificarPlaneta(planeta))
                {
                    this.planetas = listaPlanetas.ObtenerListaPlaneta();
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
        private void EliminarPlaneta()
        {
            if (!string.IsNullOrWhiteSpace(txtNombre.Text) && txtNombre.Text.All(char.IsLetter)
                    && txtGravedad.Text.All(char.IsDigit) && txtSatelites.Text.All(char.IsDigit))
            {
                AccesoDatos listaPlanetas = new AccesoDatos();
                if (listaPlanetas.EliminarPlaneta(planeta.id))
                {
                    this.planetas = listaPlanetas.ObtenerListaPlaneta();
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
