using QUAN_LI_QUAN_CAFE.DAO;
using QUAN_LI_QUAN_CAFE.DTO;
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
    public partial class FRM_QL_CB : Form
    {
        public FRM_QL_CB()
        {
            InitializeComponent();
        }
        int flagtemp = 0;


        #region Methods
        private void FRM_QL_CB_Load(object sender, EventArgs e)
        {
            LoadCombo();
            


            //phan giao dien
            GB_2.Enabled = false;
        }


        private void LoadCombo()
        {
            dtgvCombo.DataSource = ComboDAO.Instance.LayDataCombo();
            ComboBinding();
        }

        private void ComboBinding()
        {
            txtMacombo.DataBindings.Clear();
            txtMacombo.DataBindings.Add("Text", dtgvCombo.DataSource, "ID");
            txtTencombo.DataBindings.Clear();
            txtTencombo.DataBindings.Add("Text", dtgvCombo.DataSource, "Name");

        }
        #endregion


        #region Events
        private void BT_E_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BT_THEM_Click(object sender, EventArgs e)
        {
            //phan giao dien
            GB_2.Enabled = true;
            flagtemp = 1;
            btSave.Text = "LƯU, TIẾN HÀNH THÊM CHI TIẾT COMBO";
            BT_THEM.Enabled = false;
            BT_SUA.Enabled = false;
            BT_XOA.Enabled = false;
            txtMacombo.Clear();
            txtTencombo.Clear();
            dtgvCombo.Enabled = false;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            //Phan giao dien
            dtgvCombo.Enabled = true;
            btSave.Text = "LƯU";
            BT_THEM.Enabled = true;
            BT_SUA.Enabled = true;
            BT_XOA.Enabled = true;
            GB_2.Enabled = false;
            txtMacombo.Enabled = true;
            btSave.Enabled = true;
            LoadCombo();
        }

        private void btSave_Click(object sender, EventArgs e)
        {

            if (flagtemp == 1 && txtMacombo.Text != "" && txtTencombo.Text != "")
            {
                //flagtemp = 0;
                //thuc hien chuc nang luu du lieu cua "them moi"
                if (ComboDAO.Instance.insertCombo(txtMacombo.Text, txtTencombo.Text, 0))
                {
                    FRM_CT_COMBO formCTcombo = new FRM_CT_COMBO(txtMacombo.Text);
                    formCTcombo.ShowDialog();
                    LoadCombo();
                    btCancel.PerformClick();
                }
                else
                {
                    MessageBox.Show("KHÔNG THÊM ĐƯỢC COMBO!!!\r\nVUI LÒNG THỪ LẠI!", "CẢNH BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            if (flagtemp == 2)
            {
                btSave.Enabled = false;
                flagtemp = 0;
                //thuc hien chuc nang luu du lieu cua "chinh sua"
                if(ComboDAO.Instance.updateComboByID(txtMacombo.Text, txtTencombo.Text))
                {
                    FRM_CT_COMBO frm = new FRM_CT_COMBO(txtMacombo.Text);
                    frm.ShowDialog();
                    LoadCombo();
                    btCancel.PerformClick();
                }
                else
                {
                    MessageBox.Show("KHÔNG SỬA ĐƯỢC COMBO!!!\r\nVUI LÒNG THỪ LẠI!","CẢNH BÁO!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }

            }
        }

        private void BT_SUA_Click(object sender, EventArgs e)
        {
            GB_2.Enabled = true;
            flagtemp = 2;
            btSave.Text = "LƯU, CHỈNH SỬA CHI TIẾT";
            BT_THEM.Enabled = false;
            BT_SUA.Enabled = false;
            BT_XOA.Enabled = false;
            txtMacombo.Enabled = false;
            dtgvCombo.Enabled = false;
        }
        private void BT_XOA_Click(object sender, EventArgs e)
        {
            DialogResult A = MessageBox.Show("BẠN CÓ CHẮC CHẮN MUỐN XÓA COMBO VỪA CHỌN HAY KHÔNG?\r\nTHAO TÁC NÀY SẼ XÓA COMBO ĐƯỢC CHỌN RA KHỎI CSDL!", "CẢNH BÁO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (A == DialogResult.OK)
            {
                ComboDAO.Instance.deleteComboByID(txtMacombo.Text);
                LoadCombo();
            }
        }

        #endregion

    }
}
