namespace quanlyhocsinhGUI
{
    partial class frmTraCuuHocSinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraCuuHocSinh));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbTatCa = new System.Windows.Forms.RadioButton();
            this.cbTimLop = new System.Windows.Forms.ComboBox();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.tbTimKiemHoTen = new System.Windows.Forms.TextBox();
            this.dgvThongTin = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvKetQuaHocTap = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQuaHocTap)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbTatCa);
            this.groupBox2.Controls.Add(this.cbTimLop);
            this.groupBox2.Controls.Add(this.rbNu);
            this.groupBox2.Controls.Add(this.rbNam);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btTimKiem);
            this.groupBox2.Controls.Add(this.tbTimKiemHoTen);
            this.groupBox2.Location = new System.Drawing.Point(25, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(665, 68);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tra cứu học sinh";
            // 
            // rbTatCa
            // 
            this.rbTatCa.AutoSize = true;
            this.rbTatCa.Location = new System.Drawing.Point(277, 43);
            this.rbTatCa.Name = "rbTatCa";
            this.rbTatCa.Size = new System.Drawing.Size(116, 20);
            this.rbTatCa.TabIndex = 16;
            this.rbTatCa.TabStop = true;
            this.rbTatCa.Text = "Cả Nam lẫn Nữ";
            this.rbTatCa.UseVisualStyleBackColor = true;
            // 
            // cbTimLop
            // 
            this.cbTimLop.FormattingEnabled = true;
            this.cbTimLop.Location = new System.Drawing.Point(454, 22);
            this.cbTimLop.Name = "cbTimLop";
            this.cbTimLop.Size = new System.Drawing.Size(121, 24);
            this.cbTimLop.TabIndex = 7;
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(338, 17);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(43, 20);
            this.rbNu.TabIndex = 6;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(277, 17);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(55, 20);
            this.rbNam.TabIndex = 5;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(414, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Lớp:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Họ tên:";
            // 
            // btTimKiem
            // 
            this.btTimKiem.Location = new System.Drawing.Point(581, 21);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(75, 25);
            this.btTimKiem.TabIndex = 2;
            this.btTimKiem.Text = "Tìm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // tbTimKiemHoTen
            // 
            this.tbTimKiemHoTen.Location = new System.Drawing.Point(62, 21);
            this.tbTimKiemHoTen.Name = "tbTimKiemHoTen";
            this.tbTimKiemHoTen.Size = new System.Drawing.Size(200, 22);
            this.tbTimKiemHoTen.TabIndex = 1;
            // 
            // dgvThongTin
            // 
            this.dgvThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTin.Location = new System.Drawing.Point(25, 131);
            this.dgvThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.dgvThongTin.Name = "dgvThongTin";
            this.dgvThongTin.Size = new System.Drawing.Size(347, 310);
            this.dgvThongTin.TabIndex = 12;
            this.dgvThongTin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTin_CellClick);
            this.dgvThongTin.SelectionChanged += new System.EventHandler(this.dgvThongTin_SelectionChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(287, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tra cứu học sinh";
            // 
            // dgvKetQuaHocTap
            // 
            this.dgvKetQuaHocTap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQuaHocTap.Location = new System.Drawing.Point(392, 131);
            this.dgvKetQuaHocTap.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKetQuaHocTap.Name = "dgvKetQuaHocTap";
            this.dgvKetQuaHocTap.Size = new System.Drawing.Size(298, 310);
            this.dgvKetQuaHocTap.TabIndex = 12;
            // 
            // frmTraCuuHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 462);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvKetQuaHocTap);
            this.Controls.Add(this.dgvThongTin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTraCuuHocSinh";
            this.Text = "Tra cứu học sinh";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQuaHocTap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.TextBox tbTimKiemHoTen;
        private System.Windows.Forms.DataGridView dgvThongTin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTimLop;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbTatCa;
        private System.Windows.Forms.DataGridView dgvKetQuaHocTap;
    }
}