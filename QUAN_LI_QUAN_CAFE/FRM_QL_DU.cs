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




/// <summary>
/// file nay cua ku Thien
/// </summary>



namespace QUAN_LI_QUAN_CAFE
{
    public partial class FRM_QL_DU : Form
    {
        public FRM_QL_DU()
        {
            InitializeComponent();
        }
        int temp = 0; // bien nay dung de kiem tra nut lưu và hủy ở mục "thêm" hay "chỉnh sửa"
        #region Methods
        private void FRM_QL_DU_Load(object sender, EventArgs e)
        {
            GB_2.Enabled = false;
            txtMadouong.Clear();
            txtTendouong.Clear();
            txtDongia.Clear();

            BT_HUY_Click(sender, e);
            try
            {
              
                LoadLoaidouong();
                LoadDotangkem();
                LoadDouong();
            }
            catch (Exception mss)
            {
                MessageBox.Show(mss.Message);
                this.Close();
            }            
        }

        private void DouongBinding()//Kết nối DataSource của gridview với các thuộc tính khác trên form
        {
            txtTendouong.DataBindings.Clear();
            txtTendouong.DataBindings.Add("Text", dtgvDouong.DataSource, "Name");
            txtMadouong.DataBindings.Clear();
            txtMadouong.DataBindings.Add("Text", dtgvDouong.DataSource, "ID");
            txtDongia.DataBindings.Clear();
            txtDongia.DataBindings.Add("Text", dtgvDouong.DataSource, "DonGia");
            cbbDodungtangkem.DataBindings.Clear();
            cbbDodungtangkem.DataBindings.Add("SelectedValue", dtgvDouong.DataSource, "IdDoTangKem");
            cbbLoaidouong.DataBindings.Clear();
            cbbLoaidouong.DataBindings.Add("SelectedValue", dtgvDouong.DataSource, "IdLoaiDoUong");
        }

        private void LoadDotangkem()
        {
            List<DoTangKem> listDotangkem = DoTangKemDAO.Instance.LayDataDoTangKem();
            cbbDodungtangkem.DataSource = listDotangkem;
            cbbDodungtangkem.DisplayMember = "Name";
            cbbDodungtangkem.ValueMember = "ID";
            cbbDodungtangkem.SelectedValue = "0";
        }

        private void LoadLoaidouong()
        {
            List<LoaiDoUong> listLoaidouong = LoaiDoUongDAO.Instance.LayDataLoaiDoUong();
            cbbLoaidouong.DataSource = listLoaidouong;
            cbbLoaidouong.ValueMember = "ID";
            cbbLoaidouong.DisplayMember = "Name";
            cbbLoaidouong.SelectedValue = "JUICE";
        }

        private void LoadDouong()
        {
            dtgvDouong.DataSource = DoUongDAO.Instance.LayDataDoUong();
            DouongBinding();
        }

        #endregion

        #region Event

        private void BT_E_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void BT_THEM_Click(object sender, EventArgs e)
        {
            txtMadouong.Clear();
            txtTendouong.Clear();
            txtDongia.Clear();
            dtgvDouong.Enabled = false;

            //phan giao dien cua Duy
            //set gia tri cho biến temp = 1 de su dung nut "lưu"
            temp = 1;
            //hiện group box
            GB_2.Enabled = true;

            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnAdd.Enabled = false;

            BT_LUU.Text = "LƯU ĐỒ UỐNG MỚI";
        }

        private void BT_SUA_Click(object sender, EventArgs e)
        {
            dtgvDouong.Enabled = false;
            //phan giao dien cua Duy
            //set gia tri cho biến temp = 2 de su dung nut "chỉnh sửa"
            temp = 2;
            GB_2.Enabled = true;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            txtMadouong.Enabled = false;
            BT_LUU.Text = "LƯU CHỈNH SỬA";
        }

        private void BT_XOA_Click(object sender, EventArgs e)
        {

            //code giao dien cua duy
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            DialogResult A;
            A = MessageBox.Show("BẠN CÓ CHẮC CHẮN MUỐN XÓA ĐỒ UỐNG VỪA CHỌN HAY KHÔNG?\r\nTHAO TÁC NÀY SẼ XÓA ĐỒ UỐNG ĐƯỢC CHỌN RA KHỎI CSDL!", "CẢNH BÁO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (A == DialogResult.OK)
            {
                //Xóa đồ uống
                if (DoUongDAO.Instance.deleteDoUongbyID(txtMadouong.Text))
                {
                    LoadDouong();
                }
                else MessageBox.Show("XÓA ĐỒ UỐNG KHÔNG THÀNH CÔNG","THÔNG BÁO!",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                BT_HUY_Click(sender, e);
                // thuc hien hanh dong xoa do uong duoc chon

            }
            if (A == DialogResult.Cancel)
            {
                BT_HUY_Click(sender, e);
                /*nothing*/
            }
        }
        private void cbbLoaidouong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLoaidouong.SelectedValue.ToString() == "BEER")//Để thiết lập thuộc tính của combobox Dodungtangkem
            {
                cbbDodungtangkem.SelectedValue = "0";
                cbbDodungtangkem.Enabled = false;
            }
            else
            {
                cbbDodungtangkem.Enabled = true;
            }
        }

        private void BT_HUY_Click(object sender, EventArgs e)
        {
            // code giao dien cua duy
            LoadDouong();
            LoadDotangkem();

            // khi bam nut huy se xoa thong tin trong cac o va an đi group box  
            GB_2.Enabled = false;
            txtMadouong.Enabled = true;
            BT_LUU.Text = "LƯU";
            temp = 0;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnAdd.Enabled = true;
            btnAdd.Focus();
            dtgvDouong.Enabled = true;
        }

        private void BT_LUU_Click(object sender, EventArgs e)
        {
            //ham giao dien cua Duy
            // ham dung de luu du lieu trong cac text box vao co so du lieu
            // kiem tra bien temp để phân biện là lưu "chỉnh sửa" hay lưu của mục "thêm"
            if (temp == 1)
            {
                // viết hàm lưu cho mục Thêm 



                //phan code cua Thien
                if (txtMadouong.Text == "" || txtTendouong.Text == "" || txtDongia.Text == "")
                    MessageBox.Show("BẠN CHƯA NHẬP ĐỦ THÔNG TIN ĐỂ THÊM MỤC ĐỒ UỐNG!", "THÔNG BÁO!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                else
                //thêm đồ uống
                if (DoUongDAO.Instance.insertDoUong(txtMadouong.Text, txtTendouong.Text, cbbLoaidouong.SelectedValue.ToString(),
                    cbbDodungtangkem.SelectedValue.ToString(), Convert.ToInt32(txtDongia.Text)))
                {
                    MessageBox.Show("THÊM ĐỒ UỐNG THÀNH CÔNG!", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDouong();
                    BT_HUY.PerformClick();
                }
                else MessageBox.Show("KHÔNG THỂ THÊM ĐỒ UỐNG!","CẢNH BÁO!",MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }
            if (temp == 2)
            {
                // viết hàm lưu cho mục Chình sửa

                //phan code cua Thien
                //sửa đồ uống
                if (DoUongDAO.Instance.updateDoUongbyID(txtMadouong.Text, txtTendouong.Text, cbbLoaidouong.SelectedValue.ToString(),
                    cbbDodungtangkem.SelectedValue.ToString(), Convert.ToInt32(txtDongia.Text)))
                {
                    LoadDouong();
                    BT_HUY.PerformClick();
                }
                else MessageBox.Show("CHỈNH SỬA KHÔNG THÀNH CÔNG!","THÔNG BÁO!",MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }

            #endregion

        }
    }
}
