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
        //private string connectionStr = @"Data Source=kpc\homesqlserver;Initial Catalog=QUANLYHS;Integrated Security=True";
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

        public DataTable layDanhSachLopTheoNamHoc(string namhoc)
        {
            DataTable dt = new DataTable();
            string query = "select * from LOPHOC where MaNamHoc='" + namhoc + "'";

            dt = da.ExecuteQuery(query);

            return dt;
        }

        public void insert(LopHocDTO lop)
        {
            string query = "insert into LOPHOC (MaLopHoc, MaNamHoc,TenLopHoc, MaKhoiLop, SiSo) values (@malop, @manh, @tenlop, @khoilop, @siso)";

            //SqlConnection connection = new SqlConnection(connectionStr);
            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@malop", SqlDbType.VarChar).Value = lop.MaLopHoc;
            command.Parameters.AddWithValue("@manh", SqlDbType.VarChar).Value = lop.MaNamHoc;
            command.Parameters.AddWithValue("@tenlop", SqlDbType.NVarChar).Value = lop.TenLopHoc;
            command.Parameters.AddWithValue("@khoilop", SqlDbType.VarChar).Value = lop.MaKhoiLop;
            command.Parameters.AddWithValue("@siso", SqlDbType.Int).Value = lop.SiSo;

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }

        public void update(LopHocDTO lop)
        {
            string query = "update LOPHOC set TenLopHoc=@tenlop, MaKhoiLop=@khoilop, SiSo=@siso where MaLopHoc=@malop";

            //SqlConnection connection = new SqlConnection(connectionStr);
            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@malop", SqlDbType.Int).Value = lop.MaLopHoc;
            command.Parameters.AddWithValue("@tenlop", SqlDbType.VarChar).Value = lop.TenLopHoc;
            command.Parameters.AddWithValue("@khoilop", SqlDbType.Int).Value = lop.MaKhoiLop;
            command.Parameters.AddWithValue("@siso", SqlDbType.Int).Value = lop.SiSo;

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }

        public void delete(LopHocDTO lop)
        {
            string query = "delete from LOPHOC where MaLopHoc=@malop";

            //SqlConnection connection = new SqlConnection(connectionStr);
            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@malop", SqlDbType.Int).Value = lop.MaLopHoc;

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }
    }
}
