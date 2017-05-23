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
    public partial class frmDanhSachLopHoc : Form
    {
        NamHocDAL namhocDAL = new NamHocDAL();
        LopHocDAL lophocDAL = new LopHocDAL();
        KhoiLopDAL khoilopDAL = new KhoiLopDAL();

        public frmDanhSachLopHoc()
        {
            InitializeComponent();            

            cbNamHoc.DataSource = namhocDAL.layDanhSachNamHoc();
            cbNamHoc.ValueMember = "MaNamHoc";

            cbKhoiLop.DataSource = khoilopDAL.layDanhSachKhoiLop();
            cbKhoiLop.ValueMember = "MaKhoiLop";
        }

        private void frmDanhSachLopHoc_Load(object sender, EventArgs e)
        {
            cbNamHoc.Text = "";
            cbKhoiLop.Text = "";
        }

        private void dgvDanhSachLop_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDanhSachLop.SelectedRows.Count > 0)
            {
                cbKhoiLop.Text = dgvDanhSachLop.SelectedRows[0].Cells[3].Value.ToString();
                tbMaLop.Text = dgvDanhSachLop.SelectedRows[0].Cells[0].Value.ToString();
                tbTenLop.Text = dgvDanhSachLop.SelectedRows[0].Cells[2].Value.ToString();
                tbSiSo.Text = dgvDanhSachLop.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            LopHocDTO lophocDTO = new LopHocDTO();

            // Mapping...
            lophocDTO.MaLopHoc = tbMaLop.Text;
            lophocDTO.MaKhoiLop = cbKhoiLop.Text;
            lophocDTO.MaNamHoc = cbNamHoc.Text;
            lophocDTO.TenLopHoc = tbTenLop.Text;
            lophocDTO.SiSo = 0;

            // DAL - Insert
            lophocDAL.insert(lophocDTO);

            refeshDataGridView();
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachLop.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chưa chọn lớp để cập nhật!");

                return;
            }

            LopHocDTO lophocDTO = new LopHocDTO();

            // Mapping...
            lophocDTO.MaLopHoc = tbMaLop.Text;
            lophocDTO.MaKhoiLop = cbKhoiLop.Text;
            lophocDTO.MaNamHoc = cbNamHoc.Text;
            lophocDTO.TenLopHoc = tbTenLop.Text;
            lophocDTO.SiSo = Convert.ToInt16(tbSiSo.Text);

            // DAL - Update
            lophocDAL.update(lophocDTO);

            refeshDataGridView();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachLop.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chưa chọn lớp để xóa!");

                return;
            }

            LopHocDTO lophocDTO = new LopHocDTO();

            // Mapping...
            lophocDTO.MaLopHoc = tbMaLop.Text;
            lophocDTO.MaKhoiLop = cbKhoiLop.Text;
            lophocDTO.MaNamHoc = cbNamHoc.Text;
            lophocDTO.TenLopHoc = tbTenLop.Text;
            lophocDTO.SiSo = Convert.ToInt16(tbSiSo.Text);

            // DAL - Delete
            lophocDAL.delete(lophocDTO);

            refeshDataGridView();
        }

        private void cbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            refeshDataGridView();

            tbMaLop.Clear();
            tbTenLop.Clear();
            tbSiSo.Clear();
            cbKhoiLop.Text = "";
        }

        private void refeshDataGridView()
        {
            dgvDanhSachLop.DataSource = lophocDAL.layDanhSachLopTheoNamHoc(cbNamHoc.Text);
        }
    }
}