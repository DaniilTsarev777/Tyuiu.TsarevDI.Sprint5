using Tyuiu.TsarevDI.Sprint5.Task0.V5.Lib;
namespace Tyuiu.TsarevDI.Sprint5.Task0.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();
            ///string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt.txt");
            ///string path = Path.Combine(Environment.CurrentDirectory, "OutPutFileTask0.txt");
            
            string path = @"D:\Temp\OutPutFileTask0.txt";


            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            
            Assert.AreEqual(true, fileExists);
        }
    }
}