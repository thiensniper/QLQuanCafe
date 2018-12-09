using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUAN_LI_QUAN_CAFE;

namespace QUAN_LI_QUAN_CAFE_TEST
{
    [TestFixture]
    public class TestLogin
    {
        [SetUp] 
        public void SetUp()
        {
        }

        [TearDown]
        public void TearDown()
        {
        }

        [Test]  
        public void TC_LOGIN_01()
        {
            string username = "admin";
            string password = "admin";

            bool res = QUAN_LI_QUAN_CAFE.DAO.AccountDAO.Instance.CheckAccountExistsByID(username, password);
            Assert.AreEqual(res, true);
        }
    }
}
