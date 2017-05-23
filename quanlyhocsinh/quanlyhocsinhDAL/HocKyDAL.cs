using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using quanlyhocsinhDTO;

namespace quanlyhocsinhDAL
{
    public class HocKyDAL
    {
        private DataAccess da = new DataAccess();
        //private string connectionStr = @"Data Source=kpc\homesqlserver;Initial Catalog=QUANLYHS;Integrated Security=True";

        public HocKyDAL()
        {       
            
        }

        public DataTable layDanhSachHocKy()
        {
            string query = "select * from HOCKY";
            DataTable dt = new DataTable();

            SqlCommand command = new SqlCommand(query, da.connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            da.connection.Open();

            adapter.Fill(dt);

            da.connection.Close();

            return dt;
        }

        public DataTable layDanhSachHocKyTheoNamHoc(string maNamHoc)
        {
            string query = "select * from HOCKY where MaNamHoc=@manh";
            DataTable dt = new DataTable();

            SqlCommand command = new SqlCommand();

            command.CommandType = CommandType.Text;
            command.Connection = da.connection;
            command.CommandText = query;

            command.Parameters.AddWithValue("@manh", SqlDbType.VarChar).Value = maNamHoc;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            da.connection.Open();

            adapter.Fill(dt);

            da.connection.Close();

            return dt;
        }

        public void insert(HocKyDTO hocky)
        {
            string query = "insert into HOCKY (MaHocKy, TenHocKy, MaNamHoc) values (@mahk, @tenhk, @namhoc)";

            //SqlConnection connection = new SqlConnection(connectionStr);
            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@mahk", SqlDbType.VarChar).Value = hocky.MaHocKy;
            command.Parameters.AddWithValue("@tenhk", SqlDbType.NVarChar).Value = hocky.TenHocKy;
            command.Parameters.AddWithValue("@namhoc", SqlDbType.VarChar).Value = hocky.MaNamHoc;

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }

        public void update(HocKyDTO hk)
        {
            string query = "update HOCKY set MaHocKy=@mahk, TenHocKy=@tenhk, NamHoc=@namhoc where MaHocKy=" + hk.MaHocKy;

            //SqlConnection connection = new SqlConnection(connectionStr);
            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@mahk", SqlDbType.VarChar).Value = hk.MaHocKy;
            command.Parameters.AddWithValue("@tenhk", SqlDbType.NVarChar).Value = hk.TenHocKy;
            command.Parameters.AddWithValue("@namhoc", SqlDbType.VarChar).Value = hk.MaNamHoc;

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }

        public void delete(HocKyDTO hk)
        {
            string query = "delete from HOCKY where MaNamHoc=@manh";

            //SqlConnection connection = new SqlConnection(connectionStr);
            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@manh", SqlDbType.VarChar).Value = hk.MaNamHoc;

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }
    }
}
