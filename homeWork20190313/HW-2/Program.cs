using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flagB=false;
            trainingDays trD;
            byte shedule = 0;
            for (int i = 64; i >= 1; i/=2)
            {
                trD = (trainingDays)i;
                Console.WriteLine("If you have training in the {0} please enter 1, else 0",trD);
                //Console.WriteLine((byte)trD);
                flagB = bool.Parse(Console.ReadLine());
                if (flagB)
                {
                    shedule += (byte)i;
                }
                Console.WriteLine(Convert.ToString(shedule, 2));
            }
            Console.WriteLine(Convert.ToString(shedule,2));

        }
    }
}
