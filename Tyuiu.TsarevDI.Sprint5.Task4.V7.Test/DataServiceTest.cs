using Tyuiu.TsarevDI.Sprint5.Task4.V7.Lib;
namespace Tyuiu.TsarevDI.Sprint5.Task4.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\input.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool FileExist = fileInfo.Exists;
            Assert.AreEqual(true, FileExist);
        }
    }
}