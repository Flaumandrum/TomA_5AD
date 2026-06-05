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
    public partial class FrmVerwProd : Form
    {
        public FrmVerwProd()
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
            foreach (String s in ontvAntw)
            {
                cmbKies.Items.Add(s);
            }

        }

        private void btnVerw_Click(object sender, EventArgs e)
        {
            // kijk of alles werd ingevuld
            if(cmbKies.SelectedIndex != -1)
            {
                // sla op in een variabele
                int index = cmbKies.SelectedIndex;

                // stuur door naar de business
                Program.VerwProd(index);

                // gebruiker begeleiden
                MessageBox.Show("Dit product werd verwijderd.");

                // form resetten
                cmbKies.Text = "";
                cmbKies.SelectedIndex = -1;
                VulCmb();


            }
            else
            {
                // foutmelding
                MessageBox.Show("U heeft geen product geselecteerd!");
            }
        }
    }
}
