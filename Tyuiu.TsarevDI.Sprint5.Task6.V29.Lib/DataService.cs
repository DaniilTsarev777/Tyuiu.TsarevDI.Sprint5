using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.TsarevDI.Sprint5.Task6.V29.Lib
{
    public class DataService : ISprint5Task6V29
    {
        public int LoadFromDataFile(string path)
        {
            
            int k;
            k = 0;
            
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    
                    string[] array = line.Split(' ');

                    foreach (string w in array)
                    {
                       if (w.Length == 7)
                       {
                            k++;
                       }
                 
                    }

                }
            }
            return k;
        }
    }
    
}       
