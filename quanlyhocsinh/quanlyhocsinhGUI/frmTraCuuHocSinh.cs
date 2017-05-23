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
    public partial class frmTraCuuHocSinh : Form
    {
        DataAccess da = new DataAccess();
        //HocSinhDTO hsdto = new HocSinhDTO();
        HocSinhDAL hsdal = new HocSinhDAL();
        LopHocDAL lhdal = new LopHocDAL();

        public frmTraCuuHocSinh()
        {
            InitializeComponent();

            //rbNam.Checked = true;

            cbTimLop.DataSource = lhdal.layDanhSachLopTheoNamHoc(NAMHOC.NamHocMacDinh);
            cbTimLop.ValueMember = "MaLopHoc";

            rbTatCa.Checked = true;
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            // Mapping...
            string gioitinh = "";

            if (rbNam.Checked)
                gioitinh = rbNam.Text;

            if (rbNu.Checked)
                gioitinh = rbNu.Text;

            DataTable dt = hsdal.timHocSinh(tbTimKiemHoTen.Text, gioitinh, cbTimLop.Text);

            // Search , show result
            dgvThongTin.DataSource = dt;
        }

        private void dgvKetQua_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvThongTin.SelectedRows.Count > 0)
            {
                
            }
        }
    }
}
