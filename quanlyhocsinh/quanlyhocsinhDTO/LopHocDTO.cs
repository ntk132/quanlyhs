using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyhocsinhDTO
{
    public class LopHocDTO
    {
        public LopHocDTO() { }
        public LopHocDTO(string malop, string manh,string tenlop, string makhoi, int siso)
        {
            this.sMaLopHoc = malop;
            this.sMaNamHoc = manh;
            this.sTenLopHoc = tenlop;
            this.sMaKhoiLop = makhoi;
            this.iSiSo = siso;
        }

        private string sMaLopHoc;

        public string MaLopHoc
        {
            get { return sMaLopHoc; }
            set { sMaLopHoc = value; }
        }

        private string sMaNamHoc;

        public string MaNamHoc
        {
            get { return sMaNamHoc; }
            set { sMaNamHoc = value; }
        }

        private string sTenLopHoc;

        public string TenLopHoc
        {
            get { return sTenLopHoc; }
            set { sTenLopHoc = value; }
        }

        private string sMaKhoiLop;

        public string MaKhoiLop
        {
            get { return sMaKhoiLop; }
            set { sMaKhoiLop = value; }
        }

        private int iSiSo;

        public int SiSo
        {
            get { return iSiSo; }
            set { iSiSo = value; }
        }
    }
}
