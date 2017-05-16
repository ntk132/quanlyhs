namespace quanlyhocsinhGUI
{
    partial class frmDangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnUser = new System.Windows.Forms.Panel();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.pnPassword = new System.Windows.Forms.Panel();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.btLogin = new System.Windows.Forms.Button();
            this.pnUser.SuspendLayout();
            this.pnPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnUser
            // 
            this.pnUser.Controls.Add(this.tbUser);
            this.pnUser.Controls.Add(this.lbUser);
            this.pnUser.Location = new System.Drawing.Point(0, 9);
            this.pnUser.Margin = new System.Windows.Forms.Padding(4);
            this.pnUser.Name = "pnUser";
            this.pnUser.Size = new System.Drawing.Size(379, 46);
            this.pnUser.TabIndex = 5;
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(125, 14);
            this.tbUser.Margin = new System.Windows.Forms.Padding(4);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(236, 22);
            this.tbUser.TabIndex = 1;
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(16, 18);
            this.lbUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(92, 16);
            this.lbUser.TabIndex = 0;
            this.lbUser.Text = "Tên tài khoản:";
            // 
            // pnPassword
            // 
            this.pnPassword.Controls.Add(this.tbPassword);
            this.pnPassword.Controls.Add(this.lbPassword);
            this.pnPassword.Location = new System.Drawing.Point(0, 53);
            this.pnPassword.Margin = new System.Windows.Forms.Padding(4);
            this.pnPassword.Name = "pnPassword";
            this.pnPassword.Size = new System.Drawing.Size(379, 46);
            this.pnPassword.TabIndex = 6;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(125, 14);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(236, 22);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(16, 18);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(65, 16);
            this.lbPassword.TabIndex = 0;
            this.lbPassword.Text = "Mật khẩu:";
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(261, 107);
            this.btExit.Margin = new System.Windows.Forms.Padding(4);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(100, 28);
            this.btExit.TabIndex = 8;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(125, 107);
            this.btLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(100, 28);
            this.btLogin.TabIndex = 7;
            this.btLogin.Text = "Đăng nhập";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 144);
            this.Controls.Add(this.pnUser);
            this.Controls.Add(this.pnPassword);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDangNhap";
            this.Text = "Đăng nhập";
            this.pnUser.ResumeLayout(false);
            this.pnUser.PerformLayout();
            this.pnPassword.ResumeLayout(false);
            this.pnPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnUser;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Panel pnPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btLogin;
    }
}