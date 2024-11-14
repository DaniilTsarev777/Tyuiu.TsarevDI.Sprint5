using Tyuiu.TsarevDI.Sprint5.Task0.V5.Lib;
namespace Tyuiu.TsarevDI.Sprint5.Task0.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            

            Console.Title = "Спринт #5 | Выполнил: Царёв Д. И. | СМАРТб-24-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Спринт #5                                                             *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                      *");
            Console.WriteLine("* Задание #0                                                            *");
            Console.WriteLine("* Варинат #11                                                           *");
            Console.WriteLine("* Выполнил: Царёв Даниил Ильич | СМАРТб-24-1                            *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* ИССХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("*************************************************************************");

            int x = 3;
            Console.WriteLine("x = 3");

            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");

            Console.WriteLine("Файл: "+ds.SaveToFileTextData(x));
            Console.WriteLine("Создан");



        }
    }
}
