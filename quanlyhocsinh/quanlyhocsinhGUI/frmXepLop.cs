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


            cbLopHocCu.DataSource = lophocDAL.layDanhSachLopTheoNamHoc(MACDINH.NamHocMacDinh);
            cbLopHocCu.ValueMember = "MaLopHoc";

            cbLopHocMoi.DataSource = lophocDAL.layDanhSachLopTheoNamHoc(MACDINH.NamHocMacDinh);
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
            if (cbLopHocMoi.Text == string.Empty)
            {
                MessageBox.Show("Chưa chọn lớp để sắp xếp! Vui lòng thử lại!");

                cbLopHocMoi.Focus();

                return;
            }

            // Nếu chưa chọn học sinh mà đã thực hiện thao tác chuyển lớp
            // Đưa ra thông cho User thao tác không thể thực hiện
            if (dgvLopCu.SelectedRows.Count < 0)
            {
                MessageBox.Show("Chưa chọn học sinh để chuyển lớp!");

                return;
            }

            // Kiểm tra số lượng học sinh được xếp lớp có vượt quá
            // sỉ số lớp tối đa
            QuyDinhDAL quydinhDAL = new QuyDinhDAL();

            int SiSoToiDa = Convert.ToInt16(quydinhDAL.layQuyDinhSiSoToiDa().Rows[0]["GiaTriQuyDinh"].ToString());
            int SiSoHienCoCuaLop = lophocDAL.laySiSoCuaLopHoc(MACDINH.NamHocMacDinh, cbLopHocMoi.Text);

            if (dgvLopCu.SelectedRows.Count > SiSoToiDa)
            {
                MessageBox.Show("Số lượng học sinh được lựa chọn để xếp lớp vượt quá sỉ số tối đa! Vui lòng thử lại!");

                return;
            }
            else if (dgvLopCu.SelectedRows.Count > SiSoToiDa - SiSoHienCoCuaLop)
            {
                MessageBox.Show("Số lượng học sinh được xếp lớp đã vượt quá số sỉ số còn lại của lớp! Vui lòng thử lại!");

                return;
            }


            // Trong trường hợp cần chuyển nhiều hơn một hoc sinh
            // Nên sử dụng vòng for để lấy ra các học sinh được chọn để chuyển lớp
            for (int i = 0; i < dgvLopCu.SelectedRows.Count; i++)
            {
                // Mapping...
                Lop_HocSinhDTO lop_hsDTO = new Lop_HocSinhDTO();

                lop_hsDTO.MaNamHoc = MACDINH.NamHocMacDinh;
                lop_hsDTO.MaLopHoc = cbLopHocMoi.Text;
                lop_hsDTO.MaHocSinh = Convert.ToInt32(dgvLopCu.SelectedRows[i].Cells[0].Value);

                // DAL
                // Nếu là học sinh mới (Vừa thực hiện thao tác Tiếp nhận học sinh)
                // Thì mặc định là chưa được xếp lớp
                // Nên thực hiện thao tác tạo mới.
                if (chbxChuaCoLop.Checked)
                {
                    // Insert
                    lop_hsDAL.insert(lop_hsDTO);
                }
                else
                {
                    // Ngược lại nếu là học sinh cũ (đã có sẵn lớp)
                    // Thì thực hiện thao tác cập nhật lại lớp học
                    // Update
                    lop_hsDAL.update(lop_hsDTO);
                }
                
            }

            // Sau khi thực hiện xong thác chuyển lớp thì cập nhật lại các danh sách lớp, 
            // danh sách các học sinh chưa có lớp
            // Đồng thời cập nhật lại sĩ số các lớp học tham gia vào thao tác trên
            if (chbxChuaCoLop.Checked)
            {
                // Nếu học sinh vừa chuyển lớp chưa có lớp
                // Chỉ cần cập nhật lại danh sách các học sinh chưa có lớp
                layDanhSachHocSinhChuaCoLop();
            }
            else
            {
                // Ngược lại thì cập nhật sĩ số lớp cũ
                // (lớp có học sinh vừa chuyển đi)
                CapNhatSiSoLopHoc(cbLopHocCu.Text);

                refesh_DataGridView_LopCu();
            }

            // Cuối cùng là cập nhật lại sĩ số lớp học mới
            // (Vừa có học sinh mới chuyển vào)
            CapNhatSiSoLopHoc(cbLopHocMoi.Text);
            
            refesh_DataGridView_LopMoi();
        }

        private void CapNhatSiSoLopHoc(string maLopHoc)
        {
            LopHocDTO lophocDTO = new LopHocDTO();

            lophocDTO.MaNamHoc = MACDINH.NamHocMacDinh;
            lophocDTO.MaLopHoc = maLopHoc;
            lophocDTO.SiSo = lop_hsDAL.laySiSoCuaLop(MACDINH.NamHocMacDinh, maLopHoc);

            lophocDAL.suaSiSoLop(lophocDTO);
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
            dgvLopCu.DataSource = lop_hsDAL.layDanhSachHocSinhTheoNamHocVaLop(MACDINH.NamHocMacDinh, cbLopHocCu.Text);
        }

        private void refesh_DataGridView_LopMoi()
        {
            dgvLopMoi.DataSource = lop_hsDAL.layDanhSachHocSinhTheoNamHocVaLop(MACDINH.NamHocMacDinh, cbLopHocMoi.Text);
        }

        private void layDanhSachHocSinhChuaCoLop()
        {
            dgvLopCu.DataSource = lop_hsDAL.layDanhSachHocSinhChuaCoLop(MACDINH.NamHocMacDinh);
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

                dgvLopCu.DataSource = null;
            }
        }

        private void dgvLopCu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > dgvLopCu.Rows.Count - 2)
                return;

            dgvLopCu.Rows[e.RowIndex].Selected = true;
        }
    }
}
