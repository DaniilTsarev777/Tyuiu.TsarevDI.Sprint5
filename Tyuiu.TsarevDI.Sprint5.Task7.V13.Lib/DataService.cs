using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.TsarevDI.Sprint5.Task7.V13.Lib
{
    public class DataService : ISprint5Task7V13
    {
        public string LoadDataAndSave(string path)
        {
            string pathsavefile = Path.Combine(Path.GetTempPath(), "output.txt");

            FileInfo fileInfo = new FileInfo(pathsavefile);
            bool exist = fileInfo.Exists;

            if (exist)
            {
                File.Delete(pathsavefile);
            }

            string str = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    foreach(char c in line)
                    {
                        if (!char.IsUpper(c))
                        { 
                            str += c;
                        }

                    }
                    File.AppendAllText(pathsavefile, str + Environment.NewLine);
                }
            }
            return pathsavefile;

        }
    }
}
