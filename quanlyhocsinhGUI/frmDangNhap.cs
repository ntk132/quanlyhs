using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlyhocsinhGUI
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();

            this.AcceptButton = btLogin;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            // Xét điều kiện đăng nhập:
            // - Cứ chuỗi nhập trên hai Textbox mà khác rỗng thì đăng nhập hợp lệ
            if (tbUser.Text == "admin" && tbPassword.Text == "admin")
            {
                frmManHinhChinh main = new frmManHinhChinh();

                // Đăng nhập thành công thì:
                // - hiện lên Form màn hình chính
                // - đồng thời ẩn đi màn hình đăng nhập
                this.Hide();
                main.ShowDialog();
                this.Show();
            }
            // Ngược lại nếu đăng nhập không thành công thì báo lỗi
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại tên đăng nhập hoặc mật khẩu để đăng nhập lại.", "Đăng nhập không thành công.");
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn CHẮC CHẮN muốn thoát.", "Cảnh báo.", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
