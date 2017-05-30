using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using quanlyhocsinhDTO;

namespace quanlyhocsinhDAL
{
    public class ThongSoMacDinhDAL
    {
        DataAccess da = new DataAccess();

        public ThongSoMacDinhDAL() { }

        public DataTable layThongSoMacDinh(string maThongSo)
        {
            DataTable dt = new DataTable();

            string query = "select * from THONGSOMACDINH where MaThongSo=@mats";

            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@mats", SqlDbType.VarChar).Value = maThongSo;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            da.connection.Open();

            adapter.Fill(dt);

            da.connection.Close();

            return dt;
        }

        public void insert(ThongSoMacDinhDTO thongsomacdinhDTO)
        {
            string query = "insert into NAMHOCMACDINH (MaThongSo, GiaTriThongSo) values (@mats, @giatrits)";

            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@mats", SqlDbType.VarChar).Value = thongsomacdinhDTO.MaThongSo;
            command.Parameters.AddWithValue("@gietrits", SqlDbType.VarChar).Value = thongsomacdinhDTO.GiaTriThongSo;

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }

        public void update(ThongSoMacDinhDTO thongsomacdinhDTO)
        {
            string query = "update THONGSOMACDINH set GiaTriThongSo=@giatrits where MaThongSo=@mats";

            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@mats", SqlDbType.VarChar).Value = thongsomacdinhDTO.MaThongSo;
            command.Parameters.AddWithValue("@giatrits", SqlDbType.VarChar).Value = thongsomacdinhDTO.GiaTriThongSo;

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }
    }
}
