using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BrukhovAA.Sprint5.Task5.V29.Lib
{
    public class DataService : ISprint5Task5V29
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;

            List<double> arr = new List<double>();
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {

                    if ((Convert.ToDouble(line) < 100 && Convert.ToDouble(line) >= 10) && Convert.ToDouble(line) % 1 == 0)
                    {
                        arr.Add(Convert.ToDouble(line));
                    }
                }
            }

            res = arr.Min();
            return res;
        }
    }
}
