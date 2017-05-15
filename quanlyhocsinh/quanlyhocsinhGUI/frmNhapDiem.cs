using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quanlyhocsinhBUS;
using quanlyhocsinhDTO;
using quanlyhocsinhDAL;

namespace quanlyhocsinhGUI
{
    public partial class frmNhapDiem : Form
    {
        MonHocDAL mhdal = new MonHocDAL();
        string mahocsinh;
        public frmNhapDiem()
        {
            InitializeComponent();            
        }

        public frmNhapDiem(string  hocky, string malop, string mahs, string hoten)
        {
            tbHocKy.Text = hocky;
            tbLopHoc.Text = malop;
            tbHoTen.Text = hoten;

            mahocsinh = mahs;

            tbHoTen.Enabled = false;
            tbHocKy.Enabled = false;
            tbLopHoc.Enabled = false;
            tbDiemTB.Enabled = false;

            cbMonHoc.DataSource = mhdal.layDanhSachMonHoc();
            cbMonHoc.ValueMember = "TenMonHoc";
        }

        private void btChon_Click(object sender, EventArgs e)
        {

        }

        private void btLuuDiem_Click(object sender, EventArgs e)
        {
            float diemtb = ((float)Convert.ToDouble(tbDiem15p.Text) + (float)Convert.ToDouble(tbDiem1t.Text) * 2 ) / 3;
            tbDiemTB.Text = diemtb.ToString();

            KetQuaHocTapDTO ketqua = new KetQuaHocTapDTO();

            ketqua.MaHocKy = tbHocKy.Text;
            //ketqua.MaMonHoc = cbMonHoc.Text;
            ketqua.MaHocSinh = Convert.ToInt32(mahocsinh);
            ketqua.Diem15Phut = (float)Convert.ToDouble(tbDiem15p.Text);
            ketqua.Diem1Tiet = (float)Convert.ToDouble(tbDiem1t.Text);
            ketqua.DiemTB = diemtb;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
