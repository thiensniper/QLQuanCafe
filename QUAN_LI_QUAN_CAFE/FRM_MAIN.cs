using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUAN_LI_QUAN_CAFE
{
    public partial class FRM_MAIN : Form
    {
        public FRM_MAIN()
        {
            InitializeComponent();
        }

        private void TIME1_Tick(object sender, EventArgs e)
        {
            LB_TIEUDE.Text = LB_TIEUDE.Text.Substring(1) + LB_TIEUDE.Text[0];
        }

        private void BT_E_Click(object sender, EventArgs e)
        {
            Application.Exit();

            //DialogResult A;
            //A = MessageBox.Show("BẠN CÓ CHẮC CHẮN MUỐN THOÁT CHƯƠNG TRÌNH", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            //if (A == DialogResult.OK)
            //{
            //    Application.Exit();
            //}

            //if (A == DialogResult.Cancel)
            //{
            //    //nothing
            //}
        }

        private void BT_QL_DU_Click(object sender, EventArgs e)
        {
            FRM_QL_DU FRM_QL_DU = new FRM_QL_DU();
            FRM_QL_DU.ShowDialog();
        }

        private void BT_QL_CB_Click(object sender, EventArgs e)
        {
            FRM_QL_CB FRM_QL_CB = new FRM_QL_CB();
            FRM_QL_CB.ShowDialog();
        }

        private void BT_MENU_Click(object sender, EventArgs e)
        {
            FRM_MN FRM_MN = new FRM_MN();
            FRM_MN.ShowDialog();
        }

        private void BT_LAP_HD_Click(object sender, EventArgs e)
        {
            FRM_LP_HD FRM_LP_HD = new FRM_LP_HD();
            FRM_LP_HD.ShowDialog();
        }

        private void FRM_MAIN_Load(object sender, EventArgs e)
        {
        }
    }
}
