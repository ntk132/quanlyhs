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
using quanlyhocsinhDTO;

namespace quanlyhocsinhGUI
{
    public partial class frmDanhSachHocSinh : Form
    {
        DataAccess data = new DataAccess();
        HocSinhDTO hsdto = new HocSinhDTO();
        HocSinhDAL hsdal = new HocSinhDAL();

        List<int> ngay28 = new List<int>();
        List<int> ngay29 = new List<int>();
        List<int> ngay30 = new List<int>();
        List<int> ngay31 = new List<int>();
        List<int> thang = new List<int>();
        List<int> nam = new List<int>();

        public frmDanhSachHocSinh()
        {
            InitializeComponent();
            LoadStudentList();

            initComboBoxNgaySinh();

            cbNgay.Text = String.Empty;
            cbThang.Text = String.Empty;
            cbNam.Text = String.Empty;
        }

        private void initComboBoxNgaySinh()
        {
            int tuoiToiDa = 20;
            int tuoiToiThieu = 15;

            for (int i = 1; i <= 28; i++)
                ngay28.Add(i);

            for (int i = 1; i <= 29; i++)
                ngay29.Add(i);

            for (int i = 1; i <= 30; i++)
                ngay30.Add(i);

            for (int i = 1; i <= 31; i++)
                ngay31.Add(i);

            for (int i = 1; i <= 12; i++)
                thang.Add(i);

            DateTime now = DateTime.Now;

            for (int i = tuoiToiDa; i >= tuoiToiThieu; i--)
                nam.Add(now.Year - i);

            cbNgay.DataSource = ngay31;
            cbThang.DataSource = thang;
            cbNam.DataSource = nam;
        }

        private void LoadStudentList()
        {
            // Load toan bo danh sach hoc sinh len ngay khi run form
            dgvHocSinh.DataSource = data.ExecuteQuery("SELECT * FROM HOCSINH");
        }

        private void dgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            HocSinhBUS hsbus = new HocSinhBUS();
            HocSinhDAL hsdal = new HocSinhDAL();
            HocSinhDTO hsdto = new HocSinhDTO();

            // 1. Mapping...properties
            hsdto.Hoten = tbHoTen.Text;
            hsdto.NgaySinh = cbNgay.Text + "/" + cbThang.Text + "/" + cbNam.Text;

            if (rbNam.Checked)
                hsdto.GioiTinh = "Nam";
            else if (rbNu.Checked)
                hsdto.GioiTinh = "Nữ";

            hsdto.DiaChi = tbDiaChi.Text;
            hsdto.Email = tbEmail.Text;

            // 2. BUS
            if (hsbus.isLessThanMinAge() || hsbus.isGreatThanAge())
            {
                MessageBox.Show("Nhập tuổi sai quy định");

                cbNgay.Focus();
            }

            // 3. insert
            hsdal.insert(hsdto);

            // Refesh data grid view
            refeshDataTable();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dgvHocSinh.SelectedRows.Count > 0)
            {
                // Mapping..MaHocSinh
                int id = Convert.ToInt32(dgvHocSinh.SelectedRows[0].Cells[0].Value);
                
                // DAL - Delete
                hsdal.delete(id);
            }
            else
            {
                MessageBox.Show("Chưa chọn học sinh để thực hiện thao tác!");

                return;
            }

            // Refesh data grid view
            refeshDataTable();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            // Mapping...
            string gioitinh = "Nam";

            if (rbNu.Checked)
                gioitinh = rbNu.Text;

            if (dgvHocSinh.SelectedRows.Count > 0)
            {
                hsdto.MaHocSinh = Convert.ToInt32(dgvHocSinh.SelectedRows[0].Cells[0].Value);
                hsdto.Hoten = tbHoTen.Text;
                hsdto.NgaySinh = cbNgay.Text + "/" + cbThang.Text + "/" + cbNam.Text;
                hsdto.GioiTinh = gioitinh;
                hsdto.DiaChi = tbDiaChi.Text;
                hsdto.Email = tbEmail.Text;
            }
            else
            {
                MessageBox.Show("Chưa chọn học sinh để thực hiện thao tác!");

                return;
            }

            // DAL - Insert
            hsdal.update(hsdto);

            // Refesh data grid view
            refeshDataTable();
        }

        private void refeshDataTable()
        {
            dgvHocSinh.DataSource = data.ExecuteQuery("SELECT * FROM HOCSINH");
        }

        private void dgvHocSinh_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHocSinh.SelectedRows.Count > 0)
            {
                tbHoTen.Text = dgvHocSinh.SelectedRows[0].Cells[1].Value.ToString();

                DateTime dtime = Convert.ToDateTime(dgvHocSinh.SelectedRows[0].Cells[2].Value.ToString()).Date;

                cbNgay.Text = dtime.Day.ToString();
                cbThang.Text = dtime.Month.ToString();
                cbNam.Text = dtime.Year.ToString();

                string gioitinh = dgvHocSinh.SelectedRows[0].Cells[3].Value.ToString();

                if (gioitinh == "Nam")
                    rbNam.Checked = true;
                else
                    rbNu.Checked = true;

                tbDiaChi.Text = dgvHocSinh.SelectedRows[0].Cells[4].Value.ToString();
                tbEmail.Text = dgvHocSinh.SelectedRows[0].Cells[5].Value.ToString();                
            }
        }

        private void cbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNam.Text == String.Empty)
                return;
        }

        private void cbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbThang.Text == String.Empty)
                return;

            int year = 0;

            if (cbNam.Text != String.Empty)
                year = Convert.ToInt16(cbNam.Text);

            switch (Convert.ToInt16(cbThang.Text))
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    cbNgay.DataSource = ngay31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    cbNgay.DataSource = ngay30;
                    break;
                case 2:
                    if (year % 4 == 0 && year % 100 == 0)
                        cbNgay.DataSource = ngay29;
                    else
                        cbNgay.DataSource = ngay28;

                    break;
                default:
                    break;
            }
        }
    }
}
