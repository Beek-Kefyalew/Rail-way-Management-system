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
//using System.Security.Cryptography;

using uiSucks.MyClasses.DataAccess;
using uiSucks.MyClasses.Security;


namespace uiSucks
{
    public partial class login : Form
    {

        /*global variable properties*/

        public string username { get; set; }
        public string password { get; set; }
        public string role { get; set; }

        /*commands to excute*/

        public string command { get; set; }
        public string logcommand { get; set; }

        public SqlCommand cmd { get; set; }
        public SqlCommand logcmd { get; set; }

        /*--------------------------------------*/

        public login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtEnter(object sender, EventArgs e)
        {

            txtUserName.BackColor = Color.DimGray;
            txtError.Visible = false;
            txtPassword.BackColor = Color.DimGray;
            if (txtUserName.Text.Equals(@"User name \ Email"))
            {
                txtUserName.Text = "";
            }
        }

        private void txtUserLeave(object sender, EventArgs e)
        {
            if (txtUserName.Text.Equals(""))
            {
                txtUserName.Text = @"User name \ Email";
            }
        }

        private void passEnter(object sender, EventArgs e)
        {

            txtPassword.BackColor = Color.DimGray;
            txtError.Visible = false;
            txtUserName.BackColor = Color.DimGray;
            if (txtPassword.Text.Equals("Password"))
            {
                txtPassword.Text = "";
            }
        }

        private void passExit(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(""))
            {
                txtPassword.Text = "Password";
            }
        }



        /*--------------------------------------------------------------------*/

        private void button1_Click(object sender, EventArgs e)
        {

            DataConnection dataCon = new DataConnection();
            Encryption EncDec = new Encryption();

            string encryptedUname = EncDec.Encrypt(txtUserName.Text);
            string encryptedPass = EncDec.Encrypt(txtPassword.Text);

            try
            {
                command = @"checkUser";
                // DateTime logintime = new DateTime();
                logcommand = "LogLoginRecords";

                SqlConnection con = dataCon.openConnection();
                cmd = new SqlCommand(command, con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@uname", encryptedUname);
                cmd.Parameters.AddWithValue("@pass", encryptedPass);

                logcmd = new SqlCommand(logcommand, con);

                SqlCommand checkRole = new SqlCommand("checkRole", con);
                checkRole.CommandType = CommandType.StoredProcedure;
                checkRole.Parameters.AddWithValue("@uname", @txtUserName.Text);

                int value = Convert.ToInt16(cmd.ExecuteScalar());
                if (value == 1)
                {
                    string Role = Convert.ToString(checkRole.ExecuteScalar());

                    if (Role.Equals("administrator"))
                    {
                        DashBoard dash = new DashBoard();
                        dash.Show();
                        this.Hide();
                    }

                    else if (Role == "ticket")
                    {
                        uiSucks.UserControlls.Ticket ticket = new uiSucks.UserControlls.Ticket();
                        ticket.Show();
                        this.Hide();
                    }
                    else
                    {
                        uiSucks.UserControlls.Ticket ticket = new uiSucks.UserControlls.Ticket();
                        ticket.Show();
                        this.Hide();
                     //   MessageBox.Show("cant determine Role");


                    }
                }
                else
                {
                    txtUserName.BackColor = Color.LightCoral;
                    txtPassword.BackColor = Color.LightCoral;

                    txtError.Visible = true;
                }
            }

            catch (SqlException)
            {
                MessageBox.Show("Can not connect to Database");
            }

            finally
            {
                dataCon.closeConnection();
            }

        }


















        /*
         SqlConnection connection = new SqlConnection();
         SqlCommand command = new SqlCommand();

         connection.ConnectionString = @"Data Source = localhost; Initial Catalog = RailMGMT; Integrated Security =True ";
         
     try { 
         connection.Open();
        //open connection
        command.Connection = connection;
        command.CommandText = "select * from UserLogin";
        SqlDataReader dr = command.ExecuteReader();
        string log  = "insert into LoginLog values (" + dr["userName"] + "," + dr["passwordField"]+")";
        SqlCommand logcmd = new SqlCommand(log, connection);
        SqlDataReader logread = logcmd.ExcuteReader();
        while (dr.Read())
        {
            if (txtUserName.Text.Equals(dr["userName"]) && txtPassword.Text.Equals(dr["passwordField"]))
            {
                if (Convert.ToString(dr["Role"]).Equals("administrator"))
                {
                    DashBoard dash = new DashBoard();
                    dash.Show();

                    command.CommandText = "insert into LoginLog values (" + dr["userName"] + "," + dr["passwordField"]+")";
                    SqlDataReader exc = command.ExecuteReader();

                    //connection.Close();
                    this.Hide();
                }
                else if (Convert.ToString(dr["Role"]).Equals("conductor"))
                {
                    MessageBox.Show("fix this for conductor");
                }
            }
            else
            {
                txtUserName.BackColor = Color.LightCoral;
                txtPassword.BackColor = Color.LightCoral;

                txtError.Visible = true;
            }
           }
         }
     catch(Exception ex)
        {
            MessageBox.Show("Can not connect to database :( " + ex.ToString());
        }
        connection.Close();
    }
*/
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        { }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {


                DataConnection dataCon = new DataConnection();
                Encryption EncDec = new Encryption();

                string encryptedUname = EncDec.Encrypt(txtUserName.Text);
                string encryptedPass = EncDec.Encrypt(txtPassword.Text);

                try
                {
                    command = @"checkUser";
                    // DateTime logintime = new DateTime();
                    logcommand = "LogLoginRecords";

                    SqlConnection con = dataCon.openConnection();
                    cmd = new SqlCommand(command, con);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@uname", encryptedUname);
                    cmd.Parameters.AddWithValue("@pass", encryptedPass);

                    logcmd = new SqlCommand(logcommand, con);

                    SqlCommand checkRole = new SqlCommand("checkRole", con);
                    checkRole.CommandType = CommandType.StoredProcedure;
                    checkRole.Parameters.AddWithValue("@uname", @txtUserName.Text);

                    int value = Convert.ToInt16(cmd.ExecuteScalar());
                    if (value == 1)
                    {
                        string Role = Convert.ToString(checkRole.ExecuteScalar());

                        if (Role.Equals("administrator"))
                        {
                            DashBoard dash = new DashBoard();
                            dash.Show();
                            this.Hide();
                        }

                        else if (Role.Equals("conductor"))
                        {
                            MessageBox.Show("Conductor");
                        }
                        else MessageBox.Show("cant determine Role");
                    }
                    else
                    {
                        txtUserName.BackColor = Color.LightCoral;
                        txtPassword.BackColor = Color.LightCoral;

                        txtError.Visible = true;
                    }
                }

                catch (SqlException exc)
                {
                    MessageBox.Show("Database Connection Error" + exc);
                }

                finally
                {
                    dataCon.closeConnection();
                }

            }
        }
    }
}