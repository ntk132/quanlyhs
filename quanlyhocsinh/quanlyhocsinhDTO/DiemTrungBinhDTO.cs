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

        public DiemTrungBinhDTO(string maNamHoc, int maHocSinh, float diemTBHK1, float diemTBHK2, float diemTBCaNam)
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

        private float fDiemTrungBinhHK1;

        public float DiemTrungBinhHK1
        {
            get { return fDiemTrungBinhHK1; }
            set { fDiemTrungBinhHK1 = value; }

        }

        private float fDiemTrungBinhHK2;

        public float DiemTrungBinhHK2
        {
            get { return fDiemTrungBinhHK2; }
            set { fDiemTrungBinhHK2 = value; }

        }

        private float fDiemTrungBinhNam;
        public float DiemTrungBinhHKNam
        {
            get { return fDiemTrungBinhNam; }
            set { fDiemTrungBinhNam = value; }

        }
    }
}
