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

            pnWiget.Visible = false;

            // Chỉnh sửa giao diện các Button
            Custom_Button_Style(btThayDoiQuyDinh);
            Custom_Button_Style(btTraCuuHocSinh);
            Custom_Button_Style(btNhanBangDiemMon);
            Custom_Button_Style(btTiepNhanHocSinh);
            Custom_Button_Style(btLapDanhSachLop);
            Custom_Button_Style(btLapBaoCaoTongHop);
            // --  Kết thúc
        }

        private void Custom_Button_Style(Button b)
        {
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
        }

        private void tsbtTrangChu_Click(object sender, EventArgs e)
        {
            pnWiget.Visible = !pnWiget.Visible;
        }

        private void tsbtNamHoc_Click(object sender, EventArgs e)
        {
            pnWiget.Visible = false;

            frmNamHoc frm = new frmNamHoc();

            frm.MdiParent = this;
            frm.Show();
        }

        private void tsbtDanhSachLop_Click(object sender, EventArgs e)
        {
            pnWiget.Visible = false;

            frmDanhSachLopHoc frm = new frmDanhSachLopHoc();

            frm.MdiParent = this;
            frm.Show();
        }

        private void tsbtDanhSachHocSinh_Click(object sender, EventArgs e)
        {
            pnWiget.Visible = false;

            frmDanhSachHocSinh frm = new frmDanhSachHocSinh();

            frm.MdiParent = this;
            frm.Show();

        }

        private void tsbtXepLop(object sender, EventArgs e)
        {
            pnWiget.Visible = false;

            frmXepLop frm = new frmXepLop();

            frm.MdiParent = this;
            frm.Show();
        }

        private void tsbtLenLop(object sender, EventArgs e)
        {
            pnWiget.Visible = false;

            frmLenLop frm = new frmLenLop();

            frm.MdiParent = this;
            frm.Show();
        }

        private void tsbtKetQuaHocTap_Click(object sender, EventArgs e)
        {
            pnWiget.Visible = false;

            frmKetQuaHocTap frm = new frmKetQuaHocTap();

            frm.MdiParent = this;
            frm.Show();
        }

        private void tsbtTraCuuHocSinh_Click(object sender, EventArgs e)
        {
            pnWiget.Visible = false;

            frmTraCuuHocSinh frm = new frmTraCuuHocSinh();

            frm.MdiParent = this;
            frm.Show();
        }

        private void tsbtBaoCao_Click(object sender, EventArgs e)
        {
            pnWiget.Visible = false;

            frmLapBaoCaoTongHop frm = new frmLapBaoCaoTongHop();

            frm.MdiParent = this;
            frm.Show();
        }

        private void tsbtThayDoiQuyDinh_Click(object sender, EventArgs e)
        {
            pnWiget.Visible = false;

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
            pnWiget.Visible = false;

            frmQuanLyNhapDiem frm = new frmQuanLyNhapDiem();

            frm.MdiParent = this;
            frm.Show();
        }

        // --------  Xử lí sự kiên click của các button trên pnWiget  --------
        private void btTiepNhanHocSinh_Click(object sender, EventArgs e)
        {
            frmTiepNhanHocSinh frm = new frmTiepNhanHocSinh();

            frm.MdiParent = this;
            pnWiget.Visible = false;
            frm.Show();
        }

        private void btLapDanhSachLop_Click(object sender, EventArgs e)
        {
            frmLapDanhSachLop frm = new frmLapDanhSachLop();

            frm.MdiParent = this;
            pnWiget.Visible = false;
            frm.Show();
        }

        private void btTraCuuHocSinh_Click(object sender, EventArgs e)
        {
            frmTraCuuHocSinh frm = new frmTraCuuHocSinh();

            frm.MdiParent = this;
            pnWiget.Visible = false;
            frm.Show();
        }

        private void btNhanBangDiemMon_Click(object sender, EventArgs e)
        {
            frmKetQuaHocTap frm = new frmKetQuaHocTap();

            frm.MdiParent = this;
            pnWiget.Visible = false;
            frm.Show();
        }

        private void btLapBaoCaoTongHop_Click(object sender, EventArgs e)
        {
            frmLapBaoCaoTongHop frm = new frmLapBaoCaoTongHop();

            frm.MdiParent = this;
            pnWiget.Visible = false;
            frm.Show();
        }

        private void btThayDoiQuyDinh_Click(object sender, EventArgs e)
        {
            frmThayDoiQuyDinh frm = new frmThayDoiQuyDinh();

            frm.MdiParent = this;
            pnWiget.Visible = false;
            frm.Show();
        }

        // --------  Kết thúc  --------        
    }
}
