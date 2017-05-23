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

        private string TuoiToiDa;
        private string TuoiToiThieu;
        private string SiSoToiDa;
        private string DiemToiThieuDatMon;

        public frmThayDoiQuyDinh()
        {
            InitializeComponent();
        }

        private void frmThayDoiQuyDinh_Load(object sender, EventArgs e)
        {
            dgvMonHoc.DataSource = monhocDAL.layDanhSachMonHoc();

            TuoiToiThieu = quydinhDAL.layQuyDinhTuoiToiThieu().Rows[0]["GiaTriQuyDinh"].ToString();
            TuoiToiDa = quydinhDAL.layQuyDinhTuoiToiDa().Rows[0]["GiaTriQuyDinh"].ToString();
            SiSoToiDa = quydinhDAL.layQuyDinhSiSoToiDa().Rows[0]["GiaTriQuyDinh"].ToString();
            DiemToiThieuDatMon = quydinhDAL.layQuyDinhDiemToiThieuDatMon().Rows[0]["GiaTriQuyDinh"].ToString();

            tbTuoiToiThieu.Text = TuoiToiThieu;
            tbTuoiToiDa.Text = TuoiToiDa;
            tbSiSiToiDa.Text = SiSoToiDa;
            tbDiemDatMon.Text = DiemToiThieuDatMon;
        }

        private void btLuuThayDoiQD_Click(object sender, EventArgs e)
        {
            // Mapping...
            QuyDinhDTO qdTuoiToiThieu = new QuyDinhDTO(1, tbTuoiToiThieu.Text);
            QuyDinhDTO qdTuoiToiDa = new QuyDinhDTO(2, tbTuoiToiDa.Text);
            QuyDinhDTO qdSiSoToiDa = new QuyDinhDTO(3, tbSiSiToiDa.Text);
            QuyDinhDTO qdDiemDatMon = new QuyDinhDTO(4, tbDiemDatMon.Text);
            MonHocDTO monhoc = new MonHocDTO(Convert.ToInt16(tbMaMon.Text), tbTenMon.Text);

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

            // Môn học
            if (tbTenMon.Text != string.Empty)
            {
                monhocDAL.update(monhoc);
            }
        }

        private void btHuyThayDoiQD_Click(object sender, EventArgs e)
        {
            tbTuoiToiThieu.Text = TuoiToiThieu;
            tbTuoiToiDa.Text = TuoiToiDa;
            tbSiSiToiDa.Text = SiSoToiDa;
            tbDiemDatMon.Text = DiemToiThieuDatMon;

            tbMaMon.Clear();
            tbTenMon.Clear();
        }

        private void dgvMonHoc_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMonHoc.SelectedRows.Count > 0)
            {
                tbMaMon.Text = dgvMonHoc.SelectedRows[0].Cells[0].Value.ToString();
                tbTenMon.Text = dgvMonHoc.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void btThemMon_Click(object sender, EventArgs e)
        {
            // Mapping...
            MonHocDTO monhocDTO = new MonHocDTO();

            monhocDTO.MaMonHoc = Convert.ToInt16(tbMaMon.Text);
            monhocDTO.TenMonHoc = tbTenMon.Text;

            // BUS - Test
            if (monhocBUS.isMatching(monhocDTO))
            {
                MessageBox.Show("Trùng mã môn học, thao tác không thể thực hiện!");

                tbMaMon.Focus();

                return;
            }

            // DAL - Insert
            monhocDAL.insert(monhocDTO);
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

            monhocDTO.MaMonHoc = Convert.ToInt16(tbMaMon.Text);
            monhocDTO.TenMonHoc = tbTenMon.Text;

            // DAL - Update
            monhocDAL.update(monhocDTO);
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

            monhocDTO.MaMonHoc = Convert.ToInt16(tbMaMon.Text);
            monhocDTO.TenMonHoc = tbTenMon.Text;

            // DAL - Delete
            monhocDAL.delete(Convert.ToInt16(monhocDTO.MaMonHoc));
        }
    }
}
