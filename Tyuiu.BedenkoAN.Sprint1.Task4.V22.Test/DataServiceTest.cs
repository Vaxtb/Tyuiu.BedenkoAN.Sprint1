using Tyuiu.BedenkoAN.Sprint1.Task4.V22.Lib;
namespace Tyuiu.BedenkoAN.Sprint1.Task4.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x = 1;
            double y = 1;
            DataService ds = new DataService();
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.1,res);

        }
    }
}
