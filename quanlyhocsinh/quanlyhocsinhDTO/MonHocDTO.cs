using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyhocsinhDTO
{
    public class MonHocDTO
    {
        public MonHocDTO() { }

        public MonHocDTO(int mamh, string tenmh)
        {
            this.iMaMonHoc = mamh;
            this.sTenMonHoc = tenmh;
        }

        private int iMaMonHoc;

        public int MaMonHoc
        {
            get { return iMaMonHoc; }
            set { iMaMonHoc = value; }
        }

        private string sTenMonHoc;

        public string TenMonHoc
        {
            get { return sTenMonHoc; }
            set { sTenMonHoc = value; }
        }
    }
}
