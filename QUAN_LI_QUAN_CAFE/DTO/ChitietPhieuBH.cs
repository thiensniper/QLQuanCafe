using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LI_QUAN_CAFE.DTO
{
    public class ChitietPhieuBH
    {
        public ChitietPhieuBH(string maphieu, string maTp, int soluong, double dongia, string ghichu)
        {
            this.MaphieuBH = maphieu;
            this.MaThanhphan = maTp;
            this.Soluong = soluong;
            this.Dongia = dongia;
            this.Ghichu = ghichu;
        }

        public ChitietPhieuBH(DataRow row)
        {
            this.MaphieuBH = row["MaphieuBH"].ToString();
            this.MaThanhphan = row["MaThanhphan"].ToString();
            this.Soluong = Convert.ToInt32(row["Soluong"].ToString());
            this.Dongia = Convert.ToDouble(row["Dongia"].ToString());
            this.Ghichu = row["Ghichu"].ToString();
        }

        private string maphieuBH;
        private string maThanhphan;
        private int soluong;
        private double dongia;
        private string ghichu;

        [DisplayName("Mã Phiếu")]
        public string MaphieuBH
        {
            get
            {
                return maphieuBH;
            }

            set
            {
                maphieuBH = value;
            }
        }

        [DisplayName("Mã thành phần")]
        public string MaThanhphan
        {
            get
            {
                return maThanhphan;
            }

            set
            {
                maThanhphan = value;
            }
        }

        [DisplayName("Số lượng")]
        public int Soluong
        {
            get
            {
                return soluong;
            }

            set
            {
                soluong = value;
            }
        }

        [DisplayName("Đơn giá")]
        public double Dongia
        {
            get
            {
                return dongia;
            }

            set
            {
                dongia = value;
            }
        }

        
        [DisplayName("Ghi chú")]
        public string Ghichu
        {
            get
            {
                return ghichu;
            }

            set
            {
                ghichu = value;
            }
        }
    }
}
