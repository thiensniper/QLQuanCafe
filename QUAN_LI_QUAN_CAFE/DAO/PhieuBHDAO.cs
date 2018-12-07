using QUAN_LI_QUAN_CAFE.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LI_QUAN_CAFE.DAO
{
    public class PhieuBHDAO
    {
        private static PhieuBHDAO instance;

        public static PhieuBHDAO Instance
        {
            get
            {
                if (instance == null) instance = new PhieuBHDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private PhieuBHDAO() { }

        public List<PhieuBH> layDataPhieuBH()//Lấy dữ liệu phiếu bán hàng
        {
            List<PhieuBH> list = new List<PhieuBH>();
            string query = "SELECT * FROM PHIEUBH";
            DataTable data = DataProvider.Instance.excuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                PhieuBH phieu = new PhieuBH(item);
                list.Add(phieu);
            }

            return list;
        }

        public string layMaPhieuByNgayBH(DateTime ngayBH)
        {
            string maphieu;
            string query = "EXEC dbo.LayMaPhieuByNgayBH @ngaybh";
            object obj = DataProvider.Instance.excuteScarlar(query,new object[] { ngayBH });
            maphieu = Convert.ToString(obj);
            return maphieu;
        }

        public int layTrangThaiPhieuBH(string id)//Sử dụng để kiểm tra phiếu bán hàng đã được in hay chưa
        {
            try
            {
                string query = "EXEC dbo.LayTrangThaiPhieuBH @maphieu";
                object result = DataProvider.Instance.excuteScarlar(query, new object[] { id });
                return Convert.ToInt16(result);
            }
            catch { return -1; }
        }

        public bool insertPhieuBH(DateTime ngaybh, string loaibh, string tenkh, string sdt)
        {
            try
            {
                string query = "EXEC dbo.insertPhieuBanHang @ngaybh , @loaibh , @tenkh , @sdt";
                int result = DataProvider.Instance.excuteNonQuery(query, new object[] { ngaybh, loaibh, tenkh, sdt });
                return result > 0;
            }
            catch { return false; }
        }

        public bool deletePhieuBH(string id)
        {
            try
            {
                string query = "EXEC dbo.deletePhieuBH @maphieu";
                int result = DataProvider.Instance.excuteNonQuery(query, new object[] { id });
                return result > 0;
            }
            catch { return false; }
        }

        public bool updatePhieuBH(string id, DateTime ngaybh, string loaibh, string tenkh, string sdt)
        {
            try
            {
                string query = "EXEC dbo.UpdatePhieuBH @maphieu , @ngaybh , @loaibh , @tenkh , @sdt";
                int result = DataProvider.Instance.excuteNonQuery(query, new object[] { id, ngaybh, loaibh, tenkh, sdt });
                return result > 0;
            }
            catch { return false; }
        }
    }
}
