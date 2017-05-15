using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Collections.Generic;
using quanlyhocsinhDTO;

namespace quanlyhocsinhDAL
{
    public class KetQuaHocTapDAL
    {
        private DataAccess da = new DataAccess();

        public KetQuaHocTapDAL()
        {
            
        }

        public DataTable layDanhSachHocSinh(string malop, int mamon, string mahk)
        {
            DataTable dt = new DataTable();

            string query = "select HOCSINH.MaHocSinh, HoTen from KETQUAHOCTAP join HOCSINH on (KETQUAHOCTAP.MaHocSinh=HOCSINH..MaHocSinh) where MaLopHoc=@malop, MaMonHoc=@mamon, MaHocKy=@mahk";

            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@malop", SqlDbType.VarChar).Value = malop;
            command.Parameters.AddWithValue("@mamon", SqlDbType.Int).Value = mamon;
            command.Parameters.AddWithValue("@mahk", SqlDbType.VarChar).Value = mahk;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            da.connection.Open();

            adapter.Fill(dt);

            da.connection.Close();

            return dt;
        }

        public DataTable xemDiemCuaHocSinh(string malop, int mamon, string mahk)
        {
            DataTable dt = new DataTable();

            string query = "select HOCSINH.MaHocSinh, HoTen, Diem15Phut, Diem1Tiet, DiemTB from HS_LOP inner join HOCSINH on (HS_LOP.MaHocSinh=HOCSINH.MaHocSinh) join KETQUAHOCTAP on (HOCSINH.MaHocSinh=KETQUAHOCTAP.MaHocSinh) where MaLopHoc=@malop and MaMonHoc=@mamon and MaHocKy=@mahk";

            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@malop", SqlDbType.VarChar).Value = malop;
            command.Parameters.AddWithValue("@mamon", SqlDbType.Int).Value = mamon;
            command.Parameters.AddWithValue("@mahk", SqlDbType.VarChar).Value = mahk;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            da.connection.Open();

            adapter.Fill(dt);

            da.connection.Close();

            return dt;
        }

        public DataTable layDanhSachHS_QLDiem(string malop, string mahk)
        {
            DataTable dt = new DataTable();

            string query = "select HOCSINH.MaHocSinh, HoTen from KETQUAHOCTAP join HOCSINH on (KETQUAHOCTAP.MaHocSinh=HOCSINH..MaHocSinh) join HS_LOP on (HOCSINH.MaHocSinh=HS_LOP.MaHocSinh) where MaLopHoc=@malop and MaHocKy=@mahk";

            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@malop", SqlDbType.VarChar).Value = malop;
            command.Parameters.AddWithValue("@mahk", SqlDbType.VarChar).Value = mahk;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            da.connection.Open();

            adapter.Fill(dt);

            da.connection.Close();

            return dt;
        }

        public void insert(KetQuaHocTapDTO kq)
        {
            string query = "insert into KETQUAHOCTAP () values ()";

            //SqlConnection connection = new SqlConnection(connectionStr);
            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }

        public void update(KetQuaHocTapDTO kq)
        {
            string query = "update KETQUAHOCTAP set ";

            //SqlConnection connection = new SqlConnection(connectionStr);
            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }

        public void delete(KetQuaHocTapDTO kq)
        {
            string query = "delete from KETQUAHOCTAP where ";

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
