namespace quanlyhocsinhGUI
{
    partial class frmKetQuaHocTap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKetQuaHocTap));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.cbLopHoc = new System.Windows.Forms.ComboBox();
            this.cbMonHoc = new System.Windows.Forms.ComboBox();
            this.dgvChiTietDiem = new System.Windows.Forms.DataGridView();
            this.btXemDanhSach = new System.Windows.Forms.Button();
            this.btTrungBinhNam = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Học kỳ:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lớp:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Môn:";
            // 
            // cbHocKy
            // 
            this.cbHocKy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Location = new System.Drawing.Point(122, 26);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(100, 24);
            this.cbHocKy.TabIndex = 1;
            // 
            // cbLopHoc
            // 
            this.cbLopHoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbLopHoc.FormattingEnabled = true;
            this.cbLopHoc.Location = new System.Drawing.Point(288, 26);
            this.cbLopHoc.Name = "cbLopHoc";
            this.cbLopHoc.Size = new System.Drawing.Size(100, 24);
            this.cbLopHoc.TabIndex = 2;
            // 
            // cbMonHoc
            // 
            this.cbMonHoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbMonHoc.FormattingEnabled = true;
            this.cbMonHoc.Location = new System.Drawing.Point(457, 26);
            this.cbMonHoc.Name = "cbMonHoc";
            this.cbMonHoc.Size = new System.Drawing.Size(100, 24);
            this.cbMonHoc.TabIndex = 3;
            // 
            // dgvChiTietDiem
            // 
            this.dgvChiTietDiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChiTietDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietDiem.Location = new System.Drawing.Point(27, 111);
            this.dgvChiTietDiem.Name = "dgvChiTietDiem";
            this.dgvChiTietDiem.Size = new System.Drawing.Size(731, 430);
            this.dgvChiTietDiem.TabIndex = 6;
            this.dgvChiTietDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietDiem_CellClick);
            this.dgvChiTietDiem.SelectionChanged += new System.EventHandler(this.dgvChiTietDiem_SelectionChanged);
            // 
            // btXemDanhSach
            // 
            this.btXemDanhSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btXemDanhSach.Location = new System.Drawing.Point(608, 25);
            this.btXemDanhSach.Name = "btXemDanhSach";
            this.btXemDanhSach.Size = new System.Drawing.Size(150, 25);
            this.btXemDanhSach.TabIndex = 4;
            this.btXemDanhSach.Text = "Xem";
            this.btXemDanhSach.UseVisualStyleBackColor = true;
            this.btXemDanhSach.Click += new System.EventHandler(this.btXemDanhSach_Click);
            // 
            // btTrungBinhNam
            // 
            this.btTrungBinhNam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btTrungBinhNam.Location = new System.Drawing.Point(608, 65);
            this.btTrungBinhNam.Name = "btTrungBinhNam";
            this.btTrungBinhNam.Size = new System.Drawing.Size(150, 25);
            this.btTrungBinhNam.TabIndex = 5;
            this.btTrungBinhNam.Text = "Trung bình năm";
            this.btTrungBinhNam.UseVisualStyleBackColor = true;
            this.btTrungBinhNam.Click += new System.EventHandler(this.btTrungBinhNam_Click);
            // 
            // frmKetQuaHocTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btTrungBinhNam);
            this.Controls.Add(this.btXemDanhSach);
            this.Controls.Add(this.dgvChiTietDiem);
            this.Controls.Add(this.cbMonHoc);
            this.Controls.Add(this.cbLopHoc);
            this.Controls.Add(this.cbHocKy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKetQuaHocTap";
            this.Text = "Kết quả học tập";
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.ComboBox cbLopHoc;
        private System.Windows.Forms.ComboBox cbMonHoc;
        private System.Windows.Forms.DataGridView dgvChiTietDiem;
        private System.Windows.Forms.Button btXemDanhSach;
        private System.Windows.Forms.Button btTrungBinhNam;
    }
}