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
    public partial class FrmKeuzemenu : Form
    {
        public FrmKeuzemenu()
        {
            InitializeComponent();
        }

        private void btnAfsl_Click(object sender, EventArgs e)
        {
            // Form sluiten
            Close();
        }

        private void btnVerw_Click(object sender, EventArgs e)
        {
            // Nieuwe form aanmaken 
            FrmVerwProd nieuweFrm = new FrmVerwProd();

            // Deze form verbergen 
            Hide();

            // Nieuwe form tonen 
            nieuweFrm.ShowDialog();

            // Deze form tonen
            Show();
        }

        private void btnaanpas_Click(object sender, EventArgs e)
        {
            // Nieuwe form aanmaken 
            FrmAanpProd nieuweFrm = new FrmAanpProd();

            // Deze form verbergen 
            Hide();

            // Nieuwe form tonen 
            nieuweFrm.ShowDialog();

            // Deze form tonen
            Show();
        }

        private void btnOpzoek_Click(object sender, EventArgs e)
        {
            // Nieuwe form aanmaken 
            FrmOpzProd nieuweFrm = new FrmOpzProd();

            // Deze form verbergen 
            Hide();

            // Nieuwe form tonen 
            nieuweFrm.ShowDialog();

            // Deze form tonen
            Show();
        }

        private void btnToonVerv_Click(object sender, EventArgs e)
        {
            // Nieuwe form aanmaken 
            FrmToonVervProd nieuweFrm = new FrmToonVervProd();

            // Deze form verbergen 
            Hide();

            // Nieuwe form tonen 
            nieuweFrm.ShowDialog();

            // Deze form tonen
            Show();
        }

        private void btnToon_Click(object sender, EventArgs e)
        {
            // Nieuwe form aanmaken 
            FrmToonProd nieuweFrm = new FrmToonProd();

            // Deze form verbergen 
            Hide();

            // Nieuwe form tonen 
            nieuweFrm.ShowDialog();

            // Deze form tonen
            Show();
        }

        private void btnToev_Click(object sender, EventArgs e)
        {
            // Nieuwe form aanmaken 
            FrmToevoegen nieuweFrm = new FrmToevoegen();

            // Deze form verbergen 
            Hide();

            // Nieuwe form tonen 
            nieuweFrm.ShowDialog();

            // Deze form tonen
            Show();
        }
    }
}
