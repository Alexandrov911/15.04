using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите трехзначное число");
            int k = Convert.ToInt32(Console.ReadLine());
            int a = k % 10;
            int b = k / 100;
            int c = k / 10 % 10;
       
            if(k * k == ((a * a * a) + (b * b * b) + (c * c * c))){
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
