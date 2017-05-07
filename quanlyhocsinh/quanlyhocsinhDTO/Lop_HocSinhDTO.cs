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
        public Lop_HocSinhDTO(int manamhoc, int malop, int mahs)
        {
            this.sMaNamHoc = manamhoc;
            this.sMaLopHoc = malop;
            this.sMaHocSinh = mahs;
        }

        private int sMaNamHoc;

        public int MaNamHoc
        {
            get { return sMaNamHoc; }
            set { sMaNamHoc = value; }
        }

        private int sMaLopHoc;

        public int MaLopHoc
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
