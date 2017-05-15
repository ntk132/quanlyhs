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
using quanlyhocsinhDAL;

namespace quanlyhocsinhGUI
{
    public partial class frmQuanLyNhapDiem : Form
    {
        HocKyDAL hkdal = new HocKyDAL();
        LopHocDAL lhdal = new LopHocDAL();
        KetQuaHocTapDAL kqdal = new KetQuaHocTapDAL();

        public frmQuanLyNhapDiem()
        {
            InitializeComponent();

            cbHocKy.DataSource = hkdal.layDanhSachHocKy();
            cbHocKy.ValueMember = "TenHocKy";
            cbLopHoc.DataSource = lhdal.layDanhSachLop();
            cbLopHoc.ValueMember = "MaLopHoc";
        }

        private void btChon_Click(object sender, EventArgs e)
        {
            dgvDanhSachHocSinh.DataSource = kqdal.layDanhSachHS_QLDiem(cbLopHoc.Text, hkdal.layMaHK(cbHocKy.SelectedItem.ToString()));
        }

        private void btNhapDiem_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachHocSinh.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chưa chọn học sinh để nhập điểm!");

                return;
            }

            // Mapping...
            string hocky = cbHocKy.Text;
            string malop = cbLopHoc.Text;
            string mahs = dgvDanhSachHocSinh.SelectedRows[0].Cells[0].Value.ToString();
            string hoten = dgvDanhSachHocSinh.SelectedRows[0].Cells[1].Value.ToString();

            frmNhapDiem frm = new frmNhapDiem(hocky, malop, mahs, hoten);

            frm.ShowDialog();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
