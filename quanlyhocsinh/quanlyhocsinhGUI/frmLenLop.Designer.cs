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
            this.cbLopMoi = new System.Windows.Forms.ComboBox();
            this.cbLopCu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLopMoi = new System.Windows.Forms.DataGridView();
            this.dgvLopCu = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopMoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopCu)).BeginInit();
            this.SuspendLayout();
            // 
            // btThayDoiLop
            // 
            this.btThayDoiLop.Location = new System.Drawing.Point(351, 133);
            this.btThayDoiLop.Name = "btThayDoiLop";
            this.btThayDoiLop.Size = new System.Drawing.Size(75, 50);
            this.btThayDoiLop.TabIndex = 13;
            this.btThayDoiLop.Text = "Thay đổi";
            this.btThayDoiLop.UseVisualStyleBackColor = true;
            // 
            // cbLopMoi
            // 
            this.cbLopMoi.FormattingEnabled = true;
            this.cbLopMoi.Location = new System.Drawing.Point(523, 12);
            this.cbLopMoi.Name = "cbLopMoi";
            this.cbLopMoi.Size = new System.Drawing.Size(200, 24);
            this.cbLopMoi.TabIndex = 12;
            // 
            // cbLopCu
            // 
            this.cbLopCu.FormattingEnabled = true;
            this.cbLopCu.Location = new System.Drawing.Point(101, 12);
            this.cbLopCu.Name = "cbLopCu";
            this.cbLopCu.Size = new System.Drawing.Size(200, 24);
            this.cbLopCu.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Năm học:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Năm học:";
            // 
            // dgvLopMoi
            // 
            this.dgvLopMoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLopMoi.Location = new System.Drawing.Point(451, 78);
            this.dgvLopMoi.Name = "dgvLopMoi";
            this.dgvLopMoi.Size = new System.Drawing.Size(300, 300);
            this.dgvLopMoi.TabIndex = 8;
            // 
            // dgvLopCu
            // 
            this.dgvLopCu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLopCu.Location = new System.Drawing.Point(29, 78);
            this.dgvLopCu.Name = "dgvLopCu";
            this.dgvLopCu.Size = new System.Drawing.Size(300, 300);
            this.dgvLopCu.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(523, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 24);
            this.comboBox1.TabIndex = 17;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(101, 48);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 24);
            this.comboBox2.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Chọn lớp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Chọn lớp:";
            // 
            // frmLenLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 403);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btThayDoiLop);
            this.Controls.Add(this.cbLopMoi);
            this.Controls.Add(this.cbLopCu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLopMoi);
            this.Controls.Add(this.dgvLopCu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLenLop";
            this.Text = "Lên lớp";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopMoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopCu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btThayDoiLop;
        private System.Windows.Forms.ComboBox cbLopMoi;
        private System.Windows.Forms.ComboBox cbLopCu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLopMoi;
        private System.Windows.Forms.DataGridView dgvLopCu;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}