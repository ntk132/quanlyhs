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
            this.dgvQuyDinh = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btThayDoiQD = new System.Windows.Forms.Button();
            this.tbGhiChu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbGiaTri = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTenQD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMaQD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuyDinh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvQuyDinh
            // 
            this.dgvQuyDinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuyDinh.Location = new System.Drawing.Point(12, 58);
            this.dgvQuyDinh.Name = "dgvQuyDinh";
            this.dgvQuyDinh.Size = new System.Drawing.Size(349, 213);
            this.dgvQuyDinh.TabIndex = 0;
            this.dgvQuyDinh.SelectionChanged += new System.EventHandler(this.dgvQuyDinh_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btThoat);
            this.groupBox1.Controls.Add(this.btThayDoiQD);
            this.groupBox1.Controls.Add(this.tbGhiChu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbGiaTri);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbTenQD);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbMaQD);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(369, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 212);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết quy định";
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(222, 181);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 25);
            this.btThoat.TabIndex = 11;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btThayDoiQD
            // 
            this.btThayDoiQD.Location = new System.Drawing.Point(101, 181);
            this.btThayDoiQD.Name = "btThayDoiQD";
            this.btThayDoiQD.Size = new System.Drawing.Size(75, 25);
            this.btThayDoiQD.TabIndex = 10;
            this.btThayDoiQD.Text = "Thay đổi";
            this.btThayDoiQD.UseVisualStyleBackColor = true;
            this.btThayDoiQD.Click += new System.EventHandler(this.btThayDoiQD_Click);
            // 
            // tbGhiChu
            // 
            this.tbGhiChu.Location = new System.Drawing.Point(101, 117);
            this.tbGhiChu.Name = "tbGhiChu";
            this.tbGhiChu.Size = new System.Drawing.Size(196, 22);
            this.tbGhiChu.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ghi chú:";
            // 
            // tbGiaTri
            // 
            this.tbGiaTri.Location = new System.Drawing.Point(101, 87);
            this.tbGiaTri.Name = "tbGiaTri";
            this.tbGiaTri.Size = new System.Drawing.Size(196, 22);
            this.tbGiaTri.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Giá trị:";
            // 
            // tbTenQD
            // 
            this.tbTenQD.Location = new System.Drawing.Point(101, 57);
            this.tbTenQD.Name = "tbTenQD";
            this.tbTenQD.Size = new System.Drawing.Size(196, 22);
            this.tbTenQD.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên quy định:";
            // 
            // tbMaQD
            // 
            this.tbMaQD.Location = new System.Drawing.Point(101, 25);
            this.tbMaQD.Name = "tbMaQD";
            this.tbMaQD.Size = new System.Drawing.Size(196, 22);
            this.tbMaQD.TabIndex = 3;
            this.tbMaQD.TextChanged += new System.EventHandler(this.tbMaQD_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã quy định:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(282, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Thay đổi quy định";
            // 
            // frmThayDoiQuyDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 283);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvQuyDinh);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThayDoiQuyDinh";
            this.Text = "Thay đổi quy định";
            this.Load += new System.EventHandler(this.frmThayDoiQuyDinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuyDinh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQuyDinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btThayDoiQD;
        private System.Windows.Forms.TextBox tbGhiChu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbGiaTri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTenQD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMaQD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}