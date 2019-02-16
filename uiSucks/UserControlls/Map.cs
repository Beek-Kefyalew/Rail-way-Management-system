using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uiSucks
{
    public partial class mapControll : UserControl
    {
        public mapControll()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            defaultColor();
            locationName.Text = "Ayat";
            locationGPS.Text = "d2'2'23 | sf1'11";
            name.Text = "Ayat";
            btnAyat.BackColor = Color.Red;
        
        }

        private void defaultColor()
        {
            torhailoch.BackColor = Color.SeaGreen; mexico.BackColor = Color.SeaGreen;
            btnAyat.BackColor = Color.SeaGreen; btnCMC.BackColor = Color.SeaGreen;
            button4.BackColor = Color.SeaGreen; button8.BackColor = Color.SeaGreen;
            button2.BackColor = Color.SeaGreen; button10.BackColor = Color.SeaGreen;
            button9.BackColor = Color.SeaGreen; //button10.BackColor = Color.SeaGreen;
            button11.BackColor = Color.SeaGreen; button12.BackColor = Color.SeaGreen;

        }

        private void torhailoch_Click(object sender, EventArgs e)
        {
            defaultColor();
            locationName.Text = "Torhailoch";
            locationGPS.Text = "32'31'3 | 1'1";
            torhailoch.BackColor = Color.Red;
        }

        private void mexico_Click(object sender, EventArgs e)
        {
            defaultColor();
            locationName.Text = "Mexico";
            locationGPS.Text = "22'23'13 | 31'11";
            mexico.BackColor = Color.Red;
            name.Text = "Mexico";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

            defaultColor();
            locationName.Text = "Abenet";
            locationGPS.Text = "d2'212'23 | sf1'11";
            name.Text = "Abenet";
            button12.BackColor = Color.Red;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            defaultColor();
            locationName.Text = "Abenet";
            locationGPS.Text = "22'212'23 | sf1'11";
            name.Text = "Abenet";
            button11.BackColor = Color.Red;
        
        }

        private void button10_Click(object sender, EventArgs e)
        {
            defaultColor();
            locationName.Text = "Lancha";
            locationGPS.Text = "22'12'23 | sf1'11";
            name.Text = "Lancha";
            button10.BackColor = Color.Red;
        
        }

        private void button9_Click(object sender, EventArgs e)
        {
            defaultColor();
            locationName.Text = "Saris";
            locationGPS.Text = "d2'32'3d | 42'11";
            name.Text = "Saris";
            button9.BackColor = Color.Red;
        
        }

        private void button8_Click(object sender, EventArgs e)
        {
            defaultColor();
            locationName.Text = "Kaliti";
            locationGPS.Text = "d2'12'43 | f1'11";
            name.Text = "Kaliti";
            button8.BackColor = Color.Red;
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            defaultColor();
            locationName.Text = "St. Estifanos";
            locationGPS.Text = "e3'212'23 | f1'11";
            name.Text = "St. Estifanos";
            button2.BackColor = Color.Red;
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            defaultColor();
            locationName.Text = "Megenagna";
            locationGPS.Text = "d2'2a2'e3 | sf1'11";
            name.Text = "Megenagna";
            button4.BackColor = Color.Red;
        }

        private void btnCMC_Click(object sender, EventArgs e)
        {
            defaultColor();
            locationName.Text = "CMC";
            locationGPS.Text = "d2'12'23 | sf1'11";
            name.Text = "CMC";
            btnCMC.BackColor = Color.Red;
        
        }




    }
}
