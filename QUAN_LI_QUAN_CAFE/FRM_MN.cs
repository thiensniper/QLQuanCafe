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
    public partial class FRM_MN : Form
    {
        string query;
        
        public FRM_MN()
        {
            InitializeComponent();
        }

        #region Methods

        private void FRM_MN_Load(object sender, EventArgs e)
        {
            lblMenu.Text = "MENU ĐỒ UỐNG";
            visibleCombo(false);
            //Hiển thị Menu đồ uống
            loadCombo();
            try
            {
                query = "EXEC dbo.HienthiMenuDouong";
                dtgvMenu.DataSource = DataProvider.Instance.excuteQuery(query);
            }
            catch(Exception mss)
            {
                MessageBox.Show(mss.Message);
            }
        }

        private void visibleCombo(bool flag)
        {
            cbbCombo.Visible = flag;
            txtDongia.Visible = flag;
            lbDongia.Visible = flag;
        }

        private void loadCombo()
        {
            cbbCombo.DataSource = ComboDAO.Instance.LayDataCombo();
            cbbCombo.DisplayMember = "Name";
            cbbCombo.ValueMember = "ID";
        }



        #endregion


        #region Events
        private void btnXem_Click(object sender, EventArgs e)
        {
            if(btnXem.Text=="XEM MENU COMBO")
            {
                //Hiển thị Menu combo
                visibleCombo(true);


                lblMenu.Text = "MENU COMBO";
                try
                {
                    query = "EXEC dbo.HienthiMenuListDouongByIDCombo @idcombo";
                    dtgvMenu.DataSource = DataProvider.Instance.excuteQuery(query, new object[] { cbbCombo.SelectedValue.ToString() });
                }
                catch (Exception mss)
                {
                    MessageBox.Show(mss.Message);
                }
                txtDongia.Text = ComboDAO.Instance.LayDongiaComboByID(cbbCombo.SelectedValue.ToString()).ToString();
                btnXem.Text = "XEM MENU ĐỒ UỐNG";
            }
            else
            {
                lblMenu.Text = "MENU ĐỒ UỐNG";
                visibleCombo(false);
                //Hiển thị Menu đồ uống
                try
                {
                    query = "EXEC dbo.HienthiMenuDouong";
                    dtgvMenu.DataSource = DataProvider.Instance.excuteQuery(query);
                }
                catch (Exception mss)
                {
                    MessageBox.Show(mss.Message);
                }
                btnXem.Text = "XEM MENU COMBO";
            }
        }

        private void BT_E_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void cbbCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                query = "EXEC dbo.HienthiMenuListDouongByIDCombo @idcombo";
                dtgvMenu.DataSource = DataProvider.Instance.excuteQuery(query, new object[] { cbbCombo.SelectedValue.ToString() });
            }
            catch (Exception mss)
            {
                MessageBox.Show(mss.Message);
            }
            txtDongia.Text = ComboDAO.Instance.LayDongiaComboByID(cbbCombo.SelectedValue.ToString()).ToString();
        }
        #endregion
    }
}
