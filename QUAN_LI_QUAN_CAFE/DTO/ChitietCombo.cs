using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LI_QUAN_CAFE.DTO
{
    public class ChitietCombo
    {
        public ChitietCombo(string id, string iddouong, int soluong)
        {
            this.ID = id;
            this.Douong = iddouong;
            this.Soluong = soluong;
        }

        public ChitietCombo(DataRow row)
        {
            this.ID = row["MaCombo"].ToString();
            this.Douong = row["ListDoUong"].ToString();
            this.Soluong = Convert.ToInt32(row["SoLuong"].ToString());
        }

        string iD;
        string douong;
        int soluong;

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

        public string Douong
        {
            get
            {
                return douong;
            }

            set
            {
                douong = value;
            }
        }

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
    }
}
