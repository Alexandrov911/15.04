using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            //31
            Console.WriteLine("введите трехзначное число");
            int k = Convert.ToInt32(Console.ReadLine());
            int a = k % 10;
            int b = k / 100;
            int c = k / 10 % 10;

            if (a==b & b==c &c==a)
            {
                Console.WriteLine("да");
            }
            else
            {
                Console.WriteLine("нет");
            }
            // 31 б
            Console.WriteLine("введите трехзначное число");
            int k = Convert.ToInt32(Console.ReadLine());
            int a = k % 10;
            int b = k / 100;
            int c = k / 10 % 10;

            if ((a==b)|(b==c)|(c==a))
            {
                Console.WriteLine("да");
            }
            else
            {
                Console.WriteLine("нет");
            }


            Console.ReadKey();
        }
    }
}
