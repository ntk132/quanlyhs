using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using quanlyhocsinhDTO;

namespace quanlyhocsinhDAL
{
    public class NamHocMacDinhDAL
    {
        DataAccess da = new DataAccess();

        public NamHocMacDinhDAL() {}

        public DataTable layNamHocMacDinh()
        {
            DataTable dt = new DataTable();

            string query = "select * from THONGSOMACDINH";

            SqlCommand command = new SqlCommand(query, da.connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            da.connection.Open();

            adapter.Fill(dt);

            da.connection.Close();

            return dt;
        }

        public void insert(NamHocMacDinhDTO namhocmacdinhDTO)
        {
            string query = "insert into NAMHOCMACDINH (MaThongSo, GiaTriThongSo) values (@mats, @giatrits)";

            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@mats", SqlDbType.VarChar).Value = namhocmacdinhDTO.MaThongSo;
            command.Parameters.AddWithValue("@gietrits", SqlDbType.VarChar).Value = namhocmacdinhDTO.GiaTriThongSo;

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }

        public void update(NamHocMacDinhDTO namhocmacdinhDTO)
        {
            string query = "update THONGSOMACDINH set GiaTriThongSo=@giatrits where MaThongSo=@mats";

            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@mats", SqlDbType.VarChar).Value = namhocmacdinhDTO.MaThongSo;
            command.Parameters.AddWithValue("@giatrits", SqlDbType.VarChar).Value = namhocmacdinhDTO.GiaTriThongSo;

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }
    }
}
