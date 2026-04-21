using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25_TomA_Lln
{
    public partial class FrmIngLln : Form
    {
        public FrmIngLln()
        {
            InitializeComponent();
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIngeven_Click(object sender, EventArgs e)
        {
            // kijk of er gegevens zijn ingegeven
            if(txtNaam.Text != "")
            {
                // Kijk of er een lege plaats is
                int ontvPlaats = Program.ZoekenInArray(null);

                // Kijk of de plaats leeg is 
                if(ontvPlaats != -1)
                {
                    // naam van de leerling toevoegen
                    String naam = txtNaam.Text;
                    Program.OpslaanInArray(ontvPlaats, naam);

                    // begeleiden gebruiker
                    MessageBox.Show("De naam van de leerling werd toegevoegd", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    // foutmelding
                    MessageBox.Show("Er is geen plaats meer", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                // Fromulier restetten 
                txtNaam.Text = "";
            }
            else
            {
                // foutmelding
                MessageBox.Show("U gaf niets in.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
