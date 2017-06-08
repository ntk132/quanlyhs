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
        public Lop_HocSinhDTO(string maNamHoc, string maLopHoc, int maHocSinh)
        {
            this.sMaNamHoc = maNamHoc;
            this.sMaLopHoc = maLopHoc;
            this.sMaHocSinh = maHocSinh;
        }

        private int iId;

        public int Id
        {
            get { return iId; }
            set { iId = value; }
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
