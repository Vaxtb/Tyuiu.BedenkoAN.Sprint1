using Tyuiu.BedenkoAN.Sprint1.Task2.V13.Lib;
namespace Tyuiu.BedenkoAN.Sprint1.Task2.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Спринт #1 | Выполнил: Беденко А.Н. | ПИНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Беденко Алексей Николаевич | ПИНб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Известно расстояние в милях. Вычислить расстояние в километрах.         *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                              *");
            Console.WriteLine("*                                                                         *");
            
           
            DataService ds = new DataService();
            int x;
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите мили: ");
            x = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Километры в милях:" + ds.ConvertMilesToKm(x));
            Console.ReadLine();
        }   
    }
}
