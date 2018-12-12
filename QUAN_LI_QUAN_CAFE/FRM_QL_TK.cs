using QUAN_LI_QUAN_CAFE.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUAN_LI_QUAN_CAFE
{
    public partial class FRM_QL_TK : Form
    {
        private string username;
        public FRM_QL_TK(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void BT_D_Click(object sender, EventArgs e)
        {
            if (AccountDAO.Instance.CheckAccountExistsByID(TB_TENDN.Text, TB_OLDPAS.Text))
            {
                if (TB_OLDPAS.Text.Trim().Length <= 4)
                {
                    MessageBox.Show("Mật khẩu phải lớn hơn 4 ký tự", "", MessageBoxButtons.OK);
                    return;
                }

                //MessageBox.Show("thành công bước 1: lay thong tin dang nhap", "", MessageBoxButtons.OK);
                if (TB_PAS.Text == TB_PAS2.Text)
                {
                    try
                    {
                        AccountDAO.Instance.UpdatePassword(TB_TENDN.Text,TB_PAS.Text);
                        MessageBox.Show("Đổi mật khẩu thành công", "", MessageBoxButtons.OK);
                    }
                    catch
                    {
                        MessageBox.Show("Đổi mật khẩu không thành công", "", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Mật Khẩu mới không khớp nhau", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }

        }

        private void FRM_QL_TK_Load(object sender, EventArgs e)
        {
            TB_TENDN.Text = this.username;
        }
    }
}
