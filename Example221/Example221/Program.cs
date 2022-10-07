using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Example221
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("月(1-12)を入力してください: ");
            int month = int.Parse(Console.ReadLine());
            int days;
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    days = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    days = 30;
                    break;
                case 2:
                    days = 28;
                    break;
                default:
                    days = -1;
                    //return;
                    break;
            }
            if (1 <= month && month <= 12)
            {
                if (month != 2)
                { 
                    Console.WriteLine("{0}月の長さは{1}", month, days);
                }
                else
                {
                    Console.WriteLine("{0}月の長さは{1}か{2}です", month, days, days + 1);
                }

            }
            else
            {
                Console.WriteLine("不適切な値です");
            }
        }
    }
}
