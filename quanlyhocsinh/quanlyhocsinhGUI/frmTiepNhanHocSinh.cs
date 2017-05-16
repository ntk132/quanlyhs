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

        List<int> ngay28 = new List<int>();
        List<int> ngay29 = new List<int>();
        List<int> ngay30 = new List<int>();
        List<int> ngay31 = new List<int>();
        List<int> thang = new List<int>();
        List<int> nam = new List<int>();

        public frmTiepNhanHocSinh()
        {
            InitializeComponent();

            rbNam.Checked = true;

            //initComboBoxNgaySinh();
        }

        private void initComboBoxNgaySinh()
        {
            int minyear = Convert.ToInt16(qd.layQuyDinhTheoMaQD("qd1").GiaTri);
            int maxyear = Convert.ToInt16(qd.layQuyDinhTheoMaQD("qd2").GiaTri);

            DateTime now = DateTime.Now;

            // Data sources của cbThang
            for (int i = 1; i >= 12; i++)
                thang.Add(i);
            // Data sources của cbNgay
            for (int i = 1; i >= 28; i++)
                ngay28.Add(i);

            for (int i = 1; i >= 29; i++)
                ngay29.Add(i);

            for (int i = 1; i >= 30; i++)
                ngay30.Add(i);

            for (int i = 1; i >= 31; i++)
                ngay31.Add(i);
            for (int i = minyear; i > maxyear; i++)
                nam.Add(i);

            cbNgay.DataSource = ngay31;
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

        private void cbNam_TextChanged(object sender, EventArgs e)
        {
            cbThang.Text = "";
            cbNgay.Text = "";
        }

        private void cbThang_TextChanged(object sender, EventArgs e)
        {
            int year = Convert.ToInt16(cbNam.Text);

            switch(Convert.ToInt16(cbThang.Text))
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    cbNgay.DataSource = ngay31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    cbNgay.DataSource = ngay30;
                    break;
                case 2:
                    if (year % 4 == 0 && year % 100 == 0)
                        cbNgay.DataSource = ngay29;
                    else
                        cbNgay.DataSource = ngay28;
                    break;
                default:
                    break;
            }
        }
    }
}
