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
    public partial class DeleteConf : Form
    {
        public static int i;
        public DeleteConf()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i = 1;
        }

        private void DeleteConf_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
