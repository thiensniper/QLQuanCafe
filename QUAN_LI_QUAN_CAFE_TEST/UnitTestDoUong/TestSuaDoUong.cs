using NUnit.Framework;
using QUAN_LI_QUAN_CAFE;

namespace QUAN_LI_QUAN_CAFE_TEST
{
    [TestFixture]
    public class TestSuaDoUong
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
        public void TC_SUA_01()
        {
            string id = "BEER";
            string name = "TIGER";
            string loaidouong = "BEER";
            string dotangkem = "0";
            double dongia = 15000;

            bool res = QUAN_LI_QUAN_CAFE.DAO.DoUongDAO.Instance.updateDoUongbyID(id, name, loaidouong, dotangkem, dongia);
            Assert.AreEqual(res, true);
        }

        [Test]
        public void TC_SUA_02()
        {
            string id = "BEER";
            string name = "";
            string loaidouong = "BEER";
            string dotangkem = "0";
            double dongia = 15000;

            bool res = QUAN_LI_QUAN_CAFE.DAO.DoUongDAO.Instance.updateDoUongbyID(id, name, loaidouong, dotangkem, dongia);
            Assert.AreEqual(res, false);
        }

        [Test]
        public void TC_SUA_03()
        {
            string id = "BEER";
            string name = "TIGER";
            string loaidouong = "";
            string dotangkem = "0";
            double dongia = 15000;

            bool res = QUAN_LI_QUAN_CAFE.DAO.DoUongDAO.Instance.updateDoUongbyID(id, name, loaidouong, dotangkem, dongia);
            Assert.AreEqual(res, false);
        }

        [Test]
        public void TC_SUA_04()
        {
            string id = "BEER";
            string name = "TIGER";
            string loaidouong = "BEER";
            string dotangkem = "0";
            double dongia = 0;

            bool res = QUAN_LI_QUAN_CAFE.DAO.DoUongDAO.Instance.updateDoUongbyID(id, name, loaidouong, dotangkem, dongia);
            Assert.AreEqual(res, false);

            dongia = -15000;

            res = QUAN_LI_QUAN_CAFE.DAO.DoUongDAO.Instance.updateDoUongbyID(id, name, loaidouong, dotangkem, dongia);
            Assert.AreEqual(res, false);
        }
    }
}
