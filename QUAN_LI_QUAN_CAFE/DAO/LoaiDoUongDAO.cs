using QUAN_LI_QUAN_CAFE.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LI_QUAN_CAFE.DAO
{
    public class LoaiDoUongDAO
    {
        private static LoaiDoUongDAO instance;

        public static LoaiDoUongDAO Instance
        {
            get
            {
                if (instance == null) instance = new LoaiDoUongDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private LoaiDoUongDAO() { }

        public List<LoaiDoUong> LayDataLoaiDoUong()//Lấy dữ liệu loại đồ uống
        {
            List<LoaiDoUong> list = new List<LoaiDoUong>();
            string query = "SELECT * FROM LOAIDOUONG";
            DataTable data = DataProvider.Instance.excuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                LoaiDoUong loai = new LoaiDoUong(item);
                list.Add(loai);

            }
            return list;

        }
    }
}
