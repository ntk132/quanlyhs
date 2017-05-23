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
using quanlyhocsinhDTO;
using quanlyhocsinhDAL;

namespace quanlyhocsinhGUI
{
    public partial class frmNhapDiem : Form
    {
        QuyDinhDAL quydinhDAL = new QuyDinhDAL();
        MonHocDAL mhdal = new MonHocDAL();
        KetQuaHocTapDAL kqDAL = new KetQuaHocTapDAL();

        private string mahocky;
        private string mahocsinh;
        private string malophoc;
        private string hotenhs;
        private int mamonhoc;
        private float diemdatmon;

        private DataTable dtDanhSachMonHoc = new DataTable();

        public frmNhapDiem()
        {
            InitializeComponent();            

            tbHoTen.Enabled = false;
            tbHocKy.Enabled = false;
            tbLopHoc.Enabled = false;
            tbDiemTB.Enabled = false;

            tbDiem15p.Enabled = false;
            tbDiem1t.Enabled = false;

            dtDanhSachMonHoc = mhdal.layDanhSachMonHoc();

            cbMonHoc.DataSource = dtDanhSachMonHoc;
            cbMonHoc.ValueMember = "TenMonHoc";

            diemdatmon = (float)Convert.ToDouble(quydinhDAL.layQuyDinhDiemToiThieuDatMon().Rows[0]["GiaTriQuyDinh"].ToString());
        }

        public frmNhapDiem(string  hocky, string malop, string mahs, string hoten) : this()
        {
            mahocky = hocky;
            malophoc = malop;
            hotenhs = hoten;
            mahocsinh = mahs;            
        }

        private void btChon_Click(object sender, EventArgs e)
        {
            mamonhoc = Convert.ToInt16(dtDanhSachMonHoc.Rows[cbMonHoc.SelectedIndex][0]);
            
            tbDiem15p.Enabled = true;
            tbDiem1t.Enabled = true;

            tbDiem15p.Focus();
        }

        private void btLuuDiem_Click(object sender, EventArgs e)
        {
            float diemtb = ((float)Convert.ToDouble(tbDiem15p.Text) + (float)Convert.ToDouble(tbDiem1t.Text) * 2 ) / 3;
            tbDiemTB.Text = diemtb.ToString();

            KetQuaHocTapDTO ketqua = new KetQuaHocTapDTO();

            // Mapping...
            ketqua.MaHocKy = tbHocKy.Text;
            ketqua.MaMonHoc = mamonhoc;
            ketqua.MaHocSinh = Convert.ToInt32(mahocsinh);
            ketqua.Diem15Phut = (float)Convert.ToDouble(tbDiem15p.Text);
            ketqua.Diem1Tiet = (float)Convert.ToDouble(tbDiem1t.Text);
            ketqua.DiemTB = diemtb;
            ketqua.DiemToiThieuDat = diemdatmon;

            if (diemtb >= diemdatmon)
            {
                ketqua.CoDatHayKhong = 1;
            }
            else
            {
                ketqua.CoDatHayKhong = 0;
            }

            // DAL - Insert
            kqDAL.insert(ketqua);
            //MessageBox.Show(mahocky + "\n" + malophoc + "\n" + mamonhoc + "\n" + mahocsinh + "\n" + tbDiem15p.Text + "\n" + tbDiem1t.Text + "\n" + tbDiemTB.Text + "\n" + diemdatmon + "\n" + ketqua.CoDatHayKhong);

            tbDiem15p.Enabled = false;
            tbDiem1t.Enabled = false;

            cbMonHoc.Focus();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNhapDiem_Load(object sender, EventArgs e)
        {
            tbHocKy.Text = mahocky;
            tbLopHoc.Text = malophoc;
            tbHoTen.Text = hotenhs;
        }
    }
}
