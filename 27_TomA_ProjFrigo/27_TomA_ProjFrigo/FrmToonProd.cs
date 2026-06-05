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
    public partial class FrmToonProd : Form
    {
        public FrmToonProd()
        {
            InitializeComponent();
        }

        private void btnAnnul_Click(object sender, EventArgs e)
        {
            // Form sluiten
            Close();
        }

        private void FrmToonProd_Load(object sender, EventArgs e)
        {
            // haal de naam van alle producten uit de business en toon ze in de tekstbox
            txtToon.Text = Program.ToonProd();
        }
    }
}
