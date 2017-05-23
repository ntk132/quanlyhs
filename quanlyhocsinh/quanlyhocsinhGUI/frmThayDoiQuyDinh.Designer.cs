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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMaMon = new System.Windows.Forms.TextBox();
            this.tbTenMon = new System.Windows.Forms.TextBox();
            this.tbSiSiToiDa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDiemDatMon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btSuaMon = new System.Windows.Forms.Button();
            this.btThemMon = new System.Windows.Forms.Button();
            this.btXoaMon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMonHoc
            // 
            this.dgvMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonHoc.Location = new System.Drawing.Point(391, 122);
            this.dgvMonHoc.Name = "dgvMonHoc";
            this.dgvMonHoc.Size = new System.Drawing.Size(300, 260);
            this.dgvMonHoc.TabIndex = 0;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã môn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tên môn:";
            // 
            // tbMaMon
            // 
            this.tbMaMon.Location = new System.Drawing.Point(453, 38);
            this.tbMaMon.Name = "tbMaMon";
            this.tbMaMon.Size = new System.Drawing.Size(100, 22);
            this.tbMaMon.TabIndex = 14;
            // 
            // tbTenMon
            // 
            this.tbTenMon.Location = new System.Drawing.Point(453, 80);
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
            this.btSuaMon.Location = new System.Drawing.Point(616, 54);
            this.btSuaMon.Name = "btSuaMon";
            this.btSuaMon.Size = new System.Drawing.Size(75, 25);
            this.btSuaMon.TabIndex = 22;
            this.btSuaMon.Text = "Sửa";
            this.btSuaMon.UseVisualStyleBackColor = true;
            this.btSuaMon.Click += new System.EventHandler(this.btSuaMon_Click);
            // 
            // btThemMon
            // 
            this.btThemMon.Location = new System.Drawing.Point(616, 25);
            this.btThemMon.Name = "btThemMon";
            this.btThemMon.Size = new System.Drawing.Size(75, 25);
            this.btThemMon.TabIndex = 21;
            this.btThemMon.Text = "Thêm";
            this.btThemMon.UseVisualStyleBackColor = true;
            this.btThemMon.Click += new System.EventHandler(this.btThemMon_Click);
            // 
            // btXoaMon
            // 
            this.btXoaMon.Location = new System.Drawing.Point(616, 83);
            this.btXoaMon.Name = "btXoaMon";
            this.btXoaMon.Size = new System.Drawing.Size(75, 25);
            this.btXoaMon.TabIndex = 23;
            this.btXoaMon.Text = "Xóa";
            this.btXoaMon.UseVisualStyleBackColor = true;
            this.btXoaMon.Click += new System.EventHandler(this.btXoaMon_Click);
            // 
            // frmThayDoiQuyDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 411);
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
            this.Controls.Add(this.tbMaMon);
            this.Controls.Add(this.tbTuoiToiThieu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvMonHoc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThayDoiQuyDinh";
            this.Text = "Thay đổi quy định";
            this.Load += new System.EventHandler(this.frmThayDoiQuyDinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMaMon;
        private System.Windows.Forms.TextBox tbTenMon;
        private System.Windows.Forms.TextBox tbSiSiToiDa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDiemDatMon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btSuaMon;
        private System.Windows.Forms.Button btThemMon;
        private System.Windows.Forms.Button btXoaMon;
    }
}