using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesStarWars;
using System.Media; 

namespace FrmPpal
{
    public partial class FrmPpal : Form
    {
        SoundPlayer myPlayer = new SoundPlayer();
        private EjercitoImperial ejercitoImperial; 
        public FrmPpal()
        {
            ejercitoImperial = new EjercitoImperial(50);
            ejercitoImperial += new TrooperAsalto(Blaster.EC17); 
            InitializeComponent();
        }
        private void Music(SoundPlayer myPlayer)
        {
            myPlayer.SoundLocation = "C:/Users/orne_/source/repos/ModeloPPStarWars/Imagenes/music.wav";
            myPlayer.PlayLooping();
        }
        private void FrmPpal_Load(object sender, EventArgs e)
        {
            cmbTipo.Items.AddRange(new string[] { "Arena", "Asalto", "Explorador" });
            cmbBlaster.Items.AddRange(new string[] { "E11", "EC17", "DLT19" });
            cmbBlaster.Enabled = false;
            //cmbBlaster.Items.AddRange(System.Enum.GetNames(GetType(Blaster)));  //NO ANDA; 
            //cmbBlaster.DataSource = Enum.GetValues(typeof(Blaster));   
            ckbClon.Enabled = false;
            ckbClon.Checked = false; 
            btnQuitar.Visible = false;
            Music(myPlayer);      
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            btnQuitar.Visible = true;
            if (cmbTipo.CanSelect && cmbBlaster.CanSelect)
            {
                Blaster aux = (Blaster)Enum.Parse(typeof(Blaster), cmbBlaster.Text);
                Trooper auxT = null; 
                switch (cmbTipo.SelectedItem.ToString())
                {
                    case "Arena":
                        auxT = new TrooperArena(aux);
                        ejercitoImperial += auxT;
                        auxT.EsClon = ckbClon.Checked;
                        lstEjercito.Items.Add(auxT.InfoTrooper()); 
                        break;
                    case "Asalto":
                        auxT = new TrooperAsalto(aux);
                        ejercitoImperial += auxT; 
                        lstEjercito.Items.Add(auxT.InfoTrooper());
                        break;
                    case "Explorador":
                        auxT = new TrooperExplorador("Moto");
                        auxT.EsClon = ckbClon.Checked; 
                        ejercitoImperial += auxT;
                        lstEjercito.Items.Add(auxT.InfoTrooper());
                        break;
                }
            }
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBlaster.Enabled = true;
            ckbClon.Enabled = true;
            if (cmbTipo.SelectedItem.ToString() == "Asalto")
            {
                ckbClon.Checked = true;
                ckbClon.Enabled = false; 
            }
            if (cmbTipo.SelectedItem.ToString() == "Explorador")
            {
                cmbBlaster.SelectedItem = "EC17";
                cmbBlaster.Enabled = false;
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (cmbTipo.CanSelect)
            {
                switch (cmbTipo.SelectedItem.ToString())
                {
                    case "Arena":
                        ejercitoImperial -= new TrooperArena(Blaster.E11);
                        break;
                    case "Asalto":
                        ejercitoImperial-= new TrooperAsalto(Blaster.DLT19);
                        break;
                    case "Explorador":
                        ejercitoImperial -=  new TrooperExplorador("Moto");
                        break;
                }
                this.RefrescarEjercito();
            }
            if (this.lstEjercito.SelectedIndex != -1)
            {
                int i = lstEjercito.SelectedIndex;
                ejercitoImperial.Troopers.RemoveAt(i); 
                this.RefrescarEjercito();
            }
        }
        private void RefrescarEjercito()
        {
            lstEjercito.DataSource = null;
            lstEjercito.Items.Clear();
            foreach (Trooper item in ejercitoImperial.Troopers)
            {
                lstEjercito.Items.Add(item.InfoTrooper());
            }
        }
    }
}
