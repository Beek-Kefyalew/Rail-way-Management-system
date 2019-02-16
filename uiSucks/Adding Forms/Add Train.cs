using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using uiSucks.MyClasses.DataAccess;

namespace uiSucks
{
    public partial class AddTrain : Form
    {

        public SqlCommand cmd { get; set; }

        public AddTrain()
        {
            InitializeComponent();
        }

        private void AddTrain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'railMGMTDataSet.selectTrainType' table. You can move, or remove it, as needed.
         //   this.selectTrainTypeTableAdapter.Fill(this.railMGMTDataSet.selectTrainType);

        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            DataConnection datacon = new DataConnection();

            try
            {
                datacon.openConnection();
                cmd = new SqlCommand("addTrain", datacon.openConnection());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@type", (comboTrainType.SelectedIndex +1));
                cmd.Parameters.AddWithValue("@startingPT", (comboStart.SelectedIndex + 1));
                cmd.Parameters.AddWithValue("@destinationPT", (comboDestination.SelectedIndex +1));
                cmd.Parameters.AddWithValue("@MAC", txtMAC.Text);
                cmd.Parameters.AddWithValue("@description", richtxtDescription.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("success");
                this.Close();
            }
            catch(SqlException)
            {
                MessageBox.Show("Error try inserting proper data");
            }
            finally
            {
                datacon.closeConnection();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
