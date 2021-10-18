using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerClase28
{
    public partial class FormContadorPalabras : Form
    {
        public FormContadorPalabras()
        {
            InitializeComponent();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> contadorPalabras = ObtenerContadorPalabras();

            List<KeyValuePair<string, int>> podio = contadorPalabras.ToList();
            podio.Sort(CompararCantidadRepeticiones);
            MostrarPodio(podio); 
        }
        private void MostrarPodio(List<KeyValuePair<string, int>> podio)
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (podio.Count == 0)
            {
                stringBuilder.AppendLine("No se ingresaron palabras");
            }
            else
            {
                for (int i = 0; i < 3 && i<podio.Count; i++)
                {
                    KeyValuePair<string, int> par = podio[i]; 
                    stringBuilder.AppendLine($"Palabra: {par.Key} - Cantidad: {par.Value}");
                }                       
                //foreach (KeyValuePair<string, int> par in podio)
                //{
                //    stringBuilder.AppendLine($"Palabra: {par.Key} - Cantidad: {par.Value}");
                //}
                MessageBox.Show(stringBuilder.ToString(), "Podio");
            }
        }
        private int CompararCantidadRepeticiones(KeyValuePair<string, int> primerElemento,
                                                 KeyValuePair<string, int> segundoElemento)
        {
            //if (primerElemento.Value < segundoElemento.Value)
            //{
            //    return -1; 
            //}
            //if (primerElemento.Value < segundoElemento.Value)
            //{
            //    return 1; 
            //}
            return segundoElemento.Value - primerElemento.Value; 
        }
        private Dictionary<string, int> ObtenerContadorPalabras()
        {
            string texto = rtxtContadorPalabras.Text;
            string[] palabras = texto.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> contadorPalabras = new Dictionary<string, int>();

            foreach (string palabra in palabras)
            {
                if (contadorPalabras.ContainsKey(palabra))
                {
                    contadorPalabras[palabra]++;  // la palabra funciona como indice en el foreach. 
                }
                else
                {
                    contadorPalabras.Add(palabra, 1);
                }
            }
            return contadorPalabras;
        }
    }
}
