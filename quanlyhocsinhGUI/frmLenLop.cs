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
    public partial class frmLenLop : Form
    {
        NamHocDAL namhocDAL = new NamHocDAL();
        LopHocDAL lophocDAL = new LopHocDAL();
        Lop_HocSinhDAL lop_hsDAL = new Lop_HocSinhDAL();
        QuyDinhDAL quydinhDAL = new QuyDinhDAL();
        MonHocDAL monhocDAL = new MonHocDAL();
        KetQuaHocTapDAL ketquahoctapDAL = new KetQuaHocTapDAL();
        DiemTrungBinhDAL diemtbDAL = new DiemTrungBinhDAL();

        DataTable DanhSachNamHoc = new DataTable();
        DataTable DanhSachLopHoc = new DataTable();

        int SoLuongMonHoc;

        public frmLenLop()
        {
            InitializeComponent();

            cbNamHocCu.DataSource = namhocDAL.layDanhSachNamHoc();
            cbNamHocCu.ValueMember = "MaNamHoc";
            cbNamHocMoi.DataSource = namhocDAL.layDanhSachNamHoc();
            cbNamHocMoi.ValueMember = "MaNamHoc";

            SoLuongMonHoc = monhocDAL.laySoLuongMonHoc();
        }

        private void frmLenLop_Load(object sender, EventArgs e)
        {
            cbNamHocMoi.Text = MACDINH.NamHocMacDinh;

            int index = cbNamHocMoi.SelectedIndex - 1;

            if (index <= 0)
                index = 0;

            cbNamHocCu.SelectedIndex = index;

            cbLopHocCu.DataSource = lophocDAL.layDanhSachLopTheoNamHoc(cbNamHocCu.Text);
            cbLopHocCu.ValueMember = "MaLopHoc";
            cbLopHocMoi.DataSource = lophocDAL.layDanhSachLopTheoNamHoc(cbNamHocMoi.Text);
            cbLopHocMoi.ValueMember = "MaLopHoc";

            // Khi vừa mở form lên mặc định là:
            // các combo box Năm học: hiện năm học trước và năm hiện tại
            // các combo box Lớp học: để trống để người dùng lựa chọn
            // nên các data gird view cũng trống.
            cbLopHocCu.Text = string.Empty;
            cbLopHocMoi.Text = string.Empty;

            dgvLopCu.DataSource = null;
            dgvLopMoi.DataSource = null;
        }

        private void btThayDoiLop_Click(object sender, EventArgs e)
        {
            if (cbLopHocCu.Text == string.Empty || cbLopHocMoi.Text == string.Empty)
            {
                MessageBox.Show("Error");

                return;
            }

            int SiSoToiDa = Convert.ToInt16(quydinhDAL.layQuyDinhSiSoToiDa().Rows[0]["GiaTriQuyDinh"].ToString());
            int SiSoLopCu = lophocDAL.laySiSoCuaLopHoc(cbNamHocCu.Text, cbLopHocCu.Text);
            int SiSoLopMoi = lophocDAL.laySiSoCuaLopHoc(cbNamHocMoi.Text, cbLopHocMoi.Text);

            if ( SiSoLopCu > SiSoToiDa - SiSoLopMoi)
            {
                MessageBox.Show("Không thể lên lớp! Lớp học mới không đủ chỗ trống để lên lớp!");

                return;
            }

            Lop_HocSinhBUS lop_hsBUS = new Lop_HocSinhBUS();
            DiemTrungBinhBUS diemtbBUS = new DiemTrungBinhBUS();
            
            foreach (DataRow dr in ((DataTable)dgvLopCu.DataSource).Rows)
            {                
                int maHocSinh = Convert.ToInt32(dr["MaHocSinh"].ToString());
                string maNamHoc = cbNamHocMoi.Text;

                // Mapping...
                Lop_HocSinhDTO lop_hsDTO = new Lop_HocSinhDTO();

                lop_hsDTO.MaNamHoc = maNamHoc;
                lop_hsDTO.MaLopHoc = cbLopHocMoi.Text;
                lop_hsDTO.MaHocSinh = maHocSinh;

                // BUS
                // Nếu học sinh đạt điểm trung bình cả năm trên 5.0 (của năm học trước)
                // thì được lên lớp.
                // Và phải đảm bảo đã có đủ điểm trung bình của tất cả các môn trong 2 học kỳ (của năm học trước)
                if (ketquahoctapDAL.laySoLuongKetQuaHocTapCuaMotHocSinh(cbNamHocCu.Text, maHocSinh) != SoLuongMonHoc * 2)
                {
                    continue;
                }

                if (diemtbBUS.isPassed(cbNamHocCu.Text, maHocSinh))
                {
                    // Nếu học sinh này đã được xếp lớp rồi thì bỏ qua
                    if (lop_hsBUS.isExists(lop_hsDTO))
                        continue;
                    else
                        lop_hsDAL.insert(lop_hsDTO); // DAL - Insert
                }

            }

            // Sau khi thực hiện thao tác lớp xong ta cập nhật lại sỉ số cho lớp mới tạo
            CapNhatLaiSiSo();

            // Đồng thờ cập nhật lại việc hiển thị danh sách học sinh từng lớp.
            refesh_DataGridView_LopHocMoi();
        }

        private void CapNhatLaiSiSo()
        {
            LopHocDTO lophocDTO = new LopHocDTO();

            lophocDTO.MaNamHoc = cbNamHocMoi.Text;
            lophocDTO.MaLopHoc = cbLopHocMoi.Text;
            lophocDTO.SiSo = lop_hsDAL.laySiSoCuaLop(cbNamHocMoi.Text, cbLopHocMoi.Text);

            lophocDAL.suaSiSoLop(lophocDTO);
        }

        // Hàm chủ yếu dùng để load lại data hiển thị trên grid view Lớp học mới sau khi:
        // đã thực hiện thao tác Lên lớp.
        private void refesh_DataGridView_LopHocMoi()
        {
            dgvLopMoi.DataSource = lop_hsDAL.layDanhSachHocSinhTheoNamHocVaLop(cbNamHocMoi.Text, cbLopHocMoi.Text);
        }

        // Sự kiện khi User chọn một item trên combo box Lớp học cũ
        private void cbLopHocCu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLopHocCu.Text != String.Empty)
            {
                dgvLopCu.DataSource = lop_hsDAL.layDanhSachHocSinhTheoNamHocVaLop(cbNamHocCu.Text, cbLopHocCu.Text);
            }
        }

        // Sự kiện khi User chọn một item trên combo box Lớp học mới
        private void cbLopHocMoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLopHocMoi.Text != String.Empty)
            {
                dgvLopMoi.DataSource = lop_hsDAL.layDanhSachHocSinhTheoNamHocVaLop(cbNamHocMoi.Text, cbLopHocMoi.Text);
            }
        }

        // Sự kiện khi User chọn một item trên combo box năm học mới
        // Khi năm học thay đổi cập nhật lại danh sách lớp học của năm học đó
        // đồng thời clear data grid view hiển thị lớp cũ
        private void cbNamHocCu_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbLopHocCu.DataSource = lophocDAL.layDanhSachLopTheoNamHoc(cbNamHocCu.Text);
            cbLopHocCu.ValueMember = "MaLopHoc";

            cbLopHocCu.Text = String.Empty;

            dgvLopCu.DataSource = null;
        }

        // Tương tự như của cbNamHocCu
        private void cbNamHocMoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbLopHocMoi.DataSource = lophocDAL.layDanhSachLopTheoNamHoc(cbNamHocMoi.Text);
            cbLopHocMoi.ValueMember = "MaLopHoc";

            cbLopHocMoi.Text = String.Empty;

            dgvLopMoi.DataSource = null;
        }

        private void dgvLopCu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //dgvLopCu.Rows[e.RowIndex].Selected = true;
        }

        private void dgvLopMoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //dgvLopMoi.Rows[e.RowIndex].Selected = true;
        }
    }
}
