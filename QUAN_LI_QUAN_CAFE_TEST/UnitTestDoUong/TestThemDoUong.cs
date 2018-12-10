using NUnit.Framework;
using QUAN_LI_QUAN_CAFE;

namespace QUAN_LI_QUAN_CAFE_TEST
{
    [TestFixture]
    public class TestThemDoUong
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
            string id = "BEER";
            string name = "TIGER";
            string loaidouong = "BEER";
            string dotangkem = "0";
            double dongia = 15000;

            bool res = QUAN_LI_QUAN_CAFE.DAO.DoUongDAO.Instance.insertDoUong(id, name, loaidouong, dotangkem, dongia);
            Assert.AreEqual(res, true);
        }

        [Test]
        public void TC_LOGIN_02()
        {
            string id = "";
            string name = "TIGER";
            string loaidouong = "BEER";
            string dotangkem = "0";
            double dongia = 15000;

            bool res = QUAN_LI_QUAN_CAFE.DAO.DoUongDAO.Instance.insertDoUong(id, name, loaidouong, dotangkem, dongia);
            Assert.AreEqual(res, false);
        }

        [Test]
        public void TC_LOGIN_03()
        {
            string id = "BEER";
            string name = "";
            string loaidouong = "BEER";
            string dotangkem = "0";
            double dongia = 15000;

            bool res = QUAN_LI_QUAN_CAFE.DAO.DoUongDAO.Instance.insertDoUong(id, name, loaidouong, dotangkem, dongia);
            Assert.AreEqual(res, false);
        }

        [Test]
        public void TC_LOGIN_04()
        {
            string id = "BEER";
            string name = "TIGER";
            string loaidouong = "";
            string dotangkem = "0";
            double dongia = 15000;

            bool res = QUAN_LI_QUAN_CAFE.DAO.DoUongDAO.Instance.insertDoUong(id, name, loaidouong, dotangkem, dongia);
            Assert.AreEqual(res, false);
        }

        [Test]
        public void TC_LOGIN_05()
        {
            string id = "BEER";
            string name = "TIGER";
            string loaidouong = "BEER";
            string dotangkem = "0";
            double dongia = -15000;

            bool res = QUAN_LI_QUAN_CAFE.DAO.DoUongDAO.Instance.insertDoUong(id, name, loaidouong, dotangkem, dongia);
            Assert.AreEqual(res, false);

            dongia = 0;

            res = QUAN_LI_QUAN_CAFE.DAO.DoUongDAO.Instance.insertDoUong(id, name, loaidouong, dotangkem, dongia);
            Assert.AreEqual(res, false);
        }
    }
}
