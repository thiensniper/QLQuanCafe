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
    public partial class FRM_CT_LP_PHIEU : Form
    {
        private string maPhieuBH;
        private string maThanhPhan;
        private DateTime ngayBH;
        public FRM_CT_LP_PHIEU(DateTime _ngayBH)
        {
            InitializeComponent();
            ngayBH = _ngayBH;
        }

        #region Methods
        private void FRM_CT_LP_PHIEU_Load(object sender, EventArgs e)
        {
            maPhieuBH = PhieuBHDAO.Instance.layMaPhieuByNgayBH(ngayBH);
            txtMaphieu.Text = maPhieuBH;
            LoadChitietPhieuBH();
        }

        private void LoadChitietPhieuBH()
        {
            dtgvCTphieuBH.DataSource = ChitietPhieuBHDAO.Instance.layDataChitietPhieuBHbyID(maPhieuBH);
            if (rdbDoUong.Checked)
            {
                cbbTenThanhPhan.DataSource = DoUongDAO.Instance.LayDataDoUong();
            }
            else
            {
                cbbTenThanhPhan.DataSource = ComboDAO.Instance.LayDataCombo();
            }
            cbbTenThanhPhan.DisplayMember = "Name";
            cbbTenThanhPhan.ValueMember = "ID";
            cbbTenThanhPhan.SelectedIndex = 0;
            txtMaThanhPhan.Text = cbbTenThanhPhan.SelectedValue.ToString();
            if (rdbDoUong.Checked)
            {
                txtDongia.Text = DoUongDAO.Instance.LayDongiaDoUongByID(txtMaThanhPhan.Text).ToString();
            }
            else
            {
                txtDongia.Text = ComboDAO.Instance.LayDongiaComboByID(txtMaThanhPhan.Text).ToString();
            }
            try
            {
                maThanhPhan = dtgvCTphieuBH.SelectedRows[0].Cells[1].Value.ToString();
            }
            catch { }
        }



        #endregion


        #region Events
        private void rdbDoUong_CheckedChanged(object sender, EventArgs e)
        {
            LoadChitietPhieuBH();
        }

        private void cbbTenThanhPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaThanhPhan.Text = cbbTenThanhPhan.SelectedValue.ToString();
            if(rdbDoUong.Checked)
            {
                txtDongia.Text = DoUongDAO.Instance.LayDongiaDoUongByID(txtMaThanhPhan.Text).ToString();
            }
            else
            {
                txtDongia.Text=ComboDAO.Instance.LayDongiaComboByID(txtMaThanhPhan.Text).ToString();
            }
        }

        private void BTT_THEM_Click(object sender, EventArgs e)
        {
            if (ChitietPhieuBHDAO.Instance.insertChitietPhieuBH(maPhieuBH, txtMaThanhPhan.Text, cbbTenThanhPhan.Text, Convert.ToInt32(numSoluong.Value), Convert.ToDouble(txtDongia.Text)*Convert.ToDouble(numSoluong.Value), txtGhichu.Text))
            {
                LoadChitietPhieuBH();
            }
            else MessageBox.Show("THÀNH PHẦN NÀY ĐÃ TỒN TẠI TRONG DANH SÁCH!\nRẤT TIẾC!KHÔNG THỂ THÊM!!!");
            LoadChitietPhieuBH();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_XOA_Click(object sender, EventArgs e)
        {
            if(ChitietPhieuBHDAO.Instance.deleteCTPhieuBHByID(maPhieuBH, maThanhPhan))
            {
                LoadChitietPhieuBH();
            }
            else MessageBox.Show("KHÔNG THỂ XÓA!!!");
        }

        private void dtgvCTphieuBH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                maThanhPhan = dtgvCTphieuBH.SelectedRows[0].Cells[1].Value.ToString();
            }
            catch { }
        }
        #endregion
    }
}
