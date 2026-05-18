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
    public partial class FrmInlogAdm : Form
    {
        public FrmInlogAdm()
        {
            InitializeComponent();
        }

        private void btnInlog_Click(object sender, EventArgs e)
        {
            // kijk of alles werd ingevuld
            if(txtWw.Text != "")
            {
                // sla de invoer op in een variabele 
                String ww = txtWw.Text;

                // Stuur naar de functie om te checken of het wachtwoord juist is 
                bool ontvAntw = Program.CheckWw(ww);

                // als het wachtwoord juist is
                if(ontvAntw)
                {
                    // gebruik doorsturen naar keuzemenu admin
                    FrmKeuzeAdm nieuweFrm = new FrmKeuzeAdm();

                    // deze form hiden 
                    Hide();

                    // nieuwe form tonen 
                    nieuweFrm.ShowDialog();

                    // deze form tonen 
                    Show();

                }
                // Als het wachtwoord fout is
                else
                {
                    // foutmelding 
                    MessageBox.Show("Dit wachtwoord is fout!", "Fout!");
                }

                // reset form
                txtWw.Clear();
            }
            else
            {
                // foutmelding 
                MessageBox.Show("U heeft niets ingevuld", "Fout!");
            }
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
