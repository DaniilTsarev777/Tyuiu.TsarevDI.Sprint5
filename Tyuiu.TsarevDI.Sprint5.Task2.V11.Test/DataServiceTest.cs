using Tyuiu.TsarevDI.Sprint5.Task2.V11.Lib;
namespace Tyuiu.TsarevDI.Sprint5.Task2.V11.Test
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