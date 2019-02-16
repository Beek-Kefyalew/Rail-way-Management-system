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

namespace uiSucks.UserControlls
{
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }

        private bool changedStart;
        private bool changedDest;

        private void comboStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            success.Visible = false;
            Startingpt.Visible = true;
            Startingpt.Text = comboStart.SelectedItem.ToString();
             changedStart = true;
             if (changedStart == true && changedDest == true)
                 Birr.Text = Convert.ToString(calculatePrice());
        }

        private void comboDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            success.Visible = false;
            destPt.Visible = true;
            destPt.Text = comboDestination.SelectedItem.ToString();
             changedDest = true;
             if (changedDest == true && changedStart == true)
                 Birr.Text = Convert.ToString(calculatePrice());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Close();
        }

       private int calculatePrice()
        {
           int price;

           if (comboStart.SelectedIndex < comboDestination.SelectedIndex)
           {
               int x = comboDestination.SelectedIndex - comboStart.SelectedIndex;
               if (x < 3)
               {
                   price = 2;
               }
               else if (x < 5)
               {
                   price = 4;
               }
               else price = 6;

           }
           else if (comboStart.SelectedIndex > comboDestination.SelectedIndex)
           {
               int x = comboStart.SelectedIndex - comboStart.SelectedIndex;
               if (x < 3)
               {
                   price = 2;
               }
               else if (x < 5)
               {
                   price = 4;
               }
               else price = 6;
           }

           else price = 0;
            
           return price;
        }


        private void Ticket_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataConnection dataCon = new DataConnection();

            try
            {
                SqlCommand cmd = new SqlCommand("addTicket", dataCon.openConnection());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ticketPrice", calculatePrice());
                cmd.Parameters.AddWithValue("@stationSold", comboStart.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@Destination", comboDestination.SelectedIndex + 1);

                cmd.ExecuteNonQuery();
                success.Visible = true;
            }
            catch(SqlException)
            {
                MessageBox.Show("sql connection error");

            }
            finally
            {
                dataCon.closeConnection();
            }


        }
    }
}
