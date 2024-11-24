using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.TsarevDI.Sprint5.Task5.V27.Lib
{
    public class DataService : ISprint5Task5V27
    {
        public double LoadFromDataFile(string path)
        {
            double t = 0;
            int k = 0;
           

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Replace('.', ',');
                    if (Convert.ToDouble(line) % 1 == 0)
                    {
                        t += Convert.ToDouble(line);
                        k++;
                    }
                }
              

            }
            return t/k;

        } 
    }
}
