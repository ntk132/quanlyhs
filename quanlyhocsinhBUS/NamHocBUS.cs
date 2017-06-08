using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using quanlyhocsinhDTO;
using quanlyhocsinhDAL;

namespace quanlyhocsinhBUS
{
    public class NamHocBUS
    {
        /// <summary>
        /// Kiểm tra xem năm học đã tồn tại trong Db hay chưa
        /// (kiểm tra MaNamHoc đã có trong DB hay không)
        /// </summary>
        /// <param name="">
        /// Input: NamHocDTO
        /// Output: true nếu đã tồn tại, false nếu chưa
        /// </param>
        public bool isExists(NamHocDTO namhocDTO)
        {
            NamHocDAL namhocDAL = new NamHocDAL();

            DataTable dt = namhocDAL.layDanhSachNamHoc();

            foreach (DataRow dr in dt.Rows)
            {
                string temp = dr["MaNamHoc"].ToString();

                if (namhocDTO.MaNamHoc == temp)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
