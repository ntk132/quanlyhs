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

        public bool isMatching(MonHocDTO monhocDTO)
        {
            foreach (DataRow dr in monhocDAL.layDanhSachMonHoc().Rows)
            {
                int maMonHoc = Convert.ToInt16(dr["MaMonHoc"].ToString());
                if (monhocDTO.MaMonHoc == maMonHoc)
                    return true;
            }

            return false;
        }
    }
}
