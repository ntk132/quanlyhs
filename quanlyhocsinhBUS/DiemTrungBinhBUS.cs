using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using quanlyhocsinhDAL;
using quanlyhocsinhDTO;

namespace quanlyhocsinhBUS
{
    public class DiemTrungBinhBUS
    {
        /// <summary>
        /// Kiểm tra xem bảng điểm trung bình của một học sinh đã tồn tại trong DB hay chưa
        /// </summary>
        /// <param name="diemtbDTO is existsed">
        /// Input: DiemTrungBinhDTO
        /// Output: true nếu đã tồn tại trong DB, false nếu chưa có
        /// </param>
        /// <returns></returns>
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

        /// <summary>
        /// Kiểm tra xem học sinh này đã đủ điều kiện về điểm số để lên lớp hay chưa
        /// DiemTrungBinhCaNam >= DiemtoiThieuDat
        /// </summary>
        /// <param name="Is student passed all subjects">
        /// Input: ManamHoc, MaHocSinh
        /// Output: true nếu DiemTrungBinhCaNam >= DiemtoiThieuDat, false nếu ngược lại
        /// </param>
        /// <returns></returns>
        public bool isPassed(string maNamHoc, int maHocSinh)
        {
            DiemTrungBinhDAL diemtbDAL = new DiemTrungBinhDAL();
            QuyDinhDAL quydinhDAL = new QuyDinhDAL();
            DataTable dt = diemtbDAL.xemDiemTrungBinhCuaHocSinh(maNamHoc, maHocSinh);
            decimal diemTrungBinhCaNam = Convert.ToDecimal(dt.Rows[0]["DiemTrungBinhNam"].ToString());
            decimal diemToiThieuDat = Convert.ToDecimal(quydinhDAL.layQuyDinhDiemToiThieuDatMon().Rows[0]["GiaTriQuyDinh"].ToString());

            if (diemTrungBinhCaNam >= diemToiThieuDat)
                return true;

            return false;
        }
    }
}
