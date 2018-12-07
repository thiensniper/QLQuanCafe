using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LI_QUAN_CAFE.DTO
{
    public class LoaiBH
    {
        public LoaiBH(string id, string name, int sodouong)
        {
            this.ID = id;
            this.Name = name;
            this.Sodouong = sodouong;
        }

        public LoaiBH(DataRow row)
        {
            this.ID = row["MaLoaiBH"].ToString();
            this.Name = row["TenLoaiBH"].ToString();
            if (row["Sodouongtoida"].ToString() != "")
                this.Sodouong = Convert.ToInt32(row["Sodouongtoida"].ToString());
            else this.Sodouong = -1;
        }

        private string iD;
        private string name;
        private int sodouong;

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

        public int Sodouong
        {
            get
            {
                return sodouong;
            }

            set
            {
                sodouong = value;
            }
        }
    }
}
