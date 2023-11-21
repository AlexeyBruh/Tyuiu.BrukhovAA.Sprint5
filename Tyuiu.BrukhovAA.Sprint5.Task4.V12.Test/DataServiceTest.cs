using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.BrukhovAA.Sprint5.Task4.V12.Lib;

namespace Tyuiu.BrukhovAA.Sprint5.Task4.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFile()
        {
            {
                string path = @"C:\DataSprint5\Sprint5Task4\InPutDataFileTask4V12.txt";


                FileInfo fl = new FileInfo(path);
                bool fileExists = fl.Exists;
                bool wait = true;
                Assert.AreEqual(wait, fileExists);
            }
        }
        [TestMethod]
        public void CheckCalc()
        {
            {
                DataService ds = new DataService();
                string path = @"C:\DataSprint5\Sprint5Task4\InPutDataFileTask4V12.txt";

                var res = ds.LoadFromDataFile(path);
                double wait = 1.989;
                Assert.AreEqual(wait, res);
            }
        }
    }
}
