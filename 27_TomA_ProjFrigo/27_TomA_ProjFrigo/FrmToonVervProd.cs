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
    public partial class FrmToonVervProd : Form
    {
        public FrmToonVervProd()
        {
            InitializeComponent();
        }

        private void btnAnnul_Click(object sender, EventArgs e)
        {
            // Form sluiten
            Close();
        }

        private void FrmToonVervProd_Load(object sender, EventArgs e)
        {
            // haal de vervallenproducten uit de business en toon ze in de tekstbox
            txtToon.Text = Program.ToonVervProd();
        }
    }
}
