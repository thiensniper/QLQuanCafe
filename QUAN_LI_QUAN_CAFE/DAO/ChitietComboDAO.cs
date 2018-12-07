using QUAN_LI_QUAN_CAFE.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LI_QUAN_CAFE.DAO
{
    public class ChitietComboDAO
    {
        private static ChitietComboDAO instance;

        public static ChitietComboDAO Instance
        {
            get
            {
                if (instance == null) instance = new ChitietComboDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private ChitietComboDAO() { }

        public List<ChitietCombo> LayDataChitietCombo()
        {
            List<ChitietCombo> list = new List<ChitietCombo>();
            string query = "SELECT * FROM CHITIETCOMBO";
            DataTable data = DataProvider.Instance.excuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                ChitietCombo chitiet = new ChitietCombo(item);
                list.Add(chitiet);
            }

            return list;
        }

        public List<ChitietCombo> LayDataChitietComboTheoIdCombo(string id)
        {
            List<ChitietCombo> list = new List<ChitietCombo>();
            string query = "EXEC dbo.DataChitietComboTheoID @macombo";
            DataTable data = DataProvider.Instance.excuteQuery(query, new object[] { id });

            foreach (DataRow item in data.Rows)
            {
                ChitietCombo chitiet = new ChitietCombo(item);
                list.Add(chitiet);
            }

            return list;
        }

        public bool deleteChitietcomboByIDdouong(string id)
        {
            try
            {
                string query = "EXEC dbo.DeleteChitietcomboByIDdouong @madouong";
                int result = DataProvider.Instance.excuteNonQuery(query, new object[] { id });
                return result > 0;
            }
            catch { return false; }
        }

        public bool deleteChitietcomboByIDCombo(string id)
        {
            try
            {
                string query = "EXEC dbo.DeleteChitietcomboByIDCombo @macombo";
                int result = DataProvider.Instance.excuteNonQuery(query, new object[] { id });
                return result > 0;
            }
            catch { return false; }
        }

        public bool insertChitietCombo(string idCombo, string idDoUong, int soluong)
        {
            try
            {
                string query = "EXEC dbo.insertChitietCombo @macombo , @listdouong , @soluong";
                int result = DataProvider.Instance.excuteNonQuery(query, new object[] { idCombo, idDoUong, soluong });
                return result > 0;
            }
            catch { return false; }
        }

        public bool deleteChitietCombo(string id, string idDouong)
        {
            try
            {
                string query = "EXEC dbo.deleteChitietCombo @macombo , @madouong";
                int result = DataProvider.Instance.excuteNonQuery(query, new object[] { id, idDouong });
                return result > 0;
            }
            catch { return false; }
        }
    }
}
