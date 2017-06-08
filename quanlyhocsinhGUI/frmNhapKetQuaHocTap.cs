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
    public partial class frmNhapKetQuaHocTap : Form
    {
        HocKyDAL hockyDAL = new HocKyDAL();
        LopHocDAL lophocDAL = new LopHocDAL();

        QuyDinhDAL quydinhDAL = new QuyDinhDAL();
        MonHocDAL monhocDAL = new MonHocDAL();
        KetQuaHocTapDAL ketquaDAL = new KetQuaHocTapDAL();
        KetQuaHocTapBUS ketquaBUS = new KetQuaHocTapBUS();

        private decimal diemdatmon;

        public frmNhapKetQuaHocTap()
        {
            InitializeComponent();

            dgvDanhSachHocSinh.MultiSelect = false;
            dgvDanhSachHocSinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            cbHocKy.DataSource = hockyDAL.layDanhSachHocKyTheoNamHoc(MACDINH.NamHocMacDinh);
            cbHocKy.ValueMember = "TenHocKy";
            cbLopHoc.DataSource = lophocDAL.layDanhSachLopTheoNamHoc(MACDINH.NamHocMacDinh);
            cbLopHoc.ValueMember = "MaLopHoc";
            cbMonHoc.DataSource = monhocDAL.layDanhSachMonHoc();
            cbMonHoc.ValueMember = "TenMonHoc";

            tbDiemTB.Enabled = false;

            tbDiem15p.Enabled = false;
            tbDiem1t.Enabled = false;

            diemdatmon = Convert.ToDecimal(quydinhDAL.layQuyDinhDiemToiThieuDatMon().Rows[0]["GiaTriQuyDinh"].ToString());
        }

        private void btChon_Click(object sender, EventArgs e)
        {
            tbDiem15p.Enabled = false;
            tbDiem1t.Enabled = false;

            dgvDanhSachHocSinh.DataSource = ketquaDAL.layDanhSachHS_QLDiem(MACDINH.NamHocMacDinh, cbLopHoc.Text);
            dgvDanhSachHocSinh.MultiSelect = false;
        }

        private void btLuuDiem_Click(object sender, EventArgs e)
        {
            // Nếu chưa chọn học sinh thì
            // Không thể thực hiện thao tác nhập điểm
            if (dgvDanhSachHocSinh.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chưa chọn học sinh để nhập điểm!");

                return;
            }

            decimal diem15p = Convert.ToDecimal(tbDiem15p.Text);
            decimal diem1t = Convert.ToDecimal(tbDiem1t.Text);
            decimal diemtb = (diem15p + diem1t * 2) / 3;

            // Kiểm tra các cột điểm nhập vào có đúng quy đinh hay không:
            // 0 <= Điểm số <= 10
            // Kiểm tra ở cột điểm 15 phút
            if (diem15p < 0 || diem15p > 10)
            {
                MessageBox.Show("Nhập sai! Điểm số chỉ thuộc: 0 <= Điểm <= 10");

                tbDiem15p.Focus();

                return;
            }

            // Kiểm tra ở cột điểm 1 tiết 
            if (diem1t < 0 || diem1t > 10)
            {
                MessageBox.Show("Nhập sai! Điểm số chỉ thuộc: 0 <= Điểm <= 10");

                tbDiem1t.Focus();

                return;
            }

            tbDiemTB.Text = String.Format("{0:0.00}", diemtb);            

            KetQuaHocTapDTO ketquaDTO = new KetQuaHocTapDTO();

            DataTable dt = hockyDAL.layDanhSachHocKyTheoNamHoc(MACDINH.NamHocMacDinh);

            // Mapping...
            ketquaDTO.MaHocKy = dt.Rows[cbHocKy.SelectedIndex][0].ToString();
            ketquaDTO.MaMonHoc = Convert.ToInt16(((DataTable)cbMonHoc.DataSource).Rows[cbMonHoc.SelectedIndex]["MaMonHoc"].ToString());
            ketquaDTO.MaHocSinh = Convert.ToInt32(dgvDanhSachHocSinh.SelectedRows[0].Cells[0].Value);
            ketquaDTO.Diem15Phut = diem15p;
            ketquaDTO.Diem1Tiet = diem1t;
            ketquaDTO.DiemTB = diemtb;
            ketquaDTO.DiemToiThieuDat = diemdatmon;

            if (diemtb >= diemdatmon)
            {
                ketquaDTO.CoDatHayKhong = 1;
            }
            else
            {
                ketquaDTO.CoDatHayKhong = 0;
            }

            // BUS
            if (ketquaBUS.isExists(ketquaDTO))
            {
                // Nếu bảng điểm của học sinh này đã tồn tại
                // Thực hiện thoa tác cập nhật
                // DAL - Update
                ketquaDAL.update(ketquaDTO);
            }
            else
            {
                // Ngược lại thì tạo mới bảng điểm
                // với data đã nhập từ User
                // DAL - Insert
                ketquaDAL.insert(ketquaDTO);
            }

            // Khi cập nhật điểm thành công
            // Mặ định là cập nhật lại điểm trung bình
            CapNhatLaiDiemTrungBinh(ketquaDTO);

            tbDiem15p.Enabled = false;
            tbDiem1t.Enabled = false;
        }

        private decimal lamTronSo(double d, int somu)
        {
            double empty = Math.Pow(10, somu);
            int temp = (int)(Math.Round(d, somu) * empty);
            d = temp / empty;
            
            string temp1 = String.Format("{0:0.00}", d);

            return Convert.ToDecimal(temp1);
        }

        private void CapNhatLaiDiemTrungBinh(KetQuaHocTapDTO kqDTO)
        {
            // Cập nhật lại điểm trung bình môn
            decimal value = ketquaDAL.tinhDiemTBTuSoMonDaCoDiem(kqDTO);

            DiemTrungBinhDAL diemtbDAL = new DiemTrungBinhDAL();
            DiemTrungBinhBUS diemtbBUS = new DiemTrungBinhBUS();
            DiemTrungBinhDTO diemtbDTO = new DiemTrungBinhDTO();

            diemtbDTO.MaNamHoc = MACDINH.NamHocMacDinh;
            diemtbDTO.MaHocSinh = kqDTO.MaHocSinh;
            diemtbDTO.DiemTrungBinhHK1 = 0;
            diemtbDTO.DiemTrungBinhHK2 = 0;
            diemtbDTO.DiemTrungBinhHKNam = 0;

            // BUS
            // Nếu bảng điểm chưa ttonf tại thì tạo mới
            if (!diemtbBUS.isExists(diemtbDTO))
            {
                diemtbDAL.insert(diemtbDTO);
            }

            // Mapping...

            // Nếu điểm nhập vào là học kỳ 1
            if (cbHocKy.SelectedIndex == 0)
            {
                diemtbDTO.DiemTrungBinhHK1 = value;

                diemtbDAL.CapNhatDiemTBHK1(diemtbDTO);
            }                
            else // Ngược lại thì điểm nhập vào là học kỳ 2
            {
                diemtbDTO.DiemTrungBinhHK2 = value;

                diemtbDAL.CapNhatDiemTBHK2(diemtbDTO);
            }
            
            // Sau khi cập nhật điểm trung bình một học kỳ
            // thì cập nhật lại điểm trung bình cả năm học
            diemtbDTO.DiemTrungBinhHKNam = diemtbDAL.tinhDiemTrungBinhNamHoc(diemtbDTO);

            // Cuối cùng là cập nhật lại bảng điểm trung bình
            diemtbDAL.update(diemtbDTO);
        }

        private void dgvDanhSachHocSinh_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDanhSachHocSinh.CurrentRow.Index > dgvDanhSachHocSinh.Rows.Count)
            {
                MessageBox.Show("Đây không phải hàng dữ liệu! Vui lòng chọn lại!");

                return;
            }

            // Sự kiện này xảy ra khi User chọn một học sinh khác để nhập điểm
            // Các ô điểm sẽ được làm trống và mặc định bắt đầu từ điểm 15 phút
            if (dgvDanhSachHocSinh.SelectedRows.Count <= 0)
            {
                return;
            }
            else
            {
                string maHocKy = hockyDAL.layDanhSachHocKyTheoNamHoc(MACDINH.NamHocMacDinh).Rows[cbHocKy.SelectedIndex]["MaHocKy"].ToString();
                string maLopHoc = cbLopHoc.Text;
                int maMonHoc = Convert.ToInt16(((DataTable)cbMonHoc.DataSource).Rows[cbMonHoc.SelectedIndex]["MaMonHoc"].ToString());
                int maHocSinh = Convert.ToInt32(dgvDanhSachHocSinh.SelectedRows[0].Cells["MaHocSinh"].Value);

                DataTable dt = ketquaDAL.xemDiemCuaHocSinh(maHocKy, maLopHoc, maMonHoc, maHocSinh);

                if (dt.Rows.Count <= 0)
                {
                    tbDiem15p.Text = string.Empty;
                    tbDiem1t.Text = string.Empty;
                    tbDiemTB.Text = string.Empty;
                }
                else
                {
                    tbDiem15p.Text = dt.Rows[0]["Diem15Phut"].ToString();
                    tbDiem1t.Text = dt.Rows[0]["Diem1Tiet"].ToString();
                    tbDiemTB.Text = dt.Rows[0]["DiemTB"].ToString();
                };

                tbDiem15p.Enabled = true;
                tbDiem1t.Enabled = true;

                tbDiem15p.Focus();
            }
        }

        private void frmNhapKetQuaHocTap_Load(object sender, EventArgs e)
        {
            // Mắc định là khi load form lần đầu thì các ô filter sẽ để trống
            // để tùy ý lọc của User
            cbHocKy.Text = String.Empty;
            cbLopHoc.Text = String.Empty;
            cbMonHoc.Text = String.Empty;
        }

        private void dgvDanhSachHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDanhSachHocSinh.Rows[e.RowIndex].Selected = true;
        }
    }
}
