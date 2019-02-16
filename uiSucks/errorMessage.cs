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
    public partial class errorMessage : Form
    {
        public errorMessage()
        {
            InitializeComponent();
        }
        public errorMessage(string error)
        {
        }

        private void errorMessage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            messageError.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            messageError.Visible = false;
        }

    }
}
