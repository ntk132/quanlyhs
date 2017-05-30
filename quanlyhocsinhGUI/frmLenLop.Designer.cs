namespace quanlyhocsinhGUI
{
    partial class frmLenLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLenLop));
            this.btThayDoiLop = new System.Windows.Forms.Button();
            this.cbNamHocMoi = new System.Windows.Forms.ComboBox();
            this.cbNamHocCu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLopMoi = new System.Windows.Forms.DataGridView();
            this.dgvLopCu = new System.Windows.Forms.DataGridView();
            this.cbLopHocMoi = new System.Windows.Forms.ComboBox();
            this.cbLopHocCu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopMoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopCu)).BeginInit();
            this.SuspendLayout();
            // 
            // btThayDoiLop
            // 
            this.btThayDoiLop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btThayDoiLop.Location = new System.Drawing.Point(405, 162);
            this.btThayDoiLop.Name = "btThayDoiLop";
            this.btThayDoiLop.Size = new System.Drawing.Size(75, 50);
            this.btThayDoiLop.TabIndex = 13;
            this.btThayDoiLop.Text = "Thay đổi";
            this.btThayDoiLop.UseVisualStyleBackColor = true;
            this.btThayDoiLop.Click += new System.EventHandler(this.btThayDoiLop_Click);
            // 
            // cbNamHocMoi
            // 
            this.cbNamHocMoi.FormattingEnabled = true;
            this.cbNamHocMoi.Location = new System.Drawing.Point(568, 31);
            this.cbNamHocMoi.Name = "cbNamHocMoi";
            this.cbNamHocMoi.Size = new System.Drawing.Size(200, 24);
            this.cbNamHocMoi.TabIndex = 12;
            this.cbNamHocMoi.SelectedIndexChanged += new System.EventHandler(this.cbNamHocMoi_SelectedIndexChanged);
            // 
            // cbNamHocCu
            // 
            this.cbNamHocCu.FormattingEnabled = true;
            this.cbNamHocCu.Location = new System.Drawing.Point(101, 31);
            this.cbNamHocCu.Name = "cbNamHocCu";
            this.cbNamHocCu.Size = new System.Drawing.Size(200, 24);
            this.cbNamHocCu.TabIndex = 11;
            this.cbNamHocCu.SelectedIndexChanged += new System.EventHandler(this.cbNamHocCu_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Năm học:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Năm học:";
            // 
            // dgvLopMoi
            // 
            this.dgvLopMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLopMoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLopMoi.Location = new System.Drawing.Point(496, 118);
            this.dgvLopMoi.Name = "dgvLopMoi";
            this.dgvLopMoi.Size = new System.Drawing.Size(363, 318);
            this.dgvLopMoi.TabIndex = 8;
            this.dgvLopMoi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLopMoi_CellClick);
            // 
            // dgvLopCu
            // 
            this.dgvLopCu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLopCu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLopCu.Location = new System.Drawing.Point(29, 118);
            this.dgvLopCu.Name = "dgvLopCu";
            this.dgvLopCu.Size = new System.Drawing.Size(359, 318);
            this.dgvLopCu.TabIndex = 7;
            this.dgvLopCu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLopCu_CellClick);
            // 
            // cbLopHocMoi
            // 
            this.cbLopHocMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLopHocMoi.FormattingEnabled = true;
            this.cbLopHocMoi.Location = new System.Drawing.Point(568, 67);
            this.cbLopHocMoi.Name = "cbLopHocMoi";
            this.cbLopHocMoi.Size = new System.Drawing.Size(100, 24);
            this.cbLopHocMoi.TabIndex = 17;
            this.cbLopHocMoi.SelectedIndexChanged += new System.EventHandler(this.cbLopHocMoi_SelectedIndexChanged);
            // 
            // cbLopHocCu
            // 
            this.cbLopHocCu.FormattingEnabled = true;
            this.cbLopHocCu.Location = new System.Drawing.Point(101, 67);
            this.cbLopHocCu.Name = "cbLopHocCu";
            this.cbLopHocCu.Size = new System.Drawing.Size(100, 24);
            this.cbLopHocCu.TabIndex = 16;
            this.cbLopHocCu.SelectedIndexChanged += new System.EventHandler(this.cbLopHocCu_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(493, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Chọn lớp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Chọn lớp:";
            // 
            // frmLenLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.cbLopHocMoi);
            this.Controls.Add(this.cbLopHocCu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btThayDoiLop);
            this.Controls.Add(this.cbNamHocMoi);
            this.Controls.Add(this.cbNamHocCu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLopMoi);
            this.Controls.Add(this.dgvLopCu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLenLop";
            this.Text = "Lên lớp";
            this.Load += new System.EventHandler(this.frmLenLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopMoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopCu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btThayDoiLop;
        private System.Windows.Forms.ComboBox cbNamHocMoi;
        private System.Windows.Forms.ComboBox cbNamHocCu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLopMoi;
        private System.Windows.Forms.DataGridView dgvLopCu;
        private System.Windows.Forms.ComboBox cbLopHocMoi;
        private System.Windows.Forms.ComboBox cbLopHocCu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}