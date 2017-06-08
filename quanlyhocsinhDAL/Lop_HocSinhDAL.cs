using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using quanlyhocsinhDTO;

namespace quanlyhocsinhDAL
{
    public class Lop_HocSinhDAL
    {
        private DataAccess da = new DataAccess();

        public Lop_HocSinhDAL() 
        {
        }
        
        public DataTable layDanhSachHocSinhTheoLop(string maNamHoc, string maLopHoc)
        {
            DataTable dt = new DataTable();
            string query = "select HS_LOP.MaHocSinh, HoTen, MaLopHoc from HS_LOP join HOCSINH on (HS_LOP.MaHocSinh=HOCSINH.MaHocSinh) where MaNamHoc=@manh MaLopHoc=@malop";

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

        public DataTable layDanhSachHocSinhTheoNamHocVaLop(string maNamHoc, string maLopHoc)
        {
            DataTable dt = new DataTable();
            string query = "select HS_LOP.MaHocSinh, HoTen, MaLopHoc from HS_LOP join HOCSINH on (HS_LOP.MaHocSinh=HOCSINH.MaHocSinh) where MaNamHoc=@manh and MaLopHoc=@malop";

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

        public DataTable layDanhSachHocSinhChuaCoLop(string maNamHoc)
        {
            DataTable dt = new DataTable();
            string query = "select MaHocSinh, HoTen from HOCSINH where MaHocSinh not in (select MaHocSinh from HS_LOP)";

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

        public DataTable layMaLopHocTheoMaHocSinhVaNamHoc(int maHocSinh)
        {
            DataTable dt = new DataTable();
            string query = "select MaLopHoc from HS_LOP where MaHocSinh=@mahs";

            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@mahs", SqlDbType.Int).Value = maHocSinh;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            da.connection.Open();

            adapter.Fill(dt);

            da.connection.Close();

            return dt;
        }

        public int laySiSoCuaLop(string maNamHoc, string maLopHoc)
        {
            DataTable dt = new DataTable();

            string query = "select count(*) from HS_LOP where MaNamHoc=@manh and MaLopHoc=@malop";

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

            return Convert.ToInt16(dt.Rows[0][0].ToString());
        }

        public void insert(Lop_HocSinhDTO lhs)
        {
            string query = "insert into HS_LOP (MaNamHoc, MaLopHoc, MaHocSinh) values (@manh, @malop, @mahs)";

            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@manh", SqlDbType.VarChar).Value = lhs.MaNamHoc;
            command.Parameters.AddWithValue("@malop", SqlDbType.VarChar).Value = lhs.MaLopHoc;
            command.Parameters.AddWithValue("@mahs", SqlDbType.Int).Value = lhs.MaHocSinh;

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }

        public void update(Lop_HocSinhDTO lhs)
        {
            string query = "update HS_LOP set MaLopHoc=@malop where MaNamHoc=@manh and MaHocSinh=@mahs";

            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@manh", SqlDbType.VarChar).Value = lhs.MaNamHoc;
            command.Parameters.AddWithValue("@malop", SqlDbType.VarChar).Value = lhs.MaLopHoc;
            command.Parameters.AddWithValue("@mahs", SqlDbType.Int).Value = lhs.MaHocSinh;

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }

        public void delete(Lop_HocSinhDTO lhs)
        {
            string query = "delete HS_LOP where MaNamHoc=@manh and MaLopHoc=@malop and MaHocSinh=@mahs";

            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@manh", SqlDbType.VarChar).Value = lhs.MaNamHoc;
            command.Parameters.AddWithValue("@malop", SqlDbType.VarChar).Value = lhs.MaLopHoc;
            command.Parameters.AddWithValue("@mahs", SqlDbType.Int).Value = lhs.MaHocSinh;

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }

        public void xoaLopHSTrongNamHoc(string maNamHoc)
        {
            string query = "delete HS_LOP where MaNamHoc=@manh";

            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@manh", SqlDbType.VarChar).Value = maNamHoc;

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }

        public void xoaLopHSCuaMotLopTrongNamHoc(string maNamHoc, string maLopHoc)
        {
            string query = "delete HS_LOP where MaNamHoc=@manh and MaLopHoc=@malop";

            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@manh", SqlDbType.VarChar).Value = maNamHoc;
            command.Parameters.AddWithValue("@malop", SqlDbType.VarChar).Value = maLopHoc;

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }

        public void xoaLopHSCuaMotHocSinh(int maHocSinh)
        {
            string query = "delete HS_LOP where MaHocSinh=@mahs";

            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@mahs", SqlDbType.VarChar).Value = maHocSinh;

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }
    }
}
