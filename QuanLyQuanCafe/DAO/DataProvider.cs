using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyQuanCafe.DAO
{
   
    public class DataProvider
    {
        private string connect = "Data Source=GL-522VJ\\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe;Integrated Security=True";

        public DataTable ExecuteQuery (string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
              
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
            }
            return data;
        }
        
    }
}
