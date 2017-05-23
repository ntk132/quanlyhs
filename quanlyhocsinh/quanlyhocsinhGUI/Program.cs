using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using quanlyhocsinhDTO;
using quanlyhocsinhDAL;

namespace quanlyhocsinhGUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDangNhap());
        }
    }

    public class NAMHOC
    {
        

        private static string sNamHocMacDinh;
        public static string NamHocMacDinh
        {
            get
            {
                NamHocMacDinhDAL namhocmacdinhDAL = new NamHocMacDinhDAL();

                DataRow dt = namhocmacdinhDAL.layNamHocMacDinh().Rows[0];

                sNamHocMacDinh = dt["GiaTriThongSo"].ToString();

                return sNamHocMacDinh;
            }
            set 
            {
                sNamHocMacDinh = value;

                NamHocMacDinhDTO namhocmacdinhDTO = new NamHocMacDinhDTO();

                namhocmacdinhDTO.MaThongSo  ="NamHocMacDinh";
                namhocmacdinhDTO.GiaTriThongSo = sNamHocMacDinh;

                NamHocMacDinhDAL namhocmacdinhDAL = new NamHocMacDinhDAL();

                namhocmacdinhDAL.update(namhocmacdinhDTO);
            }
        }
    }
}
