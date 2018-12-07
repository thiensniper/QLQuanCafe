namespace QUAN_LI_QUAN_CAFE
{
    partial class FRM_QL_DU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_QL_DU));
            this.dtgvDouong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.BT_E = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMadouong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTendouong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbLoaidouong = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.cbbDodungtangkem = new System.Windows.Forms.ComboBox();
            this.GB_1 = new System.Windows.Forms.GroupBox();
            this.GB_2 = new System.Windows.Forms.GroupBox();
            this.BT_LUU = new System.Windows.Forms.Button();
            this.BT_HUY = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdLoaiDoUong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDoTangKem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDouong)).BeginInit();
            this.GB_1.SuspendLayout();
            this.GB_2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvDouong
            // 
            this.dtgvDouong.AllowUserToAddRows = false;
            this.dtgvDouong.AllowUserToDeleteRows = false;
            this.dtgvDouong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDouong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.name,
            this.IdLoaiDoUong,
            this.IdDoTangKem,
            this.DonGia});
            this.dtgvDouong.Location = new System.Drawing.Point(11, 53);
            this.dtgvDouong.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvDouong.MultiSelect = false;
            this.dtgvDouong.Name = "dtgvDouong";
            this.dtgvDouong.ReadOnly = true;
            this.dtgvDouong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDouong.Size = new System.Drawing.Size(725, 314);
            this.dtgvDouong.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(578, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÊM ĐỒ UỐNG VÀO DANH SÁCH";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(8, 16);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(253, 70);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "THÊM ĐỒ UỐNG MỚI";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BT_THEM_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(8, 91);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(253, 70);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "CHỈNH SỬA ĐỒ UỐNG";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BT_SUA_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(8, 166);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(253, 70);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "XÓA ĐỒ UỐNG";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BT_XOA_Click);
            // 
            // BT_E
            // 
            this.BT_E.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_E.ForeColor = System.Drawing.Color.Red;
            this.BT_E.Location = new System.Drawing.Point(8, 241);
            this.BT_E.Margin = new System.Windows.Forms.Padding(4);
            this.BT_E.Name = "BT_E";
            this.BT_E.Size = new System.Drawing.Size(253, 70);
            this.BT_E.TabIndex = 11;
            this.BT_E.Text = "THOÁT";
            this.BT_E.UseVisualStyleBackColor = true;
            this.BT_E.Click += new System.EventHandler(this.BT_E_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "MÃ ĐỒ UỐNG";
            // 
            // txtMadouong
            // 
            this.txtMadouong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMadouong.Location = new System.Drawing.Point(217, 21);
            this.txtMadouong.Margin = new System.Windows.Forms.Padding(4);
            this.txtMadouong.Multiline = true;
            this.txtMadouong.Name = "txtMadouong";
            this.txtMadouong.Size = new System.Drawing.Size(215, 30);
            this.txtMadouong.TabIndex = 1;
            this.txtMadouong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "TÊN ĐỒ UỐNG";
            // 
            // txtTendouong
            // 
            this.txtTendouong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTendouong.Location = new System.Drawing.Point(217, 69);
            this.txtTendouong.Margin = new System.Windows.Forms.Padding(4);
            this.txtTendouong.Multiline = true;
            this.txtTendouong.Name = "txtTendouong";
            this.txtTendouong.Size = new System.Drawing.Size(215, 30);
            this.txtTendouong.TabIndex = 2;
            this.txtTendouong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "LOẠI ĐỒ UỐNG";
            // 
            // cbbLoaidouong
            // 
            this.cbbLoaidouong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLoaidouong.FormattingEnabled = true;
            this.cbbLoaidouong.Location = new System.Drawing.Point(217, 121);
            this.cbbLoaidouong.Margin = new System.Windows.Forms.Padding(4);
            this.cbbLoaidouong.Name = "cbbLoaidouong";
            this.cbbLoaidouong.Size = new System.Drawing.Size(215, 28);
            this.cbbLoaidouong.TabIndex = 3;
            this.cbbLoaidouong.SelectedIndexChanged += new System.EventHandler(this.cbbLoaidouong_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(489, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "ĐƠN GIÁ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(489, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(268, 29);
            this.label6.TabIndex = 3;
            this.label6.Text = "ĐỒ DÙNG TẶNG KÈM";
            // 
            // txtDongia
            // 
            this.txtDongia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDongia.Location = new System.Drawing.Point(780, 21);
            this.txtDongia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDongia.Multiline = true;
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(215, 30);
            this.txtDongia.TabIndex = 4;
            this.txtDongia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbbDodungtangkem
            // 
            this.cbbDodungtangkem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDodungtangkem.FormattingEnabled = true;
            this.cbbDodungtangkem.Location = new System.Drawing.Point(780, 68);
            this.cbbDodungtangkem.Margin = new System.Windows.Forms.Padding(4);
            this.cbbDodungtangkem.Name = "cbbDodungtangkem";
            this.cbbDodungtangkem.Size = new System.Drawing.Size(215, 28);
            this.cbbDodungtangkem.TabIndex = 5;
            // 
            // GB_1
            // 
            this.GB_1.Controls.Add(this.btnAdd);
            this.GB_1.Controls.Add(this.btnEdit);
            this.GB_1.Controls.Add(this.btnDelete);
            this.GB_1.Controls.Add(this.BT_E);
            this.GB_1.Location = new System.Drawing.Point(745, 46);
            this.GB_1.Margin = new System.Windows.Forms.Padding(4);
            this.GB_1.Name = "GB_1";
            this.GB_1.Padding = new System.Windows.Forms.Padding(4);
            this.GB_1.Size = new System.Drawing.Size(271, 321);
            this.GB_1.TabIndex = 1;
            this.GB_1.TabStop = false;
            // 
            // GB_2
            // 
            this.GB_2.Controls.Add(this.BT_LUU);
            this.GB_2.Controls.Add(this.BT_HUY);
            this.GB_2.Controls.Add(this.txtMadouong);
            this.GB_2.Controls.Add(this.label2);
            this.GB_2.Controls.Add(this.label3);
            this.GB_2.Controls.Add(this.label5);
            this.GB_2.Controls.Add(this.cbbDodungtangkem);
            this.GB_2.Controls.Add(this.label4);
            this.GB_2.Controls.Add(this.cbbLoaidouong);
            this.GB_2.Controls.Add(this.label6);
            this.GB_2.Controls.Add(this.txtDongia);
            this.GB_2.Controls.Add(this.txtTendouong);
            this.GB_2.Location = new System.Drawing.Point(11, 374);
            this.GB_2.Margin = new System.Windows.Forms.Padding(4);
            this.GB_2.Name = "GB_2";
            this.GB_2.Padding = new System.Windows.Forms.Padding(4);
            this.GB_2.Size = new System.Drawing.Size(1005, 164);
            this.GB_2.TabIndex = 0;
            this.GB_2.TabStop = false;
            // 
            // BT_LUU
            // 
            this.BT_LUU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_LUU.Location = new System.Drawing.Point(496, 105);
            this.BT_LUU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BT_LUU.Name = "BT_LUU";
            this.BT_LUU.Size = new System.Drawing.Size(257, 50);
            this.BT_LUU.TabIndex = 6;
            this.BT_LUU.Text = "LƯU";
            this.BT_LUU.UseVisualStyleBackColor = true;
            this.BT_LUU.Click += new System.EventHandler(this.BT_LUU_Click);
            // 
            // BT_HUY
            // 
            this.BT_HUY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_HUY.Location = new System.Drawing.Point(759, 105);
            this.BT_HUY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BT_HUY.Name = "BT_HUY";
            this.BT_HUY.Size = new System.Drawing.Size(239, 50);
            this.BT_HUY.TabIndex = 7;
            this.BT_HUY.Text = "HỦY";
            this.BT_HUY.UseVisualStyleBackColor = true;
            this.BT_HUY.Click += new System.EventHandler(this.BT_HUY_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Mã đồ uống";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "Tên đồ uống";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // IdLoaiDoUong
            // 
            this.IdLoaiDoUong.DataPropertyName = "IdLoaiDoUong";
            this.IdLoaiDoUong.HeaderText = "Loại đồ uống";
            this.IdLoaiDoUong.Name = "IdLoaiDoUong";
            this.IdLoaiDoUong.ReadOnly = true;
            // 
            // IdDoTangKem
            // 
            this.IdDoTangKem.DataPropertyName = "IdDoTangKem";
            this.IdDoTangKem.HeaderText = "Đồ tặng kèm";
            this.IdDoTangKem.Name = "IdDoTangKem";
            this.IdDoTangKem.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle1.Format = "###,# VNĐ";
            dataGridViewCellStyle1.NullValue = null;
            this.DonGia.DefaultCellStyle = dataGridViewCellStyle1;
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // FRM_QL_DU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 545);
            this.Controls.Add(this.GB_2);
            this.Controls.Add(this.GB_1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvDouong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FRM_QL_DU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LẬP DANH SÁCH ĐỒ UỐNG";
            this.Load += new System.EventHandler(this.FRM_QL_DU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDouong)).EndInit();
            this.GB_1.ResumeLayout(false);
            this.GB_2.ResumeLayout(false);
            this.GB_2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvDouong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button BT_E;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMadouong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTendouong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbLoaidouong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.ComboBox cbbDodungtangkem;
        private System.Windows.Forms.GroupBox GB_1;
        private System.Windows.Forms.GroupBox GB_2;
        private System.Windows.Forms.Button BT_LUU;
        private System.Windows.Forms.Button BT_HUY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLoaiDoUong;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDoTangKem;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
    }
}