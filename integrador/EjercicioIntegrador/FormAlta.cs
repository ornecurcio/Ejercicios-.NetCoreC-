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
        Planeta planetaAux;
        bool eliminarPlaneta; 
      
        public FormAlta()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public FormAlta(List<Planeta> planetas):this()
        {
            this.planetas = planetas; 
        }
        public FormAlta(List<Planeta> planetas, Planeta planetaAux) : this(planetas)
        {
            this.planetaAux = planetaAux;
            txtNombre.Text = planetaAux.nombre;
            txtSatelites.Text = planetaAux.satelites.ToString();
            txtGravedad.Text = planetaAux.gravedad.ToString(); 
        }
        public FormAlta(List<Planeta> planetas, Planeta planetaAux, bool eliminarPlaneta) : this(planetas, planetaAux)
        {
            this.planetaAux = planetaAux;
            txtNombre.Text = planetaAux.nombre;
            txtSatelites.Text = planetaAux.satelites.ToString();
            txtGravedad.Text = planetaAux.gravedad.ToString();
            this.eliminarPlaneta = eliminarPlaneta; 
        }

        //Recupera los datos de los txtBox y carga el atributo.
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(planetaAux is null)
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
                    List<Planeta> planetasAux = listaPlanetas.ObtenerListaPlaneta();
                    foreach (Planeta item in planetasAux)
                    {
                        planetas.Add(item);
                    }
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
                if (listaPlanetas.ModificarPlaneta(planetaAux))
                {
                    List<Planeta> planetasAux = listaPlanetas.ObtenerListaPlaneta();
                    foreach (Planeta item in planetasAux)
                    {
                        planetas.Add(item);
                    }
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
                if (listaPlanetas.EliminarPlaneta(planetaAux.id))
                {
                    List<Planeta> planetasAux = listaPlanetas.ObtenerListaPlaneta();
                    foreach (Planeta item in planetasAux)
                    {
                        planetas.Add(item);
                    }
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
