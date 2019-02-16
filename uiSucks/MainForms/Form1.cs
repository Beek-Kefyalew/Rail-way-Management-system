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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
            defaultTask();
            clearHome();
            btnHome.BackColor = Color.Green;
            Home1.Visible = true;
            Home1.Dock = DockStyle.Fill;
            Home1.Size = new Size(980, 622);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            defaultTask();
            clearHome();
            btnReports.BackColor = Color.Green;
            reportUC1.Visible = true;
            reportUC1.Dock = DockStyle.Fill; 
        }
       

        private void defaultTask()
        {
            //sets the task bar to default location and removes all background colors
            btnEmployees.BackColor = Color.Transparent;
            btnHome.BackColor = Color.Transparent;
            btnMap.BackColor = Color.Transparent;
            btnTrains.BackColor = Color.Transparent;
            btnReports.BackColor = Color.Transparent;
            help.BackColor = Color.Transparent;
            btnUsers.BackColor = Color.Transparent;

            menupanel.Location = new Point(0, 336);
            panelTask.Visible = false;
            tasks.BackColor = Color.Transparent; 
        }

        private void clearHome()
        {
            Home1.Visible = false;
            mapControll1.Visible = false;
            trainsUC1.Visible = false;
            employeesUC1.Visible = false;
            help1.Visible = false;
            usersUC1.Visible = false;
            reportUC1.Visible = false;
        }

        private void tasks_Click(object sender, EventArgs e)
        {
            if (panelTask.Visible)
            {
                defaultTask();
            }
            else
            {
                defaultTask();
                menupanel.Location = new Point(0, 420);
                panelTask.Visible = true;
                tasks.BackColor = Color.Green;

            }


        }

        private void home1_Load(object sender, EventArgs e)
        {
        }

        private void home1_Click(object sender, EventArgs e)
        {

            defaultTask();
            
        }

        private void Home_Click(object sender, EventArgs e)
        {
            defaultTask();
            clearHome();
            btnHome.BackColor = Color.Green;
            Home1.Visible = true;
            Home1.Dock = DockStyle.Fill;
            Home1.Size = new Size(980, 622);

        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            defaultTask();
            clearHome();
            btnMap.BackColor = Color.Green;
            mapControll1.Visible = true;
            mapControll1.Dock = DockStyle.Fill;

        }

        private void btnTrains_Click(object sender, EventArgs e)
        {
            defaultTask();
            btnTrains.BackColor = Color.Green;
            clearHome();
            trainsUC1.Visible = true;
            trainsUC1.Dock = DockStyle.Fill;
        }

        private void employeesUC1_Load(object sender, EventArgs e)
        {

        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {

            defaultTask();
            btnEmployees.BackColor = Color.Green;
            clearHome();
            employeesUC1.Visible = true;
            employeesUC1.Dock = DockStyle.Fill;
        }

        private void HomePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
          //  MessageBox.Show("Do you want to exit?");
            Application.Exit();
        }

        private void help_Click(object sender, EventArgs e)
        {

            defaultTask();
            help.BackColor = Color.Green;
            clearHome();
            help1.Visible = true;
            help1.Dock = DockStyle.Fill;
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            defaultTask();
            btnUsers.BackColor = Color.Green;
            clearHome();
            usersUC1.Visible = true;
            usersUC1.Dock = DockStyle.Fill;

        }

        private void label5_Click(object sender, EventArgs e)
        {
            login lognew = new login();
            lognew.Show();
            this.Close();
        }

        private void logOut_MouseHover(object sender, EventArgs e)
        {
            logOut.ForeColor = Color.SteelBlue;
        }

        private void logOut_MouseLeave(object sender, EventArgs e)
        {
            logOut.ForeColor = Color.Silver;
        }


        
    }
}
