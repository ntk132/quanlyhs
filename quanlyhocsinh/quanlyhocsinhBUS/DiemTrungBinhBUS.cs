using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using quanlyhocsinhDAL;
using quanlyhocsinhDTO;

namespace quanlyhocsinhBUS
{
    public class DiemTrungBinhBUS
    {
        public bool isExists(DiemTrungBinhDTO diemtbDTO)
        {
            DataAccess da = new DataAccess();
            DataTable dt = new DataTable();

            string query = "select count(*) from DIEMTRUNGBINHNAMHOC where MaNamHoc=@manh and MaHocSinh=@mahs";

            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@manh", SqlDbType.VarChar).Value = diemtbDTO.MaNamHoc;
            command.Parameters.AddWithValue("@mahs", SqlDbType.Int).Value = diemtbDTO.MaHocSinh;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            da.connection.Open();

            adapter.Fill(dt);

            da.connection.Close();

            int value = Convert.ToInt16(dt.Rows[0][0].ToString());

            // Nếu value = 1 thì bảng điểm trung bình của học sinh này đã tồn tại
            if (value == 1)
                return true;

            return false;
        }

    }
}
