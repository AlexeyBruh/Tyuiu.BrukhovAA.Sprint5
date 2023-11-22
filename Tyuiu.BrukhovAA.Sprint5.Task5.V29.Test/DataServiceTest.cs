using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.BrukhovAA.Sprint5.Task5.V29.Lib;

namespace Tyuiu.BrukhovAA.Sprint5.Task5.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFile()
        {
            {
                string path = @"C:\DataSprint5\Sprint5Task5\InPutDataFileTask5V29.txt";


                FileInfo fl = new FileInfo(path);
                bool fileExists = fl.Exists;
                bool wait = true;
                Assert.AreEqual(wait, fileExists);
            }
        }
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\Sprint5Task5\InPutDataFileTask5V29.txt";
            double res = ds.LoadFromDataFile(path);
            double wait = 11;
            Assert.AreEqual(wait, res);
        }
    }
}
