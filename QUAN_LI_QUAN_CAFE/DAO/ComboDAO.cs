using QUAN_LI_QUAN_CAFE.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LI_QUAN_CAFE.DAO
{
    public class ComboDAO
    {
        private static ComboDAO instance;

        public static ComboDAO Instance
        {
            get
            {
                if (instance == null) instance = new ComboDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private ComboDAO() { }

        public List<Combo> LayDataCombo()//Lấy dữ liệu combo
        {
            List<Combo> list = new List<Combo>();
            string query = "EXEC dbo.HienthiCombo";
            DataTable data = DataProvider.Instance.excuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Combo combo = new Combo(item);
                list.Add(combo);

            }
            return list;

        }

        public double LayDongiaComboByID(string id)
        {
            double dongia;
            string query = "EXEC dbo.LayDongiaComboByID @macombo";
            object obj = DataProvider.Instance.excuteScarlar(query, new object[] { id });
            dongia = Convert.ToDouble(obj);
            return dongia;
        }

        public bool insertCombo(string id, string name, double dongia)
        {
            try
            {
                string query = "EXEC dbo.InsertCombo @macombo , @tencombo , @dongia";
                int result = DataProvider.Instance.excuteNonQuery(query, new object[] { id, name, dongia });
                return result > 0;
            }
            catch { return false; }
        }

        public bool updateDongiaComboByID(string id, double dongia)
        {
            try
            {
                string query = "EXEC dbo.updateDongiaCombobyID @macombo , @dongia";
                int result = DataProvider.Instance.excuteNonQuery(query, new object[] { id, dongia });
                return result > 0;
            }
            catch { return false; }

        }

        public bool deleteComboByID(string id)
        {
            try
            {
                ChitietComboDAO.Instance.deleteChitietcomboByIDCombo(id);
                string query = "EXEC dbo.deleteComboByID @macombo";
                int result = DataProvider.Instance.excuteNonQuery(query, new object[] { id });
                return result > 0;
            }
            catch { return false; }
        }

        public bool updateComboByID(string id, string name)
        {
            try
            {
                string query = "EXEC dbo.updateComboByID @macombo , @tencombo";
                int result = DataProvider.Instance.excuteNonQuery(query, new object[] { id, name });
                return result > 0;
            }
            catch { return false; }
        }

    }
}
