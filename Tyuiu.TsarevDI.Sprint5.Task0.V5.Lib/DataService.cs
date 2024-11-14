using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.TsarevDI.Sprint5.Task0.V5.Lib
{
    public class DataService : ISprint5Task0V5
    {
        public string SaveToFileTextData(int x)
        {
            ///string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";

            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");

            double y = Math.Round((Math.Log(x + 1)-Math.Log(x + 2)), 3); 

            File.WriteAllText(path, Convert.ToString(y));
            return path;



        }
    }
}
