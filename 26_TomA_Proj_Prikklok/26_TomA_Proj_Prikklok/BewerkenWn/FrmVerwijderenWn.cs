using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26_TomA_Proj_Prikklok
{
    public partial class FrmVerwijderenWn : Form
    {
        public FrmVerwijderenWn()
        {
            InitializeComponent();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Close();
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

        private void FrmVerwijderenWn_Load(object sender, EventArgs e)
        {
            VulCmb();
        }

        private void btnVerw_Click(object sender, EventArgs e)
        {
            if (cmbKies.SelectedIndex != -1 )
            {
                // sla alles op in variabelen
                int gekozenIndex = cmbKies.SelectedIndex;
                

                // Stuur de gegevens door naar de juiste functie van de business
                Program.Verwijderen(gekozenIndex);

                // Begeleid de gebruiker
                MessageBox.Show("Great success!", "Success");

                // reset form
                
                cmbKies.SelectedIndex = -1;
                VulCmb();



            }
            // Anders geef je een foutmeldig
            else
            {
                // foutmelding 
                MessageBox.Show("U heeft niet alles ingevuld of \ngeen werknemer geselecteerd", "Fout!");
            }
        }
    }
}
