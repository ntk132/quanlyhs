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
        HocSinhDTO hsdto = new HocSinhDTO();
        public frmTraCuuHocSinh()
        {
            InitializeComponent();

            rbNam.Checked = true;
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dt = da.ExecuteQuery("select MaHocSinh, HoTen from HOCSINH where Hoten like '%" + tbTimKiemHoTen.Text + "%' order by MaHocSinh");

            dgvKetQua.DataSource = dt;
        }

        private void dgvKetQua_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKetQua.SelectedRows.Count > 0)
            {
                tbHoTen.Text = dgvKetQua.SelectedRows[0].Cells[1].Value.ToString();
            }
        }
    }
}
