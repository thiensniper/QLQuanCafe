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
    public partial class FRM_DN : Form
    {
        public FRM_DN()
        {
            InitializeComponent();
        }

        private void BT_DN_Click(object sender, EventArgs e)
        {
            if (AccountDAO.Instance.CheckAccountExistsByID(TB_TENDN.Text, TB_PAS.Text))
            {
                FRM_MAIN FRM_MAIN = new FRM_MAIN(TB_TENDN.Text);
                this.Hide();
                FRM_MAIN.ShowDialog();
            }
            else
            {
                MessageBox.Show("sai thông tin đăng nhập", "thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BT_E_Click(object sender, EventArgs e)
        {
            DialogResult asd = new DialogResult();
            asd = MessageBox.Show("bạn có chắc muốn thoát chương trình hay không", "thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (asd == DialogResult.OK){ Application.Exit(); }
            if (asd == DialogResult.Cancel) { }
        }
    }
}
