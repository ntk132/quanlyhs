using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Collections.Generic;
using quanlyhocsinhDTO;

namespace quanlyhocsinhDAL
{
    class MonHocDAL
    {
        private string connectionStr = @"Data Source=kpc\HOMESQLSERVER;Initial Catalog=QuanLyHocSinh;Integrated Security=True";

        public MonHocDAL()
        {
            DataAccess da = new DataAccess();

            da.ExecuteQuery("USE QuanLyHocSinh");
            da.ExecuteQuery("SET DATEFORMAT DMY");
        }

        public void layDanhSAchMonhoc()
        {
            string query = "select * from MONHOC";
        }

        public void insert()
        {

        }

        public void update()
        {

        }

        public void delete()
        {

        }
    }
}
