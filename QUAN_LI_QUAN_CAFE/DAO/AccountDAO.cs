﻿using QUAN_LI_QUAN_CAFE.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LI_QUAN_CAFE.DAO
{
    class AccountDAO
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
            string query = "SELECT * FROM TAIKHOAN WHERE username = '" + username + "' and password = '" + password + "'";
            DataTable data = DataProvider.Instance.excuteQuery(query);
            return data.Rows.Count > 0;
        }
    }
}
