using Tyuiu.BedenkoAN.Sprint1.Task7.V7.Lib;
namespace Tyuiu.BedenkoAN.Sprint1.Task7.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()

        {
            DataService ds = new DataService();
            double x = 1;
            double y = 6;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(13.302, res);



        }
    }
}
