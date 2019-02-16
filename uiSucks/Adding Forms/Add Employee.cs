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
    public partial class EmployeeProperties : Form
    {
        /*comand string and sql command object*/
        public string command { get; set; }
        public SqlCommand cmd { get; set; }
        
        public EmployeeProperties()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void addUser()
        {

            DataConnection dataCon = new DataConnection();

            try
            {
                command = "select count(*) from UserLogin where userName = @name and passwordField = @pass ";
                SqlConnection con = dataCon.openConnection();

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

        private void defaultBack()
        {
            txtSalary.BackColor = Color.Gray; txtEducation.BackColor = Color.Gray;
            txtPhoneNumber.BackColor = Color.Gray; txtEmail.BackColor = Color.Gray;
            txtLastName.BackColor = Color.Gray; txtEmergency.BackColor = Color.Gray;
            txtEmpName.BackColor = Color.Gray; txtEmergencyPhone.BackColor = Color.Gray;
            txtBirthDate.BackColor = Color.Gray; txtAddress.BackColor = Color.Gray;
        }

      
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            DataConnection dataCon = new DataConnection();

            int department = comboDepartment.SelectedIndex + 1;
            int workingStation = comboWorkingStation.SelectedIndex + 1;
            DateTime hiredt = DateTime.Now;
            string sex = comboSex.SelectedText;
            try
            {
                
                command = @"addEmployee";
                SqlConnection con = dataCon.openConnection();
                cmd = new SqlCommand(command, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@fname", txtEmpName.Text);
                cmd.Parameters.AddWithValue("@lname", txtLastName.Text);
                cmd.Parameters.AddWithValue("@department", department);
                cmd.Parameters.AddWithValue("@hireDate", hiredt);
                cmd.Parameters.AddWithValue("@education", txtEducation.Text);
                cmd.Parameters.AddWithValue("@sex", sex);
                cmd.Parameters.AddWithValue("@birthDate", txtBirthDate.Text);
                cmd.Parameters.AddWithValue("@salary", txtSalary.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhoneNumber.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@workingStation", workingStation);
                cmd.Parameters.AddWithValue("@emergencyFname", txtEmergency.Text);
                cmd.Parameters.AddWithValue("@emergencyPhone", txtEmergencyPhone.Text);
                cmd.Parameters.AddWithValue("@description", richtxtDescription.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee sucessfully Added");
                
            }
                
            catch (SqlException )
            {
                MessageBox.Show("Failed to Add Employee");
            }

            finally
            {
                dataCon.closeConnection();
            }
        }
    
       

            

        private void txtEmpName_TextChanged(object sender, EventArgs e)
        {
        }

        private void EmployeeProperties_Load(object sender, EventArgs e)
        {

        }

        private void txtEmpName_Enter(object sender, EventArgs e)
        {
        
        }

    }
}































/*
            DataConnection dataCon = new DataConnection();
            try
            {
                int department = comboDepartment.SelectedIndex + 1;
                int workingStation = comboWorkingStation.SelectedIndex + 1;
                DateTime hiredt = DateTime.Now;
                string sex = comboSex.SelectedText;
                SqlConnection connect = dataCon.openConnection();

                command = @"exec addEmployee " + txtEmpName.Text + "," + txtLastName + "," +
                           department + "," + hiredt + "," + txtEducation.Text + "," + sex + "," +
                           txtBirthDate.Text + "," + txtSalary.Text + "," + txtPhoneNumber + "," + txtPhoneNumber + "," +
                           txtEmail.Text + "," + txtAddress.Text + "," + workingStation + "," + txtEmergencyPhone.Text + "," +
                           txtEmergencyPhone.Text + "," + richtxtDescription.Text ;

                SqlCommand cmd = new SqlCommand(command, connect);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("error" + ex);
            }*/