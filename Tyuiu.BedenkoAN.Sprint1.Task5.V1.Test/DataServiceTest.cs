using Tyuiu.BedenkoAN.Sprint1.Task5.V1.Lib;
namespace Tyuiu.BedenkoAN.Sprint1.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x1 = 1;
            double y1 = 2;



            double x2 = 2;
            double y2 = 2;


            DataService ds = new DataService();
            var res = ds.DistanceBetweenDots(x1,y1,x2,y2);
            Assert.AreEqual(1, res);


        }
    }
}
