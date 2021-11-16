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
    public partial class FormIntegrador : Form
    {
        public FormIntegrador()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

         /* 
           1- Crear un objeto de tipo Planeta.
           2- Serializarlo y mostrar en un MessageBox lo sucedido.
		   3- Si serializo, deserializarlo y mostrarlo en el RichTextBox.
         */
        private void btn1_Click(object sender, EventArgs e)
        {
            Planeta ornela = new Planeta(10, "Ornela", 2, 60);
            if(ornela.SerializarXml())
            {
                MessageBox.Show("Serializo Correctamente"); 
            }
            richTextBox1.Text = ornela.DeserializarXml(); 

        }



        /*
        1- Crear tres objetos de tipo Planeta.
		2- Crear objeto de tipo SistemaSolar.
		3- Agregarlos planetas al sistema solar.
        4- Mostrarlos en el RichTextBox.
        */
        private void btn2_Click(object sender, EventArgs e)
        {
            Planeta ornela = new Planeta(10, "Ornela", 2, 60);
            Planeta pedro = new Planeta(13, "Pedro", 200, 10);
            Planeta lucas = new Planeta(18, "Lucas", 40, 20);

            SistemaSolar<Planeta> sistemaSolar = new SistemaSolar<Planeta>(3);
            sistemaSolar.Agregar(ornela);
            sistemaSolar.Agregar(pedro);
            sistemaSolar.Agregar(lucas);

            foreach (Planeta item in sistemaSolar.lista)
            {
                richTextBox1.Text += item.ToString();
            }

        }

        /*
         1- Crear tres objetos de tipo Planeta.
		 2- Crear objeto de tipo SistemaSolar con capacidad=2.
		 3- Atrapar la Excepción "NoHayLugarException" en un bloque try-catch 
         4- Mostrar el mensaje de error en un MessageBox.
         */
        private void btn3_Click(object sender, EventArgs e)
        {
            try
            {
                Planeta ornela = new Planeta(10, "Ornela", 2, 60);
                Planeta pedro = new Planeta(13, "Pedro", 200, 10);
                Planeta lucas = new Planeta(18, "Lucas", 40, 20);

                SistemaSolar<Planeta> sistemaSolar = new SistemaSolar<Planeta>(2);
                sistemaSolar.Agregar(ornela);
                sistemaSolar.Agregar(pedro);
                sistemaSolar.Agregar(lucas); 
            }
            catch(NoHayLugarException ex)
            {
                MessageBox.Show(ex.Message); 
            }

        }

        /*
         * 1-Creo un objeto planeta
         * 2-Asociar evento al manejador "PlanetaConMuchaGravedad"
         * 3-Hago saltar el evento
         * 4-Atrapo y muestro la gravedad del planeta en el RichTextBox
         
         */

        private void btn4_Click(object sender, EventArgs e)
        {
            Planeta marte = new Planeta(); 
            DelegadoPlaneta delegado = HayMuchaGravedad;
            marte.muchaGravedad += delegado;
            marte.Gravedad = 35; 
            //Planeta marte = new Planeta(1, "Marte", 4, 50);
        }
        private void HayMuchaGravedad(double gravedad)
        {
            richTextBox1.Text = $"El planeta tiene mucha gravedad: {gravedad}m/s2"; 
        }

        /*
         1-Crea un Task, creo el método TraerPlanetas():void
         2-En el subproceso invoco al método TraerPlanetas()
         2-Traigo los planetas de la base de datos a través del hilo secundario.
         3-Modifico el ReachTextBox a través del hilo principal.
         */
        private void btnTraer_Click(object sender, EventArgs e)
        {
            Task tsk = new Task(() => this.TraerPlanetas()); 
            tsk.Start();
        }
        private void TraerPlanetas()
        {
            List<Planeta> planetas = new List<Planeta>(); 
            AccesoDatos datosPlanetas = new AccesoDatos();
            planetas=datosPlanetas.ObtenerListaPlaneta();
            if (richTextBox1.InvokeRequired)
            {
                Action ac = TraerPlanetas;
                Invoke(ac);
            }
            else
            {
                foreach (Planeta item in planetas)
                {
                    richTextBox1.Text += item.ToString();
                }
            }
        }
        /*
         1- Invoca al formulario de alta.
		 2- Si se acepta, se actualiza BD, se agrega a la lista.
         3- Retorna la lista y muestra en el RichTextBox.
         * */
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAlta formAlta = new FormAlta();
            formAlta.ShowDialog(); 
            if(formAlta.DialogResult==DialogResult.OK)
            {
                foreach (Planeta item in formAlta.Planetas)
                {
                    richTextBox1.Text += item.ToString();
                }
            }
        }

        /*
         1 Invoca el formulario de alta a modificar pasandole los datos para mostrar.
		 2- Si se acepta el modificado, se actualiza BD 
         3-retorna la lista y muestra en el RichTextBox.
         * */
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Planeta planetaAModificar = new Planeta(9, "Tierra", 1, 28); 
            FormAlta formAlta = new FormAlta(planetaAModificar);
            formAlta.ShowDialog();
            if (formAlta.DialogResult == DialogResult.OK)
            {
                foreach (Planeta item in formAlta.Planetas)
                {
                    richTextBox1.Text += item.ToString();
                }
            }
        }



        /*
         1- Invoca el formulario de alta a eliminar pasandole los datos para mostrar.
		 2- Si se acepta el eliminado, se actualiza BD
         3-retorna la lista y muestra.
         */
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Planeta planetaAModificar = new Planeta(9, "Tierra", 1, 28);
            FormAlta formAlta = new FormAlta(planetaAModificar, true);
            formAlta.ShowDialog();
            if (formAlta.DialogResult == DialogResult.OK)
            {
                foreach (Planeta item in formAlta.Planetas)
                {
                    richTextBox1.Text += item.ToString();
                }
            }
        }


       
    }
}
