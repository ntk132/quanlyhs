namespace quanlyhocsinhGUI
{
    partial class frmXepLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXepLop));
            this.dgvLopCu = new System.Windows.Forms.DataGridView();
            this.dgvLopMoi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLopCu = new System.Windows.Forms.ComboBox();
            this.cbLopMoi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btThayDoiLop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopCu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopMoi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLopCu
            // 
            this.dgvLopCu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLopCu.Location = new System.Drawing.Point(28, 75);
            this.dgvLopCu.Name = "dgvLopCu";
            this.dgvLopCu.Size = new System.Drawing.Size(300, 300);
            this.dgvLopCu.TabIndex = 0;
            // 
            // dgvLopMoi
            // 
            this.dgvLopMoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLopMoi.Location = new System.Drawing.Point(450, 75);
            this.dgvLopMoi.Name = "dgvLopMoi";
            this.dgvLopMoi.Size = new System.Drawing.Size(300, 300);
            this.dgvLopMoi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn lớp:";
            // 
            // cbLopCu
            // 
            this.cbLopCu.FormattingEnabled = true;
            this.cbLopCu.Location = new System.Drawing.Point(100, 22);
            this.cbLopCu.Name = "cbLopCu";
            this.cbLopCu.Size = new System.Drawing.Size(100, 24);
            this.cbLopCu.TabIndex = 4;
            // 
            // cbLopMoi
            // 
            this.cbLopMoi.FormattingEnabled = true;
            this.cbLopMoi.Location = new System.Drawing.Point(522, 22);
            this.cbLopMoi.Name = "cbLopMoi";
            this.cbLopMoi.Size = new System.Drawing.Size(100, 24);
            this.cbLopMoi.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chọn lớp:";
            // 
            // btThayDoiLop
            // 
            this.btThayDoiLop.Location = new System.Drawing.Point(350, 130);
            this.btThayDoiLop.Name = "btThayDoiLop";
            this.btThayDoiLop.Size = new System.Drawing.Size(75, 50);
            this.btThayDoiLop.TabIndex = 6;
            this.btThayDoiLop.Text = "Thay đổi";
            this.btThayDoiLop.UseVisualStyleBackColor = true;
            // 
            // frmXepLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 403);
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
            this.Name = "frmXepLop";
            this.Text = "Xếp lớp";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopCu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopMoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLopCu;
        private System.Windows.Forms.DataGridView dgvLopMoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLopCu;
        private System.Windows.Forms.ComboBox cbLopMoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btThayDoiLop;
    }
}