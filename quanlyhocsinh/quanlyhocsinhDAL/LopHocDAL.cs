using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using quanlyhocsinhDTO;

namespace quanlyhocsinhDAL
{
    public class LopHocDAL
    {
        private DataAccess da = new DataAccess();

        public LopHocDAL()
        {
        }

        public DataTable layDanhSachLop()
        {
            DataTable dt = new DataTable();
            string query = "select * from LOPHOC";

            dt = da.ExecuteQuery(query);

            return dt;
        }

        public int laySiSoCuaLopHoc(string maNamHoc, string maLopHoc)
        {
            DataTable dt = new DataTable();
            string query = "select * from LOPHOC where MaNamHoc=@manh and MaLopHoc=@malop";

            SqlCommand command = new SqlCommand();

            command.CommandType = CommandType.Text;
            command.Connection = da.connection;
            command.CommandText = query;

            command.Parameters.AddWithValue("@manh", SqlDbType.VarChar).Value = maNamHoc;
            command.Parameters.AddWithValue("@malop", SqlDbType.VarChar).Value = maLopHoc;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            da.connection.Open();

            adapter.Fill(dt);

            da.connection.Close();

            return Convert.ToInt16(dt.Rows[0]["SiSo"].ToString());
        }

        public DataTable layDanhSachLopTheoNamHoc(string maNamHoc)
        {
            DataTable dt = new DataTable();
            string query = "select * from LOPHOC where MaNamHoc=@manh";

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

        public int laySoLuongLopHienCoTrongMotKhoi(string maNamHoc, string maKhoiLop)
        {
            DataTable dt = new DataTable();
            string query = "select count(*) from LOPHOC where MaNamHoc=@manh and MaKhoiLop=@makhoi";

            SqlCommand command = new SqlCommand();

            command.CommandType = CommandType.Text;
            command.Connection = da.connection;
            command.CommandText = query;

            command.Parameters.AddWithValue("@manh", SqlDbType.VarChar).Value = maNamHoc;
            command.Parameters.AddWithValue("@makhoi", SqlDbType.VarChar).Value = maKhoiLop;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            da.connection.Open();

            adapter.Fill(dt);

            da.connection.Close();

            return Convert.ToInt16(dt.Rows[0][0].ToString());
        }


        public void suaSiSoLop(LopHocDTO lophocDTO)
        {
            string query = "update LOPHOC set SiSo=@siso where MaNamHoc=@manh and MaLopHoc=@malop";

            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@siso", SqlDbType.Int).Value = lophocDTO.SiSo;
            command.Parameters.AddWithValue("@manh", SqlDbType.VarChar).Value = lophocDTO.MaNamHoc;
            command.Parameters.AddWithValue("@malop", SqlDbType.VarChar).Value = lophocDTO.MaLopHoc;

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }

        public void insert(LopHocDTO lop)
        {
            string query = "insert into LOPHOC (MaLopHoc, MaNamHoc,TenLopHoc, MaKhoiLop) values (@malop, @manh, @tenlop, @khoilop)";

            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@malop", SqlDbType.VarChar).Value = lop.MaLopHoc;
            command.Parameters.AddWithValue("@manh", SqlDbType.VarChar).Value = lop.MaNamHoc;
            command.Parameters.AddWithValue("@tenlop", SqlDbType.NVarChar).Value = lop.TenLopHoc;
            command.Parameters.AddWithValue("@khoilop", SqlDbType.VarChar).Value = lop.MaKhoiLop;

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }

        public void update(LopHocDTO lop)
        {
            string query = "update LOPHOC set TenLopHoc=@tenlop, MaKhoiLop=@khoilop, SiSo=@siso where MaLopHoc=@malop";

            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@malop", SqlDbType.VarChar).Value = lop.MaLopHoc;
            command.Parameters.AddWithValue("@tenlop", SqlDbType.NVarChar).Value = lop.TenLopHoc;
            command.Parameters.AddWithValue("@khoilop", SqlDbType.Int).Value = lop.MaKhoiLop;
            command.Parameters.AddWithValue("@siso", SqlDbType.Int).Value = lop.SiSo;

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }

        public void delete(LopHocDTO lophocDTO)
        {
            string query = "delete from LOPHOC where MaNamHoc=@manh and MaLopHoc=@malop";

            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@manh", SqlDbType.Int).Value = lophocDTO.MaNamHoc;
            command.Parameters.AddWithValue("@malop", SqlDbType.Int).Value = lophocDTO.MaLopHoc;

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }

        public void xoaLopHocTrongNamHoc(string maNamHoc)
        {
            string query = "delete from LOPHOC where MaNamHoc=@manh";

            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@manh", SqlDbType.Int).Value = maNamHoc;

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }
    }
}
