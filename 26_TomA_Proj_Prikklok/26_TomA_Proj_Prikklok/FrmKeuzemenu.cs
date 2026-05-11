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
    public partial class FrmKeuzemenu : Form
    {
        public FrmKeuzemenu()
        {
            InitializeComponent();
        }

        private void btnWn_Click(object sender, EventArgs e)
        {
            // nieuw form aanmaken 
            FrmRegWn nieuwFrm = new FrmRegWn();

            // oud form verbergen 
            Hide();

            // nieuw form tonen
            nieuwFrm.ShowDialog();

            // oud form tonen
            Show();
        }

        private void btnAdm_Click(object sender, EventArgs e)
        {
            // nieuw form aanmaken 
            FrmInlogAdm nieuwFrm = new FrmInlogAdm();

            // oud form verbergen 
            Hide();

            // nieuw form tonen
            nieuwFrm.ShowDialog();

            // oud form tonen
            Show();
        }

        private void btnAfsluiten_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
