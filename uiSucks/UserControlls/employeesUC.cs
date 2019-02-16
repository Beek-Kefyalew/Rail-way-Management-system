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
    public partial class employeesUC : UserControl
    {
        public string Connectionstr { get; set; }
        public string command { get; set; }
        public static int ID;
        public employeesUC()
        {
            InitializeComponent();
                                          
        }








        private void employeesUC_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            emoloyeeGridView.DataSource = Getemployee();
            
            
        }


        private DataTable Getemployee()
        {
            DataTable dtEmployees = new DataTable();
            DataConnection dataCon = new DataConnection();
            string commandStr;
            
            try
            {
                dataCon.openConnection();
                commandStr = @"selectAllEmployees";
                SqlCommand cmd = new SqlCommand(commandStr, dataCon.openConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                
                if (comboBox1.SelectedIndex == 0)
                {
                    dtEmployees.Load(reader);
                }
                else if (comboBox1.SelectedIndex != 0 )
                {
                    int i = comboBox1.SelectedIndex;
                    cmd = new SqlCommand("select * from Employees where Department ="+ i, dataCon.openConnection());
                    reader = cmd.ExecuteReader();
                    dtEmployees.Load(reader);
                }
            }
            catch (SqlException sqlExc)
            {
                MessageBox.Show("Sql Connection Error" + sqlExc);
            }
            finally
            {
                dataCon.closeConnection();
            }
            

            return dtEmployees;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeProperties a = new EmployeeProperties();
            a.ShowDialog();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            emoloyeeGridView.DataSource = Getemployee();
        }

        private void emoloyeeGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void emoloyeeGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /*---------------------------------------------------------------------------------------------------------------*/
        public string returnID()
        {
            string id = "";
            if (emoloyeeGridView.SelectedCells.Count > 0)
            {
                id = emoloyeeGridView.SelectedCells[0].Value.ToString();
            }
            return id;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            DataConnection dtCon = new DataConnection();

            try
            {
                SqlConnection con = dtCon.openConnection();
                if (emoloyeeGridView.SelectedCells.Count > 0)
                {
                    string id = emoloyeeGridView.SelectedCells[0].Value.ToString();
                    emoloyeeGridView.Rows.RemoveAt(this.emoloyeeGridView.SelectedRows[0].Index);

                    SqlCommand cmd = new SqlCommand("deleteEmployee", con);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(" Delete succesfull");

                }
            }
            catch
            {
                MessageBox.Show("error : select proper id ");
            }

            finally
            {
                dtCon.closeConnection();
            }
        }

        public string strrr()
        {
            string id = "";
            if (emoloyeeGridView.SelectedCells.Count > 0)
            {
                id = emoloyeeGridView.SelectedCells[0].Value.ToString();
            }
            return id;
        }





        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ID = Convert.ToInt16(strrr());
                EditEmp edit = new EditEmp();
                edit.Show();

            }
            catch (System.FormatException)
            {
                MessageBox.Show("error , select proper user id");
            }
        }

    }
}
