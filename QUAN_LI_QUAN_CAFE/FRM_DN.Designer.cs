namespace QUAN_LI_QUAN_CAFE
{
    partial class FRM_DN
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
            this.TB_TENDN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_PAS = new System.Windows.Forms.TextBox();
            this.BT_DN = new System.Windows.Forms.Button();
            this.BT_E = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_TENDN
            // 
            this.TB_TENDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_TENDN.Location = new System.Drawing.Point(137, 9);
            this.TB_TENDN.Multiline = true;
            this.TB_TENDN.Name = "TB_TENDN";
            this.TB_TENDN.Size = new System.Drawing.Size(240, 29);
            this.TB_TENDN.TabIndex = 0;
            this.TB_TENDN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "TÊN ĐĂNG NHẬP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "MẬT KHẨU";
            // 
            // TB_PAS
            // 
            this.TB_PAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_PAS.Location = new System.Drawing.Point(137, 57);
            this.TB_PAS.Multiline = true;
            this.TB_PAS.Name = "TB_PAS";
            this.TB_PAS.PasswordChar = '*';
            this.TB_PAS.Size = new System.Drawing.Size(240, 29);
            this.TB_PAS.TabIndex = 1;
            this.TB_PAS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BT_DN
            // 
            this.BT_DN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_DN.Location = new System.Drawing.Point(383, 8);
            this.BT_DN.Name = "BT_DN";
            this.BT_DN.Size = new System.Drawing.Size(115, 43);
            this.BT_DN.TabIndex = 2;
            this.BT_DN.Text = "ĐĂNG NHẬP";
            this.BT_DN.UseVisualStyleBackColor = true;
            this.BT_DN.Click += new System.EventHandler(this.BT_DN_Click);
            // 
            // BT_E
            // 
            this.BT_E.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_E.Location = new System.Drawing.Point(383, 51);
            this.BT_E.Name = "BT_E";
            this.BT_E.Size = new System.Drawing.Size(115, 43);
            this.BT_E.TabIndex = 3;
            this.BT_E.Text = "THOÁT";
            this.BT_E.UseVisualStyleBackColor = true;
            this.BT_E.Click += new System.EventHandler(this.BT_E_Click);
            // 
            // FRM_DN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(507, 102);
            this.Controls.Add(this.BT_E);
            this.Controls.Add(this.BT_DN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_PAS);
            this.Controls.Add(this.TB_TENDN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_DN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ QUÁN CAFE BALCONY";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_TENDN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_PAS;
        private System.Windows.Forms.Button BT_DN;
        private System.Windows.Forms.Button BT_E;
    }
}