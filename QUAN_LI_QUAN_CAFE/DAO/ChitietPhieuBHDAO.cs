using QUAN_LI_QUAN_CAFE.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUAN_LI_QUAN_CAFE.DAO
{
    public class ChitietPhieuBHDAO
    {
        private static ChitietPhieuBHDAO instance;

        public static ChitietPhieuBHDAO Instance
        {
            get
            {
                if (instance == null) instance = new ChitietPhieuBHDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private ChitietPhieuBHDAO() { }

        public List<ChitietPhieuBH> layDataChitietPhieuBHbyID(string maphieubh)//Lấy dữ liệu chi tiết phiếu bán hàng
        {
            List<ChitietPhieuBH> list = new List<ChitietPhieuBH>();
            string query = "SELECT * FROM dbo.CHITIETPHIEUBH WHERE MaphieuBH='" + maphieubh + "'";
            DataTable data = DataProvider.Instance.excuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ChitietPhieuBH chitiet = new ChitietPhieuBH(item);
                list.Add(chitiet);
            }

            return list;
        }

        public bool insertChitietPhieuBH(string id, string thanhphan, string tenthanhphan, int soluong, double dongia, string ghichu)
        {
            try
            {
                string query = "EXEC dbo.InsertChitietPhieuBH @maphieu , @mathanhphan , @tenthanhphan , @soluong , @dongia , @ghichu";
                int result = DataProvider.Instance.excuteNonQuery(query, new object[] { id, thanhphan, tenthanhphan, soluong, dongia, ghichu });
                return result > 0;
            }
            catch(Exception mss)
            {
                //MessageBox.Show(mss.Message);
                return false;
            }
        }

        public bool deleteCTPhieuBHByID(string maPhieuBH, string mathanhphan)
        {
            try
            {
                string query = "EXEC dbo.deleteCTPhieuBHByID @maphieu , @mathanhphan";
                int result = DataProvider.Instance.excuteNonQuery(query, new object[] { maPhieuBH, mathanhphan });
                return result > 0;
            }
            catch { return false; }

        }
    }
}
