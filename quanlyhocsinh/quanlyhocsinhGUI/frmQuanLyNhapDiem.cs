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

            cbHocKy.DataSource = hkdal.layDanhSachHocKyTheoNamHoc(NAMHOC.NamHocMacDinh);
            cbHocKy.ValueMember = "TenHocKy";
            cbLopHoc.DataSource = lhdal.layDanhSachLopTheoNamHoc(NAMHOC.NamHocMacDinh);
            cbLopHoc.ValueMember = "MaLopHoc";
        }

        private void btChon_Click(object sender, EventArgs e)
        {
            dgvDanhSachHocSinh.DataSource = kqdal.layDanhSachHS_QLDiem(NAMHOC.NamHocMacDinh, cbLopHoc.Text);
        }

        private void btNhapDiem_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachHocSinh.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chưa chọn học sinh để nhập điểm!");

                return;
            }

            DataTable dt = hkdal.layDanhSachHocKyTheoNamHoc(NAMHOC.NamHocMacDinh);

            // Mapping...            
            string mahocky = dt.Rows[cbHocKy.SelectedIndex][0].ToString();
            string malop = cbLopHoc.Text;
            string mahocsinh = dgvDanhSachHocSinh.SelectedRows[0].Cells[0].Value.ToString();
            string hoten = dgvDanhSachHocSinh.SelectedRows[0].Cells[1].Value.ToString();

            frmNhapDiem frm = new frmNhapDiem(mahocky, malop, mahocsinh, hoten);

            frm.Show();
        }
    }
}
