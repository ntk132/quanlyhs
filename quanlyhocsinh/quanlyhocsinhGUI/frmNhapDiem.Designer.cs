namespace quanlyhocsinhGUI
{
    partial class frmNhapDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapDiem));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbMonHoc = new System.Windows.Forms.ComboBox();
            this.tbHoTen = new System.Windows.Forms.TextBox();
            this.btChon = new System.Windows.Forms.Button();
            this.tbLopHoc = new System.Windows.Forms.TextBox();
            this.tbHocKy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btLuuDiem = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbDiemTB = new System.Windows.Forms.TextBox();
            this.tbDiem1t = new System.Windows.Forms.TextBox();
            this.tbDiem15p = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbMonHoc);
            this.groupBox1.Controls.Add(this.tbHoTen);
            this.groupBox1.Controls.Add(this.btChon);
            this.groupBox1.Controls.Add(this.tbLopHoc);
            this.groupBox1.Controls.Add(this.tbHocKy);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 300);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin học sinh";
            // 
            // cbMonHoc
            // 
            this.cbMonHoc.FormattingEnabled = true;
            this.cbMonHoc.Location = new System.Drawing.Point(125, 147);
            this.cbMonHoc.Name = "cbMonHoc";
            this.cbMonHoc.Size = new System.Drawing.Size(150, 24);
            this.cbMonHoc.TabIndex = 1;
            // 
            // tbHoTen
            // 
            this.tbHoTen.Location = new System.Drawing.Point(125, 47);
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Size = new System.Drawing.Size(150, 22);
            this.tbHoTen.TabIndex = 0;
            // 
            // btChon
            // 
            this.btChon.Location = new System.Drawing.Point(200, 250);
            this.btChon.Name = "btChon";
            this.btChon.Size = new System.Drawing.Size(75, 25);
            this.btChon.TabIndex = 5;
            this.btChon.Text = "Chọn";
            this.btChon.UseVisualStyleBackColor = true;
            this.btChon.Click += new System.EventHandler(this.btChon_Click);
            // 
            // tbLopHoc
            // 
            this.tbLopHoc.Location = new System.Drawing.Point(125, 97);
            this.tbLopHoc.Name = "tbLopHoc";
            this.tbLopHoc.Size = new System.Drawing.Size(150, 22);
            this.tbLopHoc.TabIndex = 0;
            // 
            // tbHocKy
            // 
            this.tbHocKy.Location = new System.Drawing.Point(125, 197);
            this.tbHocKy.Name = "tbHocKy";
            this.tbHocKy.Size = new System.Drawing.Size(150, 22);
            this.tbHocKy.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tên học sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lớp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Môn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Học kỳ:";
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
            this.groupBox2.Location = new System.Drawing.Point(350, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 250);
            this.groupBox2.TabIndex = 0;
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
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(575, 300);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 25);
            this.btThoat.TabIndex = 7;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // frmNhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 361);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhapDiem";
            this.Text = "Nhập điểm";
            this.Load += new System.EventHandler(this.frmNhapDiem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbMonHoc;
        private System.Windows.Forms.TextBox tbHoTen;
        private System.Windows.Forms.Button btChon;
        private System.Windows.Forms.TextBox tbLopHoc;
        private System.Windows.Forms.TextBox tbHocKy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btLuuDiem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbDiemTB;
        private System.Windows.Forms.TextBox tbDiem1t;
        private System.Windows.Forms.TextBox tbDiem15p;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btThoat;
    }
}