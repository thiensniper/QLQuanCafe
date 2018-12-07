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
    public partial class FRM_CT_COMBO : Form
    {
        string macombo;
        public FRM_CT_COMBO(string _macombo)
        {
            InitializeComponent();
            macombo = _macombo;
        }

        #region Methods
        private void FRM_CT_COMBO_Load(object sender, EventArgs e)
        {
            Loadchitietcombo();
            LoadTendouong();
            GB_2.Enabled = false;
            txtMacombo.Text = macombo;
            txtDongia.Text = ComboDAO.Instance.LayDongiaComboByID(macombo).ToString();
        }

        private void Loadchitietcombo()
        {
            dtgvChitietcombo.DataSource = ChitietComboDAO.Instance.LayDataChitietComboTheoIdCombo(macombo);
            ChitietComboBinding();
        }

        private void ChitietComboBinding()
        {
            cbbTendouong.DataBindings.Clear();
            cbbTendouong.DataBindings.Add("SelectedValue", dtgvChitietcombo.DataSource, "Douong");
        }

        private void LoadTendouong()
        {
            cbbTendouong.DataSource = DoUongDAO.Instance.LayDataDoUongKhongBia();
            cbbTendouong.DisplayMember = "Name";
            cbbTendouong.ValueMember = "ID";
        }



        #endregion

        #region Events
        private void btSave_Click(object sender, EventArgs e)
        {
            //Thực hiện việc lưu Đơn giá combo vào CSDL
            if (txtDongia.Text != "")
            {
                GB_2.Enabled = true;
                GB_3.Enabled = false;
                txtDongia.Enabled = false;
                if (ComboDAO.Instance.updateDongiaComboByID(txtMacombo.Text, Convert.ToDouble(txtDongia.Text)))
                {
                    MessageBox.Show("LƯU COMBO THÀNH CÔNG!","THÔNG BÁO!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else MessageBox.Show("CÓ LỖI XẢY RA, VUI LÒNG THỬ LẠI!","THÔNG BÁO!",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            else MessageBox.Show("VUI LÒNG NHẬP ĐƠN GIÁ COMBO","THÔNG BÁO!",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            GB_2.Enabled = false;
            GB_3.Enabled = true;
            txtDongia.Enabled = true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ChitietComboDAO.Instance.insertChitietCombo(macombo, cbbTendouong.SelectedValue.ToString(), Convert.ToInt32(numSoluong.Value)))
            {
                Loadchitietcombo();
            }
            else MessageBox.Show("ĐỒ UỐNG NÀY ĐÃ ĐƯỢC CHỌN TRONG DANH SÁCH CỦA COMBO!\nRẤT TIẾC!KHÔNG THỂ THÊM ĐỒ UỐNG NÀY!");
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (ChitietComboDAO.Instance.deleteChitietCombo(macombo, cbbTendouong.SelectedValue.ToString()))
            {
                Loadchitietcombo();
            }
            else MessageBox.Show("ĐÃ CÓ LỖI XẢY RA! VUI LÒNG THỬ LẠI","CẢNH BÁO!",MessageBoxButtons.OK,MessageBoxIcon.Stop);
        }
        #endregion

    }
}
