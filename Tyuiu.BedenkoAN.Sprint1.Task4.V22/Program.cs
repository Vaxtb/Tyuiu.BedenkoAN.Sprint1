using Tyuiu.BedenkoAN.Sprint1.Task4.V22.Lib;
namespace Tyuiu.BedenkoAN.Sprint1.Task4.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Беденко А.Н. | ПИНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Class Math                                                        *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Беденко Алексей Николаевич | ПИНб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                              *");
            Console.WriteLine("* Формула: √(x·y) / (1 + (x + 2y)^2)                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            double x, y;
            Console.WriteLine("Введите значение X :");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Y :");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            if (x*y<0)
            {
                Console.WriteLine("Ошибка: Произведение x и y отрицательное, корень извлечь нельзя!");

            }
            else
            {
                var res = ds.Calculate(x, y);
                Console.WriteLine("√(x·y) / (1 + (x + 2y)^2) =" + res);
                
            }
            Console.ReadKey();


        }
    }
}
