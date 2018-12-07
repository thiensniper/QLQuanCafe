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
    public partial class FRM_LP_HD : Form
    {
        private string maphieu;
        public FRM_LP_HD()
        {
            InitializeComponent();
        }
        int flag = 0;

        #region Methods
        private void FRM_LP_HD_Load(object sender, EventArgs e)
        {
            //code giao dien cua duy;
            txtNgayBH.Text = DateTime.Now.ToString();

            //
            BT_HUY.Text = "HỦY";
            BT_LUU.Text = "LƯU";
            BT_LUU.Enabled = false;
            BT_HUY.Enabled = false;
            BT_TAO.Enabled = true;
            BT_SUA.Enabled = true;
            BT_XOA.Enabled = true;
            GB_1.Enabled = false;
            GB_2.Enabled = false;


            txtTenKH.Clear();
            txtSdt.Clear();
            BT_TAO.Focus();

            LoadPhieuBH();//Load database Phieu Ban Hang

        }

        private void LoadPhieuBH()
        {
            dtgvPhieuBH.DataSource = PhieuBHDAO.Instance.layDataPhieuBH();
            LoadCbbLoaiBH();//Load du lieu len combo box

            //Xử lý phần giao diện
            dtgvPhieuBH.Enabled = true;
            try
            {
                txtNgayBH.Text = dtgvPhieuBH.SelectedRows[0].Cells[1].Value.ToString();//Lấy dữ liệu ngày từ datagridview đổ lên textbox
                cbbLoaiBH.SelectedValue = dtgvPhieuBH.SelectedRows[0].Cells[2].Value.ToString();//Lấy dữ liệu loại BH từ datagridview đổ lên textbox
                txtTenKH.Text = dtgvPhieuBH.SelectedRows[0].Cells[3].Value.ToString();//Lấy dữ liệu khách hàng từ datagridview đổ lên textbox
                txtSdt.Text = dtgvPhieuBH.SelectedRows[0].Cells[4].Value.ToString();//Lấy dữ liệu số điện thoại từ datagridview đổ lên textbox
                maphieu = PhieuBHDAO.Instance.layMaPhieuByNgayBH(Convert.ToDateTime(txtNgayBH.Text));
                if (PhieuBHDAO.Instance.layTrangThaiPhieuBH(maphieu) == 1)
                    BT_SUA.Enabled = false;
                else BT_SUA.Enabled = true;
            }
            catch { }
            //

        }

        private void LoadCbbLoaiBH()
        {
            List<LoaiBH> list = LoaiBHDAO.Instance.LayDataLoaiBH();
            cbbLoaiBH.DataSource = list;
            cbbLoaiBH.DisplayMember = "Name";
            cbbLoaiBH.ValueMember = "ID";
            cbbLoaiBH.SelectedValue = "MANG";
        }
        #endregion



        #region Events
        private void BT_E_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_THEM_Click(object sender, EventArgs e)
        {
            //phan giao dien
            flag = 1;
            txtNgayBH.Text = DateTime.Now.ToString();
            BT_HUY.Text = "HỦY TẠO";
            BT_LUU.Text = "LƯU HÓA ĐƠN";
            BT_LUU.Enabled = true;
            BT_HUY.Enabled = true;
            BT_TAO.Enabled = false;
            BT_SUA.Enabled = false;
            BT_XOA.Enabled = false;
            GB_1.Enabled = true;
            GB_2.Enabled = true;
            txtTenKH.Focus();
            txtTenKH.Clear();
            txtSdt.Clear();
            cbbLoaiBH.SelectedValue = "MANG";
            dtgvPhieuBH.Enabled = false;
        }

        private void BT_HUY_Click(object sender, EventArgs e)
        {


            if (flag == 1)
            {
                //giao dien
                BT_HUY.Text = "HỦY TẠO";

                //thuc hien chuc nang huy tao moi

            }
            if (flag == 2)
            {
                //giao dien
                BT_HUY.Text = "HỦY CHỈNH SỬA";
                //thuc hien chuc nang huy chinh sua

            }
            FRM_LP_HD_Load(sender, e);            
        }

        private void BT_XUAT_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.excuteNonQuery("UPDATE dbo.PHIEUBH SET TrangThai=1 WHERE MaphieuBH='" + maphieu + "'");
            FRM_XEM_HD FRM_XEM_HD = new FRM_XEM_HD(maphieu);
            FRM_XEM_HD.ShowDialog();
            LoadPhieuBH();
        }

        private void BT_LUU_Click(object sender, EventArgs e)
        {
            if (flag == 1)//Code cho chức năng tạo mới
            {
                //giao dien
                BT_LUU.Text = "LƯU HÓA ĐƠN";
                txtNgayBH.Text = DateTime.Now.ToString();

                //thuc hien chuc nang lưu phiếu thu
                if (PhieuBHDAO.Instance.insertPhieuBH(Convert.ToDateTime(txtNgayBH.Text), cbbLoaiBH.SelectedValue.ToString(), txtTenKH.Text, txtSdt.Text))
                {
                    DateTime ngaybanhang = Convert.ToDateTime(txtNgayBH.Text);
                    FRM_CT_LP_PHIEU FRM_CT_LP_PHIEU = new FRM_CT_LP_PHIEU(ngaybanhang);
                    FRM_CT_LP_PHIEU.ShowDialog();
                    BT_HUY.PerformClick();
                }
                else MessageBox.Show("Không thể thêm! Có lỗi xảy ra! Vui lòng thử lại.");

            }
            if (flag == 2)//Code cho chức năng chỉnh sửa
            {
                //giao dien
                BT_LUU.Text = "LƯU CHỈNH SỬA";

                //thuc hien chuc nang 
                string maphieu = PhieuBHDAO.Instance.layMaPhieuByNgayBH(Convert.ToDateTime(txtNgayBH.Text));
                if(PhieuBHDAO.Instance.updatePhieuBH(maphieu, Convert.ToDateTime(txtNgayBH.Text), cbbLoaiBH.SelectedValue.ToString(), txtTenKH.Text, txtSdt.Text))
                {
                    DateTime ngaybanhang = Convert.ToDateTime(txtNgayBH.Text);
                    FRM_CT_LP_PHIEU frm = new FRM_CT_LP_PHIEU(ngaybanhang);
                    frm.ShowDialog();
                    BT_HUY.PerformClick();
                }
                else MessageBox.Show("Không thể sửa! Có lỗi xảy ra! Vui lòng thử lại.");
            }
        }
        private void BT_SUA_Click(object sender, EventArgs e)
        {
            //code giao dien
            GB_1.Enabled = true;
            GB_2.Enabled = true;
            BT_XOA.Enabled = false;
            BT_TAO.Enabled = false;
            BT_HUY.Enabled = true;
            BT_HUY.Text = "HỦY CHỈNH SỬA";
            BT_SUA.Enabled = false;
            BT_LUU.Enabled = true;
            BT_LUU.Text = "LƯU CHỈNH SỬA";
            flag = 2;
            dtgvPhieuBH.Enabled = false;
            //
        }

        private void dtgvPhieuBH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNgayBH.Text = dtgvPhieuBH.SelectedRows[0].Cells[1].Value.ToString();//Lấy dữ liệu ngày từ datagridview đổ lên textbox
                cbbLoaiBH.SelectedValue = dtgvPhieuBH.SelectedRows[0].Cells[2].Value.ToString();//Lấy dữ liệu loại BH từ datagridview đổ lên textbox
                txtTenKH.Text = dtgvPhieuBH.SelectedRows[0].Cells[3].Value.ToString();//Lấy dữ liệu khách hàng từ datagridview đổ lên textbox
                txtSdt.Text = dtgvPhieuBH.SelectedRows[0].Cells[4].Value.ToString();//Lấy dữ liệu số điện thoại từ datagridview đổ lên textbox
                maphieu = PhieuBHDAO.Instance.layMaPhieuByNgayBH(Convert.ToDateTime(txtNgayBH.Text));
                if (PhieuBHDAO.Instance.layTrangThaiPhieuBH(maphieu) == 1)
                    BT_SUA.Enabled = false;
                else BT_SUA.Enabled = true;
            }
            catch { }
        }

        private void BT_XOA_Click(object sender, EventArgs e)
        {
            DialogResult A;
            A = MessageBox.Show("BẠN CÓ CHẮC CHẮN MUỐN XÓA HÓA ĐƠN VỪA CHỌN HAY KHÔNG?", "CẢNH BÁO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (A == DialogResult.OK)
            {
                //Xóa hóa đơn
                string maphieu = PhieuBHDAO.Instance.layMaPhieuByNgayBH(Convert.ToDateTime(txtNgayBH.Text));//Lấy mã phiếu bán hàng bằng ngày bán hàng
                if (PhieuBHDAO.Instance.deletePhieuBH(maphieu))
                {
                    //LoadPhieuBH();
                }
                else MessageBox.Show("XÓA KHÔNG THÀNH CÔNG!", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                BT_HUY_Click(sender, e);
                // thuc hien hanh dong xoa do uong duoc chon

            }
            if (A == DialogResult.Cancel)
            {
                BT_HUY_Click(sender, e);
                /*nothing*/
            }
        }
        #endregion

        private void GB_1_Enter(object sender, EventArgs e)
        {

        }
    }
}
