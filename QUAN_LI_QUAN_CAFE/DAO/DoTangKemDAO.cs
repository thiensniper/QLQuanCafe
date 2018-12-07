using QUAN_LI_QUAN_CAFE.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LI_QUAN_CAFE.DAO
{
    public class DoTangKemDAO
    {
        private static DoTangKemDAO instance;

        public static DoTangKemDAO Instance
        {
            get
            {
                if (instance == null) instance = new DoTangKemDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private DoTangKemDAO() { }

        public List<DoTangKem> LayDataDoTangKem()//Lấy dữ liệu đồ tặng kèm
        {
            List<DoTangKem> list = new List<DoTangKem>();
            string query = "SELECT * FROM DOTANGKEM";
            DataTable data = DataProvider.Instance.excuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DoTangKem thing = new DoTangKem(item);
                list.Add(thing);

            }
            return list;

        }
    }
}
