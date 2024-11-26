using Tyuiu.TsarevDI.Sprint5.Task7.V13.Lib;
namespace Tyuiu.TsarevDI.Sprint5.Task7.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadDataAndSave()
        {
            DataService ds = new DataService();
            string path = @"D:\Temp\output.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool exist = fileInfo.Exists;
            Assert.AreEqual(exist, true);
        }
    }
}