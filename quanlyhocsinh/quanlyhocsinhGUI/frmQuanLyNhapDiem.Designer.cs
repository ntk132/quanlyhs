namespace quanlyhocsinhGUI
{
    partial class frmQuanLyNhapDiem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.cbLopHoc = new System.Windows.Forms.ComboBox();
            this.btChon = new System.Windows.Forms.Button();
            this.dgvDanhSachHocSinh = new System.Windows.Forms.DataGridView();
            this.btNhapDiem = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHocSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Học kỳ:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lớp:";
            // 
            // cbHocKy
            // 
            this.cbHocKy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Location = new System.Drawing.Point(84, 22);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(150, 24);
            this.cbHocKy.TabIndex = 2;
            // 
            // cbLopHoc
            // 
            this.cbLopHoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLopHoc.FormattingEnabled = true;
            this.cbLopHoc.Location = new System.Drawing.Point(290, 22);
            this.cbLopHoc.Name = "cbLopHoc";
            this.cbLopHoc.Size = new System.Drawing.Size(150, 24);
            this.cbLopHoc.TabIndex = 3;
            // 
            // btChon
            // 
            this.btChon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btChon.Location = new System.Drawing.Point(475, 22);
            this.btChon.Name = "btChon";
            this.btChon.Size = new System.Drawing.Size(100, 25);
            this.btChon.TabIndex = 4;
            this.btChon.Text = "Chọn";
            this.btChon.UseVisualStyleBackColor = true;
            this.btChon.Click += new System.EventHandler(this.btChon_Click);
            // 
            // dgvDanhSachHocSinh
            // 
            this.dgvDanhSachHocSinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHocSinh.Location = new System.Drawing.Point(25, 65);
            this.dgvDanhSachHocSinh.Name = "dgvDanhSachHocSinh";
            this.dgvDanhSachHocSinh.Size = new System.Drawing.Size(550, 343);
            this.dgvDanhSachHocSinh.TabIndex = 5;
            // 
            // btNhapDiem
            // 
            this.btNhapDiem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btNhapDiem.Location = new System.Drawing.Point(340, 424);
            this.btNhapDiem.Name = "btNhapDiem";
            this.btNhapDiem.Size = new System.Drawing.Size(100, 25);
            this.btNhapDiem.TabIndex = 6;
            this.btNhapDiem.Text = "Nhập điểm";
            this.btNhapDiem.UseVisualStyleBackColor = true;
            this.btNhapDiem.Click += new System.EventHandler(this.btNhapDiem_Click);
            // 
            // btThoat
            // 
            this.btThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btThoat.Location = new System.Drawing.Point(475, 424);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(100, 25);
            this.btThoat.TabIndex = 7;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // frmQuanLyNhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 461);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btNhapDiem);
            this.Controls.Add(this.dgvDanhSachHocSinh);
            this.Controls.Add(this.btChon);
            this.Controls.Add(this.cbLopHoc);
            this.Controls.Add(this.cbHocKy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLyNhapDiem";
            this.Text = "Quản lý nhập điểm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHocSinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.ComboBox cbLopHoc;
        private System.Windows.Forms.Button btChon;
        private System.Windows.Forms.DataGridView dgvDanhSachHocSinh;
        private System.Windows.Forms.Button btNhapDiem;
        private System.Windows.Forms.Button btThoat;
    }
}