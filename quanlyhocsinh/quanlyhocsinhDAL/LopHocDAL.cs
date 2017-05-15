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

        public List<object> layDanhSachTenLop()
        {
            List<object> list = new List<object>();

            DataTable dt = layDanhSachLop();

            foreach (DataRow item in dt.Rows)
            {
                list.Add(item);
            }

            return list;
        }

        public void insert(LopHocDTO lop)
        {
            string query = "insert into LOPHOC (MaLopHoc, MaNamHoc,TenLop, KhoiLop, SiSo) values (@malop, @manh, @tenlop, @khoilop, @siso)";

            //SqlConnection connection = new SqlConnection(connectionStr);
            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@malop", SqlDbType.VarChar).Value = lop.MaLop;
            command.Parameters.AddWithValue("@manh", SqlDbType.VarChar).Value = lop.MaNamHoc;
            command.Parameters.AddWithValue("@tenlop", SqlDbType.NVarChar).Value = lop.TenLop;
            command.Parameters.AddWithValue("@khoilop", SqlDbType.VarChar).Value = lop.KhoiLop;
            command.Parameters.AddWithValue("@siso", SqlDbType.Int).Value = lop.SiSo;

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }

        public void update(LopHocDTO lop)
        {
            string query = "update LOPHOC set TenLop=@tenlop, KhoiLop=@khoilop, SiSo=@siso where MaHocSinh=" + lop.MaLop;

            //SqlConnection connection = new SqlConnection(connectionStr);
            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@malop", SqlDbType.Int).Value = lop.MaLop;
            command.Parameters.AddWithValue("@tenlop", SqlDbType.VarChar).Value = lop.TenLop;
            command.Parameters.AddWithValue("@khoilop", SqlDbType.Int).Value = lop.KhoiLop;
            command.Parameters.AddWithValue("@siso", SqlDbType.Int).Value = lop.SiSo;

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }

        public void delete(LopHocDTO lop)
        {
            string query = "delete from LOPHOC where MaHocSinh=" + lop.MaLop;

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
