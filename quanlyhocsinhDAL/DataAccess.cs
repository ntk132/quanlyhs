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
        private static string connectionStr = ConfigurationManager.ConnectionStrings["QuanLyHocSinh"].ConnectionString;
        public SqlConnection connection = new SqlConnection(connectionStr);

        public DataAccess()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            ExecuteQuery("USE QUANLYHOCSINH");
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
                OpenConnection();

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(dt);
            }
            catch
            {

            }
            finally
            {
                CloseConnection();
            }

            return dt;
        }

        public int ExecuteNonQuery(string query)
        {
            int dt = 0;           
                        
            try
            {
                OpenConnection();

                SqlCommand command = new SqlCommand(query, connection);

                dt = command.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                CloseConnection();
            }

            return dt;
        }
    }
}
