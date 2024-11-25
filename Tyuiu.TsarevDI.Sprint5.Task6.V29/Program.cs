using Tyuiu.TsarevDI.Sprint5.Task6.V29.Lib;
namespace Tyuiu.TsarevDI.Sprint5.Task6.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Царёв Д. И. | СМАРТб-24-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Спринт #5                                                             *");
            Console.WriteLine("* Тема: Обработка текстовых файлов                                      *");
            Console.WriteLine("* Задание #6                                                            *");
            Console.WriteLine("* Варинат #29                                                           *");
            Console.WriteLine("* Выполнил: Царёв Даниил Ильич | СМАРТб-24-1                            *");
            Console.WriteLine("*************************************************************************");


            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* ИССХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("*************************************************************************");

            string path = @"D:\DataSprint5\input.txt";
            Console.WriteLine("Данные находятся в файле: " + path);


            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");

            Console.WriteLine("количество слов длиной семь символов = " + ds.LoadFromDataFile(path));
        }
    }
}
