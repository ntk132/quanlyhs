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
            this.dgvBaoCao = new System.Windows.Forms.DataGridView();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.cbMonHoc = new System.Windows.Forms.ComboBox();
            this.btXemBaoCao = new System.Windows.Forms.Button();
            this.chbMonHoc = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBaoCao
            // 
            this.dgvBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoCao.Location = new System.Drawing.Point(24, 105);
            this.dgvBaoCao.Name = "dgvBaoCao";
            this.dgvBaoCao.Size = new System.Drawing.Size(534, 432);
            this.dgvBaoCao.TabIndex = 6;
            this.dgvBaoCao.SelectionChanged += new System.EventHandler(this.dgvBaoCao_SelectionChanged);
            // 
            // cbHocKy
            // 
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Location = new System.Drawing.Point(123, 27);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(121, 24);
            this.cbHocKy.TabIndex = 3;
            // 
            // cbMonHoc
            // 
            this.cbMonHoc.FormattingEnabled = true;
            this.cbMonHoc.Location = new System.Drawing.Point(123, 57);
            this.cbMonHoc.Name = "cbMonHoc";
            this.cbMonHoc.Size = new System.Drawing.Size(121, 24);
            this.cbMonHoc.TabIndex = 3;
            // 
            // btXemBaoCao
            // 
            this.btXemBaoCao.Location = new System.Drawing.Point(293, 26);
            this.btXemBaoCao.Name = "btXemBaoCao";
            this.btXemBaoCao.Size = new System.Drawing.Size(100, 25);
            this.btXemBaoCao.TabIndex = 7;
            this.btXemBaoCao.Text = "Xem báo cáo";
            this.btXemBaoCao.UseVisualStyleBackColor = true;
            this.btXemBaoCao.Click += new System.EventHandler(this.btXemBaoCao_Click);
            // 
            // chbMonHoc
            // 
            this.chbMonHoc.AutoSize = true;
            this.chbMonHoc.Location = new System.Drawing.Point(24, 59);
            this.chbMonHoc.Name = "chbMonHoc";
            this.chbMonHoc.Size = new System.Drawing.Size(81, 20);
            this.chbMonHoc.TabIndex = 9;
            this.chbMonHoc.Text = "Môn học:";
            this.chbMonHoc.UseVisualStyleBackColor = true;
            this.chbMonHoc.CheckedChanged += new System.EventHandler(this.chbMonHoc_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Học kỳ:";
            // 
            // frmLapBaoCaoTongHop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chbMonHoc);
            this.Controls.Add(this.btXemBaoCao);
            this.Controls.Add(this.cbMonHoc);
            this.Controls.Add(this.cbHocKy);
            this.Controls.Add(this.dgvBaoCao);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLapBaoCaoTongHop";
            this.Text = "Báo cáo tổng kết";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBaoCao;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.ComboBox cbMonHoc;
        private System.Windows.Forms.Button btXemBaoCao;
        private System.Windows.Forms.CheckBox chbMonHoc;
        private System.Windows.Forms.Label label1;
    }
}