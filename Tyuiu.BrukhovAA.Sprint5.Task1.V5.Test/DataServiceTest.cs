using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.BrukhovAA.Sprint5.Task1.V5.Lib;

namespace Tyuiu.BrukhovAA.Sprint5.Task1.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\bruho\source\repos\Tyuiu.BrukhovAA.Sprint5\Tyuiu.BrukhovAA.Sprint5.Task1.V5\bin\Debug\OutPutFileTask1.txt";


            FileInfo fl = new FileInfo(path);
            bool fileExists = fl.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
