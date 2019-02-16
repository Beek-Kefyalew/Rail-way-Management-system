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
using uiSucks.MyClasses.Security;

namespace uiSucks
{
    public partial class UserAdd : Form
    {
        public SqlCommand cmd { get; set; }
        public SqlCommand cmdID { get; set; }
        public UserAdd()
        {
            InitializeComponent();
        }

        private void UserAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            DataConnection datacon = new DataConnection();
            Encryption EncDec = new Encryption();

            try
            {
                datacon.openConnection();
                cmd = new SqlCommand("addUser", datacon.openConnection());
                cmdID = new SqlCommand("selectIDuser", datacon.openConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmdID.CommandType = CommandType.StoredProcedure;
                
                
                try
                {
                    cmdID.Parameters.AddWithValue("@selectIDuser", txtemployee.Text);
                    int id = cmdID.ExecuteNonQuery();
                
                string encryptedPass = EncDec.Encrypt(txtpass.Text);
                string encryptedUser = EncDec.Encrypt(txtuname.Text);
                
                cmd.Parameters.AddWithValue("@role", comboRole.SelectedText);
                cmd.Parameters.AddWithValue("@userName", txtuname.Text);
                cmd.Parameters.AddWithValue("@password", txtpass.Text);
                cmd.Parameters.AddWithValue("@employee", id);

                cmd.ExecuteNonQuery();

                MessageBox.Show("succesfull");
                this.Close();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Error : Employee Not Found");
                }

            }
            catch
            {
                MessageBox.Show("Error: check Your Inputs and Try Again");
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
