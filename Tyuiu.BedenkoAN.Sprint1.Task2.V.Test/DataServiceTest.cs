using Tyuiu.BedenkoAN.Sprint1.Task2.V13.Lib;

namespace Tyuiu.BedenkoAN.Sprint1.Task2.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()


        {
            int x = 1;
            DataService ds = new DataService();
            var res = ds.ConvertMilesToKm(x);
            Assert.AreEqual(1.609, res);


        }
    }
}
