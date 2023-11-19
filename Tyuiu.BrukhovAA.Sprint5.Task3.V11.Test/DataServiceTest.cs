using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.BrukhovAA.Sprint5.Task3.V11.Lib;

namespace Tyuiu.BrukhovAA.Sprint5.Task3.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\bruho\source\repos\Tyuiu.BrukhovAA.Sprint5\Tyuiu.BrukhovAA.Sprint5.Task3.V11\bin\Debug\OutPutFileTask3.bin";


            FileInfo fl = new FileInfo(path);
            bool fileExists = fl.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
