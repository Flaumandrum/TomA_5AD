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
