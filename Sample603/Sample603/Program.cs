﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample603
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> capital = new Dictionary<string, string>();
            capital["日本"] = "東京";
            capital["イギリス"] = "ロンドン";
            capital["フランス"] = "パリ";
            capital["中国"] = "北京";
            Console.WriteLine("世界の首都");
            foreach (string s in capital.Keys)
            {
                Console.WriteLine("{0}の首都は{1}です。", s, capital[s]);
            }
        }
    }
}
