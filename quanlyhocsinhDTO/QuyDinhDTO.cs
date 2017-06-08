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
        public QuyDinhDTO(int maQuyDinh, string giatri)
        {
            this.sMaQuyDinh = maQuyDinh;
            this.sGiaTri = giatri;
        }

        private int sMaQuyDinh;

        public int MaQuyDinh
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
