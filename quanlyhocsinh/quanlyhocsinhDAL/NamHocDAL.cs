using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using quanlyhocsinhDTO;

namespace quanlyhocsinhDAL
{
    public class NamHocDAL
    {
        DataAccess da = new DataAccess();

        public NamHocDAL() { }

        public DataTable layDanhSachNamHoc()
        {
            DataTable dt = new DataTable();

            string query = "select * from NAMHOC";

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

        public void insert(NamHocDTO namhoc)
        {
            string query = "insert into NAMHOC values (@manh, @tennh)";

            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@manh", SqlDbType.VarChar).Value = namhoc.MaNamHoc;
            command.Parameters.AddWithValue("@tennh", SqlDbType.NVarChar).Value = namhoc.TenNamHoc;

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }

        public void update(NamHocDTO namhoc)
        {
            string query = "update NAMHOC set TenNamHoc=@tennh where MaNamHoc=@manh";

            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@manh", SqlDbType.VarChar).Value = namhoc.MaNamHoc;
            command.Parameters.AddWithValue("@tennh", SqlDbType.NVarChar).Value = namhoc.TenNamHoc;

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }

        public void delete(string maNamHoc)
        {
            string query = "delete from NAMHOC where MaNamHoc=@manh";

            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@manh", SqlDbType.VarChar).Value = maNamHoc;

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }
    }
}
