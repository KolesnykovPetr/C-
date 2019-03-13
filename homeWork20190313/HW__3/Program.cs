using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW__3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            weekDays wd;
            byte numWd=0;

            Console.WriteLine("Enter number od weeks day:");
            numWd = byte.Parse(Console.ReadLine());                 //input
            wd=(weekDays)numWd;

            Console.WriteLine("Day of Week is {0}", wd);            //output

        }
    }
}
