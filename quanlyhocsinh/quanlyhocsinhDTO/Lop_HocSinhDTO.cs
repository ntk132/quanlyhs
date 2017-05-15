using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyhocsinhDTO
{
    public class Lop_HocSinhDTO
    {
        public Lop_HocSinhDTO() { }
        public Lop_HocSinhDTO(string manamhoc, string malop, int mahs)
        {
            this.sMaNamHoc = manamhoc;
            this.sMaLopHoc = malop;
            this.sMaHocSinh = mahs;
        }

        private string sMaNamHoc;

        public string MaNamHoc
        {
            get { return sMaNamHoc; }
            set { sMaNamHoc = value; }
        }

        private string sMaLopHoc;

        public string MaLopHoc
        {
            get { return sMaLopHoc; }
            set { sMaLopHoc = value; }
        }

        private int sMaHocSinh;

        public int MaHocSinh
        {
            get { return sMaHocSinh; }
            set { sMaHocSinh = value; }
        }
    }
}
