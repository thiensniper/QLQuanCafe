using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace QUAN_LI_QUAN_CAFE_TEST
{
    [TestFixture]
    public class TestDoiMatKhau
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
        public void TC_DOIMK_01()
        {
            string username = "admin";
            string password = "admin";

            bool res = QUAN_LI_QUAN_CAFE.DAO.AccountDAO.Instance.UpdatePassword(username, password);
            Assert.AreEqual(res, true);
        }
    }
}
