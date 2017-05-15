using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using quanlyhocsinhDTO;

namespace quanlyhocsinhDAL
{
    public class Lop_HocSinhDAL
    {
        //private string connectionStr = @"Data Source=kpc\homesqlserver;Initial Catalog=QUANLYHS;Integrated Security=True";
        private DataAccess da = new DataAccess();

        public Lop_HocSinhDAL() 
        {
        }
        
        public DataTable layDanhSachHocSinhTheoLop(int id)
        {
            DataTable dt = new DataTable();
            string query = "select MaHocSinh from HS_LOP where MaLopHoc=@malop";
            //SqlConnection connection = new SqlConnection(connectionStr);
            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@malop", SqlDbType.Int).Value = id;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            da.connection.Open();

            adapter.Fill(dt);

            da.connection.Close();

            return dt;
        }

        public DataTable getByMaNamHoc(int manh)
        {
            DataTable dt = new DataTable();

            string query = "select * from HS_LOP where MaNamHoc=" + manh;

            dt = da.ExecuteQuery(query);

            return dt;
        }

        public void insert(Lop_HocSinhDTO lhs)
        {
            string query = "insert into HS_LOP (MaNamHoc, MaLopHoc, MaHocSinh) values (@manh, @malop, @mahs)";

            //SqlConnection connection = new SqlConnection(connectionStr);
            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@manh", SqlDbType.Int).Value = lhs.MaNamHoc;
            command.Parameters.AddWithValue("@malop", SqlDbType.Int).Value = lhs.MaLopHoc;
            command.Parameters.AddWithValue("@mahs", SqlDbType.Int).Value = lhs.MaHocSinh;

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }

        public void delete(Lop_HocSinhDTO lhs)
        {
            string query = "delete HS_LOP where MaNamHoc=@manh, MaLopHoc=@malop, MaHocSinh=@mahs";

            //SqlConnection connection = new SqlConnection(connectionStr);
            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@manh", SqlDbType.Int).Value = lhs.MaNamHoc;
            command.Parameters.AddWithValue("@malop", SqlDbType.Int).Value = lhs.MaLopHoc;
            command.Parameters.AddWithValue("@mahs", SqlDbType.Int).Value = lhs.MaHocSinh;

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }
    }
}
