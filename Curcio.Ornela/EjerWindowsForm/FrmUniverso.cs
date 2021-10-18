using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerWindowsForm
{
    public partial class FormUniverso : Form
    {
        public FormUniverso()
        {
            InitializeComponent(); //constructor
        }

        private void btnNuevoHeroe_Click(object sender, EventArgs e)
        {
            FrmHeroe frmHeroe = new FrmHeroe();
            frmHeroe.Show();
        }

        // setear detalles antes de que sea visible
        private void Form1_Load(object sender, EventArgs e)  
        {

        }
    }
}
