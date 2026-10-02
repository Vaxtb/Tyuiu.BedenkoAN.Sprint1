using Tyuiu.BedenkoAN.Sprint1.Task6.V8.Lib;

namespace Tyuiu.BedenkoAN.Sprint1.Task6.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Беденко А.Н. | ПИНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Работа со строками класс String                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Беденко Алексей Николаевич | ПИНб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* пользователь вводит текст.                                              *");
            Console.WriteLine("* Напечатать все слова, перенеся их первую букву в конец.                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            Console.WriteLine("Введите слово:");

            string slovo = Console.ReadLine();
            string[] words = slovo.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            foreach (string word in words)
            {
                Console.Write(ds.MoveLetterToEnd(word) + " ");
            }
            Console.ReadKey();

        }
    }
}
