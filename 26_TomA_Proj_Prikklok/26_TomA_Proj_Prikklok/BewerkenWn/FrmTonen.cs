using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26_TomA_Proj_Prikklok.BewerkenWn
{
    public partial class FrmTonen : Form
    {
        public FrmTonen()
        {
            InitializeComponent();
        }

        private void VulCmb()
        {
            // Haalt de lijst met namen van de werknemers op
            List<String> werknemers = Program.StuurLijstDoor();

            // Verwijder alle items uit de combobox
            cmbKies.Items.Clear();

            // overloop de lijst en voeg elk element toe in de combobox
            foreach (String s in werknemers)
            {
                // neem het element en voeg het toe in de combobox
                cmbKies.Items.Add(s);
            }

        }
        private void btnTerug_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmTonen_Load(object sender, EventArgs e)
        {
            VulCmb();
        }

        private void cmbKies_SelectedIndexChanged(object sender, EventArgs e)
        {
             // ga na of er iets is geselecteerd 
             if(cmbKies.SelectedIndex != -1)
            {
                lblToon.Text = Program.ToonCode(cmbKies.SelectedIndex);
            }
            
        }
    }
}
