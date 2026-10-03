using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BedenkoAN.Sprint1.Task7.V7.Lib
{
    public class DataService : ISprint1Task7V7
    {
        public double Calculate(double x, double y)
        {
            double z = Math.Round((Math.Cos(x)/(Math.PI - 2*Math.Pow(y, x))) + 16*x * Math.Cos(x*y) -2, 3);
            return z;
        }
    }
}
