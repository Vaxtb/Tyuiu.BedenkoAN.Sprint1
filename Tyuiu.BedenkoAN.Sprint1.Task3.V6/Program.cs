using Tyuiu.BedenkoAN.Sprint1.Task3.V6.Lib;
namespace Tyuiu.BedenkoAN.Sprint1.Task3.V6
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.Title = "Спринт #1 | Выполнил: Беденко А.Н. | ПИНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Беденко Алексей Николаевич | ПИНб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу вычисления стоимости поездки на автомобиле           *");
            Console.WriteLine("* на дачу (туда и обратно).Исходными данными являются: расстояние до дачи (км);*");
            Console.WriteLine("* количество бензина, которое потребляет автомобиль на 100 км пробега;    *");
            Console.WriteLine("* цена одного литра бензина. Ответ округлите до 3 знаков после запятой.   *");
            double x = 67, y = 8.5, z = 6.5;
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            Console.WriteLine("Расстояние до дачи (км) -> " + x);
            Console.WriteLine("Расход бензина (литров на 100 км пробега) -> " + y);
            Console.WriteLine("Цена литра бензина (руб.) -> " + z);
            
            var res = ds.TravelCost(x, y, z);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Поездка на дачу и обратно обойдется в :" + res);




        }
    }
}
