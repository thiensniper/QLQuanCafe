using QUAN_LI_QUAN_CAFE.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LI_QUAN_CAFE.DAO
{
    public class DoUongDAO
    {
        private static DoUongDAO instance;

        public static DoUongDAO Instance
        {
            get
            {
                if (instance == null) instance = new DoUongDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private DoUongDAO() { }

        public List<DoUong> LayDataDoUong()//Lấy dữ liệu đồ uống
        {
            List<DoUong> list = new List<DoUong>();
            string query = "EXEC dbo.HienthiDouong";
            DataTable data = DataProvider.Instance.excuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DoUong drink = new DoUong(item);
                list.Add(drink);

            }
            return list;

        }

        public List<DoUong> LayDataDoUongKhongBia()//Lấy dữ liệu đồ uống không có rượu bia
        {
            List<DoUong> list = new List<DoUong>();
            string query = "EXEC dbo.HienthiDouongkhongbia";
            DataTable data = DataProvider.Instance.excuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DoUong drink = new DoUong(item);
                list.Add(drink);

            }
            return list;

        }

        public bool insertDoUong(string id, string name, string loaidouong, string dotangkem, double dongia)
        {
            try
            {
                string query = "EXEC dbo.InsertDoUong @madouong , @tendouong ,  @loaidouong ,  @dotangkem , @dongia";
                int result = DataProvider.Instance.excuteNonQuery(query,
                    new object[] { id, name, loaidouong, dotangkem, dongia.ToString() });
                return result > 0;
            }
            catch { return false; }
        }

        public double LayDongiaDoUongByID(string madouong)
        {
            try
            {
                string query = "EXEC dbo.LayDongiaDoUongByID @madouong";
                double result = Convert.ToDouble(DataProvider.Instance.excuteScarlar(query, new object[] { madouong }));
                return result;
            }
            catch { return 0; }            
        }

        public bool updateDoUongbyID(string id, string name, string loaidouong, string dotangkem, double dongia)
        {
            try
            {
                string query = "EXEC dbo.UpdateDoUong @madouong , @tendouong ,  @loaidouong ,  @dotangkem , @dongia";
                int result = DataProvider.Instance.excuteNonQuery(query,
                    new object[] { id, name, loaidouong, dotangkem, dongia.ToString() });
                return result > 0;
            }
            catch { return false; }
        }

        public bool deleteDoUongbyID(string id)
        {
            try
            {
                ChitietComboDAO.Instance.deleteChitietcomboByIDdouong(id);

                string query = "EXEC dbo.DeleteDoUong @madouong";
                int result = DataProvider.Instance.excuteNonQuery(query, new object[] { id });
                return result > 0;
            }
            catch { return false; }
        }
    }
}
