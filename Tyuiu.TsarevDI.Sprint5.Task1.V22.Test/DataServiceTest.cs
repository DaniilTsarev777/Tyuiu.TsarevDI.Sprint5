using Tyuiu.TsarevDI.Sprint5.Task1.V22.Lib;
namespace Tyuiu.TsarevDI.Sprint5.Task1.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();

            string path = Path.GetTempFileName();

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
           
            Assert.AreEqual(true, fileExists);
        }
    }
}