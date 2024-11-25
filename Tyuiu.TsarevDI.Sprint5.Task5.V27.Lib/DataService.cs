using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.TsarevDI.Sprint5.Task5.V27.Lib
{
    public class DataService : ISprint5Task5V27
    {
        public double LoadFromDataFile(string path)
        {
            

            string[] strings = path.Split(' ');
            int k, s;
            k = 0;
            s = 0;

            foreach (string str in strings)

            {

                if (int.TryParse(str.Trim(), out int number) && number % 1 == 0)

                {
                    s += Convert.ToInt32(number);
                    k++;
                }
            }

            return s/k; 

        } 
    }
}
