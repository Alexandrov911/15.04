using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._04._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите трехзначное число");
            int k= Convert.ToInt32(Console.ReadLine());
            int a = k % 10;
            int b = k / 100;
            int c = k / 10 & 10;
            
            if ( a==b)
            {
                Console.WriteLine("палидром");
            }
            else
            {
                Console.WriteLine("не палидром");
            }

            if ((a+b)%3==0)
                    {
                Console.WriteLine("делится на 3");
            }
            else
            {
                Console.WriteLine("не делется на 3");
            }
            Console.ReadKey();
            

        }
    }
}
