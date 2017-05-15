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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTBHK2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTBHK1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbHoTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
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
            this.groupBox2.Location = new System.Drawing.Point(12, 43);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTBHK2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbTBHK1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbLop);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbHoTen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(367, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 176);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin học sinh";
            // 
            // tbTBHK2
            // 
            this.tbTBHK2.Location = new System.Drawing.Point(101, 135);
            this.tbTBHK2.Name = "tbTBHK2";
            this.tbTBHK2.Size = new System.Drawing.Size(200, 22);
            this.tbTBHK2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "TB học kỳ II:";
            // 
            // tbTBHK1
            // 
            this.tbTBHK1.Location = new System.Drawing.Point(101, 99);
            this.tbTBHK1.Name = "tbTBHK1";
            this.tbTBHK1.Size = new System.Drawing.Size(200, 22);
            this.tbTBHK1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "TB học kỳ I:";
            // 
            // tbLop
            // 
            this.tbLop.Location = new System.Drawing.Point(101, 65);
            this.tbLop.Name = "tbLop";
            this.tbLop.Size = new System.Drawing.Size(200, 22);
            this.tbLop.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lớp:";
            // 
            // tbHoTen
            // 
            this.tbHoTen.Location = new System.Drawing.Point(101, 30);
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Size = new System.Drawing.Size(200, 22);
            this.tbHoTen.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên:";
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Location = new System.Drawing.Point(13, 118);
            this.dgvKetQua.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.Size = new System.Drawing.Size(347, 310);
            this.dgvKetQua.TabIndex = 12;
            this.dgvKetQua.SelectionChanged += new System.EventHandler(this.dgvKetQua_SelectionChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(252, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tra cứu học sinh";
            // 
            // frmTraCuuHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 441);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvKetQua);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTraCuuHocSinh";
            this.Text = "Tra cứu học sinh";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.TextBox tbTimKiemHoTen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbTBHK2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTBHK1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbHoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvKetQua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTimLop;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbTatCa;
    }
}