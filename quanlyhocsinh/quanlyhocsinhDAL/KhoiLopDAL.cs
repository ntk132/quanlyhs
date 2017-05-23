using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using quanlyhocsinhDTO;

namespace quanlyhocsinhDAL
{
    public class KhoiLopDAL
    {
        DataAccess da = new DataAccess();

        public KhoiLopDAL()
        {
        }

        public DataTable layDanhSachKhoiLop()
        {
            DataTable dt = new DataTable();

            string query = "select * from KHOILOP";

            dt = da.ExecuteQuery(query);

            return dt;
        }
    }
}
