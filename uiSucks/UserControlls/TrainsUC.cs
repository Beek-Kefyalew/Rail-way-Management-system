using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uiSucks;
using System.Data.SqlClient;
using uiSucks.Editing_Forms;
using uiSucks.MyClasses.DataAccess;


namespace uiSucks
{
    public partial class TrainsUC : UserControl
    {
        public string Connectionstr { get; set; }
        public string command { get; set; }
 
       public static int ID;

        public TrainsUC()
        {
            InitializeComponent();
        }


        private void TrainsUC_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            trainsGridView.DataSource = GetTrains();
        }

        

        private DataTable GetTrains()
        {
            DataTable dtTrains = new DataTable();
            Connectionstr = @"Data Source=.; Initial Catalog = RailMGMT ; Integrated Security=True";
            SqlConnection connection = new SqlConnection(Connectionstr);
            SqlCommand cmd;
            SqlCommand count;
            SqlDataReader reader;
            try
            {

                connection.Open();

                if (comboBox1.SelectedIndex == 0)
                {
                    cmd = new SqlCommand("select * from Train", connection);
                    reader = cmd.ExecuteReader();
                    dtTrains.Load(reader);
                    count = new SqlCommand("select count(*) from Train", connection);
                    rowNumber.Text = Convert.ToString(count.ExecuteNonQuery());
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    cmd = new SqlCommand("select * from Train where type = 'Single'", connection);
                    reader = cmd.ExecuteReader();
                    dtTrains.Load(reader);
                    count = new SqlCommand("select count(*) from Train where  type = 'Single'", connection);
                    rowNumber.Text = Convert.ToString(count.ExecuteNonQuery());
                }
                else
                {
                    cmd = new SqlCommand("select * from Train where type = 'double'", connection);
                    reader = cmd.ExecuteReader();
                    dtTrains.Load(reader);
                    count = new SqlCommand("select count(*) from Train where  type = 'double'", connection);
                    rowNumber.Text = Convert.ToString(count.ExecuteNonQuery());
                }
            }
            catch (SqlException sqlExc)
            {
                MessageBox.Show("Sql Connection Error" + sqlExc);
            }
            finally
            {
                connection.Close();
            }


            connection.Close();


            return dtTrains;


        }
/*---------------------------------------------------------------------------*/


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
            trainsGridView.DataSource = GetTrains();
         
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DataConnection dtCon = new DataConnection();

            try
            {
                SqlConnection con = dtCon.openConnection();
                if (trainsGridView.SelectedCells.Count > 0)
                {
                    string id = trainsGridView.SelectedCells[0].Value.ToString();
                    try
                    {
                        trainsGridView.Rows.RemoveAt(this.trainsGridView.SelectedRows[0].Index);

                        SqlCommand cmd = new SqlCommand("deleteTrain", con);

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("DELETED");

                    }
                    catch (System.ArgumentOutOfRangeException)
                    {
                        MessageBox.Show("Error Select the ID to delete");
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("ERROR");
            }

            finally
            {
                dtCon.closeConnection();
            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddTrain trainadd = new AddTrain();
            trainadd.Show();
            

        }

        private void button1_Leave(object sender, EventArgs e)
        {
            trainsGridView.DataSource = GetTrains();
        }


        public string strrr()
        {
            string id = "";
            if (trainsGridView.SelectedCells.Count > 0)
            {
                id = trainsGridView.SelectedCells[0].Value.ToString();
            }
            return id;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ID = Convert.ToInt16(strrr());
                Edit_Train edit = new Edit_Train();
                edit.Show();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("error : please select proper id");
            }
        }
    }
}
