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


namespace uiSucks.Editing_Forms
{
    public partial class Edit_Train : Form
    {
        public Edit_Train()
        {
            InitializeComponent();
        }

        private void Edit_Train_Load(object sender, EventArgs e)
        {
            insertData();
        }





        public void insertData()
        {
            DataConnection dataCon = new DataConnection();

            try
            {
                employeesUC.ID.ToString();

                SqlCommand cmd = new SqlCommand("selecttrainByID", dataCon.openConnection());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", employeesUC.ID);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboTrainType.Text = reader["type"].ToString();
                    comboStart.SelectedIndex = Convert.ToInt16(reader["startingPoint"].ToString()) - 1;
                    comboDestination.SelectedIndex = Convert.ToInt16(reader["destinationPoint"].ToString()) - 1;
                    txtMAC.Text = reader["MACaddress"].ToString();
                    richtxtDescription.Text = reader["Desciption"].ToString();
                    
                }



            }
            catch (SqlException)
            {
                errorMessage er = new errorMessage();
                er.Show();
            }
            finally
            {
                dataCon.openConnection();
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            DataConnection datacon = new DataConnection();

            try
            {
                datacon.openConnection();
                SqlCommand cmd = new SqlCommand("addTrain", datacon.openConnection());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@type", (comboTrainType.SelectedIndex + 1));
                cmd.Parameters.AddWithValue("@startingPT", (comboStart.SelectedIndex + 1));
                cmd.Parameters.AddWithValue("@destinationPT", (comboDestination.SelectedIndex + 1));
                cmd.Parameters.AddWithValue("@MAC", txtMAC.Text);
                cmd.Parameters.AddWithValue("@description", richtxtDescription.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("success");
                this.Close();
            }
            catch (SqlException)
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
