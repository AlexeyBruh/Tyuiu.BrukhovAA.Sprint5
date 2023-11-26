using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.BrukhovAA.Sprint5.Task7.V26.Lib;

namespace Tyuiu.BrukhovAA.Sprint5.Task7.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFile ()
        {
            string path = @"C:\Users\bruho\source\repos\Tyuiu.BrukhovAA.Sprint5\Tyuiu.BrukhovAA.Sprint5.Task7.V26\bin\Debug\OutPutDataFileTask7V26.txt";


            FileInfo fl = new FileInfo(path);
            bool fileExists = fl.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
