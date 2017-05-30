namespace quanlyhocsinhGUI
{
    partial class frmNhapKetQuaHocTap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapKetQuaHocTap));
            this.dgvDanhSachHocSinh = new System.Windows.Forms.DataGridView();
            this.btChon = new System.Windows.Forms.Button();
            this.cbLopHoc = new System.Windows.Forms.ComboBox();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMonHoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btLuuDiem = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbDiemTB = new System.Windows.Forms.TextBox();
            this.tbDiem1t = new System.Windows.Forms.TextBox();
            this.tbDiem15p = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHocSinh)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDanhSachHocSinh
            // 
            this.dgvDanhSachHocSinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHocSinh.Location = new System.Drawing.Point(25, 25);
            this.dgvDanhSachHocSinh.Name = "dgvDanhSachHocSinh";
            this.dgvDanhSachHocSinh.Size = new System.Drawing.Size(400, 512);
            this.dgvDanhSachHocSinh.TabIndex = 11;
            this.dgvDanhSachHocSinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachHocSinh_CellClick);
            this.dgvDanhSachHocSinh.SelectionChanged += new System.EventHandler(this.dgvDanhSachHocSinh_SelectionChanged);
            // 
            // btChon
            // 
            this.btChon.Location = new System.Drawing.Point(132, 184);
            this.btChon.Name = "btChon";
            this.btChon.Size = new System.Drawing.Size(75, 25);
            this.btChon.TabIndex = 10;
            this.btChon.Text = "Chọn";
            this.btChon.UseVisualStyleBackColor = true;
            this.btChon.Click += new System.EventHandler(this.btChon_Click);
            // 
            // cbLopHoc
            // 
            this.cbLopHoc.FormattingEnabled = true;
            this.cbLopHoc.Location = new System.Drawing.Point(132, 81);
            this.cbLopHoc.Name = "cbLopHoc";
            this.cbLopHoc.Size = new System.Drawing.Size(150, 24);
            this.cbLopHoc.TabIndex = 9;
            // 
            // cbHocKy
            // 
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Location = new System.Drawing.Point(132, 31);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(150, 24);
            this.cbHocKy.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lớp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Học kỳ:";
            // 
            // cbMonHoc
            // 
            this.cbMonHoc.FormattingEnabled = true;
            this.cbMonHoc.Location = new System.Drawing.Point(132, 133);
            this.cbMonHoc.Name = "cbMonHoc";
            this.cbMonHoc.Size = new System.Drawing.Size(150, 24);
            this.cbMonHoc.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Môn:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btLuuDiem);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbDiemTB);
            this.groupBox2.Controls.Add(this.tbDiem1t);
            this.groupBox2.Controls.Add(this.tbDiem15p);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(460, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 250);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết điểm";
            // 
            // btLuuDiem
            // 
            this.btLuuDiem.Location = new System.Drawing.Point(132, 150);
            this.btLuuDiem.Name = "btLuuDiem";
            this.btLuuDiem.Size = new System.Drawing.Size(75, 25);
            this.btLuuDiem.TabIndex = 6;
            this.btLuuDiem.Text = "Lưu Điểm";
            this.btLuuDiem.UseVisualStyleBackColor = true;
            this.btLuuDiem.Click += new System.EventHandler(this.btLuuDiem_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Điểm trung bình:";
            // 
            // tbDiemTB
            // 
            this.tbDiemTB.Location = new System.Drawing.Point(132, 197);
            this.tbDiemTB.Name = "tbDiemTB";
            this.tbDiemTB.Size = new System.Drawing.Size(150, 22);
            this.tbDiemTB.TabIndex = 0;
            // 
            // tbDiem1t
            // 
            this.tbDiem1t.Location = new System.Drawing.Point(132, 97);
            this.tbDiem1t.Name = "tbDiem1t";
            this.tbDiem1t.Size = new System.Drawing.Size(150, 22);
            this.tbDiem1t.TabIndex = 3;
            // 
            // tbDiem15p
            // 
            this.tbDiem15p.Location = new System.Drawing.Point(132, 47);
            this.tbDiem15p.Name = "tbDiem15p";
            this.tbDiem15p.Size = new System.Drawing.Size(150, 22);
            this.tbDiem15p.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Điểm 1 tiết:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Điểm 15 phút:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbHocKy);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbMonHoc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbLopHoc);
            this.groupBox1.Controls.Add(this.btChon);
            this.groupBox1.Location = new System.Drawing.Point(460, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 229);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc dữ liệu";
            // 
            // frmNhapKetQuaHocTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvDanhSachHocSinh);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhapKetQuaHocTap";
            this.Text = "Nhập Kết quả học tập";
            this.Load += new System.EventHandler(this.frmNhapKetQuaHocTap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHocSinh)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSachHocSinh;
        private System.Windows.Forms.Button btChon;
        private System.Windows.Forms.ComboBox cbLopHoc;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMonHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btLuuDiem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbDiemTB;
        private System.Windows.Forms.TextBox tbDiem1t;
        private System.Windows.Forms.TextBox tbDiem15p;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}