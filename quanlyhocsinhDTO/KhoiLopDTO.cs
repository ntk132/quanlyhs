using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyhocsinhDTO
{
    public class KhoiLopDTO
    {
        public KhoiLopDTO() { }
        public KhoiLopDTO(string maKhoiLop, string tenKhoiLop, int soLopToiDa)
        {
            this.sMaKhoiLop = maKhoiLop;
            this.sTenKhoiLop = tenKhoiLop;
            this.iSoLopToiDa = soLopToiDa;
        }

        private string sMaKhoiLop;

        public string MaKhoilop
        {
            get { return sMaKhoiLop; }
            set { sMaKhoiLop = value; }
        }

        private string sTenKhoiLop;

        public string TenKhoiLop
        {
            get { return sTenKhoiLop; }
            set { sTenKhoiLop = value; }
        }

        private int iSoLopToiDa;

        public int SoLopToiDa
        {
            get { return iSoLopToiDa; }
            set { iSoLopToiDa = value; }
        }
    }
}
