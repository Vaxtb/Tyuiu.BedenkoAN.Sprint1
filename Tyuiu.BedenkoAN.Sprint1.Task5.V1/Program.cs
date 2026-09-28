using Tyuiu.BedenkoAN.Sprint1.Task5.V1.Lib;
namespace Tyuiu.BedenkoAN.Sprint1.Task5.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Беденко А.Н. | ПИНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Беденко Алексей Николаевич | ПИНб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Найти расстояние между двумя точками с заданными координатами (x, y).   *");
            Console.WriteLine("* Ответ привести к целому с помощью класса Convert.                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            double x1, y1, x2, y2;
            Console.WriteLine("Введите значение X1 :");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Y1 :");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение X2 :");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Y2 :");
            y2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            int res = Convert.ToInt32(ds.DistanceBetweenDots(x1,y1, x2, y2));
            Console.WriteLine("Расстояние между точками: "+ res);
            Console.ReadKey();

        }
    }
}
