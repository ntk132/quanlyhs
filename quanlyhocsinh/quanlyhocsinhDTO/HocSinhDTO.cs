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
        public HocSinhDTO(int mahs, string hoten, string ngaysinh, string gioitinh, string diachi, string email)
        {
            this.IMaHocSinh = mahs;
            this.sHoTen = hoten;
            this.dtNgaySinh = ngaysinh;
            this.sGioiTinh = gioitinh;
            this.sDiaChi = diachi;
            this.sEmail = email;
        }

        private int IMaHocSinh;
        public int MaHocSinh
        {
            get { return IMaHocSinh; }
            set { IMaHocSinh = value; }
        }

        private string sHoTen;
        public string Hoten
        {
            get { return sHoTen; }
            set { sHoTen = value; }
        }

        private string dtNgaySinh;
        public string NgaySinh
        {
            get { return dtNgaySinh; }
            set { dtNgaySinh = value; }
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
