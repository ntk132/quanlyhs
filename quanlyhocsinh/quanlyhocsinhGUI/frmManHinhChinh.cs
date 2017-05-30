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

            if (frm.isRunning)
                return;
            else
            {
                controlStartForms(frm);

                frm.isRunning = true;
            }                
        }

        private void tsbtDanhSachLop_Click(object sender, EventArgs e)
        {
            frmDanhSachLopHoc frm = new frmDanhSachLopHoc();

            controlStartForms(frm);
        }

        private void tsbtDanhSachHocSinh_Click(object sender, EventArgs e)
        {
            frmDanhSachHocSinh frm = new frmDanhSachHocSinh();

            controlStartForms(frm);

        }

        private void tsbtXepLop(object sender, EventArgs e)
        {
            frmXepLop frm = new frmXepLop();

            controlStartForms(frm);
        }

        private void tsbtLenLop(object sender, EventArgs e)
        {
            frmLenLop frm = new frmLenLop();

            controlStartForms(frm);
        }

        private void tsbtKetQuaHocTap_Click(object sender, EventArgs e)
        {
            frmKetQuaHocTap frm = new frmKetQuaHocTap();

            controlStartForms(frm);
        }

        private void tsbtTraCuuHocSinh_Click(object sender, EventArgs e)
        {
            frmTraCuuHocSinh frm = new frmTraCuuHocSinh();

            controlStartForms(frm);
        }

        private void tsbtBaoCao_Click(object sender, EventArgs e)
        {
            frmLapBaoCaoTongHop frm = new frmLapBaoCaoTongHop();

            controlStartForms(frm);
        }

        private void tsbtThayDoiQuyDinh_Click(object sender, EventArgs e)
        {
            frmThayDoiQuyDinh frm = new frmThayDoiQuyDinh();

            controlStartForms(frm);
        }

        private void controlStartForms(Form frm)
        {
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsbtThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNhapDiem_Click(object sender, EventArgs e)
        {
            //frmQuanLyNhapDiem frm = new frmQuanLyNhapDiem();

            frmNhapKetQuaHocTap frm = new frmNhapKetQuaHocTap();

            frm.MdiParent = this;
            frm.Show();
        }
    }
}
