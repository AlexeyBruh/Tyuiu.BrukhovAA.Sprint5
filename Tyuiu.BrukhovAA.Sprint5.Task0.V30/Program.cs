﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.BrukhovAA.Sprint5.Task0.V30.Lib;

namespace Tyuiu.BrukhovAA.Sprint5.Task0.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Брюхов А. А. | АСОиУБ-23-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #5                                                              *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                       *");
            Console.WriteLine("* Задание #0                                                             *");
            Console.WriteLine("* Вариант #30                                                            *");
            Console.WriteLine("* Выполнил: Брюхов Алексей Андреевич | АСОиУБ-23-1                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить   *");
            Console.WriteLine("* в текстовый файл OutPutFileTask0.txt и вывести на консоль.             *");
            Console.WriteLine("* Округлить до трёх знаков после запятой                                 *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int x = 3;
            Console.WriteLine("x = " + x);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();

        }
    }
}
