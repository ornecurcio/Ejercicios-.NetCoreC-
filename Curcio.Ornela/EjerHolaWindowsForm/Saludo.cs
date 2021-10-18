using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerHolaWindowsForm
{
    public partial class Saludo : Form
    {
        public Saludo(string titulo, string mensaje)
        {
            InitializeComponent();
            lblTituloMensaje.Text = titulo;
            lblDatos.Text = mensaje;
        }   
    }
}
