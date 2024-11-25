using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.TsarevDI.Sprint5.Task5.V27.Lib
{
    public class DataService : ISprint5Task5V27
    {
        public double LoadFromDataFile(string path)
        {

            string line = path.Replace('.', ',');
            string[] strings = line.Split(' ');
            
            double k, s;
            k = 0;
            s = 0;

            foreach (string str in strings)

            {

                if (double.TryParse(str.Trim(), out double number) && number % 1 == 0)

                {
                    s += Convert.ToDouble(number);
                    k++;
                }
            }

            return Math.Round(s/k, 3); 

        } 
    }
}
