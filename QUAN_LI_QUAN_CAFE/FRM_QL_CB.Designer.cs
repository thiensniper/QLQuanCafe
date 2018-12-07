namespace QUAN_LI_QUAN_CAFE
{
    partial class FRM_QL_CB
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_QL_CB));
            this.GB_2 = new System.Windows.Forms.GroupBox();
            this.btSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.txtMacombo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTencombo = new System.Windows.Forms.TextBox();
            this.GB_1 = new System.Windows.Forms.GroupBox();
            this.BT_THEM = new System.Windows.Forms.Button();
            this.BT_SUA = new System.Windows.Forms.Button();
            this.BT_XOA = new System.Windows.Forms.Button();
            this.BT_E = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvCombo = new System.Windows.Forms.DataGridView();
            this.MaCombo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCombo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DongiaCombo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.GB_2.SuspendLayout();
            this.GB_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCombo)).BeginInit();
            this.SuspendLayout();
            // 
            // GB_2
            // 
            this.GB_2.Controls.Add(this.btSave);
            this.GB_2.Controls.Add(this.btCancel);
            this.GB_2.Controls.Add(this.txtMacombo);
            this.GB_2.Controls.Add(this.label2);
            this.GB_2.Controls.Add(this.label3);
            this.GB_2.Controls.Add(this.txtTencombo);
            this.GB_2.Location = new System.Drawing.Point(9, 302);
            this.GB_2.Name = "GB_2";
            this.GB_2.Size = new System.Drawing.Size(727, 88);
            this.GB_2.TabIndex = 13;
            this.GB_2.TabStop = false;
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Location = new System.Drawing.Point(314, 19);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(229, 59);
            this.btSave.TabIndex = 5;
            this.btSave.Text = "LƯU";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Location = new System.Drawing.Point(549, 19);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(171, 59);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "HỦY";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // txtMacombo
            // 
            this.txtMacombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMacombo.Location = new System.Drawing.Point(136, 19);
            this.txtMacombo.Multiline = true;
            this.txtMacombo.Name = "txtMacombo";
            this.txtMacombo.Size = new System.Drawing.Size(173, 25);
            this.txtMacombo.TabIndex = 4;
            this.txtMacombo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "MÃ COMBO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "TÊN COMBO";
            // 
            // txtTencombo
            // 
            this.txtTencombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTencombo.Location = new System.Drawing.Point(136, 51);
            this.txtTencombo.Multiline = true;
            this.txtTencombo.Name = "txtTencombo";
            this.txtTencombo.Size = new System.Drawing.Size(173, 25);
            this.txtTencombo.TabIndex = 4;
            this.txtTencombo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GB_1
            // 
            this.GB_1.Controls.Add(this.BT_THEM);
            this.GB_1.Controls.Add(this.BT_SUA);
            this.GB_1.Controls.Add(this.BT_XOA);
            this.GB_1.Controls.Add(this.BT_E);
            this.GB_1.Location = new System.Drawing.Point(533, 39);
            this.GB_1.Name = "GB_1";
            this.GB_1.Size = new System.Drawing.Size(203, 261);
            this.GB_1.TabIndex = 10;
            this.GB_1.TabStop = false;
            // 
            // BT_THEM
            // 
            this.BT_THEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_THEM.Location = new System.Drawing.Point(6, 13);
            this.BT_THEM.Name = "BT_THEM";
            this.BT_THEM.Size = new System.Drawing.Size(190, 57);
            this.BT_THEM.TabIndex = 1;
            this.BT_THEM.Text = "THÊM COMBO MỚI";
            this.BT_THEM.UseVisualStyleBackColor = true;
            this.BT_THEM.Click += new System.EventHandler(this.BT_THEM_Click);
            // 
            // BT_SUA
            // 
            this.BT_SUA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_SUA.Location = new System.Drawing.Point(6, 74);
            this.BT_SUA.Name = "BT_SUA";
            this.BT_SUA.Size = new System.Drawing.Size(190, 57);
            this.BT_SUA.TabIndex = 2;
            this.BT_SUA.Text = "CHỈNH SỬA COMBO";
            this.BT_SUA.UseVisualStyleBackColor = true;
            this.BT_SUA.Click += new System.EventHandler(this.BT_SUA_Click);
            // 
            // BT_XOA
            // 
            this.BT_XOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_XOA.Location = new System.Drawing.Point(6, 135);
            this.BT_XOA.Name = "BT_XOA";
            this.BT_XOA.Size = new System.Drawing.Size(190, 57);
            this.BT_XOA.TabIndex = 3;
            this.BT_XOA.Text = "XÓA COMBO";
            this.BT_XOA.UseVisualStyleBackColor = true;
            this.BT_XOA.Click += new System.EventHandler(this.BT_XOA_Click);
            // 
            // BT_E
            // 
            this.BT_E.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_E.ForeColor = System.Drawing.Color.Red;
            this.BT_E.Location = new System.Drawing.Point(6, 196);
            this.BT_E.Name = "BT_E";
            this.BT_E.Size = new System.Drawing.Size(190, 57);
            this.BT_E.TabIndex = 4;
            this.BT_E.Text = "THOÁT";
            this.BT_E.UseVisualStyleBackColor = true;
            this.BT_E.Click += new System.EventHandler(this.BT_E_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, -55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "DANH SÁCH ĐỒ UỐNG";
            // 
            // dtgvCombo
            // 
            this.dtgvCombo.AllowUserToAddRows = false;
            this.dtgvCombo.AllowUserToDeleteRows = false;
            this.dtgvCombo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCombo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCombo,
            this.TenCombo,
            this.DongiaCombo});
            this.dtgvCombo.Location = new System.Drawing.Point(9, 45);
            this.dtgvCombo.MultiSelect = false;
            this.dtgvCombo.Name = "dtgvCombo";
            this.dtgvCombo.ReadOnly = true;
            this.dtgvCombo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvCombo.Size = new System.Drawing.Size(518, 255);
            this.dtgvCombo.TabIndex = 11;
            // 
            // MaCombo
            // 
            this.MaCombo.DataPropertyName = "ID";
            this.MaCombo.HeaderText = "Mã Combo";
            this.MaCombo.Name = "MaCombo";
            this.MaCombo.ReadOnly = true;
            // 
            // TenCombo
            // 
            this.TenCombo.DataPropertyName = "Name";
            this.TenCombo.HeaderText = "Tên combo";
            this.TenCombo.Name = "TenCombo";
            this.TenCombo.ReadOnly = true;
            // 
            // DongiaCombo
            // 
            this.DongiaCombo.DataPropertyName = "Dongia";
            dataGridViewCellStyle1.Format = "###,# VNĐ";
            dataGridViewCellStyle1.NullValue = null;
            this.DongiaCombo.DefaultCellStyle = dataGridViewCellStyle1;
            this.DongiaCombo.HeaderText = "Đơn giá";
            this.DongiaCombo.Name = "DongiaCombo";
            this.DongiaCombo.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(72, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(432, 31);
            this.label8.TabIndex = 14;
            this.label8.Text = "THÊM COMBO VÀO DANH SÁCH";
            // 
            // FRM_QL_CB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 398);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.GB_2);
            this.Controls.Add(this.GB_1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvCombo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FRM_QL_CB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LẬP DANH SÁCH COMBO";
            this.Load += new System.EventHandler(this.FRM_QL_CB_Load);
            this.GB_2.ResumeLayout(false);
            this.GB_2.PerformLayout();
            this.GB_1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCombo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_2;
        private System.Windows.Forms.TextBox txtMacombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTencombo;
        private System.Windows.Forms.GroupBox GB_1;
        private System.Windows.Forms.Button BT_THEM;
        private System.Windows.Forms.Button BT_SUA;
        private System.Windows.Forms.Button BT_XOA;
        private System.Windows.Forms.Button BT_E;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvCombo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DongiaCombo;
    }
}