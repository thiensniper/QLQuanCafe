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
        public FRM_QL_TK()
        {
            InitializeComponent();
        }

        private void BT_D_Click(object sender, EventArgs e)
        {
            if (AccountDAO.Instance.CheckAccountExistsByID(TB_TENDN.Text, TB_OLDPAS.Text))
            {
                MessageBox.Show("thành công bước 1: lay thong tin dang nhap", "", MessageBoxButtons.OK);
                if (TB_PAS.Text == TB_PAS2.Text)
                {
                    MessageBox.Show("thành công bước 2: mat khau moi giong nhau", "", MessageBoxButtons.OK);

                    try
                    {
                        AccountDAO.Instance.UpdatePassword(TB_PAS.Text);
                        MessageBox.Show("thành công bước 3: doi mat khau thanh cong", "", MessageBoxButtons.OK);
                    }
                    catch
                    {
                        MessageBox.Show("đổi mật khẩu không thành công", "", MessageBoxButtons.OK);
                    }

                }
                else
                {
                    MessageBox.Show("Mật Khẩu mới không khớp nhau", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }

        }
    }
}
