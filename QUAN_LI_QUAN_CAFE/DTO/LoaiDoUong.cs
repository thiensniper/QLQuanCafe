using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LI_QUAN_CAFE.DTO
{
    public class LoaiDoUong
    {
        public LoaiDoUong(string id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        public LoaiDoUong(DataRow row)
        {
            this.ID = row["MaLoai"].ToString();
            this.Name = row["TenLoai"].ToString();
        }

        private string name;
        private string iD;

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
    }
}
