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
