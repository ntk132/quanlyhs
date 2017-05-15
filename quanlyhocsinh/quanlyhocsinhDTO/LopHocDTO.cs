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
            this.sMaLop = malop;
            this.sMaNamHoc = manh;
            this.sTenLop = tenlop;
            this.sKhoiLop = makhoi;
            this.iSiSo = siso;
        }

        private string sMaLop;

        public string MaLop
        {
            get { return sMaLop; }
            set { sMaLop = value; }
        }

        private string sMaNamHoc;

        public string MaNamHoc
        {
            get { return sMaNamHoc; }
            set { sMaNamHoc = value; }
        }

        private string sTenLop;

        public string TenLop
        {
            get { return sTenLop; }
            set { sTenLop = value; }
        }

        private string sKhoiLop;

        public string KhoiLop
        {
            get { return sKhoiLop; }
            set { sKhoiLop = value; }
        }

        private int iSiSo;

        public int SiSo
        {
            get { return iSiSo; }
            set { iSiSo = value; }
        }
    }
}
