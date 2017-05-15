using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyhocsinhDTO
{
    public class NamHocDTO
    {
        public NamHocDTO() { }

        public NamHocDTO(string manh, string tennh)
        {

        }

        private string sMaNamHoc;

        public string MaNamHoc
        {
            get { return sMaNamHoc; }
            set { sMaNamHoc = value; }
        }

        private string sTenNamHoc;

        public string TenNamHoc
        {
            get { return sTenNamHoc; }
            set { sTenNamHoc = value; }
        }
    }
}
