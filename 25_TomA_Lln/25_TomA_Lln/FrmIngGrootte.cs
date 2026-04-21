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
    public partial class FrmIngGrootte : Form
    {
        public FrmIngGrootte()
        {
            InitializeComponent();
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIngeven_Click(object sender, EventArgs e)
        {
            // is er iets ingegevn in de textbox
            if(txtGrootte.Text != "")
            {
                // We proberen of we dit kunnen omzetten naar een getal
                try
                {
                    int grootte = int.Parse(txtGrootte.Text);

                    Program.PasArrayAan(grootte);


                    // begeleiden van de gebruiker
                    MessageBox.Show("De grootte van de klas werd aangepast", "Succes!",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    // form resetten
                    txtGrootte.Text = "";
                }
                catch
                {
                    // foutmelding
                    MessageBox.Show("U gaf geen getal in", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                // foutmelding
                MessageBox.Show("U gaf niets in.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
