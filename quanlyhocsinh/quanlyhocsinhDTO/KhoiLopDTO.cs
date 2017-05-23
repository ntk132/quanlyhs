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
        public KhoiLopDTO(int makkoilop, string tenkhoilop, int soloptoida)
        {

        }

        private int iMaKhoiLop;

        public int MaKhoilop
        {
            get { return iMaKhoiLop; }
            set { iMaKhoiLop = value; }
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
