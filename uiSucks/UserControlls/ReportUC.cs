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
    public partial class ReportUC : UserControl
    {
        public ReportUC()
        {
            InitializeComponent();
        }

        private void btnTicketReport_Click(object sender, EventArgs e)
        {
            txtReport.Text = "Ticket Report";
            dataGridView1.DataSource = getTicket();
        }


        private DataTable getTicket()
        {
            DataTable dtTodo = new DataTable();
            DataConnection datacon = new DataConnection();

            try
            {
                datacon.openConnection();
                SqlCommand cmd = new SqlCommand("selectTopTickets", datacon.openConnection());
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













        private void btnMentenanceReport_Click(object sender, EventArgs e)
        {
            txtReport.Text = "Mentenance Report";
        }

        private void btnTrainReport_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = getTicket();
            txtReport.Text = "Train Report";
        }

        private void btnFinancialReport_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = getTicket();
            txtReport.Text = "Financial Report";
        }

        private void ReportUC_Load(object sender, EventArgs e)
        {

        }
 }
}
