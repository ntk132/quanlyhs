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
        DataAccess da = new DataAccess();
        HocSinhDAL hocsinhDAL = new HocSinhDAL();
        HocSinhBUS hocsinhBUS = new HocSinhBUS();
        LopHocDAL lophocDAL = new LopHocDAL();
        QuyDinhDAL quydinhDAL = new QuyDinhDAL();
        Lop_HocSinhDAL lop_hsDAL = new Lop_HocSinhDAL();
        KetQuaHocTapDAL ketquaDAL = new KetQuaHocTapDAL();
        DiemTrungBinhDAL diemtbDAL = new DiemTrungBinhDAL();
        

        List<int> ngay28 = new List<int>();
        List<int> ngay29 = new List<int>();
        List<int> ngay30 = new List<int>();
        List<int> ngay31 = new List<int>();
        List<int> thang = new List<int>();
        List<int> nam = new List<int>();

        public frmDanhSachHocSinh()
        {
            InitializeComponent();

            dgvHocSinh.MultiSelect = false;

            initComboBoxNgaySinh();

            cbLopHoc.DataSource = lophocDAL.layDanhSachLopTheoNamHoc(MACDINH.NamHocMacDinh);
            cbLopHoc.ValueMember = "MaLopHoc";
        }

        private void initComboBoxNgaySinh()
        {
            int tuoiToiDa = Convert.ToInt16(quydinhDAL.layQuyDinhTuoiToiDa().Rows[0]["GiaTriQuyDinh"].ToString());
            int tuoiToiThieu = Convert.ToInt16(quydinhDAL.layQuyDinhTuoiToiThieu().Rows[0]["GiaTriQuyDinh"].ToString());

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
            dgvHocSinh.DataSource = hocsinhDAL.xuatToanBoHocSinh();
            dgvHocSinh.MultiSelect = false;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            
            HocSinhDTO hocsinhDTO = new HocSinhDTO();

            // Kiểm tra User dẫ nhập đầy đủ thông tin để tạo mới hay chưa
            if (!isFullInformation())
            {
                return;
            }

            // 1. Mapping...properties
            hocsinhDTO.Hoten = tbHoTen.Text;
            hocsinhDTO.NgaySinh = cbNgay.Text + "/" + cbThang.Text + "/" + cbNam.Text;

            if (rbNam.Checked)
                hocsinhDTO.GioiTinh = "Nam";
            else if (rbNu.Checked)
                hocsinhDTO.GioiTinh = "Nữ";

            hocsinhDTO.DiaChi = tbDiaChi.Text;
            hocsinhDTO.Email = tbEmail.Text;

            // 2. BUS
            if (hocsinhBUS.isLessThanMinAge() || hocsinhBUS.isGreatThanAge())
            {
                MessageBox.Show("Nhập tuổi sai quy định");

                cbNgay.Focus();
            }

            // 3. insert
            hocsinhDAL.insert(hocsinhDTO);

            // Refesh data grid view
            LoadStudentList();
        }

        // Hàm có chức năng kiểm tra giá trị ở các thành phần nhập thông tin học sinh
        // trong quá trình thực hiện thao tác nhập, sửa
        // Các thông tin: họ tên, ngày sinh, giới tính, địa chỉ trống -> hiện thông báo lỗi
        private bool isFullInformation()
        {
            // Ho ten
            if (tbHoTen.Text== string.Empty)
            {
                MessageBox.Show("Họ tên học sinh còn trống!");

                tbHoTen.Focus();

                return false;
            }

            // ngay thang nam sinh
            if (cbNgay.Text == string.Empty)
            {
                MessageBox.Show("Ngày sinh học sinh còn trống!");

                cbNgay.Focus();

                return false;
            }

            if (cbThang.Text == string.Empty)
            {
                MessageBox.Show("Tháng sinh học sinh còn trống!");

                cbThang.Focus();

                return false;
            }

            if (cbNam.Text == string.Empty)
            {
                MessageBox.Show("Năm sinh học sinh còn trống!");

                cbNam.Focus();

                return false;
            }

            // gioi tinh
            if (!rbNam.Checked && !rbNu.Checked)
            {
                MessageBox.Show("Giới tính học sinh còn trống!");

                return false;
            }

            // dia chi
            if (tbDiaChi.Text == string.Empty)
            {
                MessageBox.Show("Địa chỉ học sinh còn trống!");

                tbDiaChi.Focus();

                return false;
            }

            return true;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dgvHocSinh.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chưa chọn học sinh để thực hiện thao tác!");

                return;                
            }
            else
            {
                // Mapping..MaHocSinh
                int id = Convert.ToInt32(dgvHocSinh.SelectedRows[0].Cells[0].Value);
                DataTable dt = lop_hsDAL.layMaLopHocTheoMaHocSinhVaNamHoc(id);
                

                // DAL - Delete
                // Do Mã học sinh là khóa ngoại của các bảng:
                // HS_LOP, KETQUAHOCTAP, DIEMTRUNGBINHNAMHOC
                // Nên phải thực hiên thao tác xóa trên các bảng này trước
                lop_hsDAL.xoaLopHSCuaMotHocSinh(id);
                ketquaDAL.xoaKetQuaHoctapCuaMotHocSinh(id);
                diemtbDAL.xoaDiemTBCuaMotHocSinh(id);

                hocsinhDAL.delete(id);

                // Sau khi xoa hs update lai si so lop
                // ma hoc sinh nay da tham gia
                foreach (DataRow dr in dt.Rows)
                {
                    string maLopHoc = dr["MaLopHoc"].ToString();

                    CapNhatSiSoLopHoc(maLopHoc);
                }
                
            }

            // Refesh data grid view
            LoadStudentList();
        }

        private void CapNhatSiSoLopHoc(string maLopHoc)
        {
            LopHocDTO lophocDTO = new LopHocDTO();

            lophocDTO.MaNamHoc = MACDINH.NamHocMacDinh;
            lophocDTO.MaLopHoc = maLopHoc;
            lophocDTO.SiSo = lop_hsDAL.laySiSoCuaLop(MACDINH.NamHocMacDinh, maLopHoc);

            lophocDAL.suaSiSoLop(lophocDTO);
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn học sinh để cập nhật thông tin chưa
            if (dgvHocSinh.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chưa chọn học sinh để thực hiện thao tác!");

                return;
            }

            // Kiểm tra xem có ô thông tin nào trống hay không
            // nếu có thì thông báo tới User và dừng thao tác
            if (!isFullInformation())
                return;

            // Ngược lại thì bắt đầu thao tác cập nhật thông tin học sinh

            // Mapping...
            HocSinhDTO hocsinhDTO = new HocSinhDTO();
            string gioitinh = rbNam.Text;

            if (rbNu.Checked)
                gioitinh = rbNu.Text;

            hocsinhDTO.MaHocSinh = Convert.ToInt32(dgvHocSinh.SelectedRows[0].Cells[0].Value);
            hocsinhDTO.Hoten = tbHoTen.Text;
            hocsinhDTO.NgaySinh = cbNgay.Text + "/" + cbThang.Text + "/" + cbNam.Text;
            hocsinhDTO.GioiTinh = gioitinh;
            hocsinhDTO.DiaChi = tbDiaChi.Text;
            hocsinhDTO.Email = tbEmail.Text;

            // DAL - Insert
            hocsinhDAL.update(hocsinhDTO);

            // Refesh data grid view
            LoadStudentList();
        }

        private void dgvHocSinh_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHocSinh.CurrentRow.Index > dgvHocSinh.Rows.Count - 2)
            {
                MessageBox.Show("Đây không phải hàng dữ liệu! Vui lòng chọn lại!");

                return;
            }

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

        private void chbToanBoHS_CheckedChanged(object sender, EventArgs e)
        {
            if (chbToanBoHS.Checked)
            {
                cbLopHoc.Enabled = false;

                LoadStudentList();
                clearAllInformation();
            }
            else
            {
                cbLopHoc.Enabled = true;
                cbLopHoc.Text = string.Empty;

                clearAllInformation();

                dgvHocSinh.DataSource = null;
                dgvHocSinh.MultiSelect = false;
            }
        }

        private void frmDanhSachHocSinh_Load(object sender, EventArgs e)
        {
            LoadStudentList();

            cbNgay.Text = String.Empty;
            cbThang.Text = String.Empty;
            cbNam.Text = String.Empty;

            cbLopHoc.Text = String.Empty;
            chbToanBoHS.Checked = true;
        }

        private void cbLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvHocSinh.DataSource = hocsinhDAL.layDanhSachHocSinhTheoLop(MACDINH.NamHocMacDinh, cbLopHoc.Text);
            dgvHocSinh.MultiSelect = false;
            clearAllInformation();
        }

        private void clearAllInformation()
        {
            tbHoTen.Text = string.Empty;
            cbNgay.Text = string.Empty;
            cbThang.Text = string.Empty;
            cbNam.Text = string.Empty;
            rbNam.Checked = false;
            rbNu.Checked = false;
            tbDiaChi.Text = string.Empty;
            tbEmail.Text = string.Empty;
        }

        private void dgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 3)
                return;

            dgvHocSinh.Rows[e.RowIndex].Selected = true;
        }
    }
}
