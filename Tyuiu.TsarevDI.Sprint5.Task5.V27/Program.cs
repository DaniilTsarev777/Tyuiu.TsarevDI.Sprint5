using Tyuiu.TsarevDI.Sprint5.Task5.V27.Lib;
namespace Tyuiu.TsarevDI.Sprint5.Task5.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Царёв Д. И. | СМАРТб-24-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Спринт #5                                                             *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                        *");
            Console.WriteLine("* Задание #5                                                            *");
            Console.WriteLine("* Варинат #27                                                           *");
            Console.WriteLine("* Выполнил: Царёв Даниил Ильич | СМАРТб-24-1                            *");
            Console.WriteLine("*************************************************************************");


            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* ИССХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("*************************************************************************");

            string path = @"C:\DataSprint5\input.txt";


            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");

            Console.WriteLine("среднее значение файла = "+ds.LoadFromDataFile(path));
        }
    }
}
