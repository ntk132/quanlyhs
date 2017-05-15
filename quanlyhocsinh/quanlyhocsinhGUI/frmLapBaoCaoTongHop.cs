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
        HocKyDAL hkdal = new HocKyDAL();
        LopHocDAL lhdal = new LopHocDAL();
        MonHocDAL mhdal = new MonHocDAL();
        
        public frmLapBaoCaoTongHop()
        {
            InitializeComponent();

            cbHocKy.DataSource = hkdal.layDanhSachHocKy();
            cbHocKy.ValueMember = "TenHocKy";
            cbLopHoc.DataSource = lhdal.layDanhSachLop();
            cbLopHoc.ValueMember = "MaLopHoc";
            cbMonHoc.DataSource = mhdal.layDanhSachMonHoc();
            cbMonHoc.ValueMember = "TenMonHoc";
        }

        private void rbHocKy_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHocKy.Checked)
            {
                cbMonHoc.Enabled = false;
                cbHocKy.Enabled = true;
            }
        }

        private void rbMonHoc_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMonHoc.Checked)
            {
                cbHocKy.Enabled = false;
                cbMonHoc.Enabled = true;
            }
        }
    }
}
