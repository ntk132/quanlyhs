namespace quanlyhocsinhGUI
{
    partial class frmLapDanhSachLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLapDanhSachLop));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbSiSo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbLopMoi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.dgvDanhSachLopMoi = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvTimHocSinh = new System.Windows.Forms.DataGridView();
            this.cbLopCu = new System.Windows.Forms.ComboBox();
            this.btAddAll = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLopMoi)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimHocSinh)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbSiSo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbLopMoi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 38);
            this.panel1.TabIndex = 6;
            // 
            // tbSiSo
            // 
            this.tbSiSo.Location = new System.Drawing.Point(240, 7);
            this.tbSiSo.Name = "tbSiSo";
            this.tbSiSo.Size = new System.Drawing.Size(100, 22);
            this.tbSiSo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sỉ số:";
            // 
            // cbLopMoi
            // 
            this.cbLopMoi.FormattingEnabled = true;
            this.cbLopMoi.Location = new System.Drawing.Point(53, 7);
            this.cbLopMoi.Name = "cbLopMoi";
            this.cbLopMoi.Size = new System.Drawing.Size(100, 24);
            this.cbLopMoi.TabIndex = 1;
            this.cbLopMoi.TextChanged += new System.EventHandler(this.cbLopMoi_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lớp:";
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(164, 386);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(100, 25);
            this.btSua.TabIndex = 2;
            this.btSua.Text = "Cập nhật";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(270, 386);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(100, 25);
            this.btXoa.TabIndex = 1;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(136, 386);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(100, 25);
            this.btThem.TabIndex = 0;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // dgvDanhSachLopMoi
            // 
            this.dgvDanhSachLopMoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachLopMoi.Location = new System.Drawing.Point(6, 65);
            this.dgvDanhSachLopMoi.Name = "dgvDanhSachLopMoi";
            this.dgvDanhSachLopMoi.Size = new System.Drawing.Size(364, 315);
            this.dgvDanhSachLopMoi.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvTimHocSinh);
            this.groupBox2.Controls.Add(this.cbLopCu);
            this.groupBox2.Controls.Add(this.btAddAll);
            this.groupBox2.Controls.Add(this.btThem);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btTimKiem);
            this.groupBox2.Controls.Add(this.tbTimKiem);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 417);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách lớp cũ";
            // 
            // dgvTimHocSinh
            // 
            this.dgvTimHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimHocSinh.Location = new System.Drawing.Point(6, 90);
            this.dgvTimHocSinh.Name = "dgvTimHocSinh";
            this.dgvTimHocSinh.Size = new System.Drawing.Size(336, 290);
            this.dgvTimHocSinh.TabIndex = 8;
            // 
            // cbLopCu
            // 
            this.cbLopCu.FormattingEnabled = true;
            this.cbLopCu.Location = new System.Drawing.Point(100, 60);
            this.cbLopCu.Name = "cbLopCu";
            this.cbLopCu.Size = new System.Drawing.Size(89, 24);
            this.cbLopCu.TabIndex = 7;
            this.cbLopCu.TextChanged += new System.EventHandler(this.cbLopCu_TextChanged);
            // 
            // btAddAll
            // 
            this.btAddAll.Location = new System.Drawing.Point(242, 386);
            this.btAddAll.Name = "btAddAll";
            this.btAddAll.Size = new System.Drawing.Size(100, 25);
            this.btAddAll.TabIndex = 0;
            this.btAddAll.Text = "Thêm tất cả";
            this.btAddAll.UseVisualStyleBackColor = true;
            this.btAddAll.Click += new System.EventHandler(this.btAddAll_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lớp:";
            // 
            // btTimKiem
            // 
            this.btTimKiem.Location = new System.Drawing.Point(267, 24);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(75, 25);
            this.btTimKiem.TabIndex = 5;
            this.btTimKiem.Text = "Tìm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Location = new System.Drawing.Point(100, 27);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(161, 22);
            this.tbTimKiem.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tìm tên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(284, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Lập danh sách lớp";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btXoa);
            this.groupBox3.Controls.Add(this.btSua);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.dgvDanhSachLopMoi);
            this.groupBox3.Location = new System.Drawing.Point(376, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(380, 417);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách lớp mới";
            // 
            // frmLapDanhSachLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 461);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLapDanhSachLop";
            this.Text = "Lập danh sách lớp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLopMoi)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimHocSinh)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbSiSo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbLopMoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.DataGridView dgvDanhSachLopMoi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btAddAll;
        private System.Windows.Forms.DataGridView dgvTimHocSinh;
        private System.Windows.Forms.ComboBox cbLopCu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}