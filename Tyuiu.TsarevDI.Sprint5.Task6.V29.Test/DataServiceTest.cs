using Tyuiu.TsarevDI.Sprint5.Task6.V29.Lib;
namespace Tyuiu.TsarevDI.Sprint5.Task6.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();
            string path = @"D:\DataSprint5\input.txt";
            Assert.AreEqual(3, ds.LoadFromDataFile(path));
        }


        [TestMethod]
        public void ValidLoadFromDataFile1()
        {
            DataService ds = new DataService();
            string path = @"D:\DataSprint5\input.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool exist = fileInfo.Exists;

            Assert.AreEqual(true, exist);
        }
    }
}