using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_practice
{
    public class Student:Person, IMIS3033Stu
    {
        public string stuID { get; set; }

        public double TakeMIS3033Excercise()
        {
            Console.WriteLine("I work hard in MIS 3033");
            return 90.6;
        }
        public double MIS3033Homework()
        {
            Console.WriteLine("I do very well");
            return 100;
        }
    }
}
