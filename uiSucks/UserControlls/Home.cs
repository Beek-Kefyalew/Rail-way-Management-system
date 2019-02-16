using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using uiSucks.MyClasses.DataAccess;

namespace uiSucks
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
            dataGridView1.DataSource = getTodo();
            setTrainNum();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private DataTable getTodo()
        {
            DataTable dtTodo = new DataTable();
            DataConnection datacon = new DataConnection();

            try
            {
                datacon.openConnection();
                SqlCommand cmd = new SqlCommand("listTask", datacon.openConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                dtTodo.Load(reader);
            }
            catch (SqlException)
            {
               
            }
            finally
            {
                datacon.closeConnection();
            }

            return dtTodo;
        }


        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void setTrainNum()
        {
            DataTable dtTodo = new DataTable();
            DataConnection datacon = new DataConnection();

            try
            {
                datacon.openConnection();
                SqlCommand cmd = new SqlCommand("counttrain", datacon.openConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                trainNum.Text = Convert.ToString(cmd.ExecuteScalar());

                cmd = new SqlCommand("countEmployee", datacon.openConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                empNum.Text = Convert.ToString(cmd.ExecuteScalar());

            }
            catch (SqlException)
            {

            }
            finally
            {
                datacon.closeConnection();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void empNum_Click(object sender, EventArgs e)
        {

        }
    }
}
