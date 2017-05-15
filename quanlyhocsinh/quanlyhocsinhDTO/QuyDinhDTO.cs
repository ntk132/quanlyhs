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
        public QuyDinhDTO(string maqd, string giatri)
        {
            this.sMaQuyDinh = maqd;
            this.sGiaTri = giatri;
        }

        private string sMaQuyDinh;

        public string MaQuyDinh
        {
            get { return sMaQuyDinh; }
            set { sMaQuyDinh = value; }
        }

        private string sGiaTri;

        public string GiaTri
        {
            get { return sGiaTri; }
            set { sGiaTri = value; }
        }
    }
}
