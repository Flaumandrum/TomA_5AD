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
    public partial class FrmKeuzemenu : Form
    {
        public FrmKeuzemenu()
        {
            InitializeComponent();
        }

        private void FrmKeuzemenu_Load(object sender, EventArgs e)
        {
            Uitzicht();

        }

        private void Uitzicht()
        {
            bool ontvAntw = Program.IsArrayAangepast();

            btnToon.Visible = ontvAntw;
            btnToev.Visible = ontvAntw;


            //if(ontvAntw)
            //{
            //    btnToon.Visible = true;
            //    btnToev.Visible = true; 
            //}
            //else
            //{
            //    btnToon.Visible = false;
            //    btnToev.Visible = false;
            //}

            if (ontvAntw)
            {
                btnAfsluiten.Location = new Point(28, 167);
                this.Size = new Size(375, 270);
            }
            else
            {
                btnAfsluiten.Location = new Point(28, 73);
                this.Size = new Size(375, 168);
            }
        }

        private void btnAfsluiten_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGrootte_Click(object sender, EventArgs e)
        {
            // nieuwe form aanmaken
            FrmIngGrootte nieuwFrm = new FrmIngGrootte();

            // oude form hide
            Hide();

            // nieuwe form tonen 
            nieuwFrm.ShowDialog();

            // oude form tonen
            Uitzicht();
            Show();
        }

        private void btnToon_Click(object sender, EventArgs e)
        {
            // nieuwe form aanmaken
            FrmToonLln nieuwFrm = new FrmToonLln();

            // oude form hide
            Hide();

            // nieuwe form tonen 
            nieuwFrm.ShowDialog();

            // oude form tonen
            Show();
        }

        private void btnToev_Click(object sender, EventArgs e)
        {
            // nieuwe form aanmaken
            FrmIngLln nieuwFrm = new FrmIngLln();

            // oude form hide
            Hide();

            // nieuwe form tonen 
            nieuwFrm.ShowDialog();

            // oude form tonen
            Show();
        }
    }
}
