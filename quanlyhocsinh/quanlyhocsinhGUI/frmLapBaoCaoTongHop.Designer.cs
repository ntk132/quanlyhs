namespace quanlyhocsinhGUI
{
    partial class frmLapBaoCaoTongHop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLapBaoCaoTongHop));
            this.cbLopHoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvBaoCao = new System.Windows.Forms.DataGridView();
            this.rbHocKy = new System.Windows.Forms.RadioButton();
            this.rbMonHoc = new System.Windows.Forms.RadioButton();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.cbMonHoc = new System.Windows.Forms.ComboBox();
            this.btXemBaoCao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // cbLopHoc
            // 
            this.cbLopHoc.FormattingEnabled = true;
            this.cbLopHoc.Location = new System.Drawing.Point(52, 15);
            this.cbLopHoc.Name = "cbLopHoc";
            this.cbLopHoc.Size = new System.Drawing.Size(100, 24);
            this.cbLopHoc.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lớp:";
            // 
            // dgvBaoCao
            // 
            this.dgvBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoCao.Location = new System.Drawing.Point(12, 84);
            this.dgvBaoCao.Name = "dgvBaoCao";
            this.dgvBaoCao.Size = new System.Drawing.Size(500, 240);
            this.dgvBaoCao.TabIndex = 6;
            // 
            // rbHocKy
            // 
            this.rbHocKy.AutoSize = true;
            this.rbHocKy.Location = new System.Drawing.Point(177, 16);
            this.rbHocKy.Name = "rbHocKy";
            this.rbHocKy.Size = new System.Drawing.Size(68, 20);
            this.rbHocKy.TabIndex = 2;
            this.rbHocKy.TabStop = true;
            this.rbHocKy.Text = "Học kỳ";
            this.rbHocKy.UseVisualStyleBackColor = true;
            this.rbHocKy.CheckedChanged += new System.EventHandler(this.rbHocKy_CheckedChanged);
            // 
            // rbMonHoc
            // 
            this.rbMonHoc.AutoSize = true;
            this.rbMonHoc.Location = new System.Drawing.Point(177, 46);
            this.rbMonHoc.Name = "rbMonHoc";
            this.rbMonHoc.Size = new System.Drawing.Size(77, 20);
            this.rbMonHoc.TabIndex = 2;
            this.rbMonHoc.TabStop = true;
            this.rbMonHoc.Text = "Môn học";
            this.rbMonHoc.UseVisualStyleBackColor = true;
            this.rbMonHoc.CheckedChanged += new System.EventHandler(this.rbMonHoc_CheckedChanged);
            // 
            // cbHocKy
            // 
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Location = new System.Drawing.Point(260, 15);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(121, 24);
            this.cbHocKy.TabIndex = 3;
            // 
            // cbMonHoc
            // 
            this.cbMonHoc.FormattingEnabled = true;
            this.cbMonHoc.Location = new System.Drawing.Point(260, 45);
            this.cbMonHoc.Name = "cbMonHoc";
            this.cbMonHoc.Size = new System.Drawing.Size(121, 24);
            this.cbMonHoc.TabIndex = 3;
            // 
            // btXemBaoCao
            // 
            this.btXemBaoCao.Location = new System.Drawing.Point(413, 14);
            this.btXemBaoCao.Name = "btXemBaoCao";
            this.btXemBaoCao.Size = new System.Drawing.Size(100, 25);
            this.btXemBaoCao.TabIndex = 7;
            this.btXemBaoCao.Text = "Xem báo cáo";
            this.btXemBaoCao.UseVisualStyleBackColor = true;
            // 
            // frmLapBaoCaoTongHop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 336);
            this.Controls.Add(this.btXemBaoCao);
            this.Controls.Add(this.cbMonHoc);
            this.Controls.Add(this.cbHocKy);
            this.Controls.Add(this.rbMonHoc);
            this.Controls.Add(this.rbHocKy);
            this.Controls.Add(this.cbLopHoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvBaoCao);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLapBaoCaoTongHop";
            this.Text = "Báo cáo tổng kết học kỳ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLopHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvBaoCao;
        private System.Windows.Forms.RadioButton rbHocKy;
        private System.Windows.Forms.RadioButton rbMonHoc;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.ComboBox cbMonHoc;
        private System.Windows.Forms.Button btXemBaoCao;
    }
}