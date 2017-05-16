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
    public partial class frmThayDoiQuyDinh : Form
    {
        DataAccess da = new DataAccess();
        QuyDinhDAL qddal = new QuyDinhDAL();

        public frmThayDoiQuyDinh()
        {
            InitializeComponent();
        }

        private void btThayDoiQD_Click(object sender, EventArgs e)
        {
            QuyDinhDTO qd = new QuyDinhDTO();

            qd.MaQuyDinh = tbMaQD.Text;
            qd.GiaTri = tbGiaTri.Text;

            qddal.update(qd);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvQuyDinh_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvQuyDinh.SelectedRows.Count > 0)
            {
                tbMaQD.Text = dgvQuyDinh.SelectedRows[0].Cells[0].Value.ToString();
                tbGiaTri.Text = dgvQuyDinh.SelectedRows[0].Cells[2].Value.ToString();
            }
        }

        private void frmThayDoiQuyDinh_Load(object sender, EventArgs e)
        {
            dgvQuyDinh.DataSource = qddal.layDanhSachQuyDinh();
        }

        private void tbMaQD_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
