using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork20190313
{
    class Program
    {
        static void Main(string[] args)
        {
            char endEnter=' ';
            int usEnter  =0,
                minEnter = 0,
                maxEnter = 0;
            //do
            //{
            //    Console.Write("Ведите число: ");
            //    usEnter = int.Parse(Console.ReadLine());
            //    if (usEnter > maxEnter)
            //    {
            //        maxEnter = usEnter;
            //    }
            //    if (usEnter<minEnter)
            //    {
            //        minEnter = usEnter;
            //    }
            //    Console.Write("Чтобы продолжить ввод нажмите пробел. Для выхода нажмите любой другой символ. ");
            //    endEnter = char.Parse(Console.ReadLine());

            //} while (endEnter==' ');

            //for (; endEnter == ' ';)
            //{
            //    Console.Write("Ведите число: ");
            //    usEnter = int.Parse(Console.ReadLine());
            //    if (usEnter > maxEnter)
            //    {
            //        maxEnter = usEnter;
            //    }
            //    if (usEnter < minEnter)
            //    {
            //        minEnter = usEnter;
            //    }
            //    Console.Write("Чтобы продолжить ввод нажмите пробел. Для выхода нажмите любой другой символ. ");
            //    endEnter = char.Parse(Console.ReadLine());

            //}
            while (endEnter == ' ')
                {
                    Console.Write("Ведите число: ");
                    usEnter = int.Parse(Console.ReadLine());
                    if (usEnter > maxEnter)
                    {
                        maxEnter = usEnter;
                    }
                    if (usEnter < minEnter)
                    {
                        minEnter = usEnter;
                    }
                    Console.Write("Чтобы продолжить ввод нажмите пробел. Для выхода нажмите любой другой символ. ");
                    endEnter = char.Parse(Console.ReadLine());
                }


                Console.WriteLine("the minimum number is:  {0}", minEnter);
            Console.WriteLine("the maximum number is:  {0}", maxEnter);

        }
    }
}
