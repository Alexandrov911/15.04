using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите четырехзначное число");
            int k = Convert.ToInt32(Console.ReadLine());
            int a = k % 10;
            int b = k / 1000;
            int c = k / 10 % 10;
            int d = k / 100 % 10;
            if ((a == b)&(c==d))
            {
                Console.WriteLine("палидром");
            }
            else {
                Console.WriteLine("не полидром");
            }
            Console.ReadKey();
    }
}
