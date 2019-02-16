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
    public partial class UsersUC : UserControl
    {
        public UsersUC()
        {
            InitializeComponent();
            userGridView.DataSource = listUsers();
        }

        public DataTable listUsers()
        {
            DataTable dt = new DataTable();
            DataConnection dataCon = new DataConnection();
            string commandStr;
            
            try
            {
                dataCon.openConnection();
                commandStr = @"selectAllUser";
                SqlCommand cmd = new SqlCommand(commandStr, dataCon.openConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
            }
            catch (SqlException exc)
            {
                MessageBox.Show("Error" + exc);
            }
            finally
            {
                dataCon.closeConnection();
            }

            return dt;
        }

        private void UsersUC_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserAdd user = new UserAdd();
            user.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DataConnection dtCon = new DataConnection();

            try
            {
                SqlConnection con = dtCon.openConnection();
                if (  userGridView.SelectedCells.Count > 0)
                {
                    string id = userGridView.SelectedCells[0].Value.ToString();
                    try
                    {
                        userGridView.Rows.RemoveAt(this.userGridView.SelectedRows[0].Index);

                        SqlCommand cmd = new SqlCommand("deleteUser", con);

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
    }
}
