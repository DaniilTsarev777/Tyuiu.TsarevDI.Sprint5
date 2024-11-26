using Tyuiu.TsarevDI.Sprint5.Task7.V13.Lib;
namespace Tyuiu.TsarevDI.Sprint5.Task7.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Царёв Д. И. | СМАРТб-24-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Спринт #5                                                             *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту               *");
            Console.WriteLine("* Задание #7                                                            *");
            Console.WriteLine("* Варинат #13                                                           *");
            Console.WriteLine("* Выполнил: Царёв Даниил Ильич | СМАРТб-24-1                            *");
            Console.WriteLine("*************************************************************************");


            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* ИССХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("*************************************************************************");

            string path = @"C:\DataSprint5\input.txt";
            
            Console.WriteLine("Данные находятся в файле: " + path);


            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");

            Console.WriteLine("Находится в файле " + ds.LoadDataAndSave(path));
            Console.ReadKey();
        }
    }
}
