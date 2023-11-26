using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.BrukhovAA.Sprint5.Task6.V1.Lib;

namespace Tyuiu.BrukhovAA.Sprint5.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFile()
        {
            string path = @"C:\DataSprint5\Sprint5Task6\InPutDataFileTask6V1.txt";


            FileInfo fl = new FileInfo(path);
            bool fileExists = fl.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }

        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\Sprint5Task6\InPutDataFileTask6V1.txt";
            int res = ds.LoadFromDataFile(path);
            int wait = 6;

            Assert.AreEqual(wait, res);
        }
    }
}
