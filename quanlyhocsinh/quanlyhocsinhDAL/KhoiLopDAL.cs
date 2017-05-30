using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using quanlyhocsinhDTO;

namespace quanlyhocsinhDAL
{
    public class KhoiLopDAL
    {
        DataAccess da = new DataAccess();

        public KhoiLopDAL()
        {
        }

        public DataTable layDanhSachKhoiLop()
        {
            DataTable dt = new DataTable();

            string query = "select * from KHOILOP";

            dt = da.ExecuteQuery(query);

            return dt;
        }

        public int laySoLopToiDaTrongMotKhoi(string maKhoiLop)
        {
            DataTable dt = new DataTable();
            string query = "select SoLopToiDa from KHOILOP where MaKhoiLop=@makhoi";

            SqlCommand command = new SqlCommand();

            command.CommandType = CommandType.Text;
            command.Connection = da.connection;
            command.CommandText = query;

            command.Parameters.AddWithValue("@makhoi", SqlDbType.VarChar).Value = maKhoiLop;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            da.connection.Open();

            adapter.Fill(dt);

            da.connection.Close();

            return Convert.ToInt16(dt.Rows[0]["SoLopToiDa"].ToString());
        }

        public DataTable layKhoiLopTheoMaKhoiLop(int maKhoiLop)
        {
            DataTable dt = new DataTable();
            string query = "select * from KHOILOP where MaKhoiLop=@makhoi";

            SqlCommand command = new SqlCommand();

            command.CommandType = CommandType.Text;
            command.Connection = da.connection;
            command.CommandText = query;

            command.Parameters.AddWithValue("@makhoi", SqlDbType.Int).Value = maKhoiLop;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            da.connection.Open();

            adapter.Fill(dt);

            da.connection.Close();

            return dt;
        }

        public void update(KhoiLopDTO khoilopDTO)
        {
            string query = "update KHOILOP set TenKhoiLop=@tenkhoi, SoLopToiDa=@soloptoida where MaKhoiLop=@makhoi";

            SqlCommand command = new SqlCommand();

            command.CommandType = CommandType.Text;
            command.Connection = da.connection;
            command.CommandText = query;

            command.Parameters.AddWithValue("@makhoi", SqlDbType.VarChar).Value = khoilopDTO.MaKhoilop;
            command.Parameters.AddWithValue("@tenkhoi", SqlDbType.NVarChar).Value = khoilopDTO.TenKhoiLop;
            command.Parameters.AddWithValue("@soloptoida", SqlDbType.Int).Value = khoilopDTO.SoLopToiDa;

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }
    }
}
