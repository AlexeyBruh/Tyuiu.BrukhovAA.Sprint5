using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BrukhovAA.Sprint5.Task7.V26.Lib
{
    public class DataService : ISprint5Task7V26
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFIle = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V26.txt";

            FileInfo fl = new FileInfo(pathSaveFIle);

            bool fileExists = fl.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFIle);
            }
            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string rrr = "";
                    List<string> arr = new List<string>();
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (Regex.IsMatch(Convert.ToString(line[i]), "^[a-zA-Z0-9]*$"))
                        {
                            rrr += line[i];
                        }
                        else
                        {
                            rrr += " ";
                        }
                    }
                    string bb = "";
                    foreach(char ch in rrr)
                    {
                        if(char.IsLetter(ch) && !(char.IsWhiteSpace(ch)))
                        {
                            bb += ch;
                        }
                        else
                        {
                            arr.Add(bb);
                            bb = "";
                        }
                    }
                    var temp = new List<string>();
                    foreach (var s in arr)
                    {
                        if (!string.IsNullOrEmpty(s))
                            temp.Add(s);
                    }

                    for (int i = 0; i < line.Length; i++)
                    {
                        if (!(line[i] >= 'A' && line[i] <= 'Z') && !(line[i] >= 'a' && line[i] <= 'z'))
                        {
                            strLine += line[i];
                        }
                        else
                        {
                            strLine = strLine + line[i];
                        }
                    }
                    string a = "word";
                    foreach (string str in temp)
                    {
                        strLine = strLine.Replace(str, a);
                    }



                    File.AppendAllText(pathSaveFIle, strLine + Environment.NewLine);
                }
            }
            return pathSaveFIle;
        }
    }
}
