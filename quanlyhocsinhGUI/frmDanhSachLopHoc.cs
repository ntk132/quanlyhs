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

            dgvDanhSachLop.MultiSelect = false;

            cbNamHoc.DataSource = namhocDAL.layDanhSachNamHoc();
            cbNamHoc.ValueMember = "MaNamHoc";

            cbKhoiLop.DataSource = khoilopDAL.layDanhSachKhoiLop();
            cbKhoiLop.ValueMember = "MaKhoiLop";

            tbSiSo.Enabled = false;
        }

        private void frmDanhSachLopHoc_Load(object sender, EventArgs e)
        {
            cbNamHoc.Text = MACDINH.NamHocMacDinh;
            cbKhoiLop.Text = "";
        }

        private void dgvDanhSachLop_SelectionChanged(object sender, EventArgs e)
        {
            /*
            if (dgvDanhSachLop.CurrentRow.Index > dgvDanhSachLop.Rows.Count - 2)
            {
                MessageBox.Show("Đây không phải hàng dữ liệu! Vui lòng chọn lại!");

                return;
            }
            */

            // Nếu chọn một dòng dữ liệu thì Binding data từ hàng đó sang
            // các text box tương ứng
            if (dgvDanhSachLop.SelectedRows.Count > 0)
            {                
                tbMaLop.Text = dgvDanhSachLop.SelectedRows[0].Cells[0].Value.ToString();
                tbTenLop.Text = dgvDanhSachLop.SelectedRows[0].Cells[2].Value.ToString();
                cbKhoiLop.Text = dgvDanhSachLop.SelectedRows[0].Cells[3].Value.ToString();
                tbSiSo.Text = dgvDanhSachLop.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            // Nếu người dùng chưa chọn\nhập bất cứ thông tin gì mà đã tạo lớp
            // Hiện thông báo cho User biết thao tác không thể thực hiện được
            isFullInformation();

            LopHocDTO lophocDTO = new LopHocDTO();
            LopHocBUS lophocBUS = new LopHocBUS();            

            // Kiểm tra số lớp trong một khối đã là tối đa chưa
            // Nếu chưa thì cho phép tạo mới
            // Ngược lại hiện thông báo cho User biết, không thể thực hiện thao tác

            // BUS
            // Kiểm tra số lượng lớp trong khối đã đầy chưa
            // Nếu đã đầy thì hiện thông báo
            if (!lophocBUS.isLessThanMax(cbNamHoc.Text, cbKhoiLop.Text))
            {
                MessageBox.Show("Số lượng lớp của khối lớp này đã đủ! Vui lòng thực hiện lại");

                cbKhoiLop.Focus();

                return;
            }

            // Ngược lại:
            // Kiểm tra mã lớp đã tồn tại hay chưa
            if (lophocBUS.isExists(cbNamHoc.Text, tbMaLop.Text))
            {
                MessageBox.Show("Mã lớp này đã tồn tại! Vui lòng thực hiện lại");

                tbMaLop.Focus();

                return;
            }


            // Mapping...
            lophocDTO.MaLopHoc = tbMaLop.Text;
            lophocDTO.MaKhoiLop = cbKhoiLop.Text;
            lophocDTO.MaNamHoc = cbNamHoc.Text;
            lophocDTO.TenLopHoc = tbTenLop.Text;
            lophocDTO.SiSo = 0;           

            // DAL - Insert
            lophocDAL.insert(lophocDTO);

            // Cập nhật lại danh sách lớp sau khi đã thêm mới
            // Nếu thêm thành công
            refeshDataGridView();
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {            
            if (dgvDanhSachLop.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chưa chọn lớp để cập nhật!");

                return;
            }

            isFullInformation();

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

            Lop_HocSinhDAL lop_hsDAl = new Lop_HocSinhDAL();

            // DAL - Delete
            // Do Mã lớp học là khóa ngoại của bảng
            // HS_LOP
            // nên phải xóa trên bảng đó trước
            lop_hsDAl.xoaLopHSCuaMotLopTrongNamHoc(MACDINH.NamHocMacDinh, lophocDTO.MaLopHoc);
            lophocDAL.delete(lophocDTO);

            refeshDataGridView();
        }

        private void isFullInformation()
        {
            if (tbMaLop.Text == string.Empty)
            {
                MessageBox.Show("Mã lớp học còn trống!");

                tbMaLop.Focus();

                return;
            }

            if (cbNamHoc.Text == string.Empty)
            {
                MessageBox.Show("Mã năm học còn trống!");

                cbNamHoc.Focus();

                return;
            }

            if (cbKhoiLop.Text == string.Empty)
            {
                MessageBox.Show("Mã khối lớp còn trống!");

                cbKhoiLop.Focus();

                return;
            }
        }

        private void cbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Nếu năm học thay đổi thì cập nhật lại danh sách lớp hiển thị theo năm học đó
            refeshDataGridView();

            // Đồng thời làm trống các textbox
            tbMaLop.Clear();
            tbTenLop.Clear();
            tbSiSo.Clear();
            cbKhoiLop.Text = "";
        }

        private void refeshDataGridView()
        {
            dgvDanhSachLop.DataSource = lophocDAL.layDanhSachLopTheoNamHoc(cbNamHoc.Text);
            dgvDanhSachLop.MultiSelect = false;
        }

        private void dgvDanhSachLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDanhSachLop.Rows.Count < 3)
                return;

            if (e.RowIndex < 0)
                return;

            dgvDanhSachLop.Rows[e.RowIndex].Selected = true;
        }
    }
}