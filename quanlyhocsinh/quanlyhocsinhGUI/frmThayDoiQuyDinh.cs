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
        QuyDinhDAL qddal = new QuyDinhDAL();
        MonHocDAL mhdal = new MonHocDAL();

        public frmThayDoiQuyDinh()
        {
            InitializeComponent();
        }

        private void frmThayDoiQuyDinh_Load(object sender, EventArgs e)
        {
            dgvMonHoc.DataSource = mhdal.layDanhSachMonHoc();

            tbTuoiToiThieu.Text = layDuLieuTuBangQuyDinh("TUOI_TOI_THIEU");
            tbTuoiToiDa.Text = layDuLieuTuBangQuyDinh("TUOI_TOI_DA");
            tbSiSiToiDa.Text = layDuLieuTuBangQuyDinh("SI_SO_TOI_DA");
            tbDiemDatMon.Text = layDuLieuTuBangQuyDinh("DIEM_TOI_THIEU_DE_DAT");
        }

        private string layDuLieuTuBangQuyDinh(string maqd)
        {
            DataRow dr = qddal.layQuyDinhTheoMaQD(maqd).Rows[0];

            return dr["GiaTriQuyDinh"].ToString();
        }

        private void btLuuThayDoiQD_Click(object sender, EventArgs e)
        {

        }

        private void btHuyThayDoiQD_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvMonHoc_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMonHoc.SelectedRows.Count > 0)
            {
                tbMaMon.Text = dgvMonHoc.SelectedRows[0].Cells[0].Value.ToString();
                tbTenMon.Text = dgvMonHoc.SelectedRows[0].Cells[1].Value.ToString();
            }
        }
    }
}
