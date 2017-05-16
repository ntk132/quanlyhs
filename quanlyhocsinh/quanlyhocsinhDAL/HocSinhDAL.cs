using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using quanlyhocsinhDTO;

namespace quanlyhocsinhDAL
{
    public class HocSinhDAL
    {
        private string connectionStr = @"Data Source=kpc\HOMESQLSERVER;Initial Catalog=QuanLyHocSinh;Integrated Security=True";

        public HocSinhDAL()
        {
            DataAccess da = new DataAccess();

            da.ExecuteQuery("USE QuanLyHocSinh");
            da.ExecuteQuery("SET DATEFORMAT DMY");
        }

        public HocSinhDTO searchStudentById(int id)
        {
            HocSinhDTO hocsinh = new HocSinhDTO();
            DataTable dt = new DataTable();

            string query = "select * from HOCSINH where MaHocSinh=@mahs";

            SqlConnection connection = new SqlConnection(connectionStr);
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@mahs", SqlDbType.Int).Value = id;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            connection.Open();

            adapter.Fill(dt);

            connection.Close();

            return hocsinh;
        }

        public void insert(HocSinhDTO hs)
        {
            string query = "insert into HOCSINH (MaHocSinh, HoTen, NgaySinh, GioiTinh, DiaChi, Email) values (@mahs, @hoten, @ngaysinh, @gioitinh, @diachi, @email)";

            SqlConnection connection = new SqlConnection(connectionStr);
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@mahs", SqlDbType.Int).Value = hs.MaHocSinh;
            command.Parameters.AddWithValue("@hoten", SqlDbType.NVarChar).Value = hs.Hoten;
            command.Parameters.Add("@ngaysinh", SqlDbType.SmallDateTime).Value = hs.NgaySinh;
            command.Parameters.AddWithValue("@gioitinh", SqlDbType.NChar).Value = hs.GioiTinh;
            command.Parameters.AddWithValue("@diachi", SqlDbType.NVarChar).Value = hs.DiaChi;
            command.Parameters.AddWithValue("@email", SqlDbType.VarChar).Value = hs.Email;

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }

        public void update(HocSinhDTO hs)
        {
            string query = "update HOCSINH set HoTen=@hoten, NgaySinh=@ngaysinh, GioiTinh=@gioitinh, DiaChi=@diachi, Email=@email where MaHocSinh=" + hs.MaHocSinh;

            SqlConnection connection = new SqlConnection(connectionStr);
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@hoten", SqlDbType.NVarChar).Value = hs.Hoten;
            command.Parameters.Add("@ngaysinh", SqlDbType.SmallDateTime).Value = hs.NgaySinh;
            command.Parameters.AddWithValue("@gioitinh", SqlDbType.NChar).Value = hs.GioiTinh;
            command.Parameters.AddWithValue("@diachi", SqlDbType.NVarChar).Value = hs.DiaChi;
            command.Parameters.AddWithValue("@email", hs.Email);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }

        public void delete(int id)
        {
            string query = "delete from HOCSINH where MaHocSinh=" + id;

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
