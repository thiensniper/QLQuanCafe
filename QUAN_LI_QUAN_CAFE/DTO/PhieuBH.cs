using QUAN_LI_QUAN_CAFE.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LI_QUAN_CAFE.DTO
{
    public class PhieuBH
    {
        public PhieuBH(string id, DateTime ngaybh, string loaibh, string tenkh, string sdt, double tongtien, bool trangthai)
        {
            this.ID = id;
            this.NgayBH = ngayBH;
            this.LoaiBH = loaibh;
            this.TenKH = tenkh;
            this.Sdt = sdt;
            this.Tongtien = tongtien;
            this.TrangThai = trangthai;
        }

        public PhieuBH(DataRow row)
        {
            this.ID = row["MaphieuBH"].ToString();
            this.NgayBH = Convert.ToDateTime(row["NgayBH"].ToString());
            this.LoaiBH = row["LoaiBH"].ToString();
            this.TenKH = row["TenKH"].ToString();
            this.Sdt = row["SoDienthoai"].ToString();
            this.Tongtien = Convert.ToDouble(row["TongTien"]);
            this.TrangThai = Convert.ToBoolean(row["TrangThai"]);
        }

        private string iD;
        private DateTime ngayBH;
        private string loaiBH;
        private string tenKH;
        private string sdt;
        private double tongtien;
        private bool trangThai;

        public string ID
        {
            get
            {
                return iD;
            }

            set
            {
                iD = value;
            }
        }

        public DateTime NgayBH
        {
            get
            {
                return ngayBH;
            }

            set
            {
                ngayBH = value;
            }
        }

        public string LoaiBH
        {
            get
            {
                return loaiBH;
            }

            set
            {
                loaiBH = value;
            }
        }

        public string TenKH
        {
            get
            {
                return tenKH;
            }

            set
            {
                tenKH = value;
            }
        }

        public string Sdt
        {
            get
            {
                return sdt;
            }

            set
            {
                sdt = value;
            }
        }

        public double Tongtien
        {
            get
            {
                return tongtien;
            }

            set
            {
                tongtien = value;
            }
        }

        [DisplayName("Trạng thái thanh toán")]
        public bool TrangThai
        {
            get
            {
                return trangThai;
            }

            set
            {
                trangThai = value;
            }
        }
    }
}
