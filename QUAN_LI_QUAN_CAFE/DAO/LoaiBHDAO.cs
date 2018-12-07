using QUAN_LI_QUAN_CAFE.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LI_QUAN_CAFE.DAO
{
    public class LoaiBHDAO
    {
        private static LoaiBHDAO instance;

        public static LoaiBHDAO Instance
        {
            get
            {
                if (instance == null) instance = new LoaiBHDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private LoaiBHDAO() { }

        public List<LoaiBH> LayDataLoaiBH()//Lấy dữ liệu loại bán hàng
        {
            List<LoaiBH> list = new List<LoaiBH>();
            string query = "SELECT * FROM LOAIBH";
            DataTable data = DataProvider.Instance.excuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                LoaiBH loai = new LoaiBH(item);
                list.Add(loai);

            }
            return list;

        }

        public string LayTenLoaiBHbyID(string id)//Lấy tên loại bán hàng
        {
            try
            {
                string query = "SELECT TenLoaiBH FROM dbo.LOAIBH WHERE MaLoaiBH='" + id + "'";
                string ten = Convert.ToString(DataProvider.Instance.excuteScarlar(query));
                return ten;
            }
            catch { return null; }
        }
    }
}
