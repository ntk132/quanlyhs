using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlyhocsinhGUI
{
    public partial class frmManHinhChinh : Form
    {
        public frmManHinhChinh()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.IsMdiContainer = true;
        }

        private void tsbtNamHoc_Click(object sender, EventArgs e)
        {
            frmNamHoc frm = new frmNamHoc();

            frm.MdiParent = this;
            frm.Show();
        }

        private void tsbtDanhSachLop_Click(object sender, EventArgs e)
        {
            frmDanhSachLopHoc frm = new frmDanhSachLopHoc();

            frm.MdiParent = this;
            frm.Show();
        }

        private void tsbtDanhSachHocSinh_Click(object sender, EventArgs e)
        {
            frmDanhSachHocSinh frm = new frmDanhSachHocSinh();

            frm.MdiParent = this;
            frm.Show();

        }

        private void tsbtXepLop(object sender, EventArgs e)
        {
            frmXepLop frm = new frmXepLop();

            frm.MdiParent = this;
            frm.Show();
        }

        private void tsbtLenLop(object sender, EventArgs e)
        {
            frmLenLop frm = new frmLenLop();

            frm.MdiParent = this;
            frm.Show();
        }

        private void tsbtKetQuaHocTap_Click(object sender, EventArgs e)
        {
            frmKetQuaHocTap frm = new frmKetQuaHocTap();

            frm.MdiParent = this;
            frm.Show();
        }

        private void tsbtTraCuuHocSinh_Click(object sender, EventArgs e)
        {
            frmTraCuuHocSinh frm = new frmTraCuuHocSinh();

            frm.MdiParent = this;
            frm.Show();
        }

        private void tsbtBaoCao_Click(object sender, EventArgs e)
        {
            frmLapBaoCaoTongHop frm = new frmLapBaoCaoTongHop();

            frm.MdiParent = this;
            frm.Show();
        }

        private void tsbtThayDoiQuyDinh_Click(object sender, EventArgs e)
        {
            frmThayDoiQuyDinh frm = new frmThayDoiQuyDinh();

            frm.MdiParent = this;
            frm.Show();
        }

        private void tsbtThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNhapDiem_Click(object sender, EventArgs e)
        {
            frmQuanLyNhapDiem frm = new frmQuanLyNhapDiem();

            frm.MdiParent = this;
            frm.Show();
        }
    }
}
