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
    public partial class frmTiepNhanHocSinh : Form
    {
        QuyDinhDAL qd = new QuyDinhDAL();
        public frmTiepNhanHocSinh()
        {
            InitializeComponent();

            rbNam.Checked = true;
        }

        private void initComboBoxNgaySinh()
        {
            List<string> ngay = new List<string>();
            List<string> thang = new List<string>();
            List<string> nam = new List<string>();

            cbNgay.DataSource = ngay;
            cbThang.DataSource = thang;
            cbNam.DataSource = nam;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            HocSinhBUS hsbus = new HocSinhBUS();
            HocSinhDAL hsdal = new HocSinhDAL();
            HocSinhDTO hsdto = new HocSinhDTO();

            // 1. Mapping...properties
            hsdto.MaHocSinh = da.ExecuteQuery("select * from HOCSINH").Rows.Count + 2;
            hsdto.Hoten = tbHoTen.Text;
            hsdto.NgaySinh = cbNgay.Text + "/" + cbThang.Text + "/" + cbNam.Text;

            if (rbNam.Checked)
                hsdto.GioiTinh = "Nam";
            else if (rbNu.Checked)
                hsdto.GioiTinh = "Nữ";
            else
                MessageBox.Show("Bạn chưa chon giới tính");

            hsdto.DiaChi = tbDiaChi.Text;
            hsdto.Email = tbEmail.Text;

            // 2. BUS
            if (hsbus.isLessThanMinAge() || hsbus.isGreatThanAge())
            {
                MessageBox.Show("Nhập tuổi sai quy định");

                cbNgay.Focus();
            }

            // 3. insert
            hsdal.insert(hsdto);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
