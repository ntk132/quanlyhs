using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyhocsinhDAL
{
    public class DataAccess
    {
        private static string connectionStr = @"Data Source=kpc\homesqlserver;Initial Catalog=QLHS;Integrated Security=True";
        public SqlConnection connection = new SqlConnection(connectionStr);

        public DataAccess()
        {
            ExecuteQuery("USE QLHS");
            ExecuteQuery("SET DATEFORMAT DMY");
        }

        public DataTable ExecuteQuery(string query)
        {
            DataTable dt = new DataTable();

            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(dt);

            connection.Close();

            return dt;
        }

        public int ExecuteNonQuery(string query)
        {
            int dt = 0;

            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);

            command.ExecuteNonQuery();

            connection.Close();

            return dt;
        }
    }
}
