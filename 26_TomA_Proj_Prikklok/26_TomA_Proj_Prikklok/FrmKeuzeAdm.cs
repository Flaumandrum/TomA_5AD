using _26_TomA_Proj_Prikklok.BewerkenWn;
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
    public partial class FrmKeuzeAdm : Form
    {
        public FrmKeuzeAdm()
        {
            InitializeComponent();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            // nieuw form aanmaken 
            FrmToevoegenWn nieuwFrm = new FrmToevoegenWn();

            // oud form verbergen 
            Hide();

            // nieuw form tonen
            nieuwFrm.ShowDialog();

            // oud form tonen
            Show();
        }

        private void btnTonen_Click(object sender, EventArgs e)
        {
            // nieuw form aanmaken 
            FrmTonen nieuwFrm = new FrmTonen();

            // oud form verbergen 
            Hide();

            // nieuw form tonen
            nieuwFrm.ShowDialog();

            // oud form tonen
            Show();
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            // nieuw form aanmaken 
            FrmVerwijderenWn nieuwFrm = new FrmVerwijderenWn();

            // oud form verbergen 
            Hide();

            // nieuw form tonen
            nieuwFrm.ShowDialog();

            // oud form tonen
            Show();
        }

        private void btnAanpassen_Click(object sender, EventArgs e)
        {
            // nieuw form aanmaken 
            FrmAanpassenWn nieuwFrm = new FrmAanpassenWn();

            // oud form verbergen 
            Hide();

            // nieuw form tonen
            nieuwFrm.ShowDialog();

            // oud form tonen
            Show();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
