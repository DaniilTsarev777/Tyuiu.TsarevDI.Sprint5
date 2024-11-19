﻿using Tyuiu.TsarevDI.Sprint5.Task2.V11.Lib;
namespace Tyuiu.TsarevDI.Sprint5.Task2.V11
{
    internal class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Царёв Д. И. | СМАРТб-24-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Спринт #5                                                             *");
            Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл    *");
            Console.WriteLine("* Задание #2                                                            *");
            Console.WriteLine("* Варинат #11                                                           *");
            Console.WriteLine("* Выполнил: Царёв Даниил Ильич | СМАРТб-24-1                            *");
            Console.WriteLine("*************************************************************************");

            int[,] m = new int[3, 3] { { 4, 9, 3 },
                                       { 5, 8, 8 },
                                       { 5, 7, 5 } };

            int rows, columns;
            rows = m.GetLength(0);
            columns = m.GetLength(1);

            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* ИССХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("*************************************************************************");

            Console.WriteLine("Массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{m[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");

            Console.WriteLine("Файл: "+ds.SaveToFileTextData(m));
            Console.WriteLine("Создан");



        }
    }
}
