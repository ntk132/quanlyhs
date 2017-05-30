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
using quanlyhocsinhBUS;

namespace quanlyhocsinhGUI
{
    
    public partial class frmNamHoc : Form
    {
        public bool isRunning = false;

        NamHocDAL namhocDAL = new NamHocDAL();
        NamHocMacDinhDAL namhocmacdinhDAL = new NamHocMacDinhDAL();

        public frmNamHoc()
        {
            InitializeComponent();
           
            dgvDanhSachNamHoc.MultiSelect = false;
        }

        private void btChon_Click(object sender, EventArgs e)
        {
            MACDINH.NamHocMacDinh = cbNamHocMacDinh.Text;

            /*
            // Mapping...
            NamHocMacDinhDTO namhocmacdinhDTO = new NamHocMacDinhDTO();

            namhocmacdinhDTO.MaThongSo = "NamHocMacDinh";
            namhocmacdinhDTO.GiaTriThongSo = cbNamHocMacDinh.Text;

            // DAL - Update
            namhocmacdinhDAL.update(namhocmacdinhDTO);
            */

            MessageBox.Show(MACDINH.NamHocMacDinh);
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra User đã nhập mã năm học hay chưa
            if (tbMaNamHoc.Text == string.Empty)
            {
                MessageBox.Show("Chưa nhập mã năm học. Không thể tạo mới!");

                tbMaNamHoc.Focus();

                return;
            }            

            // 1. Mapping...
            NamHocDTO namhocDTO = new NamHocDTO(tbMaNamHoc.Text, tbTenNamHoc.Text);

            // 2. BUS
            // Kiểm tra xem mã năm học đã tồn tại hay chưa
            NamHocBUS namhocBUS = new NamHocBUS();

            if (namhocBUS.isExists(namhocDTO))
            {
                MessageBox.Show("Mã năm học này đã tồn tại! Vui lòng thử lại!");

                tbMaNamHoc.Focus();

                return;
            }

            // 3. DAL - Insert
            namhocDAL.insert(namhocDTO);

            // Một năm học được insert thì auto insert 2 học kỳ: HK 1, HK 2
                // Mapping... học kỳ 1
            HocKyDTO hockyI = new HocKyDTO();

            hockyI.MaNamHoc = namhocDTO.MaNamHoc;
            hockyI.TenHocKy = "Học Kỳ I";
            hockyI.MaHocKy = hockyI.MaNamHoc + "_HK1";

                // Mapping... học kỳ 2
            HocKyDTO hockyII = new HocKyDTO();

            hockyII.MaNamHoc = namhocDTO.MaNamHoc;
            hockyII.TenHocKy = "Học Kỳ II";
            hockyII.MaHocKy = hockyII.MaNamHoc + "_HK2";

                // DAL - Insert
            HocKyDAL hockyDAL = new HocKyDAL();
                
            hockyDAL.insert(hockyI);
            hockyDAL.insert(hockyII);

            // Cập nhật lại Data Grid View
            refeshDataGridView();
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            // Nếu chưa chọn năm học thì chưa thể cập nhật
            if (dgvDanhSachNamHoc.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chưa chọn năm học để cập nhật!");

                return;
            }

            // 1. Mapping...
            NamHocDTO nhdto = new NamHocDTO(tbMaNamHoc.Text, tbTenNamHoc.Text);

            // 2. BUS

            // 3. DAL - Insert
            namhocDAL.update(nhdto);

            refeshDataGridView();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            KetQuaHocTapDAL ketquaDAL = new KetQuaHocTapDAL();
            HocKyDAL hockyDAL = new HocKyDAL();
            Lop_HocSinhDAL lop_hsDAL = new Lop_HocSinhDAL();
            LopHocDAL lophocDAL = new LopHocDAL();
            DiemTrungBinhDAL diemtbDAl = new DiemTrungBinhDAL();

            // Nếu chưa chọn năm học thì chưa thể xóa
            if (dgvDanhSachNamHoc.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chưa chọn năm học để xóa!");

                return;
            }

            // Mapping... học kỳ với năm học cần xóa
            string maNamHoc = tbMaNamHoc.Text;

            HocKyDTO hocky = new HocKyDTO();

            hocky.MaNamHoc = maNamHoc;
            hocky.TenHocKy = "";
            hocky.MaHocKy = "";

            // Xóa một năm học:
            // Do quá trình xóa có liên quan đến khóa ngoại nên
            // Xóa Bảng: KETQUAHOCTAP -> HOCKY
            // Xóa bảng: HS_LOP -> LOPHOC
            // Xóa bảng: DIEMTB -> NAMHOC
            //          | HOCKY  -  KETQUAHOCTAP
            // NAMHOC - | LOPHOC -  HS_LOP
            //          | DIEMTB

            ketquaDAL.xoaKetQuaTrongMotNamHoc(maNamHoc);
            hockyDAL.delete(hocky);
            lop_hsDAL.xoaLopHSTrongNamHoc(maNamHoc);
            lophocDAL.xoaLopHocTrongNamHoc(maNamHoc);
            diemtbDAl.xoaDiemTBTrongNamHoc(maNamHoc);
            namhocDAL.delete(maNamHoc);
            
            refeshDataGridView();
        }

        private void frmNamHoc_Load(object sender, EventArgs e)
        {
            isRunning = true;

            refeshDataGridView();

            cbNamHocMacDinh.Text = MACDINH.NamHocMacDinh;
        }

        private void refeshDataGridView()
        {
            dgvDanhSachNamHoc.DataSource = namhocDAL.layDanhSachNamHocVaHocKy();

            cbNamHocMacDinh.DataSource = namhocDAL.layDanhSachNamHoc();
            cbNamHocMacDinh.ValueMember = "MaNamHoc";
        }

        private void dgvDanhSachNamHoc_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDanhSachNamHoc.CurrentRow.Index > dgvDanhSachNamHoc.Rows.Count - 2)
            {
                MessageBox.Show("Đây không phải hàng dữ liệu! Vui lòng chọn lại!");

                return;
            }

            if (dgvDanhSachNamHoc.SelectedRows.Count > 0)
            {
                tbMaNamHoc.Text = dgvDanhSachNamHoc.SelectedRows[0].Cells[0].Value.ToString();
                tbTenNamHoc.Text = dgvDanhSachNamHoc.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void dgvDanhSachNamHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDanhSachNamHoc.Rows.Count < 3)
                return;

            dgvDanhSachNamHoc.Rows[e.RowIndex].Selected = true;
        }

        private void frmNamHoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            isRunning = false;
        }
    }    
}
