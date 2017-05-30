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
    public class MonHocBUS
    {
        MonHocDAL monhocDAL = new MonHocDAL();

        public bool isExists(MonHocDTO monhocDTO)
        {
            foreach (DataRow dr in monhocDAL.layDanhSachMonHoc().Rows)
            {
                int maMonHoc = Convert.ToInt16(dr["MaMonHoc"].ToString());
                string tenMonHoc = dr["TenMonHoc"].ToString();

                if (monhocDTO.MaMonHoc == maMonHoc)
                    return true;
                else
                {
                    if (monhocDTO.TenMonHoc == tenMonHoc)
                        return true;
                }
            }

            return false;
        }
    }
}
