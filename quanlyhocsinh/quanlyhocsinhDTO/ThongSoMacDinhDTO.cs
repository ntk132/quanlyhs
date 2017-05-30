using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyhocsinhDTO
{
    public class ThongSoMacDinhDTO
    {
        public ThongSoMacDinhDTO() { }

        public ThongSoMacDinhDTO(string maThongSo, string giatriThongSo)
        {
            this.sMaThongSo = maThongSo;
            this.sGiaTriThongSo = giatriThongSo;
        }

        private string sMaThongSo;

        public string MaThongSo
        {
            get { return sMaThongSo; }
            set { sMaThongSo = value; }
        }

        private string sGiaTriThongSo;

        public string GiaTriThongSo
        { 
            get { return sGiaTriThongSo; }
            set { sGiaTriThongSo = value; }
        }

    }
}
