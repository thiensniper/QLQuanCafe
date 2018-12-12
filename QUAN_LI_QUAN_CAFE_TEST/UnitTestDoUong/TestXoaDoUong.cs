using NUnit.Framework;
using QUAN_LI_QUAN_CAFE;

namespace QUAN_LI_QUAN_CAFE_TEST
{
    [TestFixture]
    public class TestXoaDoUong
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
        public void TC_XOA_01()
        {
            string id = "BEER";

            bool res = QUAN_LI_QUAN_CAFE.DAO.DoUongDAO.Instance.deleteDoUongbyID(id);
            Assert.AreEqual(res, true);
        }

        [Test]
        public void TC_XOA_02()
        {
            string id = "";

            bool res = QUAN_LI_QUAN_CAFE.DAO.DoUongDAO.Instance.deleteDoUongbyID(id);
            Assert.AreEqual(res, false);
        }

        [Test]
        public void TC_XOA_03()
        {
            string id = "ABC";
 
            bool res = QUAN_LI_QUAN_CAFE.DAO.DoUongDAO.Instance.deleteDoUongbyID(id);
            Assert.AreEqual(res, false);
        }
    }
}
