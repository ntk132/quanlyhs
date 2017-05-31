using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyhocsinhDTO
{
    public class DiemTrungBinhDTO
    {
        public DiemTrungBinhDTO() { }

        public DiemTrungBinhDTO(string maNamHoc, int maHocSinh, decimal diemTBHK1, decimal diemTBHK2, decimal diemTBCaNam)
        {
            this.sMaNamHoc = maNamHoc;
            this.iMaHocSinh = maHocSinh;
            this.DiemTrungBinhHK1 = diemTBHK1;
            this.DiemTrungBinhHK2 = diemTBHK2;
            this.DiemTrungBinhHKNam = diemTBCaNam;
        }

        private string sMaNamHoc;

        public string MaNamHoc
        {
            get { return sMaNamHoc; }
            set { sMaNamHoc = value; }
        }

        private int iMaHocSinh;

        public int MaHocSinh
        {
            get { return iMaHocSinh; }
            set { iMaHocSinh = value; }
        }

        private decimal fDiemTrungBinhHK1;

        public decimal DiemTrungBinhHK1
        {
            get { return fDiemTrungBinhHK1; }
            set { fDiemTrungBinhHK1 = value; }

        }

        private decimal fDiemTrungBinhHK2;

        public decimal DiemTrungBinhHK2
        {
            get { return fDiemTrungBinhHK2; }
            set { fDiemTrungBinhHK2 = value; }

        }

        private decimal fDiemTrungBinhNam;
        public decimal DiemTrungBinhHKNam
        {
            get { return fDiemTrungBinhNam; }
            set { fDiemTrungBinhNam = value; }

        }
    }
}
