﻿using Tyuiu.TsarevDI.Sprint5.Task3.V30.Lib;
namespace Tyuiu.TsarevDI.Sprint5.Task3.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Царёв Д. И. | СМАРТб-24-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Спринт #5                                                             *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                   *");
            Console.WriteLine("* Задание #3                                                            *");
            Console.WriteLine("* Варинат #30                                                           *");
            Console.WriteLine("* Выполнил: Царёв Даниил Ильич | СМАРТб-24-1                            *");
            Console.WriteLine("*************************************************************************");

            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* ИССХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("*************************************************************************");

            Console.WriteLine("x = 3");
            int x = 3;

            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");

            Console.WriteLine("Файл: "+ds.SaveToFileTextData(x));
            Console.WriteLine("Создан");




        }
    }
}
