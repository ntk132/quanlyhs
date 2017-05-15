using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using quanlyhocsinhDTO;

namespace quanlyhocsinhDAL
{
    public class QuyDinhDAL
    {
        private DataAccess da = new DataAccess();
        //private string connectionStr = @"Data Source=kpc\homesqlserver;Initial Catalog=QUANLYHS;Integrated Security=True";

        public QuyDinhDAL()
        {

        }

        public DataTable layDanhSachQuyDinh()
        {
            DataTable dt = new DataTable();
            string query = "select * from QUYDINH";

            //SqlConnection connection = new SqlConnection(connectionStr);
            SqlCommand command = new SqlCommand(query, da.connection);

            SqlDataAdapter adpater = new SqlDataAdapter(command);

            da.connection.Open();

            adpater.Fill(dt);

            da.connection.Close();

            return dt;

        }

        public DataTable layQuyDinhTheoMaQD(string maqd)
        {
            DataTable dt = new DataTable();
            string query = "select * from QUYDINH where MaQuyDinh='" + maqd + "'";

            //SqlConnection connection = new SqlConnection(connectionStr);
            SqlCommand command = new SqlCommand(query, da.connection);

            SqlDataAdapter adpater = new SqlDataAdapter(command);

            da.connection.Open();

            adpater.Fill(dt);

            da.connection.Close();

            return dt;
        }

        public void update(QuyDinhDTO qd)
        {
            string query = "update QUYDINH set GiaTri=@giatri where MaQuyDinh=" + qd.MaQuyDinh;

            //SqlConnection connection = new SqlConnection(connectionStr);
            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@giatri", SqlDbType.NChar).Value = qd.GiaTri;

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }
    }
}
