using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyhocsinhDTO
{
    public class QuyDinhDTO
    {
        public QuyDinhDTO() { }
        public QuyDinhDTO(string maqd, string tenqd, string giatri)
        {
            this.sMaQuyDinh = maqd;
            this.sTenQuyDinh = tenqd;
            this.sGiaTri = giatri;
        }

        private string sMaQuyDinh;

        public string MaQuyDinh
        {
            get { return sMaQuyDinh; }
            set { sMaQuyDinh = value; }
        }

        private string sTenQuyDinh;

        public string TenQuyDinh
        {
            get { return sTenQuyDinh; }
            set { sTenQuyDinh = value; }
        }

        private string sGiaTri;

        public string GiaTri
        {
            get { return sGiaTri; }
            set { sGiaTri = value; }
        }
    }
}
