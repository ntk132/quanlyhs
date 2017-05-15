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
    public partial class frmLapDanhSachLop : Form
    {
        DataAccess da = new DataAccess();
        Lop_HocSinhBUS lhsbus = new Lop_HocSinhBUS();
        Lop_HocSinhDTO lhsdto = new Lop_HocSinhDTO();
        Lop_HocSinhDAL lhsdal = new Lop_HocSinhDAL();
        HocSinhDTO hsdto = new HocSinhDTO();
        HocSinhDAL hsdal = new HocSinhDAL();
        LopHocDTO lhdto = new LopHocDTO();
        LopHocDAL lhdal = new LopHocDAL();

        public frmLapDanhSachLop()
        {
            InitializeComponent();

            cbLopCu.DataSource = lhdal.layDanhSachLop();
            cbLopCu.ValueMember = "MaLopHoc";
            cbLopMoi.DataSource = lhdal.layDanhSachLop();
            cbLopMoi.ValueMember = "MaLopHoc";
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            //DataTable dt = da.ExecuteQuery("select MaHocSinh, HoTen from HOCSINH where Hoten like '%" + tbTimKiem.Text + "%' order by MaHocSinh");

            DataTable dt = hsdal.timHocSinh(tbTimKiem.Text, "", "");

            dgvTimHocSinh.DataSource = dt;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            // 1. Mapping...properties
            Lop_HocSinhDTO lhsdto = new Lop_HocSinhDTO();

            if (dgvTimHocSinh.SelectedRows.Count == 0)
                MessageBox.Show("Chua chon hoc sinh de them vao!");
            else
            {
                lhsdto.MaLopHoc = cbLopMoi.Text;
                lhsdto.MaHocSinh = Convert.ToInt16(dgvTimHocSinh.SelectedRows[0].Cells[0].Value);
            }
            // 2. BUS
            // Nếu học sinh đậu hết tất cả các môn
            if (lhsbus.isPassedAllSubject(hsdto))
            {
                // Nếu số lượng học sinh chưa vượt quá sỉ số tối đa
                if (lhsbus.isLessThanMax(lhdto))
                {
                    // 3. DAL - Insert
                    lhsdal.insert(lhsdto);

                    refesh_dgvDanhSachLopMoi();
                }
                else
                    MessageBox.Show("Lop da day, khong the them hoc sinh!");
            }
            else
                MessageBox.Show("Hoc sinh khong du tieu chuan len lop");

            
        }

        private void btAddAll_Click(object sender, EventArgs e)
        {

        }

        private void btSua_Click(object sender, EventArgs e)
        {

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            // 1. Mapping...
            Lop_HocSinhDTO lhsdto = new Lop_HocSinhDTO();

            if (dgvTimHocSinh.SelectedRows.Count == 0)
                MessageBox.Show("Chua chon hoc sinh de xoa!");
            else
            {
                lhsdto.MaLopHoc = cbLopMoi.Text;
                lhsdto.MaHocSinh = Convert.ToInt16(dgvDanhSachLopMoi.SelectedRows[0].Cells[1].Value);
            }

            // 2. DAL - Delete
            lhsdal.delete(lhsdto);
            refesh_dgvDanhSachLopMoi();
        }

        private void cbLopCu_TextChanged(object sender, EventArgs e)
        {
            if (cbLopCu.Text == String.Empty)
                return;


        }

        private void cbLopMoi_TextChanged(object sender, EventArgs e)
        {
            if (cbLopCu.Text == String.Empty)
                return;

            refesh_dgvDanhSachLopMoi();
        }

        private void refesh_dgvDanhSachLopMoi()
        {
            dgvDanhSachLopMoi.DataSource = da.ExecuteQuery("select Hoten, GioiTinh, year(NgaySinh) as 'NamSinh', DiaChi from HS_LOP join HOCSINH on (HS_LOP.MaHocSinh=HOCSINH.MaHocSinh) where MaLopHoc='" + cbLopMoi.Text + "'");
        }
    }
}
