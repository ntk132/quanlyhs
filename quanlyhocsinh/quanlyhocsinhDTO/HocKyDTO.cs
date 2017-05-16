using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyhocsinhDTO
{
    public class HocKyDTO
    {
        public HocKyDTO() { }

        public HocKyDTO(int mahk, string tenhk, string namhoc)
        {
            this.iMaHocKy = mahk;
            this.sTenHocKy = tenhk;
            this.sNamHoc = namhoc;
        }

        private int iMaHocKy;

        public int MaHocKy
        {
            get { return iMaHocKy; }
            set { iMaHocKy = value; }
        }

        private string sTenHocKy;

        public string TenHocKy
        {
            get { return sTenHocKy; }
            set { sTenHocKy = value; }
        }

        private string sNamHoc;

        public string NamHoc
        {
            get { return sNamHoc; }
            set { sNamHoc = value; }
        }
    }
}
