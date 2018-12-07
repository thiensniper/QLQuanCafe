using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LI_QUAN_CAFE.DTO
{
    public class DoTangKem
    {
        public DoTangKem(string id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        public DoTangKem(DataRow row)
        {
            this.ID = row["MaDoTangKem"].ToString();
            this.Name = row["TenDoTangKem"].ToString();
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
