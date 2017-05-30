namespace quanlyhocsinhGUI
{
    partial class frmThayDoiQuyDinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThayDoiQuyDinh));
            this.dgvMonHoc = new System.Windows.Forms.DataGridView();
            this.btHuyThayDoiQD = new System.Windows.Forms.Button();
            this.btLuuThayDoiQD = new System.Windows.Forms.Button();
            this.tbTuoiToiDa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTuoiToiThieu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTenMon = new System.Windows.Forms.TextBox();
            this.tbSiSiToiDa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDiemDatMon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btSuaMon = new System.Windows.Forms.Button();
            this.btThemMon = new System.Windows.Forms.Button();
            this.btXoaMon = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSiSoK12 = new System.Windows.Forms.TextBox();
            this.tbSiSoK11 = new System.Windows.Forms.TextBox();
            this.tbSiSoK10 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMonHoc
            // 
            this.dgvMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonHoc.Location = new System.Drawing.Point(628, 122);
            this.dgvMonHoc.Name = "dgvMonHoc";
            this.dgvMonHoc.Size = new System.Drawing.Size(300, 260);
            this.dgvMonHoc.TabIndex = 0;
            this.dgvMonHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonHoc_CellClick);
            this.dgvMonHoc.SelectionChanged += new System.EventHandler(this.dgvMonHoc_SelectionChanged);
            // 
            // btHuyThayDoiQD
            // 
            this.btHuyThayDoiQD.Location = new System.Drawing.Point(136, 280);
            this.btHuyThayDoiQD.Name = "btHuyThayDoiQD";
            this.btHuyThayDoiQD.Size = new System.Drawing.Size(75, 25);
            this.btHuyThayDoiQD.TabIndex = 11;
            this.btHuyThayDoiQD.Text = "Mặc định";
            this.btHuyThayDoiQD.UseVisualStyleBackColor = true;
            this.btHuyThayDoiQD.Click += new System.EventHandler(this.btHuyThayDoiQD_Click);
            // 
            // btLuuThayDoiQD
            // 
            this.btLuuThayDoiQD.Location = new System.Drawing.Point(55, 280);
            this.btLuuThayDoiQD.Name = "btLuuThayDoiQD";
            this.btLuuThayDoiQD.Size = new System.Drawing.Size(75, 25);
            this.btLuuThayDoiQD.TabIndex = 10;
            this.btLuuThayDoiQD.Text = "Lưu";
            this.btLuuThayDoiQD.UseVisualStyleBackColor = true;
            this.btLuuThayDoiQD.Click += new System.EventHandler(this.btLuuThayDoiQD_Click);
            // 
            // tbTuoiToiDa
            // 
            this.tbTuoiToiDa.Location = new System.Drawing.Point(227, 122);
            this.tbTuoiToiDa.Name = "tbTuoiToiDa";
            this.tbTuoiToiDa.Size = new System.Drawing.Size(100, 22);
            this.tbTuoiToiDa.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Thay đổi tuổi tối đa:";
            // 
            // tbTuoiToiThieu
            // 
            this.tbTuoiToiThieu.Location = new System.Drawing.Point(227, 72);
            this.tbTuoiToiThieu.Name = "tbTuoiToiThieu";
            this.tbTuoiToiThieu.Size = new System.Drawing.Size(100, 22);
            this.tbTuoiToiThieu.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thay đổi tuổi tối thiểu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(179, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Thay đổi quy định";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(625, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tên môn:";
            // 
            // tbTenMon
            // 
            this.tbTenMon.Location = new System.Drawing.Point(690, 60);
            this.tbTenMon.Name = "tbTenMon";
            this.tbTenMon.Size = new System.Drawing.Size(100, 22);
            this.tbTenMon.TabIndex = 15;
            // 
            // tbSiSiToiDa
            // 
            this.tbSiSiToiDa.Location = new System.Drawing.Point(227, 172);
            this.tbSiSiToiDa.Name = "tbSiSiToiDa";
            this.tbSiSiToiDa.Size = new System.Drawing.Size(100, 22);
            this.tbSiSiToiDa.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Thay đổi sỉ số tối đa:";
            // 
            // tbDiemDatMon
            // 
            this.tbDiemDatMon.Location = new System.Drawing.Point(227, 222);
            this.tbDiemDatMon.Name = "tbDiemDatMon";
            this.tbDiemDatMon.Size = new System.Drawing.Size(100, 22);
            this.tbDiemDatMon.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Thay đổi điểm đạt môn:";
            // 
            // btSuaMon
            // 
            this.btSuaMon.Location = new System.Drawing.Point(853, 54);
            this.btSuaMon.Name = "btSuaMon";
            this.btSuaMon.Size = new System.Drawing.Size(75, 25);
            this.btSuaMon.TabIndex = 22;
            this.btSuaMon.Text = "Sửa";
            this.btSuaMon.UseVisualStyleBackColor = true;
            this.btSuaMon.Click += new System.EventHandler(this.btSuaMon_Click);
            // 
            // btThemMon
            // 
            this.btThemMon.Location = new System.Drawing.Point(853, 25);
            this.btThemMon.Name = "btThemMon";
            this.btThemMon.Size = new System.Drawing.Size(75, 25);
            this.btThemMon.TabIndex = 21;
            this.btThemMon.Text = "Thêm";
            this.btThemMon.UseVisualStyleBackColor = true;
            this.btThemMon.Click += new System.EventHandler(this.btThemMon_Click);
            // 
            // btXoaMon
            // 
            this.btXoaMon.Location = new System.Drawing.Point(853, 83);
            this.btXoaMon.Name = "btXoaMon";
            this.btXoaMon.Size = new System.Drawing.Size(75, 25);
            this.btXoaMon.TabIndex = 23;
            this.btXoaMon.Text = "Xóa";
            this.btXoaMon.UseVisualStyleBackColor = true;
            this.btXoaMon.Click += new System.EventHandler(this.btXoaMon_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbSiSoK12);
            this.groupBox1.Controls.Add(this.tbSiSoK11);
            this.groupBox1.Controls.Add(this.tbSiSoK10);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(370, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 203);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Số lớp tối đa";
            // 
            // tbSiSoK12
            // 
            this.tbSiSoK12.Location = new System.Drawing.Point(96, 147);
            this.tbSiSoK12.Name = "tbSiSoK12";
            this.tbSiSoK12.Size = new System.Drawing.Size(100, 22);
            this.tbSiSoK12.TabIndex = 4;
            // 
            // tbSiSoK11
            // 
            this.tbSiSoK11.Location = new System.Drawing.Point(96, 97);
            this.tbSiSoK11.Name = "tbSiSoK11";
            this.tbSiSoK11.Size = new System.Drawing.Size(100, 22);
            this.tbSiSoK11.TabIndex = 4;
            // 
            // tbSiSoK10
            // 
            this.tbSiSoK10.Location = new System.Drawing.Point(96, 47);
            this.tbSiSoK10.Name = "tbSiSoK10";
            this.tbSiSoK10.Size = new System.Drawing.Size(100, 22);
            this.tbSiSoK10.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Khối 12:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Khối 11:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Khối 10:";
            // 
            // frmThayDoiQuyDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 411);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btXoaMon);
            this.Controls.Add(this.btThemMon);
            this.Controls.Add(this.btSuaMon);
            this.Controls.Add(this.btHuyThayDoiQD);
            this.Controls.Add(this.btLuuThayDoiQD);
            this.Controls.Add(this.tbDiemDatMon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbSiSiToiDa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbTuoiToiDa);
            this.Controls.Add(this.tbTenMon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTuoiToiThieu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvMonHoc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThayDoiQuyDinh";
            this.Text = "Thay đổi quy định";
            this.Load += new System.EventHandler(this.frmThayDoiQuyDinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMonHoc;
        private System.Windows.Forms.Button btHuyThayDoiQD;
        private System.Windows.Forms.Button btLuuThayDoiQD;
        private System.Windows.Forms.TextBox tbTuoiToiDa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTuoiToiThieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTenMon;
        private System.Windows.Forms.TextBox tbSiSiToiDa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDiemDatMon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btSuaMon;
        private System.Windows.Forms.Button btThemMon;
        private System.Windows.Forms.Button btXoaMon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSiSoK12;
        private System.Windows.Forms.TextBox tbSiSoK11;
        private System.Windows.Forms.TextBox tbSiSoK10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}