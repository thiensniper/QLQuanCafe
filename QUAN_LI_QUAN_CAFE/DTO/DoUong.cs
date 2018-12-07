using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LI_QUAN_CAFE.DTO
{
    public class DoUong
    {
        public DoUong(string id, string name, string idloaidouong, string iddotangkem, double dongia)
        {
            this.ID = id;
            this.Name = name;
            this.IdLoaiDoUong = idloaidouong;
            this.IdDoTangKem = iddotangkem;
            this.DonGia = dongia;
        }

        public DoUong(DataRow row)
        {
            this.ID = row["MaDoUong"].ToString();
            this.Name = row["TenDoUong"].ToString();
            this.IdLoaiDoUong = row["LoaiDoUong"].ToString();
            this.IdDoTangKem = row["DoTangKem"].ToString();
            this.DonGia = Convert.ToDouble(row["DonGiaDoUong"].ToString());
        }

        private string iD;
        private string name;
        private string idLoaiDoUong;
        private string idDoTangKem;
        private double donGia;

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

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string IdLoaiDoUong
        {
            get
            {
                return idLoaiDoUong;
            }

            set
            {
                idLoaiDoUong = value;
            }
        }

        public string IdDoTangKem
        {
            get
            {
                return idDoTangKem;
            }

            set
            {
                idDoTangKem = value;
            }
        }

        public double DonGia
        {
            get
            {
                return donGia;
            }

            set
            {
                donGia = value;
            }
        }
    }
}
