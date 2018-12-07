using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LI_QUAN_CAFE.DTO
{
    public class Combo
    {
        public Combo(string id, string name, double dongia)
        {
            this.ID = id;
            this.Name = name;
            this.Dongia = dongia;
        }

        public Combo(DataRow row)
        {
            this.ID = row["MaCombo"].ToString();
            this.Name = row["TenCombo"].ToString();
            this.Dongia = Convert.ToDouble(row["DongiaCombo"].ToString());
        }

        string iD;
        string name;
        double dongia;

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
    }
}
