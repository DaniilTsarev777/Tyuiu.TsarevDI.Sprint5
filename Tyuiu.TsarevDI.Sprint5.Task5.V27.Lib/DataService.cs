using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.TsarevDI.Sprint5.Task5.V27.Lib
{
    public class DataService : ISprint5Task5V27
    {
        public double LoadFromDataFile(string path)
        {
            string line;
            double k, s;
            k = 0;
            s = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                
                while ((line = reader.ReadLine()) != null)
                {
                    string strings = line.Replace('.', ',');
                    string[] array = strings.Split(' ');

                    foreach (string number in array)
                    {
                        double n = double.Parse(number);

                        if ((n % 1 == 0)&&(n%5==0))
                        {
                            s += n;
                            k++;
                        }

                    }
                }
                return Math.Round(s / k, 3);

            }
        }
    }
}
