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
    public partial class EditEmp : Form
    {           
        public EditEmp()
        {
            InitializeComponent();            
        }


        public void insertData()
        {
            DataConnection dataCon = new DataConnection();
            
            try
            {
                employeesUC.ID.ToString();

                SqlCommand cmd = new SqlCommand("selectEmployeeByID", dataCon.openConnection());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", employeesUC.ID);
               
                SqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    txtEmpName.Text = reader["FirstName"].ToString();
                    txtLastName.Text = reader["LastName"].ToString();
                    comboDepartment.SelectedIndex = Convert.ToInt16( reader["Department"].ToString()) -1;
                    txtEducation.Text = reader["EducationLevel"].ToString();
                    comboSex.Text = reader["Sex"].ToString();
                    txtBirthDate.Text = reader["BirthDate"].ToString();
                    txtSalary.Text = reader["Salary"].ToString();
                    txtPhoneNumber.Text = reader["PhoneNumber"].ToString();
                    txtEmail.Text = reader["Email"].ToString();
                    txtAddress.Text = reader["Address"].ToString();
                    comboWorkingStation.SelectedIndex = Convert.ToInt16( reader["WorkingStation"].ToString()) -1;
                    txtEmergency.Text = reader["EmergencyContactFullName"].ToString();
                    txtEmergencyPhone.Text = reader["EmergencyContactPhoneNumber"].ToString();
                    richtxtDescription.Text = reader["Description"].ToString();
                }

                

            }
            catch (SqlException)
            {
                MessageBox.Show("error");
            }
            finally
            {
                dataCon.openConnection();
            }
        }

        private void EditEmp_Load(object sender, EventArgs e)
        {
            insertData();

        }

   
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            DataConnection dataCon = new DataConnection();
             employeesUC.ID.ToString();

            errortxt.Visible = false;

            int department = comboDepartment.SelectedIndex + 1;
            int workingStation = comboWorkingStation.SelectedIndex + 1;
            DateTime hiredt = DateTime.Now;
            string sex = comboSex.SelectedText;
            try
            {

                SqlConnection con = dataCon.openConnection();
                SqlCommand cmd = new SqlCommand("updateEmployee", con);
                
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", employeesUC.ID);
                cmd.Parameters.AddWithValue("@department", department);
                cmd.Parameters.AddWithValue("@education", txtEducation.Text);
                cmd.Parameters.AddWithValue("@birthDate", txtBirthDate.Text);
                cmd.Parameters.AddWithValue("@salary", txtSalary.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhoneNumber.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@workingStation", workingStation);
                cmd.Parameters.AddWithValue("@emergencyFname", txtEmergency.Text);
                cmd.Parameters.AddWithValue("@emergencyPhone", txtEmergencyPhone.Text);
                

                cmd.Parameters.AddWithValue("@fname", txtEmpName.Text);
                cmd.Parameters.AddWithValue("@lname", txtLastName.Text);
                cmd.Parameters.AddWithValue("@hireDate", hiredt);
                cmd.Parameters.AddWithValue("@sex", sex);
                cmd.Parameters.AddWithValue("@description", richtxtDescription.Text);

                cmd.ExecuteNonQuery();
                
                MessageBox.Show("Succesfully Updated");

            }

            catch (SqlException)
            {
                errortxt.Visible = true;
                MessageBox.Show("Error : Check Input");
            }

            finally
            {
                dataCon.closeConnection();
            }
        }
    }
}
