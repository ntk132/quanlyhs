using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;

namespace quanlyhocsinhDAL
{
    public class DataAccess
    {
        private string currentPath = Environment.CurrentDirectory;
        private static string connectionStr = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\QUANLYHOCSINH.mdf;Integrated Security=True;Connect Timeout=30";
        public SqlConnection connection = new SqlConnection(connectionStr);

        public DataAccess()
        {            
            ExecuteQuery("USE QLHS");
            ExecuteQuery("SET DATEFORMAT DMY");
        }

        public void OpenConnection()
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }
        }

        public void CloseConnection()
        {
            connection.Close();
        }

        public DataTable ExecuteQuery(string query)
        {
            DataTable dt = new DataTable();

            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(dt);
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public int ExecuteNonQuery(string query)
        {
            int dt = 0;           
                        
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                dt = command.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return dt;
        }
    }
}
