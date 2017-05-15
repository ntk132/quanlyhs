using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using quanlyhocsinhDTO;

namespace quanlyhocsinhDAL
{
    public class HocSinhDAL
    {
        private DataAccess da = new DataAccess();

        public HocSinhDAL()
        {
        }

        public HocSinhDTO searchStudentById(int id)
        {
            HocSinhDTO hocsinh = new HocSinhDTO();
            DataTable dt = new DataTable();

            string query = "select * from HOCSINH where MaHocSinh=@mahs";

            //SqlConnection connection = new SqlConnection(connectionStr);
            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@mahs", SqlDbType.Int).Value = id;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            da.connection.Open();

            adapter.Fill(dt);

            da.connection.Close();

            return hocsinh;
        }

        public DataTable xuatToanBoHocSinh()
        {
            DataTable dt = new DataTable();

            string query = "select * from HOCSINH";

            //SqlConnection connection = new SqlConnection(connectionStr);
            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            da.connection.Open();

            adapter.Fill(dt);

            da.connection.Close();

            return dt;
        }

        public DataTable timHocSinh(string hoten, string gioitinh, string malop)
        {
            DataTable dt = new DataTable();

            string query = "select HOCSINH.MaHocSinh, HoTen from HOCSINH join HS_LOP on (HOCSINH.MaHocSinh=HS_LOP.MaHocSinh) where HOCSINH.HoTen like N'%" + hoten + "%' and GioiTinh like N'%" + gioitinh + "%' and MaLopHoc like '" + malop + "'";

            //SqlConnection connection = new SqlConnection(connectionStr);
            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            da.connection.Open();

            adapter.Fill(dt);

            da.connection.Close();

            return dt;
        }

        public void insert(HocSinhDTO hs)
        {
            string query = "insert into HOCSINH (HoTen, NgaySinh, GioiTinh, DiaChi, Email) values (@hoten, @ngaysinh, @gioitinh, @diachi, @email)";

            //SqlConnection connection = new SqlConnection(connectionStr);
            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@hoten", SqlDbType.NVarChar).Value = hs.Hoten;
            command.Parameters.Add("@ngaysinh", SqlDbType.SmallDateTime).Value = hs.NgaySinh;
            command.Parameters.AddWithValue("@gioitinh", SqlDbType.NChar).Value = hs.GioiTinh;
            command.Parameters.AddWithValue("@diachi", SqlDbType.NVarChar).Value = hs.DiaChi;
            command.Parameters.AddWithValue("@email", SqlDbType.VarChar).Value = hs.Email;

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }

        public void update(HocSinhDTO hs)
        {
            string query = "update HOCSINH set HoTen=@hoten, NgaySinh=@ngaysinh, GioiTinh=@gioitinh, DiaChi=@diachi, Email=@email where MaHocSinh=" + hs.MaHocSinh;

            //SqlConnection connection = new SqlConnection(connectionStr);
            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@hoten", SqlDbType.NVarChar).Value = hs.Hoten;
            command.Parameters.Add("@ngaysinh", SqlDbType.SmallDateTime).Value = hs.NgaySinh;
            command.Parameters.AddWithValue("@gioitinh", SqlDbType.NChar).Value = hs.GioiTinh;
            command.Parameters.AddWithValue("@diachi", SqlDbType.NVarChar).Value = hs.DiaChi;
            command.Parameters.AddWithValue("@email", hs.Email);

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }

        public void delete(int id)
        {
            string query = "delete from HOCSINH where MaHocSinh=" + id;

            //SqlConnection connection = new SqlConnection(connectionStr);
            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }
    }
}
