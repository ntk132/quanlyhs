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
        public KetQuaHocTapDTO(string mahk, int mamon, int mahs, decimal diem15p, decimal diem1t, decimal diemtb)
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

        private decimal fDiem15Phut;

        public decimal Diem15Phut
        {
            get { return fDiem15Phut; }
            set { fDiem15Phut = value; }
        }

        private decimal fDiem1Tiet;

        public decimal Diem1Tiet
        {
            get { return fDiem1Tiet; }
            set { fDiem1Tiet = value; }
        }

        private decimal fDiemTB;

        public decimal DiemTB
        {
            get { return fDiemTB; }
            set { fDiemTB = value; }
        }

        private decimal fDiemToiThieuDat;

        public decimal DiemToiThieuDat
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
