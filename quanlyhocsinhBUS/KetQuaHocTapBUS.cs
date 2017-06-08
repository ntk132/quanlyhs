using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using quanlyhocsinhDAL;
using quanlyhocsinhDTO;

namespace quanlyhocsinhBUS
{
    public class KetQuaHocTapBUS
    {
        /// <summary>
        /// Kiểm tra xem kết quả học tập của một học sinh đã tồn tại trong DB hay chưa
        /// </summary>
        /// <param name="ketquahoctapDTO is existsed">
        /// Input: KetQuaHocTapDTO
        /// Output: false nếu chưa tồn tại KetQuaHocTap, true nếu đã tồn tại
        /// </param>
        public bool isExists(KetQuaHocTapDTO ketquahoctapDTO)
        {
            DataTable dt = new DataTable();
            DataAccess da = new DataAccess();

            string query = "select count(*) from KETQUAHOCTAP where MaHocKy=@mahk and MaMonHoc=@mamh and MaHocSinh=@mahs";

            SqlCommand command = new SqlCommand();

            command.CommandType = CommandType.Text;
            command.Connection = da.connection;
            command.CommandText = query;

            command.Parameters.AddWithValue("@mahk", SqlDbType.VarChar).Value = ketquahoctapDTO.MaHocKy;
            command.Parameters.AddWithValue("@mamh", SqlDbType.Int).Value = ketquahoctapDTO.MaMonHoc;
            command.Parameters.AddWithValue("@mahs", SqlDbType.Int).Value = ketquahoctapDTO.MaHocSinh;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            da.connection.Open();

            adapter.Fill(dt);

            da.connection.Close();

            int value = Convert.ToInt16(dt.Rows[0][0].ToString());

            if (value == 0)
                return false;

            return true;
        }
    }
}
