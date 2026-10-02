using Tyuiu.BedenkoAN.Sprint1.Task6.V8.Lib;

namespace Tyuiu.BedenkoAN.Sprint1.Task6.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string f = "привет";
            var res = ds.MoveLetterToEnd(f);
            Assert.AreEqual("риветп", res);


        }
    }
}
