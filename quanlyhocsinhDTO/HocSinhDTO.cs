using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyhocsinhDTO
{
    public class HocSinhDTO
    {
        public HocSinhDTO() { }
        public HocSinhDTO(int mahs, string hoten, DateTime ngaysinh, string gioitinh, string diachi, string email)
        {
            this.iMaHocSinh = mahs;
            this.sHoTen = hoten;
            this.sNgaySinh = ngaysinh;
            this.sGioiTinh = gioitinh;
            this.sDiaChi = diachi;
            this.sEmail = email;
        }

        private int iMaHocSinh;
        public int MaHocSinh
        {
            get { return iMaHocSinh; }
            set { iMaHocSinh = value; }
        }

        private string sHoTen;
        public string Hoten
        {
            get { return sHoTen; }
            set { sHoTen = value; }
        }

        private DateTime sNgaySinh;
        public DateTime NgaySinh
        {
            get { return sNgaySinh; }
            set { sNgaySinh = value; }
        }

        private string sGioiTinh;
        public string GioiTinh
        {
            get { return sGioiTinh; }
            set { sGioiTinh = value; }
        }

        private string sDiaChi;
        public string DiaChi
        {
            get { return sDiaChi; }
            set { sDiaChi = value; }
        }

        private string sEmail;
        public string Email
        {
            get { return sEmail; }
            set { sEmail = value; }
        }
    }
}
