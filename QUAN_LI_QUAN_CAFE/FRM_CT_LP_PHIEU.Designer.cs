namespace QUAN_LI_QUAN_CAFE
{
    partial class FRM_CT_LP_PHIEU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_CT_LP_PHIEU));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numSoluong = new System.Windows.Forms.NumericUpDown();
            this.rdbCombo = new System.Windows.Forms.RadioButton();
            this.rdbDoUong = new System.Windows.Forms.RadioButton();
            this.txtMaThanhPhan = new System.Windows.Forms.TextBox();
            this.txtGhichu = new System.Windows.Forms.TextBox();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.cbbTenThanhPhan = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtgvCTphieuBH = new System.Windows.Forms.DataGridView();
            this.BT_THEM = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.BT_XOA = new System.Windows.Forms.Button();
            this.BTT_THEM = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaphieu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoluong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCTphieuBH)).BeginInit();
            this.BT_THEM.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(541, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHI TIẾT HÓA ĐƠN";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numSoluong);
            this.groupBox3.Controls.Add(this.rdbCombo);
            this.groupBox3.Controls.Add(this.rdbDoUong);
            this.groupBox3.Controls.Add(this.txtMaThanhPhan);
            this.groupBox3.Controls.Add(this.txtGhichu);
            this.groupBox3.Controls.Add(this.txtDongia);
            this.groupBox3.Controls.Add(this.cbbTenThanhPhan);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(501, 73);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(523, 271);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "THÀNH PHẦN";
            // 
            // numSoluong
            // 
            this.numSoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numSoluong.Location = new System.Drawing.Point(288, 139);
            this.numSoluong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoluong.Name = "numSoluong";
            this.numSoluong.Size = new System.Drawing.Size(215, 30);
            this.numSoluong.TabIndex = 39;
            this.numSoluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numSoluong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rdbCombo
            // 
            this.rdbCombo.AutoSize = true;
            this.rdbCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdbCombo.Location = new System.Drawing.Point(259, 18);
            this.rdbCombo.Name = "rdbCombo";
            this.rdbCombo.Size = new System.Drawing.Size(102, 28);
            this.rdbCombo.TabIndex = 25;
            this.rdbCombo.Text = "COMBO";
            this.rdbCombo.UseVisualStyleBackColor = true;
            // 
            // rdbDoUong
            // 
            this.rdbDoUong.AutoSize = true;
            this.rdbDoUong.Checked = true;
            this.rdbDoUong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdbDoUong.Location = new System.Drawing.Point(81, 18);
            this.rdbDoUong.Name = "rdbDoUong";
            this.rdbDoUong.Size = new System.Drawing.Size(120, 28);
            this.rdbDoUong.TabIndex = 24;
            this.rdbDoUong.TabStop = true;
            this.rdbDoUong.Text = "ĐỒ UỐNG";
            this.rdbDoUong.UseVisualStyleBackColor = true;
            this.rdbDoUong.CheckedChanged += new System.EventHandler(this.rdbDoUong_CheckedChanged);
            // 
            // txtMaThanhPhan
            // 
            this.txtMaThanhPhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaThanhPhan.Location = new System.Drawing.Point(288, 51);
            this.txtMaThanhPhan.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaThanhPhan.Multiline = true;
            this.txtMaThanhPhan.Name = "txtMaThanhPhan";
            this.txtMaThanhPhan.ReadOnly = true;
            this.txtMaThanhPhan.Size = new System.Drawing.Size(215, 30);
            this.txtMaThanhPhan.TabIndex = 5;
            this.txtMaThanhPhan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGhichu
            // 
            this.txtGhichu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhichu.Location = new System.Drawing.Point(288, 216);
            this.txtGhichu.Margin = new System.Windows.Forms.Padding(4);
            this.txtGhichu.Multiline = true;
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(215, 30);
            this.txtGhichu.TabIndex = 9;
            this.txtGhichu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDongia
            // 
            this.txtDongia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDongia.Location = new System.Drawing.Point(288, 176);
            this.txtDongia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDongia.Multiline = true;
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.ReadOnly = true;
            this.txtDongia.Size = new System.Drawing.Size(215, 30);
            this.txtDongia.TabIndex = 9;
            this.txtDongia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbbTenThanhPhan
            // 
            this.cbbTenThanhPhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenThanhPhan.FormattingEnabled = true;
            this.cbbTenThanhPhan.Location = new System.Drawing.Point(288, 95);
            this.cbbTenThanhPhan.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTenThanhPhan.Name = "cbbTenThanhPhan";
            this.cbbTenThanhPhan.Size = new System.Drawing.Size(215, 28);
            this.cbbTenThanhPhan.TabIndex = 4;
            this.cbbTenThanhPhan.SelectedIndexChanged += new System.EventHandler(this.cbbTenThanhPhan_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 175);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 29);
            this.label6.TabIndex = 23;
            this.label6.Text = "ĐƠN GIÁ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 215);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "GHI CHÚ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 137);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 29);
            this.label8.TabIndex = 18;
            this.label8.Text = "SỐ LƯỢNG";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 50);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(221, 29);
            this.label10.TabIndex = 17;
            this.label10.Text = "MÃ THÀNH PHẦN";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 94);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(233, 29);
            this.label9.TabIndex = 17;
            this.label9.Text = "TÊN THÀNH PHẦN";
            // 
            // dtgvCTphieuBH
            // 
            this.dtgvCTphieuBH.AllowUserToAddRows = false;
            this.dtgvCTphieuBH.AllowUserToDeleteRows = false;
            this.dtgvCTphieuBH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCTphieuBH.Location = new System.Drawing.Point(9, 73);
            this.dtgvCTphieuBH.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvCTphieuBH.Name = "dtgvCTphieuBH";
            this.dtgvCTphieuBH.ReadOnly = true;
            this.dtgvCTphieuBH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvCTphieuBH.Size = new System.Drawing.Size(484, 441);
            this.dtgvCTphieuBH.TabIndex = 6;
            this.dtgvCTphieuBH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCTphieuBH_CellContentClick);
            // 
            // BT_THEM
            // 
            this.BT_THEM.Controls.Add(this.btnExit);
            this.BT_THEM.Controls.Add(this.BT_XOA);
            this.BT_THEM.Controls.Add(this.BTT_THEM);
            this.BT_THEM.Location = new System.Drawing.Point(501, 352);
            this.BT_THEM.Margin = new System.Windows.Forms.Padding(4);
            this.BT_THEM.Name = "BT_THEM";
            this.BT_THEM.Padding = new System.Windows.Forms.Padding(4);
            this.BT_THEM.Size = new System.Drawing.Size(523, 172);
            this.BT_THEM.TabIndex = 38;
            this.BT_THEM.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(8, 92);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(255, 70);
            this.btnExit.TabIndex = 38;
            this.btnExit.Text = "THOÁT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // BT_XOA
            // 
            this.BT_XOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_XOA.Location = new System.Drawing.Point(271, 18);
            this.BT_XOA.Margin = new System.Windows.Forms.Padding(4);
            this.BT_XOA.Name = "BT_XOA";
            this.BT_XOA.Size = new System.Drawing.Size(244, 70);
            this.BT_XOA.TabIndex = 38;
            this.BT_XOA.Text = "XÓA THÀNH PHẦN";
            this.BT_XOA.UseVisualStyleBackColor = true;
            this.BT_XOA.Click += new System.EventHandler(this.BT_XOA_Click);
            // 
            // BTT_THEM
            // 
            this.BTT_THEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTT_THEM.Location = new System.Drawing.Point(8, 18);
            this.BTT_THEM.Margin = new System.Windows.Forms.Padding(4);
            this.BTT_THEM.Name = "BTT_THEM";
            this.BTT_THEM.Size = new System.Drawing.Size(255, 70);
            this.BTT_THEM.TabIndex = 38;
            this.BTT_THEM.Text = "THÊM THÀNH PHẦN";
            this.BTT_THEM.UseVisualStyleBackColor = true;
            this.BTT_THEM.Click += new System.EventHandler(this.BTT_THEM_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaphieu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(484, 55);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            // 
            // txtMaphieu
            // 
            this.txtMaphieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaphieu.Location = new System.Drawing.Point(182, 15);
            this.txtMaphieu.Name = "txtMaphieu";
            this.txtMaphieu.ReadOnly = true;
            this.txtMaphieu.Size = new System.Drawing.Size(295, 30);
            this.txtMaphieu.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "MÃ HÓA ĐƠN ";
            // 
            // FRM_CT_LP_PHIEU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 533);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BT_THEM);
            this.Controls.Add(this.dtgvCTphieuBH);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FRM_CT_LP_PHIEU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHI TIẾT HÓA ĐƠN";
            this.Load += new System.EventHandler(this.FRM_CT_LP_PHIEU_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoluong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCTphieuBH)).EndInit();
            this.BT_THEM.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMaThanhPhan;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.ComboBox cbbTenThanhPhan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dtgvCTphieuBH;
        private System.Windows.Forms.GroupBox BT_THEM;
        private System.Windows.Forms.Button BT_XOA;
        private System.Windows.Forms.Button BTT_THEM;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbCombo;
        private System.Windows.Forms.RadioButton rdbDoUong;
        private System.Windows.Forms.TextBox txtMaphieu;
        private System.Windows.Forms.NumericUpDown numSoluong;
        private System.Windows.Forms.TextBox txtGhichu;
        private System.Windows.Forms.Label label3;
    }
}