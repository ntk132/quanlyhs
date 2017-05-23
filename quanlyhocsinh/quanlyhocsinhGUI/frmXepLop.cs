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

namespace quanlyhocsinhGUI
{
    public partial class frmXepLop : Form
    {
        LopHocDAL lophocDAL = new LopHocDAL();
        Lop_HocSinhDAL lop_hsDAL = new Lop_HocSinhDAL();

        public frmXepLop()
        {
            InitializeComponent();

            
            cbLopHocCu.DataSource = lophocDAL.layDanhSachLopTheoNamHoc(NAMHOC.NamHocMacDinh);
            cbLopHocCu.ValueMember = "MaLopHoc";
            
            cbLopHocMoi.DataSource = lophocDAL.layDanhSachLopTheoNamHoc(NAMHOC.NamHocMacDinh);
            cbLopHocMoi.ValueMember = "MaLopHoc";

            chbxChuaCoLop.Checked = true;
        }

        private void frmXepLop_Load(object sender, EventArgs e)
        {
            cbLopHocCu.Text = "";
            cbLopHocMoi.Text = "";
        }

        private void btThayDoiLop_Click(object sender, EventArgs e)
        {
            if (dgvLopCu.SelectedRows.Count < 0)
            {
                MessageBox.Show("Chưa chọn học sinh để chuyển lớp!");

                return;
            }

            for (int i = 0; i < dgvLopCu.SelectedRows.Count; i++)
            {
                // Mapping...
                Lop_HocSinhDTO lop_hsDTO = new Lop_HocSinhDTO();

                lop_hsDTO.MaNamHoc = NAMHOC.NamHocMacDinh;
                lop_hsDTO.MaLopHoc = cbLopHocMoi.Text;
                lop_hsDTO.MaHocSinh = Convert.ToInt32(dgvLopCu.SelectedRows[i].Cells[0].Value);

                // DAL
                if (chbxChuaCoLop.Checked)
                {
                    // Insert
                    lop_hsDAL.insert(lop_hsDTO);
                }
                else
                {
                    // Update
                    lop_hsDAL.update(lop_hsDTO);
                }
                
            }

            if (chbxChuaCoLop.Checked)
            {
                layDanhSachHocSinhChuaCoLop();
            }
            else
            {
                refesh_DataGridView_LopCu();
            }
            
            refesh_DataGridView_LopMoi();
        }

        private void cbLopHocCu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLopHocCu.Text != String.Empty)
            {
                refesh_DataGridView_LopCu();
            }
        }

        private void cbLopHocMoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLopHocMoi.Text != String.Empty)
            {
                refesh_DataGridView_LopMoi();
            }
        }

        private void refesh_DataGridView_LopCu()
        {
            dgvLopCu.DataSource = lop_hsDAL.layDanhSachHocSinhTheoNamHocVaLop(NAMHOC.NamHocMacDinh, cbLopHocCu.Text);
        }

        private void refesh_DataGridView_LopMoi()
        {
            dgvLopMoi.DataSource = lop_hsDAL.layDanhSachHocSinhTheoNamHocVaLop(NAMHOC.NamHocMacDinh, cbLopHocMoi.Text);
        }

        private void layDanhSachHocSinhChuaCoLop()
        {
            dgvLopCu.DataSource = lop_hsDAL.layDanhSachHocSinhChuaCoLop(NAMHOC.NamHocMacDinh);
        }

        private void chbxChuaCoLop_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxChuaCoLop.Checked)
            {
                cbLopHocCu.Enabled = false;

                layDanhSachHocSinhChuaCoLop();
            }
            else
            {
                cbLopHocCu.Enabled = true;
                cbLopHocCu.Text = "";
            }
        }
    }
}
