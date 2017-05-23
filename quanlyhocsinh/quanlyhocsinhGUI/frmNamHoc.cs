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
        NamHocDAL namhocDAL = new NamHocDAL();
        NamHocMacDinhDAL namhocmacdinhDAL = new NamHocMacDinhDAL();

        public frmNamHoc()
        {
            InitializeComponent();
        }

        private void btChon_Click(object sender, EventArgs e)
        {
            NAMHOC.NamHocMacDinh = cbNamHocMacDinh.Text;

            /*
            // Mapping...
            NamHocMacDinhDTO namhocmacdinhDTO = new NamHocMacDinhDTO();

            namhocmacdinhDTO.MaThongSo = "NamHocMacDinh";
            namhocmacdinhDTO.GiaTriThongSo = cbNamHocMacDinh.Text;

            // DAL - Update
            namhocmacdinhDAL.update(namhocmacdinhDTO);
            */

            MessageBox.Show(NAMHOC.NamHocMacDinh);
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            // 1. Mapping...
            NamHocDTO namhocDTO = new NamHocDTO(tbMaNamHoc.Text, tbTenNamHoc.Text);

            // 2. BUS

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
            // Nếu chưa chọn năm học thì chưa thể xóa
            if (dgvDanhSachNamHoc.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chưa chọn năm học để xóa!");

                return;
            }

            // Mapping... học kỳ với năm học cần xóa
            HocKyDTO hocky = new HocKyDTO();

            hocky.MaNamHoc = tbMaNamHoc.Text;
            hocky.TenHocKy = "";
            hocky.MaHocKy = "";

            // Xoa nam hoc thi auto xoa 2 hoc ky trong nam hoc do
            HocKyDAL hockyDAL = new HocKyDAL();


            hockyDAL.delete(hocky);
            namhocDAL.delete(tbMaNamHoc.Text);
            
            refeshDataGridView();
        }

        private void frmNamHoc_Load(object sender, EventArgs e)
        {
            refeshDataGridView();
        }

        private void refeshDataGridView()
        {
            dgvDanhSachNamHoc.DataSource = namhocDAL.layDanhSachNamHocVaHocKy();

            cbNamHocMacDinh.DataSource = namhocDAL.layDanhSachNamHoc();
            cbNamHocMacDinh.ValueMember = "MaNamHoc";
        }

        private void dgvDanhSachNamHoc_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDanhSachNamHoc.SelectedRows.Count > 0)
            {
                tbMaNamHoc.Text = dgvDanhSachNamHoc.SelectedRows[0].Cells[0].Value.ToString();
                tbTenNamHoc.Text = dgvDanhSachNamHoc.SelectedRows[0].Cells[1].Value.ToString();
            }
        }
    }    
}
