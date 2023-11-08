using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IvanovSI.Sprint4.Task5.V18.Lib;
namespace Tyuiu.IvanovSI.Sprint4.Task5.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Иванов С. И. | РПСб-23-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                         *");
            Console.WriteLine("* Задания #5                                                               *");
            Console.WriteLine("* Вариант #18                                                              *");
            Console.WriteLine("* Выполнил: Иванов Семён Иванович | РПСб-23-1                              *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный         *");
            Console.WriteLine("* случайными значениями в диапазоне от -6 до 7.                            *");
            Console.WriteLine("* Заменить отрицательные элементы на 0.                                    *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            Console.Write("Введите количество строк в массиве: ");

            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количство столбцов в массиве: ");

            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] mas = new int[rows, columns];

            Console.WriteLine("****************************************************************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    mas[i, j] = rnd.Next(-6, 7);
                }
            }
            Console.WriteLine("\nМассив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(string.Format("{0,5}", mas[i, j]));
                }
                Console.WriteLine();
            }


            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Изменённый массив: ");
            int[,] mtrx = (ds.Calculate(mas));
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(string.Format("{0,5}", mtrx[i, j])); // Здесь "5" это ширина поля, вы можете изменить ее в зависимости от ваших потребностей
                }
                Console.WriteLine(); // Добавим переход на новую строку после каждой строки массива
            }
            Console.ReadKey();
        }
    }
}
