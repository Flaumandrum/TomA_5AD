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
    public partial class FrmAanpassenWn : Form
    {
        public FrmAanpassenWn()
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
            foreach(String s in werknemers)
            {
                // neem het element en voeg het toe in de combobox
                cmbKies.Items.Add(s);
            }

        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Bij het laden van de form, wordt de functie uitgevoerd om de combpobox te vullen
        private void FrmAanpassenWn_Load(object sender, EventArgs e)
        {
            VulCmb();
        }

        private void btnAanp_Click(object sender, EventArgs e)
        {
            // Kijk of alles werd ingevuld
            if(cmbKies.SelectedIndex != -1 && txtVn.Text != "" && txtAn.Text != "")
            {
                // sla alles op in variabelen
                int gekozenIndex = cmbKies.SelectedIndex;
                String vn = txtVn.Text;
                String an = txtAn.Text;

                // Stuur de gegevens door naar de juiste functie van de business
                Program.Aanpassen(gekozenIndex, vn, an);

                // Begeleid de gebruiker
                MessageBox.Show("Great success!", "Success");

                // reset form
                txtAn.Clear();
                txtVn.Clear();

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
