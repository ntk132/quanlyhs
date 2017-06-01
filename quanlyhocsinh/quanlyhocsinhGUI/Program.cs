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
using System.Globalization;

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
            // Định dạng ngày giờ để sử dụng cho project này
            FormatDatetime();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDangNhap());
        }

        static void FormatDatetime()
        {
            try
            {
                CultureInfo culture = new System.Globalization.CultureInfo("vi-VN", true);
                DateTimeFormatInfo dfi = (DateTimeFormatInfo)culture.DateTimeFormat.Clone();

                dfi.ShortDatePattern = "dd/MM/yyyy";
                dfi.LongDatePattern = "dd/MM/yyyy";
                dfi.FullDateTimePattern = "dd/MM/yyyy";

                culture.DateTimeFormat = dfi;
                System.Windows.Forms.Application.CurrentCulture = culture;
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Không thể định dạng ngày tháng", "FormatDatetime", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }

    public class MACDINH
    {
        private static string sNamHocMacDinh;

        private MACDINH()
        {
            ThongSoMacDinhDAL thongsomacdinhDAL = new ThongSoMacDinhDAL();

            sNamHocMacDinh = thongsomacdinhDAL.layThongSoMacDinh("NamHocMacDinh").Rows[0]["GiaTriThongSo"].ToString();
            sTuoiToiThieu = thongsomacdinhDAL.layThongSoMacDinh("TuoiToiThieu").Rows[0]["GiaTriThongSo"].ToString();
            sTuoiToiDa = thongsomacdinhDAL.layThongSoMacDinh("TuoiToiDa").Rows[0]["GiaTriThongSo"].ToString();
            sSiSoLopToiDa = thongsomacdinhDAL.layThongSoMacDinh("SiSoLopToiDa").Rows[0]["GiaTriThongSo"].ToString();
            sDiemToiThieuDatMon = thongsomacdinhDAL.layThongSoMacDinh("DiemToiThieuDat").Rows[0]["GiaTriThongSo"].ToString();
            sSoLuongLopKhoi10 = thongsomacdinhDAL.layThongSoMacDinh("SoLuongLopKhoi10").Rows[0]["GiaTriThongSo"].ToString();
            sSoLuongLopKhoi11 = thongsomacdinhDAL.layThongSoMacDinh("SoLuongLopKhoi11").Rows[0]["GiaTriThongSo"].ToString();
            sSoLuongLopKhoi12 = thongsomacdinhDAL.layThongSoMacDinh("SoLuongLopKhoi12").Rows[0]["GiaTriThongSo"].ToString();
        }

        public static string NamHocMacDinh
        {
            get
            {
                ThongSoMacDinhDAL thongsomacdinhDAL = new ThongSoMacDinhDAL();

                sNamHocMacDinh = thongsomacdinhDAL.layThongSoMacDinh("NamHocMacDinh").Rows[0]["GiaTriThongSo"].ToString();

                return sNamHocMacDinh;
            }
            set 
            {
                sNamHocMacDinh = value;

                ThongSoMacDinhDTO thongsomacdinhDTO = new ThongSoMacDinhDTO();

                thongsomacdinhDTO.MaThongSo  ="NamHocMacDinh";
                thongsomacdinhDTO.GiaTriThongSo = sNamHocMacDinh;

                ThongSoMacDinhDAL thongsomacdinhDAL = new ThongSoMacDinhDAL();

                thongsomacdinhDAL.update(thongsomacdinhDTO);
            }
        }

        private static string sTuoiToiThieu;
        public static string TuoiToiThieu
        {
            get { return sTuoiToiThieu; }
        }

        private static string sTuoiToiDa;
        public static string TuoiToiDa
        {
            get { return sTuoiToiDa; }
        }

        private static string sSiSoLopToiDa;
        public static string SiSoLopToiDa
        {
            get { return sSiSoLopToiDa; }
        }

        private static string sDiemToiThieuDatMon;
        public static string DiemToiThieuDatMon
        {
            get { return sDiemToiThieuDatMon; }
        }

        private static string sSoLuongLopKhoi10;
        public static string SoLuongLopKhoi10
        {
            get { return sSoLuongLopKhoi10; }
        }

        private static string sSoLuongLopKhoi11;
        public static string SoLuongLopKhoi11
        {
            get { return sSoLuongLopKhoi11; }
        }

        private static string sSoLuongLopKhoi12;
        public static string SoLuongLopKhoi12
        {
            get { return sSoLuongLopKhoi12; }
        }
    }
}
