using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.BrukhovAA.Sprint5.Task0.V30.Lib;

namespace Tyuiu.BrukhovAA.Sprint5.Task0.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\bruho\source\repos\Tyuiu.BrukhovAA.Sprint5\Tyuiu.BrukhovAA.Sprint5.Task0.V30\bin\Debug\OutPutFileTask0.txt";


            FileInfo fl = new FileInfo(path);
            bool fileExists = fl.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
