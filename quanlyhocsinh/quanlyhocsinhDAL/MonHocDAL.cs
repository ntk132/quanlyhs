using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Collections.Generic;
using quanlyhocsinhDTO;

namespace quanlyhocsinhDAL
{
    public class MonHocDAL
    {
        private DataAccess da = new DataAccess();
        //private string connectionStr = @"Data Source=kpc\homesqlserver;Initial Catalog=QUANLYHS;Integrated Security=True";

        public MonHocDAL()
        {
        }

        public DataTable layDanhSachMonHoc()
        {
            DataTable dt = new DataTable();

            string query = "select * from MONHOC";
            SqlCommand command = new SqlCommand(query, da.connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            da.connection.Open();

            adapter.Fill(dt);

            da.connection.Close();

            return dt;
        }

        public void insert(MonHocDTO monhoc)
        {
            string query = "insert into MONHOC values (@mamh, @tenmh)";

            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@mamh", SqlDbType.Int).Value = monhoc.MaMonHoc;
            command.Parameters.AddWithValue("@tenmh", SqlDbType.NVarChar).Value = monhoc.TenMonHoc;

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }

        public void update(MonHocDTO monhoc)
        {
            string query = "update MONHOC set TenMonHoc=@tenmh where MaMonHoc=@mamh";

            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@mamh", SqlDbType.Int).Value = monhoc.MaMonHoc;
            command.Parameters.AddWithValue("@tenmh", SqlDbType.NVarChar).Value = monhoc.TenMonHoc;

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }

        public void delete(int mamh)
        {
            string query = "delete from MONHOC where MaMonHoc=@mamh";

            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@mamh", SqlDbType.Int).Value = mamh;
            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }
    }
}
