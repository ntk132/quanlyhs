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
    public class LopHocBUS
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="">
        /// Input:
        /// Output:
        /// </param>
        public bool isLessThanMax(string maNamHoc, string maKhoiLop)
        {
            LopHocDAL lophocDAL = new LopHocDAL();
            KhoiLopDAL khoilopDAL = new KhoiLopDAL();

            if (lophocDAL.laySoLuongLopHienCoTrongMotKhoi(maNamHoc, maKhoiLop) == khoilopDAL.laySoLopToiDaTrongMotKhoi(maKhoiLop))
                return false;

            return true;
        }

        /// <summary>
        /// Kiểm tra xem lớp học đã tồn tại trong Db hay chưa
        /// (kiểm tra MaLopHoc đã có trong DB hay không)
        /// </summary>
        /// <param name="">
        /// Input: MaNamHoc, MaLopHoc
        /// Output: true nếu đã tồn tại, false nếu chưa
        /// </param>
        public bool isExists(string maNamHoc, string maLopHoc)
        {
            LopHocDAL lophocDAL = new LopHocDAL();

            DataTable dt = lophocDAL.layDanhSachLopTheoNamHoc(maNamHoc);

            foreach (DataRow dr in dt.Rows)
            {
                // Lấy ra từng mã lớp trong năm học
                string temp = dr["MaLopHoc"].ToString();

                // Nếu trùng nghĩa là mã lớp này đã tồn tại
                if (maLopHoc == temp)
                {
                    return true;
                }     
            }

            // Ngược lại, là chưa tồn tại trong database
            return false;
        }
    }
}
