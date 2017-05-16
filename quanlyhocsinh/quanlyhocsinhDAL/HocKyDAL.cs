using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using quanlyhocsinhDTO;

namespace quanlyhocsinhDAL
{
    class HocKyDAL
    {
        DataAccess da = new DataAccess();
        private string connectionStr = @"Data Source=kpc\HOMESQLSERVER;Initial Catalog=QuanLyHocSinh;Integrated Security=True";

        public HocKyDAL()
        {         
            da.ExecuteQuery("USE QuanLyHocSinh");
            da.ExecuteQuery("SET DATEFORMAT DMY");
        }

        public DataTable layDanhSachTenHocKy()
        {
            string query = "select TenHocKy from HOCKY";
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(connectionStr);
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            connection.Open();

            adapter.Fill(dt);

            connection.Close();

            return dt;
        }

        public void insert(HocKyDTO hk)
        {
            string query = "insert into HOCKY (MaHocKy, TenHocKy, NamHoc) values (@mahk, @tenhk, @namhoc)";

            SqlConnection connection = new SqlConnection(connectionStr);
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@mahk", SqlDbType.Int).Value = hk.MaHocKy;
            command.Parameters.AddWithValue("@tenhk", SqlDbType.NVarChar).Value = hk.TenHocKy;
            command.Parameters.AddWithValue("@namhoc", SqlDbType.Int).Value = hk.NamHoc;

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }

        public void update(HocKyDTO hk)
        {
            string query = "update HOCKY set MaHocKy=@mahk, TenHocKy=@tenhk, NamHoc=@namhoc where MaHocKy=" + hk.MaHocKy;

            SqlConnection connection = new SqlConnection(connectionStr);
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@mahk", SqlDbType.Int).Value = hk.MaHocKy;
            command.Parameters.AddWithValue("@tenhk", SqlDbType.VarChar).Value = hk.TenHocKy;
            command.Parameters.AddWithValue("@namhoc", SqlDbType.Int).Value = hk.NamHoc;

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }

        public void delete(HocKyDTO hk)
        {
            string query = "delete from LOPHOC where MaHocKy=" + hk.MaHocKy;

            SqlConnection connection = new SqlConnection(connectionStr);
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }
    }
}
