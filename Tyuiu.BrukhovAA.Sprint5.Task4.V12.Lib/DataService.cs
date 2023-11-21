using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BrukhovAA.Sprint5.Task4.V12.Lib
{
    public class DataService : ISprint5Task4V12
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            var X = Convert.ToDouble(strX);

            double res = Math.Cos(Math.Pow(X, 3)) + (X/2);
            res = Math.Round(res, 3);
            return res;
        }
    }
}
