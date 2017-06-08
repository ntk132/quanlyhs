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
    public partial class frmLapBaoCaoTongHop : Form
    {
        HocKyDAL hockyDAL = new HocKyDAL();
        MonHocDAL monhocDAL = new MonHocDAL();
        QuyDinhDAL quydinhDAL = new QuyDinhDAL();
        KetQuaHocTapDAL ketquahoctapDAL = new KetQuaHocTapDAL();
        DiemTrungBinhDAL diemtbDAL = new DiemTrungBinhDAL();

        public frmLapBaoCaoTongHop()
        {
            InitializeComponent();

            cbHocKy.DataSource = hockyDAL.layDanhSachHocKyTheoNamHoc(MACDINH.NamHocMacDinh);
            cbHocKy.ValueMember = "TenHocKy";
            cbMonHoc.DataSource = monhocDAL.layDanhSachMonHoc();
            cbMonHoc.ValueMember = "TenMonHoc";

            chbMonHoc.Checked = true;
        }

        private void btXemBaoCao_Click(object sender, EventArgs e)
        {
            // Mapping...
            string maHocKy = ((DataTable)cbHocKy.DataSource).Rows[cbHocKy.SelectedIndex]["MaHocKy"].ToString();
            int maMonHoc = Convert.ToInt16(((DataTable)cbMonHoc.DataSource).Rows[cbMonHoc.SelectedIndex]["MaMonHoc"].ToString());
            decimal diemToiThieuDat = Convert.ToDecimal(quydinhDAL.layQuyDinhDiemToiThieuDatMon().Rows[0]["GiaTriQuyDinh"].ToString().Replace(".", ","));

            // Nếu User chọn vào check box Môn học
            // Thì xuất ra báo cáo môn học(được chọn) của học kỳ đó
            if (chbMonHoc.Checked)
            {
                dgvBaoCao.DataSource = ketquahoctapDAL.xuatBaoCaoTongKetMonHoc(MACDINH.NamHocMacDinh, maHocKy, maMonHoc, diemToiThieuDat);
            }
                // Ngược lại, xuất ra báo cáo tổng hợp học kỳ đó
            else
            {
                string index = string.Empty;
                
                if (cbHocKy.SelectedIndex == 0)
                    index = "1";
                else
                    index = "2";

                dgvBaoCao.DataSource = diemtbDAL.xuatBaoCaoTongKetHocKy(MACDINH.NamHocMacDinh, index, diemToiThieuDat);
            }
        }

        private void chbMonHoc_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMonHoc.Checked)
            {
                cbMonHoc.Enabled = true;
            }
            else
            {
                cbMonHoc.Enabled = false;
            }
        }

        private void dgvBaoCao_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBaoCao.CurrentCell.RowIndex > dgvBaoCao.Rows.Count - 2)
            {
                return;
            }
        }
    }
}
