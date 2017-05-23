namespace quanlyhocsinhGUI
{
    partial class frmNamHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNamHoc));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDanhSachNamHoc = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNamHocMacDinh = new System.Windows.Forms.ComboBox();
            this.btChon = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMaNamHoc = new System.Windows.Forms.TextBox();
            this.tbTenNamHoc = new System.Windows.Forms.TextBox();
            this.btThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNamHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách năm học";
            // 
            // dgvDanhSachNamHoc
            // 
            this.dgvDanhSachNamHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachNamHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachNamHoc.Location = new System.Drawing.Point(29, 68);
            this.dgvDanhSachNamHoc.Name = "dgvDanhSachNamHoc";
            this.dgvDanhSachNamHoc.Size = new System.Drawing.Size(458, 300);
            this.dgvDanhSachNamHoc.TabIndex = 1;
            this.dgvDanhSachNamHoc.SelectionChanged += new System.EventHandler(this.dgvDanhSachNamHoc_SelectionChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Năm học mặc định:";
            // 
            // cbNamHocMacDinh
            // 
            this.cbNamHocMacDinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbNamHocMacDinh.FormattingEnabled = true;
            this.cbNamHocMacDinh.Location = new System.Drawing.Point(634, 43);
            this.cbNamHocMacDinh.Name = "cbNamHocMacDinh";
            this.cbNamHocMacDinh.Size = new System.Drawing.Size(150, 24);
            this.cbNamHocMacDinh.TabIndex = 3;
            // 
            // btChon
            // 
            this.btChon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btChon.Location = new System.Drawing.Point(634, 86);
            this.btChon.Name = "btChon";
            this.btChon.Size = new System.Drawing.Size(75, 25);
            this.btChon.TabIndex = 4;
            this.btChon.Text = "Chọn";
            this.btChon.UseVisualStyleBackColor = true;
            this.btChon.Click += new System.EventHandler(this.btChon_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(506, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã năm học:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(506, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên năm học:";
            // 
            // tbMaNamHoc
            // 
            this.tbMaNamHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMaNamHoc.Location = new System.Drawing.Point(634, 133);
            this.tbMaNamHoc.Name = "tbMaNamHoc";
            this.tbMaNamHoc.Size = new System.Drawing.Size(150, 22);
            this.tbMaNamHoc.TabIndex = 7;
            // 
            // tbTenNamHoc
            // 
            this.tbTenNamHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTenNamHoc.Location = new System.Drawing.Point(634, 178);
            this.tbTenNamHoc.Name = "tbTenNamHoc";
            this.tbTenNamHoc.Size = new System.Drawing.Size(150, 22);
            this.tbTenNamHoc.TabIndex = 8;
            // 
            // btThem
            // 
            this.btThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btThem.Location = new System.Drawing.Point(634, 243);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 25);
            this.btThem.TabIndex = 9;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btXoa.Location = new System.Drawing.Point(634, 288);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 25);
            this.btXoa.TabIndex = 11;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // frmNamHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 396);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.tbTenNamHoc);
            this.Controls.Add(this.tbMaNamHoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btChon);
            this.Controls.Add(this.cbNamHocMacDinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDanhSachNamHoc);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNamHoc";
            this.Text = "Năm học";
            this.Load += new System.EventHandler(this.frmNamHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNamHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDanhSachNamHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbNamHocMacDinh;
        private System.Windows.Forms.Button btChon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMaNamHoc;
        private System.Windows.Forms.TextBox tbTenNamHoc;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btXoa;
    }
}