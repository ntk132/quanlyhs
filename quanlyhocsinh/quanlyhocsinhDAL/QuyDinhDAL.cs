using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using quanlyhocsinhDTO;

namespace quanlyhocsinhDAL
{
    public class QuyDinhDAL
    {
        private string connectionStr = @"Data Source=kpc\HOMESQLSERVER;Initial Catalog=QuanLyHocSinh;Integrated Security=True";

        public QuyDinhDAL()
        {
            DataAccess da = new DataAccess();

            da.ExecuteQuery("USE QuanLyHocSinh");
            da.ExecuteQuery("SET DATEFORMAT DMY");
        }

        public DataTable layDanhSachQuyDinh()
        {
            DataTable dt = new DataTable();
            string query = "select * from QUYDINH";

            SqlConnection connection = new SqlConnection(connectionStr);
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataAdapter adpater = new SqlDataAdapter(command);

            connection.Open();

            adpater.Fill(dt);

            connection.Close();

            return dt;

        }

        public DataTable layQuyDinhTheoaQD(string maqd)
        {
            DataTable dt = new DataTable();
            string query = "select * from QUYDINH where MaQuyDinh='" + maqd + "'";

            SqlConnection connection = new SqlConnection(connectionStr);
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataAdapter adpater = new SqlDataAdapter(command);

            connection.Open();

            adpater.Fill(dt);

            connection.Close();

            return dt;
        }

        public void update(QuyDinhDTO qd)
        {
            string query = "update QUYDINH set GiaTri=@giatri where MaQuyDinh=" + qd.MaQuyDinh;

            SqlConnection connection = new SqlConnection(connectionStr);
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@giatri", SqlDbType.NChar).Value = qd.GiaTri;

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }
    }
}
