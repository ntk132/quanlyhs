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
    public partial class frmThayDoiQuyDinh : Form
    {
        DataAccess da = new DataAccess();
        QuyDinhDAL quydinhDAL = new QuyDinhDAL();
        MonHocDAL monhocDAL = new MonHocDAL();
        MonHocBUS monhocBUS = new MonHocBUS();
        KhoiLopDAL khoilopDAL = new KhoiLopDAL();
        ThongSoMacDinhDAL thongsomacdinhDAL = new ThongSoMacDinhDAL();

        private string TuoiToiDa;
        private string TuoiToiThieu;
        private string SiSoToiDa;
        private string DiemToiThieuDatMon;
        private string SoLuongLopKhoi10;
        private string SoLuongLopKhoi11;
        private string SoLuongLopKhoi12;

        private string strMaMonHoc;
        private string strTenMonHoc;

        public frmThayDoiQuyDinh()
        {
            InitializeComponent();

            dgvMonHoc.MultiSelect = false;
        }

        private void frmThayDoiQuyDinh_Load(object sender, EventArgs e)
        {
            dgvMonHoc.DataSource = monhocDAL.layDanhSachMonHoc();

            TuoiToiThieu = thongsomacdinhDAL.layThongSoMacDinh("TuoiToiThieu").Rows[0]["GiaTriThongSo"].ToString();
            TuoiToiDa = thongsomacdinhDAL.layThongSoMacDinh("TuoiToiDa").Rows[0]["GiaTriThongSo"].ToString();
            SiSoToiDa = thongsomacdinhDAL.layThongSoMacDinh("SiSoToiDa").Rows[0]["GiaTriThongSo"].ToString();
            DiemToiThieuDatMon = thongsomacdinhDAL.layThongSoMacDinh("DiemToiThieuDat").Rows[0]["GiaTriThongSo"].ToString();
            SoLuongLopKhoi10 = thongsomacdinhDAL.layThongSoMacDinh("SoLuongLopKhoi10").Rows[0]["GiaTriThongSo"].ToString();
            SoLuongLopKhoi11 = thongsomacdinhDAL.layThongSoMacDinh("SoLuongLopKhoi11").Rows[0]["GiaTriThongSo"].ToString();
            SoLuongLopKhoi12 = thongsomacdinhDAL.layThongSoMacDinh("SoLuongLopKhoi12").Rows[0]["GiaTriThongSo"].ToString();

            tbTuoiToiThieu.Text = quydinhDAL.layQuyDinhTuoiToiThieu().Rows[0]["GiaTriQuyDinh"].ToString();
            tbTuoiToiDa.Text = quydinhDAL.layQuyDinhTuoiToiDa().Rows[0]["GiaTriQuyDinh"].ToString();
            tbSiSiToiDa.Text = quydinhDAL.layQuyDinhSiSoToiDa().Rows[0]["GiaTriQuyDinh"].ToString();
            tbDiemDatMon.Text = quydinhDAL.layQuyDinhDiemToiThieuDatMon().Rows[0]["GiaTriQuyDinh"].ToString();
            tbSiSoK10.Text = khoilopDAL.laySoLopToiDaTrongMotKhoi("K10").ToString();
            tbSiSoK11.Text = khoilopDAL.laySoLopToiDaTrongMotKhoi("K11").ToString();
            tbSiSoK12.Text = khoilopDAL.laySoLopToiDaTrongMotKhoi("K12").ToString();
        }

        private void btLuuThayDoiQD_Click(object sender, EventArgs e)
        {
            isFullInformation();

            // Mapping...
            QuyDinhDTO qdTuoiToiThieu = new QuyDinhDTO(1, tbTuoiToiThieu.Text);
            QuyDinhDTO qdTuoiToiDa = new QuyDinhDTO(2, tbTuoiToiDa.Text);
            QuyDinhDTO qdSiSoToiDa = new QuyDinhDTO(3, tbSiSiToiDa.Text);
            QuyDinhDTO qdDiemDatMon = new QuyDinhDTO(4, tbDiemDatMon.Text);
            KhoiLopDTO qdSoLopKhoi10 = new KhoiLopDTO("K10", "", Convert.ToInt16(tbSiSoK10.Text));
            KhoiLopDTO qdSoLopKhoi11 = new KhoiLopDTO("K11", "", Convert.ToInt16(tbSiSoK11.Text));
            KhoiLopDTO qdSoLopKhoi12 = new KhoiLopDTO("K12", "", Convert.ToInt16(tbSiSoK12.Text));

            // DAL - Update
            // Tuổi tối thiểu
            if (tbTuoiToiThieu.Text != TuoiToiThieu)
            {
                quydinhDAL.update(qdTuoiToiThieu);
            }

            // Tuổi tối đa
            if (tbTuoiToiDa.Text != TuoiToiDa)
            {
                quydinhDAL.update(qdTuoiToiDa);
            }

            // Sỉ số tối đa
            if (tbSiSiToiDa.Text != SiSoToiDa)
            {
                quydinhDAL.update(qdSiSoToiDa);
            }

            // Điểm tối thiểu để đạt môn
            if (tbDiemDatMon.Text != DiemToiThieuDatMon)
            {
                quydinhDAL.update(qdDiemDatMon);
            }

            // K10
            if (tbSiSoK10.Text != SoLuongLopKhoi10)
            {
                khoilopDAL.update(qdSoLopKhoi10);
            }

            // K11
            if (tbSiSoK11.Text != SoLuongLopKhoi10)
            {
                khoilopDAL.update(qdSoLopKhoi11);
            }

            // K12
            if (tbSiSoK12.Text != SoLuongLopKhoi10)
            {
                khoilopDAL.update(qdSoLopKhoi12);
            }
        }

        private void isFullInformation()
        {
            if (tbTuoiToiThieu.Text == string.Empty)
            {
                MessageBox.Show("Error");

                tbTuoiToiThieu.Focus();

                return;
            }

            if (tbTuoiToiDa.Text == string.Empty)
            {
                MessageBox.Show("Error");

                tbTuoiToiDa.Focus();

                return;
            }

            if (tbSiSiToiDa.Text == string.Empty)
            {
                MessageBox.Show("Error");

                tbSiSiToiDa.Focus();

                return;
            }

            if (tbDiemDatMon.Text == string.Empty)
            {
                MessageBox.Show("Error");

                tbDiemDatMon.Focus();

                return;
            }

            if (tbSiSoK10.Text == string.Empty)
            {
                MessageBox.Show("Error");

                tbSiSoK10.Focus();

                return;
            }

            if (tbSiSoK11.Text == string.Empty)
            {
                MessageBox.Show("Error");

                tbSiSoK11.Focus();

                return;
            }

            if (tbSiSoK12.Text == string.Empty)
            {
                MessageBox.Show("Error");

                tbSiSoK12.Focus();

                return;
            }
        }

        private void btHuyThayDoiQD_Click(object sender, EventArgs e)
        {
            tbTuoiToiThieu.Text = TuoiToiThieu;
            tbTuoiToiDa.Text = TuoiToiDa;
            tbSiSiToiDa.Text = SiSoToiDa;
            tbDiemDatMon.Text = DiemToiThieuDatMon;
            tbSiSoK10.Text = SoLuongLopKhoi10;
            tbSiSoK11.Text = SoLuongLopKhoi11;
            tbSiSoK12.Text = SoLuongLopKhoi12;

            tbTenMon.Clear();
        }

        private void dgvMonHoc_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMonHoc.SelectedRows.Count > 0)
            {
                strTenMonHoc = dgvMonHoc.SelectedRows[0].Cells[1].Value.ToString();

                tbTenMon.Text = strTenMonHoc;
            }
        }

        private void btThemMon_Click(object sender, EventArgs e)
        {
            if (tbTenMon.Text == string.Empty)
            {
                MessageBox.Show("Thiếu tên môn học! Vui lòng thử lại!");

                tbTenMon.Focus();

                return;
            }


            // Mapping...
            MonHocDTO monhocDTO = new MonHocDTO();

            monhocDTO.TenMonHoc = tbTenMon.Text;

            // BUS - Test

            // DAL - Insert
            monhocDAL.insert(monhocDTO);

            dgvMonHoc.DataSource = monhocDAL.layDanhSachMonHoc();
            dgvMonHoc.MultiSelect = false;
        }

        private void btSuaMon_Click(object sender, EventArgs e)
        {
            if (dgvMonHoc.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chưa chọn môn để sửa!");

                return;
            }

            // Mapping...
            MonHocDTO monhocDTO = new MonHocDTO();

            monhocDTO.TenMonHoc = tbTenMon.Text;

            // DAL - Update
            monhocDAL.update(monhocDTO);

            dgvMonHoc.DataSource = monhocDAL.layDanhSachMonHoc();
            dgvMonHoc.MultiSelect = false;
        }

        private void btXoaMon_Click(object sender, EventArgs e)
        {
            if (dgvMonHoc.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chưa chọn môn để xóa!");

                return;
            }

            // Mapping...
            MonHocDTO monhocDTO = new MonHocDTO();

            monhocDTO.TenMonHoc = tbTenMon.Text;

            // DAL - Delete
            // Do Bảng MONHOC có khóa ngoại trên bảng KETQUAHOCTAP
            // Nên phải xóa trên bảng KETQUAHOCTAP trước
            KetQuaHocTapDAL ketquaDAL = new KetQuaHocTapDAL();

            ketquaDAL.xoaKetQuaTrongMotMon(monhocDTO.MaMonHoc);
            monhocDAL.delete(monhocDTO.MaMonHoc);

            dgvMonHoc.DataSource = monhocDAL.layDanhSachMonHoc();
            dgvMonHoc.MultiSelect = false;
        }

        private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvMonHoc.Rows[e.RowIndex].Selected = true;
        }
    }
}
