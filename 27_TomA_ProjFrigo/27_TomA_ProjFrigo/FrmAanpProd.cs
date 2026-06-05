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
    public partial class FrmAanpProd : Form
    {
        public FrmAanpProd()
        {
            InitializeComponent();
        }

        private void btnAnnul_Click(object sender, EventArgs e)
        {
            // Form sluiten
            Close();
        }

        /// <summary>
        /// neemt de lijst met producten uit de business en vul de combobox
        /// </summary>
        private void VulCmb()
        {
            // vraag de lijst op uit de business
            List<String> ontvAntw = Program.LijstProd();

            // maak de combobox lees
            cmbKies.Items.Clear();

            // overloop de lijst en vul de combobox
            foreach(String s in ontvAntw)
            {
                cmbKies.Items.Add(s);
            }

        }

        private void btnAanp_Click(object sender, EventArgs e)
        {
            // kijk of alles werd ingevuld
            if(txtNaam.Text != "" && txtDatum.Text != "" && cmbKies.SelectedIndex != -1)
            {
                // probeer de inputs om te zetten naar het juiste datatype
                try
                {
                    // sla de inputs op in variabelen
                    String nm = txtNaam.Text;
                    DateTime dt = DateTime.Parse(txtDatum.Text);
                    int index = cmbKies.SelectedIndex;

                    // doorsturen naar business
                    Program.AanpProd(index, nm, dt);

                    // Gebruiker begeleiden
                    MessageBox.Show("Dit product werd toegevoegd!");

                    // form resetten
                    txtNaam.Clear();
                    txtDatum.Clear();
                    cmbKies.SelectedIndex = -1;
                    cmbKies.Text= "";
                    VulCmb();


                }
                catch
                {
                    // foutmelding
                    MessageBox.Show("U heeft een verkeerde datum ingegeven! (dd/mm/jjjj)");
                }
   
            }
            else
            {
                // foutmelding
                MessageBox.Show("U heeft niet alles ingevuld!");
            }
        }

        private void FrmAanpProd_Load(object sender, EventArgs e)
        {
            // vul de combobox bij het laden van de pagina
            VulCmb();
        }
    }
}
