using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IvanovSI.Sprint4.Task3.V8.Lib;
namespace Tyuiu.IvanovSI.Sprint4.Task3.V8
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
            Console.WriteLine("* Задания #3                                                               *");
            Console.WriteLine("* Вариант #8                                                               *");
            Console.WriteLine("* Выполнил: Иванов Семён Иванович | РПСб-23-1                              *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 2 до 8. Найдите минимальный       *");
            Console.WriteLine("* элемент в четвертом столбце массива.                                     *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            int[,] mas = new int[5, 5] { {4, 8, 3, 4, 8},
                                         {5, 3, 5, 7, 8},
                                         {3, 7, 2, 7, 7},
                                         {5, 2, 4, 6, 4},
                                         {4, 4, 6, 7, 2} };
            int rows = mas.GetUpperBound(0) + 1;
            int columns = mas.Length / rows;

            Console.WriteLine();
            Console.WriteLine("Массив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mas[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Минимальный элемент 4 столбца: ");
            Console.WriteLine(ds.Calculate(mas));

            Console.ReadKey();
        }
    }
}
