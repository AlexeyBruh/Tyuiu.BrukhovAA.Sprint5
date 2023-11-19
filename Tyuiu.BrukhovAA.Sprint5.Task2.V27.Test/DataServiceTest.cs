using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.BrukhovAA.Sprint5.Task2.V27.Lib;

namespace Tyuiu.BrukhovAA.Sprint5.Task2.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\bruho\source\repos\Tyuiu.BrukhovAA.Sprint5\Tyuiu.BrukhovAA.Sprint5.Task2.V27\bin\Debug\OutPutFileTask2.txt";


            FileInfo fl = new FileInfo(path);
            bool fileExists = fl.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
