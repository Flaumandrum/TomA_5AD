using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_TomA_FormsStart
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void btnAfsluiten_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnHallo_Click(object sender, EventArgs e)
        {
            // neem de text uit de textbox en sla deze op
            string naam = txtNaam.Text;

            // roep de functie op met de text uit de textbox
            // en sla het return antwoord op
            string ontvAntwoord = Program.ZegHallo(naam);

            // Toon het return antwoord in het label
            lblHallo.Text = ontvAntwoord;
        }
    }
}
