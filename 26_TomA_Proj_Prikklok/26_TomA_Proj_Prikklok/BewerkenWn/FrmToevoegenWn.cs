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
    public partial class FrmToevoegenWn : Form
    {
        public FrmToevoegenWn()
        {
            InitializeComponent();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnToev_Click(object sender, EventArgs e)
        {
            // kijk of alles werd ingevuld 
            if(txtVn.Text != "" && txtAn.Text != "")
            {
                // Check of het aantal werknemers kleiner is dan 20
                if(Program.CheckAantalWn())
                {
                    // zet alle om naar een variabele
                    String vn = txtVn.Text;
                    String an = txtAn.Text;


                    // stuur alles door naar de juiste functie
                    Program.OpslaanWn(vn, an);

                    // Begeleid de gebruiker
                    MessageBox.Show("Great succes!", "Succes");

                    // reset form
                    txtAn.Clear();
                    txtVn.Clear();
                }
                else
                {
                    // foutmelding 
                    MessageBox.Show("U heeft te veel werknemers."+Environment.NewLine+"U heeft geen plaats meer.", "Fout!");
                }


            }
            else
            {
                // foutmelding 
                MessageBox.Show("U heeft niets ingevuld", "Fout!");
            }
        }
    }
}
