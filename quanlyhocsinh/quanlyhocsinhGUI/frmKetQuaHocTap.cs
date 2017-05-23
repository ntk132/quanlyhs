using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quanlyhocsinhDTO;
using quanlyhocsinhDAL;

namespace quanlyhocsinhGUI
{
    public partial class frmKetQuaHocTap : Form
    {
        KetQuaHocTapDAL kqDAL = new KetQuaHocTapDAL();
        HocKyDAL hkDAL = new HocKyDAL();
        LopHocDAL lhDAL = new LopHocDAL();
        MonHocDAL mhDAL = new MonHocDAL();

        public frmKetQuaHocTap()
        {
            InitializeComponent();

            cbHocKy.DataSource = hkDAL.layDanhSachHocKyTheoNamHoc(NAMHOC.NamHocMacDinh);
            cbHocKy.ValueMember = "TenHocKy";
            cbLopHoc.DataSource = lhDAL.layDanhSachLopTheoNamHoc(NAMHOC.NamHocMacDinh);
            cbLopHoc.ValueMember = "MaLopHoc";
            cbMonHoc.DataSource = mhDAL.layDanhSachMonHoc();
            cbMonHoc.ValueMember = "TenMonHoc";
        }

        private void btXemDanhSach_Click(object sender, EventArgs e)
        {
            DataTable dtMaHocKy = hkDAL.layDanhSachHocKyTheoNamHoc(NAMHOC.NamHocMacDinh);
            DataTable dtMaMonHoc = mhDAL.layDanhSachMonHoc();

            // Mapping...
            string mahk = dtMaHocKy.Rows[cbHocKy.SelectedIndex]["MaHocKy"].ToString();
            string malop = cbLopHoc.Text;
            int mamon = Convert.ToInt16(dtMaMonHoc.Rows[cbMonHoc.SelectedIndex]["MaMonHoc"]);

            // Show result
            dgvChiTietDiem.DataSource = kqDAL.xemDiemCuaHocSinh(malop, mamon, mahk);
            //MessageBox.Show(mahk + "\n" + malop + "\n" + mamon);
        }

        private void btTrungBinhNam_Click(object sender, EventArgs e)
        {

        }

        private void dgvChiTietDiem_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
