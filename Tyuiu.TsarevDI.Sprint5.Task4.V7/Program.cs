using Tyuiu.TsarevDI.Sprint5.Task4.V7.Lib;
namespace Tyuiu.TsarevDI.Sprint5.Task4.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Царёв Д. И. | СМАРТб-24-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Спринт #5                                                             *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                               *");
            Console.WriteLine("* Задание #4                                                            *");
            Console.WriteLine("* Варинат #7                                                            *");
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


            
            Console.WriteLine(ds.LoadFromDataFile(path));
            Console.ReadKey();


        }
    }
}
