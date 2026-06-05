using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27_TomA_ProjFrigo
{
    public partial class FrmOpzProd : Form
    {
        public FrmOpzProd()
        {
            InitializeComponent();
        }

        private void btnAnnul_Click(object sender, EventArgs e)
        {
            // Form sluiten
            Close();
        }

        private void btnOpz_Click(object sender, EventArgs e)
        {
            // Kijk of alles werd ingevuld
            if(txtNaam.Text != null)
            {
                // Sla de invoer op 
                String ontvNm = txtNaam.Text;

                // stuur de naam door naar de business en van het antwoord op 
                bool ontvAntw = Program.NakijkenProd(ontvNm);

                // begeleid de gebruiker 
                if (ontvAntw)
                {
                    // is het antwoord true 
                    // gebruiker begleiden
                    MessageBox.Show("Dit product zit in de frigo.");
                }
                else 
                {
                    // is het antwoord false 
                    // gebruiker begleiden
                    MessageBox.Show("Dit product werd niet gevonden in de frigo.");
                }


                // Reset het form 
                txtNaam.Clear();
            }
            else
            {
                // foutmelding
                MessageBox.Show("U heeft niet alles ingevuld!");
            }
        }
    }
}
