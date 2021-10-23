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

namespace UI
{
    public partial class Form1 : Form
    {
        List<Jugador> jugadoresTotales;
        public Form1() // CONSTRUCTOR
        {
            InitializeComponent();
            jugadoresTotales = new List<Jugador>();
        }


        // EVENTO LOAD 
        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < Torneo.ListaEquipos.Count; i++)
            {
                jugadoresTotales.AddRange(Torneo.ListaEquipos[i].ListaJugadores);
            }

            //foreach (Equipo item in Torneo.ListaEquipos)
            //{
            //    jugadoresTotales.AddRange(item.ListaJugadores);
            //}

            RefrescarDatagrid();
        }


        private void RefrescarDatagrid()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = jugadoresTotales;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            jugadoresTotales.Add(new Jugador("pep epe pepe", 100, 99, EPuesto.Arquero));
            RefrescarDatagrid();

        }
    }
}
