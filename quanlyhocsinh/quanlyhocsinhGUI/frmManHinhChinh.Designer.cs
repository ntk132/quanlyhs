namespace quanlyhocsinhGUI
{
    partial class frmManHinhChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManHinhChinh));
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbNamHoc = new System.Windows.Forms.ToolStripButton();
            this.tsbDanhSachLop = new System.Windows.Forms.ToolStripButton();
            this.tsbDanhSachHocSinh = new System.Windows.Forms.ToolStripButton();
            this.tsbXepLop = new System.Windows.Forms.ToolStripButton();
            this.tsbLenLop = new System.Windows.Forms.ToolStripButton();
            this.tsbNhapDiem = new System.Windows.Forms.ToolStripButton();
            this.tsbKetQuaHocTap = new System.Windows.Forms.ToolStripButton();
            this.tsbTraCuu = new System.Windows.Forms.ToolStripButton();
            this.tsbBaoCao = new System.Windows.Forms.ToolStripButton();
            this.tsbThayDoiQuyDinh = new System.Windows.Forms.ToolStripButton();
            this.tsbThoat = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.AutoSize = false;
            this.tsMenu.BackColor = System.Drawing.Color.White;
            this.tsMenu.ImageScalingSize = new System.Drawing.Size(100, 100);
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNamHoc,
            this.tsbDanhSachLop,
            this.tsbDanhSachHocSinh,
            this.tsbXepLop,
            this.tsbLenLop,
            this.tsbNhapDiem,
            this.tsbKetQuaHocTap,
            this.tsbTraCuu,
            this.tsbBaoCao,
            this.tsbThayDoiQuyDinh,
            this.tsbThoat});
            this.tsMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(1284, 100);
            this.tsMenu.TabIndex = 15;
            this.tsMenu.Text = "toolStrip1";
            // 
            // tsbNamHoc
            // 
            this.tsbNamHoc.AutoSize = false;
            this.tsbNamHoc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbNamHoc.Image = ((System.Drawing.Image)(resources.GetObject("tsbNamHoc.Image")));
            this.tsbNamHoc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbNamHoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNamHoc.Name = "tsbNamHoc";
            this.tsbNamHoc.Size = new System.Drawing.Size(100, 100);
            this.tsbNamHoc.Text = "Năm học";
            this.tsbNamHoc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbNamHoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbNamHoc.Click += new System.EventHandler(this.tsbtNamHoc_Click);
            // 
            // tsbDanhSachLop
            // 
            this.tsbDanhSachLop.AutoSize = false;
            this.tsbDanhSachLop.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbDanhSachLop.Image = global::quanlyhocsinhGUI.Properties.Resources.danhsachlop;
            this.tsbDanhSachLop.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbDanhSachLop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDanhSachLop.Name = "tsbDanhSachLop";
            this.tsbDanhSachLop.Size = new System.Drawing.Size(100, 100);
            this.tsbDanhSachLop.Text = "Danh sách lớp";
            this.tsbDanhSachLop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbDanhSachLop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDanhSachLop.Click += new System.EventHandler(this.tsbtDanhSachLop_Click);
            // 
            // tsbDanhSachHocSinh
            // 
            this.tsbDanhSachHocSinh.AutoSize = false;
            this.tsbDanhSachHocSinh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbDanhSachHocSinh.Image = global::quanlyhocsinhGUI.Properties.Resources.danhsachhocsinh;
            this.tsbDanhSachHocSinh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbDanhSachHocSinh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDanhSachHocSinh.Name = "tsbDanhSachHocSinh";
            this.tsbDanhSachHocSinh.Size = new System.Drawing.Size(120, 100);
            this.tsbDanhSachHocSinh.Text = "Danh sách học sinh";
            this.tsbDanhSachHocSinh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbDanhSachHocSinh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDanhSachHocSinh.Click += new System.EventHandler(this.tsbtDanhSachHocSinh_Click);
            // 
            // tsbXepLop
            // 
            this.tsbXepLop.AutoSize = false;
            this.tsbXepLop.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbXepLop.Image = ((System.Drawing.Image)(resources.GetObject("tsbXepLop.Image")));
            this.tsbXepLop.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbXepLop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbXepLop.Name = "tsbXepLop";
            this.tsbXepLop.Size = new System.Drawing.Size(100, 100);
            this.tsbXepLop.Text = "Xếp lớp";
            this.tsbXepLop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbXepLop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbXepLop.Click += new System.EventHandler(this.tsbtXepLop);
            // 
            // tsbLenLop
            // 
            this.tsbLenLop.AutoSize = false;
            this.tsbLenLop.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbLenLop.Image = ((System.Drawing.Image)(resources.GetObject("tsbLenLop.Image")));
            this.tsbLenLop.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbLenLop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLenLop.Name = "tsbLenLop";
            this.tsbLenLop.Size = new System.Drawing.Size(100, 100);
            this.tsbLenLop.Text = "Lên lớp";
            this.tsbLenLop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbLenLop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbLenLop.Click += new System.EventHandler(this.tsbtLenLop);
            // 
            // tsbNhapDiem
            // 
            this.tsbNhapDiem.AutoSize = false;
            this.tsbNhapDiem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbNhapDiem.Image = ((System.Drawing.Image)(resources.GetObject("tsbNhapDiem.Image")));
            this.tsbNhapDiem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbNhapDiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNhapDiem.Name = "tsbNhapDiem";
            this.tsbNhapDiem.Size = new System.Drawing.Size(100, 100);
            this.tsbNhapDiem.Text = "Nhập điểm";
            this.tsbNhapDiem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbNhapDiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbNhapDiem.Click += new System.EventHandler(this.tsbNhapDiem_Click);
            // 
            // tsbKetQuaHocTap
            // 
            this.tsbKetQuaHocTap.AutoSize = false;
            this.tsbKetQuaHocTap.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbKetQuaHocTap.Image = global::quanlyhocsinhGUI.Properties.Resources.ketquahoctap;
            this.tsbKetQuaHocTap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbKetQuaHocTap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbKetQuaHocTap.Name = "tsbKetQuaHocTap";
            this.tsbKetQuaHocTap.Size = new System.Drawing.Size(100, 100);
            this.tsbKetQuaHocTap.Text = "Kết quả học tập";
            this.tsbKetQuaHocTap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbKetQuaHocTap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbKetQuaHocTap.Click += new System.EventHandler(this.tsbtKetQuaHocTap_Click);
            // 
            // tsbTraCuu
            // 
            this.tsbTraCuu.AutoSize = false;
            this.tsbTraCuu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbTraCuu.Image = global::quanlyhocsinhGUI.Properties.Resources.tracuu;
            this.tsbTraCuu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbTraCuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTraCuu.Name = "tsbTraCuu";
            this.tsbTraCuu.Size = new System.Drawing.Size(100, 100);
            this.tsbTraCuu.Text = "Tra cứu";
            this.tsbTraCuu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbTraCuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbTraCuu.Click += new System.EventHandler(this.tsbtTraCuuHocSinh_Click);
            // 
            // tsbBaoCao
            // 
            this.tsbBaoCao.AutoSize = false;
            this.tsbBaoCao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbBaoCao.Image = global::quanlyhocsinhGUI.Properties.Resources.baocao;
            this.tsbBaoCao.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbBaoCao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBaoCao.Name = "tsbBaoCao";
            this.tsbBaoCao.Size = new System.Drawing.Size(100, 100);
            this.tsbBaoCao.Text = "Báo cáo";
            this.tsbBaoCao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbBaoCao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbBaoCao.Click += new System.EventHandler(this.tsbtBaoCao_Click);
            // 
            // tsbThayDoiQuyDinh
            // 
            this.tsbThayDoiQuyDinh.AutoSize = false;
            this.tsbThayDoiQuyDinh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbThayDoiQuyDinh.Image = global::quanlyhocsinhGUI.Properties.Resources.thaydoiquydinh;
            this.tsbThayDoiQuyDinh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbThayDoiQuyDinh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbThayDoiQuyDinh.Name = "tsbThayDoiQuyDinh";
            this.tsbThayDoiQuyDinh.Size = new System.Drawing.Size(120, 100);
            this.tsbThayDoiQuyDinh.Text = "Thay đổi quy định";
            this.tsbThayDoiQuyDinh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbThayDoiQuyDinh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbThayDoiQuyDinh.Click += new System.EventHandler(this.tsbtThayDoiQuyDinh_Click);
            // 
            // tsbThoat
            // 
            this.tsbThoat.AutoSize = false;
            this.tsbThoat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbThoat.Image = global::quanlyhocsinhGUI.Properties.Resources.thoat;
            this.tsbThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbThoat.Name = "tsbThoat";
            this.tsbThoat.Size = new System.Drawing.Size(100, 100);
            this.tsbThoat.Text = "Thoát";
            this.tsbThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbThoat.Click += new System.EventHandler(this.tsbtThoat_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(675, 536);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(597, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Version 1.0 | UIT.Micracle- team | Liên hệ: ..., Khu phố 6, P. Linh Trung, Quận T" +
    "hủ Đức, Tp Hồ Chí Minh";
            // 
            // frmManHinhChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1284, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tsMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManHinhChinh";
            this.Text = "Phần mềm Quản lý học sinh";
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbNamHoc;
        private System.Windows.Forms.ToolStripButton tsbDanhSachLop;
        private System.Windows.Forms.ToolStripButton tsbDanhSachHocSinh;
        private System.Windows.Forms.ToolStripButton tsbXepLop;
        private System.Windows.Forms.ToolStripButton tsbLenLop;
        private System.Windows.Forms.ToolStripButton tsbNhapDiem;
        private System.Windows.Forms.ToolStripButton tsbKetQuaHocTap;
        private System.Windows.Forms.ToolStripButton tsbTraCuu;
        private System.Windows.Forms.ToolStripButton tsbBaoCao;
        private System.Windows.Forms.ToolStripButton tsbThayDoiQuyDinh;
        private System.Windows.Forms.ToolStripButton tsbThoat;
        private System.Windows.Forms.Label label1;
    }
}