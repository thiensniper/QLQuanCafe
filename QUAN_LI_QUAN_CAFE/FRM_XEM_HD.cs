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
    public partial class FRM_XEM_HD : Form
    {
        string maphieu;
        DateTime ngaylaphd;
        string tenkh;
        string maloaibh;
        string tenloaibh;
        string sdt;
        double tongtien = 0;
        double vat = 0;
        double tienphaitra = 0;
        public FRM_XEM_HD(string _maphieu)
        {
            InitializeComponent();
            maphieu = _maphieu;
        }

        private void FRM_XEM_HD_Load(object sender, EventArgs e)
        {
            ngaylaphd = Convert.ToDateTime(DataProvider.Instance.excuteScarlar("SELECT NgayBH FROM dbo.PHIEUBH WHERE MaphieuBH='" + maphieu + "'"));
            tenkh = Convert.ToString(DataProvider.Instance.excuteScarlar("SELECT TenKH FROM dbo.PHIEUBH WHERE MaphieuBH='" + maphieu + "'"));
            maloaibh = Convert.ToString(DataProvider.Instance.excuteScarlar("SELECT LoaiBH FROM dbo.PHIEUBH WHERE MaphieuBH='" + maphieu + "'"));
            tenloaibh = Convert.ToString(DataProvider.Instance.excuteScarlar("SELECT TenLoaiBH FROM dbo.LOAIBH WHERE MaLoaiBH='" + maloaibh + "'"));
            sdt = Convert.ToString(DataProvider.Instance.excuteScarlar("SELECT SoDienthoai FROM dbo.PHIEUBH WHERE MaphieuBH='" + maphieu + "'"));
            tongtien = Convert.ToDouble(DataProvider.Instance.excuteScarlar("SELECT TongTien FROM dbo.PHIEUBH WHERE MaphieuBH='" + maphieu + "'"));
            vat = tongtien * 0.1;
            if ((ngaylaphd.Day == 14 && ngaylaphd.Month == 2) || (ngaylaphd.Day == 30 && ngaylaphd.Month == 4)||(ngaylaphd.Day==1&&ngaylaphd.Month==5)||(ngaylaphd.Day==22&&ngaylaphd.Month==12))
            {
                vat = 0;
                tongtien = tongtien * 0.8;
            }
            if (maloaibh == "SHIP") tienphaitra += 5000;
            if (maloaibh == "MANG") vat = 0;
            if (maloaibh == "TAIQ") vat = tongtien * 0.03;

            tienphaitra = tongtien + vat;
            
            /////////////////////////////////

            lblMaphieu.Text = maphieu;
            lblNgay.Text = ngaylaphd.ToString();
            lblTenKH.Text = tenkh;
            lblLoaiBH.Text = tenloaibh;
            lblTongtien.Text = sdt;
            lblVAT.Text = vat.ToString();
            lblSdt.Text = sdt;
            lblTongtien.Text = tongtien.ToString();
            lblTienphaitra.Text = tienphaitra.ToString();

        }

        private void btIn_Click(object sender, EventArgs e)
        {
            //printPreviewDialog1();

            


            //PrintPreviewDialog.Show.PrintPreviewDialog dlgPreview = new PrintPreviewDialog();
            //dlgPreview.Document = doc;
            //dlgPreview.Show();
        }
    }
}
