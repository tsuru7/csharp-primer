using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example431
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[3];
            students[0] = new Student("高貴", 3, 18);
            //students[0].SetInformation("高貴", 3, 18);
            students[1] = new Student("勇一", 2, 17);
            //students[1].SetInformation("勇一", 2, 17);
            students[2] = new Student("花子", 1, 16);
            //students[2].SetInformation("花子", 1, 16);
            foreach (Student s in students)
            {
                s.ShowInformation();
            }
        }
    }
}
