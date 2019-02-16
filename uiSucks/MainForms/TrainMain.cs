using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uiSucks
{
    public partial class TrainMain : Form
    {
        public TrainMain()
        {
            InitializeComponent();
            clearHome();
            btnMytrain.BackColor = Color.Green;
                    }

        private void clearHome()
        {
            myTrainUC1.Visible = false;
            contact1.Visible = false;
            help1.Visible = false;

            btnabout.BackColor = Color.Transparent;
            btnhelp.BackColor = Color.Transparent;
            btnMap.BackColor = Color.Transparent;
            btnMytrain.BackColor = Color.Transparent;
            btnReports.BackColor = Color.Transparent;
            btnContact.BackColor = Color.Transparent;
        }

        private void btnMytrain_Click(object sender, EventArgs e)
        {
            clearHome();
            myTrainUC1.Visible = true;
            myTrainUC1.Dock = DockStyle.Fill;
            btnMytrain.BackColor = Color.Green;
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            clearHome();
            btnMap.BackColor = Color.Green;
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            clearHome();
            contact1.Visible = true;
            contact1.Dock = DockStyle.Fill;
            btnContact.BackColor = Color.Green;

        }

        private void btnhelp_Click(object sender, EventArgs e)
        {
            clearHome();
            help1.Visible = true;
            help1.Dock = DockStyle.Fill;
            btnhelp.BackColor = Color.Green;

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void myTrainUC1_Load(object sender, EventArgs e)
        {

        }

    }
}
