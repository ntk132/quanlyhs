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
    public partial class frmTraCuuHocSinh : Form
    {
        DataAccess da = new DataAccess();
        //HocSinhDTO hsdto = new HocSinhDTO();
        HocSinhDAL hsdal = new HocSinhDAL();
        LopHocDAL lhdal = new LopHocDAL();
        DiemTrungBinhDAL diemtbDAL = new DiemTrungBinhDAL();

        public frmTraCuuHocSinh()
        {
            InitializeComponent();

            dgvThongTin.MultiSelect = false;

            cbTimLop.DataSource = lhdal.layDanhSachLopTheoNamHoc(MACDINH.NamHocMacDinh);
            cbTimLop.ValueMember = "MaLopHoc";

            rbTatCa.Checked = true;
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            // Mapping...
            string gioitinh = "";

            if (rbNam.Checked)
                gioitinh = rbNam.Text;

            if (rbNu.Checked)
                gioitinh = rbNu.Text;

            DataTable dt = hsdal.timHocSinh(MACDINH.NamHocMacDinh, cbTimLop.Text, tbTimKiemHoTen.Text, gioitinh);

            // Search , show result
            dgvThongTin.DataSource = dt;
            dgvThongTin.MultiSelect = false;
        }

        private void dgvThongTin_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvThongTin.CurrentRow.Index > dgvThongTin.Rows.Count - 2)
            {
                MessageBox.Show("Đây không phải hàng dữ liệu!");

                return;
            }

            if (dgvThongTin.SelectedRows.Count > 0)
            {
                int maHocSinh = Convert.ToInt32(dgvThongTin.SelectedRows[0].Cells[0].Value);
                dgvKetQuaHocTap.DataSource = diemtbDAL.xemDiemTrungBinhCuaHocSinh(MACDINH.NamHocMacDinh, maHocSinh);
            }
        }

        private void dgvThongTin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvThongTin.Rows[e.RowIndex].Selected = true;
        }
    }
}
