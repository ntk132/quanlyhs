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

        DataTable DanhSachNamHoc = new DataTable();
        DataTable DanhSachLopHoc = new DataTable();

        public frmLenLop()
        {
            InitializeComponent();

            cbNamHocCu.DataSource = namhocDAL.layDanhSachNamHoc();
            cbNamHocCu.ValueMember = "MaNamHoc";
            cbNamHocMoi.DataSource = namhocDAL.layDanhSachNamHoc();
            cbNamHocMoi.ValueMember = "MaNamHoc";
                      
        }

        private void frmLenLop_Load(object sender, EventArgs e)
        {
            cbNamHocMoi.Text = NAMHOC.NamHocMacDinh;

            int index = cbNamHocMoi.SelectedIndex - 1;

            if (index <= 0)
                index = 0;

            cbNamHocCu.SelectedIndex = index;

            cbLopHocCu.DataSource = lophocDAL.layDanhSachLopTheoNamHoc(cbNamHocCu.Text);
            cbLopHocCu.ValueMember = "MaLopHoc";
            cbLopHocMoi.DataSource = lophocDAL.layDanhSachLopTheoNamHoc(cbNamHocMoi.Text);
            cbLopHocMoi.ValueMember = "MaLopHoc";  
        }

        private void btThayDoiLop_Click(object sender, EventArgs e)
        {
            Lop_HocSinhBUS lop_hsBUS = new Lop_HocSinhBUS();
            
            foreach (DataRow dr in ((DataTable)dgvLopCu.DataSource).Rows)
            {                
                int maHocSinh = Convert.ToInt32(dr["MaHocSinh"].ToString());
                string maNamHoc = cbNamHocMoi.Text;

                // Mapping...
                Lop_HocSinhDTO lop_hsDTO = new Lop_HocSinhDTO();

                lop_hsDTO.MaNamHoc = maNamHoc;
                lop_hsDTO.MaLopHoc = cbLopHocMoi.Text;
                lop_hsDTO.MaHocSinh = maHocSinh;

                // Nếu học sinh đạt tất cả các môn (của năm học trước)
                // thì được lên lớp.
                if (lop_hsBUS.isPassedAllSubject(maNamHoc, maHocSinh))
                {
                    lop_hsDAL.insert(lop_hsDTO);
                }

            }

            refesh_DataGridView_LopHocMoi();
        }

        private void refesh_DataGridView_LopHocMoi()
        {
            dgvLopMoi.DataSource = lop_hsDAL.layDanhSachHocSinhTheoNamHocVaLop(cbNamHocMoi.Text, cbLopHocMoi.Text);
        }

        private void cbLopHocCu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLopHocCu.Text != String.Empty)
            {
                dgvLopCu.DataSource = lop_hsDAL.layDanhSachHocSinhTheoNamHocVaLop(cbNamHocCu.Text, cbLopHocCu.Text);
            }
        }

        private void cbLopHocMoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLopHocMoi.Text != String.Empty)
            {
                dgvLopMoi.DataSource = lop_hsDAL.layDanhSachHocSinhTheoNamHocVaLop(cbNamHocMoi.Text, cbLopHocMoi.Text);
            }
        }

        private void cbNamHocCu_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbLopHocCu.DataSource = lophocDAL.layDanhSachLopTheoNamHoc(cbNamHocCu.Text);
            cbLopHocCu.ValueMember = "MaLopHoc";

            cbLopHocCu.Text = "";
        }

        private void cbNamHocMoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbLopHocMoi.DataSource = lophocDAL.layDanhSachLopTheoNamHoc(cbNamHocMoi.Text);
            cbLopHocMoi.ValueMember = "MaLopHoc";

            cbLopHocMoi.Text = "";
        }
    }
}
