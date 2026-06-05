using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27_TomA_ProjFrigo
{
    public partial class FrmToevoegen : Form
    {
        public FrmToevoegen()
        {
            InitializeComponent();
        }

        private void btnAnnul_Click(object sender, EventArgs e)
        {
            // Form sluiten
            Close();
        }

        private void btnToev_Click(object sender, EventArgs e)
        {
            // Check of alle werd ingevuld
            if(txtNaam.Text!= "" && txtDatum.Text != "")
            {
                // sla alle inputs op in een variabele
                try
                {
                    String nm = txtNaam.Text;
                    DateTime vdatum = DateTime.Parse(txtDatum.Text);

                    // stuur variabelen naar de business
                    Program.ToevProd(nm, vdatum);

                    // gebruiker begleiden
                    MessageBox.Show("Dit product werd opgeslagen.");

                    // form resetten
                    txtDatum.Clear();
                    txtNaam.Clear();

                }
                catch
                {
                    // foutmelding
                    MessageBox.Show("U gaf geen juiste datum in (dd/mm/jjjj)");
                }
            }
            else
            {
                // foutmelding
                MessageBox.Show("U heeft niet alles ingevuld!");
            }
        }
    }
}
