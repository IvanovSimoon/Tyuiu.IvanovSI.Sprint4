using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IvanovSI.Sprint4.Task6.V17.Lib;
namespace Tyuiu.IvanovSI.Sprint4.Task6.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Иванов С. И. | РПСб-23-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                         *");
            Console.WriteLine("* Задания #6                                                               *");
            Console.WriteLine("* Вариант #17                                                              *");
            Console.WriteLine("* Выполнил: Иванов Семён Иванович | РПСб-23-1                              *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дан строковый массив данных                                              *");
            Console.WriteLine("* [Python, JavaScript, Java, C#, Swift, Kotlin, Ruby]                      *");
            Console.WriteLine("* используя класс Array подсчитайте количество элементов, длина равна 6.   *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            var lng = new string[] { "Python", "JavaScript", "Java", "C#", "Swift", "Kotlin", "Ruby" };
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i <= lng.Length -1; i++)
            {
                Console.WriteLine(lng[i]);
            }
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Количество элементов длинна которых = 6:");

            int nums = ds.Calculate(lng);
            Console.WriteLine(nums);
            Console.ReadKey();
        }
    }
}
