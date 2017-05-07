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

        public frmDanhSachHocSinh()
        {
            InitializeComponent();

            LoadStudentList();
        }

        private void LoadStudentList()
        {
            // Load toan bo danh sach hoc sinh len ngay khi run form
            dgvHocSinh.DataSource = data.ExecuteQuery("SELECT * FROM HOCSINH");
        }

        private void dgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //DataGridViewCell cell = (DataGridViewCell)sender;

            clearDataBinding();

            //id = cell.DataGridView.Columns[0].ToString();
            
            tbHoTen.DataBindings.Add("Text", dgvHocSinh.DataSource, "HoTen");
            tbNgaySinh.DataBindings.Add("Text", dgvHocSinh.DataSource, "NgaySinh");
            tbGioiTinh.DataBindings.Add("Text", dgvHocSinh.DataSource, "GioiTinh");
            tbDiaChi.DataBindings.Add("Text", dgvHocSinh.DataSource, "DiaChi");
            tbEmail.DataBindings.Add("Text", dgvHocSinh.DataSource, "Email");
        }

        private void clearDataBinding()
        {
            tbHoTen.Text = "";
            tbNgaySinh.Text = "";
            tbGioiTinh.Text = "";
            tbDiaChi.Text = "";
            tbEmail.Text = "";
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            frmTiepNhanHocSinh frm = new frmTiepNhanHocSinh();

            frm.ShowDialog();

            refeshDataTable();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dgvHocSinh.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvHocSinh.SelectedRows[0].Cells[0].Value);

                hsdal.delete(id);
            }

            refeshDataTable();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (dgvHocSinh.SelectedRows.Count > 0)
            {
                hsdto.MaHocSinh = Convert.ToInt32(dgvHocSinh.SelectedRows[0].Cells[0].Value);
                hsdto.Hoten = tbHoTen.Text;
                hsdto.NgaySinh = tbNgaySinh.Text;
                hsdto.GioiTinh = tbGioiTinh.Text;
                hsdto.DiaChi = tbDiaChi.Text;
                hsdto.Email = tbEmail.Text;
            }

            hsdal.update(hsdto);

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
                btSua.Enabled = true;
                btXoa.Enabled = true;

                tbHoTen.Text = dgvHocSinh.SelectedRows[0].Cells[1].Value.ToString();
                tbNgaySinh.Text = dgvHocSinh.SelectedRows[0].Cells[2].Value.ToString();
                tbGioiTinh.Text = dgvHocSinh.SelectedRows[0].Cells[3].Value.ToString();
                tbDiaChi.Text = dgvHocSinh.SelectedRows[0].Cells[4].Value.ToString();
                tbEmail.Text = dgvHocSinh.SelectedRows[0].Cells[5].Value.ToString();

                
            }
        }
    }
}
