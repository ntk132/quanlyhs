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
    public class Lop_HocSinhBUS
    {
        public bool isLessThanMax(LopHocDTO lh)
        {
            return true;
        }

        public bool isPassedAllSubject(string maNamHoc, int maHocSinh)
        {
            return true;
        }

        public bool isExists(Lop_HocSinhDTO lop_hsDTO)
        {
            DataAccess da = new DataAccess();
            DataTable dt = new DataTable();

            string query = "select count(*) from HS_LOP where MaNamHoc=@manh and MaHocSinh=@mahs";

            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@manh", SqlDbType.VarChar).Value = lop_hsDTO.MaNamHoc;
            command.Parameters.AddWithValue("@mahs", SqlDbType.Int).Value = lop_hsDTO.MaHocSinh;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            da.connection.Open();

            adapter.Fill(dt);

            da.connection.Close();

            int value = Convert.ToInt16(dt.Rows[0][0].ToString());

            // Nếu value = 1 thì học sinh này đã được xếp lớp ở năm học mới
            if (value == 1)
                return true;

            return false;
        }
    }
}
