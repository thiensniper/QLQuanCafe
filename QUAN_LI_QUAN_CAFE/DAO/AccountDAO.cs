using QUAN_LI_QUAN_CAFE.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LI_QUAN_CAFE.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null) instance = new AccountDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private AccountDAO() { }

        public bool CheckAccountExistsByID(string username, string password)
        {
            string query = "SELECT * FROM TAIKHOAN WHERE Username = '" + username + "' and Password = '" + password + "'";
            DataTable data = DataProvider.Instance.excuteQuery(query);
            return data.Rows.Count > 0;
        }

     

        public bool UpdatePassword(string username,  string newpass)
        {
            string query = "UPDATE TAIKHOAN SET Password= '"+ newpass + "' WHERE username = '"+ username + "'";
            int res_col = DataProvider.Instance.excuteNonQuery(query);
            return res_col > 0;
        }



    }
}
