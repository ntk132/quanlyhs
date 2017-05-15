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
    public partial class frmDemoBangDiem : Form
    {
        KetQuaHocTapDAL kqdal = new KetQuaHocTapDAL();

        LopHocDAL lhdal = new LopHocDAL();
        MonHocDAL mhdal = new MonHocDAL();
        HocKyDAL hkdal = new HocKyDAL();
        QuyDinhDAL qddal = new QuyDinhDAL();

        float DiemToiThieuDeQuaMon = 0;

        public frmDemoBangDiem()
        {
            InitializeComponent();

            initDataSourceForComboBoxes();

            //cbLopHoc.Text = "";
            //cbMonHoc.Text = "";
            //cbHocKy.Text = "";

            //DiemToiThieuDeQuaMon = qddal.layQuyDinhTheoaQD("DIEM_TOI_THIEU_DAT");
        }

        // Khai báo datasource của các ô tìm kiếm.
        private void initDataSourceForComboBoxes()
        {
            cbLopHoc.DataSource = lhdal.layDanhSachLop();
            cbLopHoc.ValueMember = "MaLopHoc";
            cbMonHoc.DataSource = mhdal.layDanhSachMonHoc();
            cbMonHoc.ValueMember = "TenMonHoc";
            cbHocKy.DataSource = hkdal.layDanhSachHocKy();
            cbHocKy.ValueMember = "TenHocKy";
        }

        // Hàm tìm kiếm học sinh
        private void btTimKiem_Click(object sender, EventArgs e)
        {
            DataRow drMaMon = (DataRow)cbMonHoc.SelectedItem;
            DataRow drMaHK = (DataRow)cbHocKy.SelectedItem;

            // Nếu như người dùng chưa nhập hoặc nhập thiếu vào các ô filter
            // Gửi thông báo phản hồi và dừng tìm kiếm.
            if (cbLopHoc.Text == String.Empty || cbMonHoc.Text == String.Empty || cbHocKy.Text == String.Empty)
            {
                MessageBox.Show("Dữ liệu lọc chưa đầy đủ! Vui lòng thử lại!");

                return;
            }

            dgvKetQuaTimKiem.DataSource = kqdal.layDanhSachHocSinh(cbLopHoc.Text, cbMonHoc.SelectedIndex, cbHocKy.Text);
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (dgvKetQuaTimKiem.SelectedRows.Count < 0)
            {
                MessageBox.Show("Chưa chọn học sinh để xử lí!");
            }

            // Mapping...
            KetQuaHocTapDTO ketqua = mappingProperties();

            // DAL - Insert
            kqdal.insert(ketqua);
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (dgvKetQuaTimKiem.SelectedRows.Count < 0)
            {
                MessageBox.Show("Chưa chọn học sinh để xử lí!");
            }

            // Mapping...
            KetQuaHocTapDTO ketqua = mappingProperties();

            // DAL - Update
            kqdal.update(ketqua);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {

        }

        private void dgvKetQuaTimKiem_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKetQuaTimKiem.SelectedRows.Count > 0)
            {
                lbHoTen.Text = dgvKetQuaTimKiem.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        // Kết nối các dữ liệu trên form gắn vào đối tượng KetQuaHocTapDTO
        // để xử lí các thao tác: insert, update,...
        private KetQuaHocTapDTO mappingProperties()
        {
            DataRow drMaMon = (DataRow)cbMonHoc.SelectedItem;
            DataRow drMaHK = (DataRow)cbHocKy.SelectedItem;

            // Mapping...
            KetQuaHocTapDTO ketqua = new KetQuaHocTapDTO();

            float diem15p = (float)Convert.ToDouble(tbDiem15Phut.Text);
            float diem1t = (float)Convert.ToDouble(tbDiem1Tiet.Text);
            float diemtb = (float)Convert.ToDouble(tbĐiemTB.Text);

            ketqua.MaHocKy = drMaHK["MaHocKy"].ToString();
            ketqua.MaMonHoc = Convert.ToInt32(drMaMon["MaMonHoc"].ToString());
            ketqua.MaHocSinh = (int)dgvKetQuaTimKiem.SelectedRows[0].Cells[0].Value;
            ketqua.Diem15Phut = diem15p;
            ketqua.Diem1Tiet = diem1t;
            ketqua.DiemTB = diemtb;

            if (diemtb >= DiemToiThieuDeQuaMon)
            {
                ketqua.CoDatHayKhong = true;
            }
            else
                ketqua.CoDatHayKhong = false;

            return ketqua;
        }
    }
}
