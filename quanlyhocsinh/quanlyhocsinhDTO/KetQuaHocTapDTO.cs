using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyhocsinhDTO
{
    public class KetQuaHocTapDTO
    {
        public KetQuaHocTapDTO() { }
        public KetQuaHocTapDTO(string mahk, int mamon, int mahs, float diem15p, float diem1t, float diemtb)
        {
            this.sMaHocKy = mahk;
            this.iMaMonHoc = mamon;
            this.iMaHocSinh = mahs;
            this.fDiem15Phut = diem15p;
            this.fDiem1Tiet = diem1t;
            this.fDiemTB = diemtb;
        }

        private string sMaHocKy;

        public string MaHocKy
        {
            get { return sMaHocKy; }
            set { sMaHocKy = value; }
        }

        private int iMaMonHoc;

        public int MaMonHoc
        {
            get { return iMaMonHoc; }
            set { iMaMonHoc = value; }
        }

        private int iMaHocSinh;

        public int MaHocSinh
        {
            get { return iMaHocSinh; }
            set { iMaHocSinh = value; }
        }

        private float fDiem15Phut;

        public float Diem15Phut
        {
            get { return fDiem15Phut; }
            set { fDiem15Phut = value; }
        }

        private float fDiem1Tiet;

        public float Diem1Tiet
        {
            get { return fDiem1Tiet; }
            set { fDiem1Tiet = value; }
        }

        private float fDiemTB;

        public float DiemTB
        {
            get { return fDiemTB; }
            set { fDiemTB = value; }
        }

        private float fDiemToiThieuDat;

        public float DiemToiThieuDat
        {
            get { return fDiemToiThieuDat; }
            set { fDiemToiThieuDat = value; }
        }

        private int iCoDatHayKhong;

        public int CoDatHayKhong
        {
            get { return iCoDatHayKhong; }
            set { iCoDatHayKhong = value; }
        }
    }
}
