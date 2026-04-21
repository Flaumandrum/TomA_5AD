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
    public partial class FrmToonLln : Form
    {
        public FrmToonLln()
        {
            InitializeComponent();
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmToonLln_Load(object sender, EventArgs e)
        {
            // Zorg dat je de leerlingen toont in de textbox
            txtToon.Text = Program.ToonLln();


        }
    }
}
