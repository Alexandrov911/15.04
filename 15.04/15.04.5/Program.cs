using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._04._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число");
            int r = Convert.ToInt32(Console.ReadLine());
            int a = r / 10;
            int b = r % 10;

            if ((a+b) % 2 == 0)

            {
                Console.WriteLine("четное");
            }
            else
            {
                Console.WriteLine("не четное");
            }
            Console.ReadKey();
        }
    }
}
