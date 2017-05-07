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
        private string connectionStr = @"Data Source=kpc\HOMESQLSERVER;Initial Catalog=QuanLyHocSinh;Integrated Security=True";
        DataAccess da = new DataAccess();

        public LopHocDAL()
        {
            da.ExecuteQuery("USE QuanLyHocSinh");
            da.ExecuteQuery("SET DATEFORMAT DMY");
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

        public int layMaLopTheoTenLop(string tenlop)
        {
            DataTable dt = da.ExecuteQuery("select MaLopHoc from LOPHOC where TenLop='" + tenlop + "'");
            DataRow data = dt.Rows[0];
            return (int)data["MaLopHoc"];
        }

        public void insert(LopHocDTO lop)
        {
            string query = "insert into LOPHOC (MaLopHoc, TenLop, KhoiLop, SiSo) values (@malop, @tenlop, @khoilop, @siso)";

            SqlConnection connection = new SqlConnection(connectionStr);
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@malop", SqlDbType.Int).Value = lop.MaLop;
            command.Parameters.AddWithValue("@tenlop", SqlDbType.NVarChar).Value = lop.TenLop;
            command.Parameters.AddWithValue("@khoilop", SqlDbType.Int).Value = lop.KhoiLop;
            command.Parameters.AddWithValue("@siso", SqlDbType.Int).Value = lop.SiSo;

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }

        public void update(LopHocDTO lop)
        {
            string query = "update LOPHOC set TenLop=@tenlop, KhoiLop=@khoilop, SiSo=@siso where MaHocSinh=" + lop.MaLop;

            SqlConnection connection = new SqlConnection(connectionStr);
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@malop", SqlDbType.Int).Value = lop.MaLop;
            command.Parameters.AddWithValue("@tenlop", SqlDbType.VarChar).Value = lop.TenLop;
            command.Parameters.AddWithValue("@khoilop", SqlDbType.Int).Value = lop.KhoiLop;
            command.Parameters.AddWithValue("@siso", SqlDbType.Int).Value = lop.SiSo;

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }

        public void delete(LopHocDTO lop)
        {
            string query = "delete from LOPHOC where MaHocSinh=" + lop.MaLop;

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
