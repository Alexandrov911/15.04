using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число");
            int r = Convert.ToInt32(Console.ReadLine());

            if (r % 2 == 0)
            {
                Console.WriteLine("четное");
            }
            else
            {
                Console.WriteLine("нечетное");
            }
            Console.ReadKey(); 
        }

       
    }
}
