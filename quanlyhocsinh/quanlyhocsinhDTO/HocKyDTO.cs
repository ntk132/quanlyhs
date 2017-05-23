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
            this.sMaNamHoc = namhoc;
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

        private string sMaNamHoc;

        public string MaNamHoc
        {
            get { return sMaNamHoc; }
            set { sMaNamHoc = value; }
        }
    }
}
