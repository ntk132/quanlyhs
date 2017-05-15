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
    public partial class frmNamHoc : Form
    {
        NamHocDAL nhdal = new NamHocDAL();

        public frmNamHoc()
        {
            InitializeComponent();
        }

        private void btChon_Click(object sender, EventArgs e)
        {
            // TO DO:..
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            // 1. Mapping...
            NamHocDTO nhdto = new NamHocDTO(tbMaNamHoc.Text, tbTenNamHoc.Text);

            // 2. BUS

            // 3. DAL - Insert
            nhdal.insert(nhdto);

            refeshDataGridView();
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            // 1. Mapping...
            NamHocDTO nhdto = new NamHocDTO(tbMaNamHoc.Text, tbTenNamHoc.Text);

            // 2. BUS

            // 3. DAL - Insert
            nhdal.update(nhdto);

            refeshDataGridView();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            nhdal.delete(tbMaNamHoc.Text);

            refeshDataGridView();
        }

        private void frmNamHoc_Load(object sender, EventArgs e)
        {
            refeshDataGridView();
        }

        private void refeshDataGridView()
        {
            dgvDanhSachNamHoc.DataSource = nhdal.layDanhSachNamHoc();
        }
    }
}
