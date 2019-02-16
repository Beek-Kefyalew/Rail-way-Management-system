using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace uiSucks.MyClasses.DataAccess
{
    class DataConnection
    {
        public string connectionStr { get; set; }
  //      public string command { get; set; }
        
        public SqlConnection connection { get; set; }
    //    public SqlCommand cmd { get; set; }
        

        public DataConnection()
        {
            connectionStr = @"Data Source= .; Initial Catalog= RailMGMT ; Integrated security=True; ";
        }

       /* public DataConnection(string command)
        {
            connectionStr = @"Data Source = localhost; Initial Catalog = RailMGMT; Integrated Security =True ";
            this.command = command;
        }*/

        public SqlConnection openConnection()
        {
            try
            {
                connection = new SqlConnection(connectionStr);
                connection.Open();
            }
            catch (SqlException sqlex)
            {
                throw sqlex;
            }
            return connection;
        }

        public void closeConnection()
        {
            connection.Close();
        }
    }
}
