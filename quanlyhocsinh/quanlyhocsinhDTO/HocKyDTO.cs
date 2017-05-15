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

        public HocKyDTO(string mahk, string tenhk, string namhoc)
        {
            this.sMaHocKy = mahk;
            this.sTenHocKy = tenhk;
            this.sNamHoc = namhoc;
        }

        private string sMaHocKy;

        public string MaHocKy
        {
            get { return sMaHocKy; }
            set { sMaHocKy = value; }
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
