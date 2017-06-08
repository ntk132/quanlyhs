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

        public DataTable layDanhSachHocSinhTheoLop(string maNamHoc, string maLopHoc)
        {
            DataTable dt = new DataTable();

            string query = "select HOCSINH.MaHocSinh, HoTen, NgaySinh, GioiTinh, DiaChi, Email from HOCSINH join HS_LOP on (HOCSINH.MaHocSinh=HS_LOP.MaHocSinh) where MaNamHoc=@manh and MaLopHoc=@malop";

            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@manh", SqlDbType.VarChar).Value = maNamHoc;
            command.Parameters.AddWithValue("@malop", SqlDbType.VarChar).Value = maLopHoc;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            da.connection.Open();

            adapter.Fill(dt);

            da.connection.Close();

            return dt;
        }

        public DataTable timHocSinh(string maNamHoc, string maLopHoc, string hoten, string gioitinh)
        {
            DataTable dt = new DataTable();

            string query = "select HOCSINH.MaHocSinh, HoTen from HOCSINH join HS_LOP on (HOCSINH.MaHocSinh=HS_LOP.MaHocSinh) where MaNamHoc=@manh and HoTen like N'%" + hoten + "%' and GioiTinh like N'%" + gioitinh + "%' and MaLopHoc like '" + maLopHoc + "'";

            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@manh", SqlDbType.VarChar).Value = maNamHoc;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            da.connection.Open();

            adapter.Fill(dt);

            da.connection.Close();

            return dt;
        }

        public void insert(HocSinhDTO hocsinhDTO)
        {
            string query = "insert into HOCSINH (HoTen, NgaySinh, GioiTinh, DiaChi, Email) values (@hoten, @ngaysinh, @gioitinh, @diachi, @email)";

            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@hoten", SqlDbType.NVarChar).Value = hocsinhDTO.Hoten;
            command.Parameters.AddWithValue("@ngaysinh", SqlDbType.SmallDateTime).Value = hocsinhDTO.NgaySinh;
            command.Parameters.AddWithValue("@gioitinh", SqlDbType.NChar).Value = hocsinhDTO.GioiTinh;
            command.Parameters.AddWithValue("@diachi", SqlDbType.NVarChar).Value = hocsinhDTO.DiaChi;
            command.Parameters.AddWithValue("@email", SqlDbType.VarChar).Value = hocsinhDTO.Email;

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }

        public void update(HocSinhDTO hs)
        {
            string query = "update HOCSINH set HoTen=@hoten, NgaySinh=@ngaysinh, GioiTinh=@gioitinh, DiaChi=@diachi, Email=@email where MaHocSinh=" + hs.MaHocSinh;

            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@hoten", SqlDbType.NVarChar).Value = hs.Hoten;
            command.Parameters.AddWithValue("@ngaysinh", SqlDbType.SmallDateTime).Value = hs.NgaySinh;
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
