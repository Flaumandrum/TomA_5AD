using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26_TomA_Proj_Prikklok
{
    public partial class FrmRegWn : Form
    {
        public FrmRegWn()
        {
            InitializeComponent();
        }
        

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            // kijk of alles werd ingevuld
            if( !String.IsNullOrEmpty(txtReg.Text.Trim()))
            {
                try
                {
                    int code = int.Parse(txtReg.Text);

                    // Stuur de code naar business+ vang antwoord op
                    bool ontvAntw = Program.CheckCode(code);

                    // Als de code juist is 
                    if(ontvAntw)
                    {
                        // registreren
                        Program.RegistreerTijd(code);

                        // tekst tonen
                        lbltekst.Text = Program.ToonWerktijd(code);

                        

                        
                    }
                    else
                    {
                        // foutmelding 
                        MessageBox.Show("Deze code werd niet gevonden", "Fout!");
                    }
                }
                catch
                {
                    // foutmelding 
                    MessageBox.Show("U vulde geen code in", "Fout!");
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
