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
    public partial class frmDanhSachLopHoc : Form
    {
        LopHocDTO lpdto = new LopHocDTO();
        LopHocDAL lpdal = new LopHocDAL();

        public frmDanhSachLopHoc()
        {
            InitializeComponent();
        }

        private void frmDanhSachLopHoc_Load(object sender, EventArgs e)
        {
            dgvDanhSachLop.DataSource = lpdal.layDanhSachLop();
        }
    }
}