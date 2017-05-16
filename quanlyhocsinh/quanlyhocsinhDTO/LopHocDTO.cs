using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyhocsinhDTO
{
    public class LopHocDTO
    {
        public LopHocDTO() { }
        public LopHocDTO(string tenlop, int khoi, int siso)
        {
            this.ITenLop = tenlop;
            this.IKhoiLop = khoi;
            this.ISiSo = siso;
        }

        private int IMalop;

        public int MaLop
        {
            get { return IMalop; }
            set { IMalop = value; }
        }

        private string ITenLop;

        public string TenLop
        {
            get { return ITenLop; }
            set { ITenLop = value; }
        }

        private int IKhoiLop;

        public int KhoiLop
        {
            get { return IKhoiLop; }
            set { IKhoiLop = value; }
        }

        private int ISiSo;

        public int SiSo
        {
            get { return ISiSo; }
            set { ISiSo = value; }
        }
    }
}
