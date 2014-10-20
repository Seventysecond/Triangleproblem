using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Please input 1st edge:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input 2nd edge:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input 3rd edge:");
            c = int.Parse(Console.ReadLine());

            if (a + b > c && b + c > a && a + c > b)
            {
                if (a == b || a == c || b == c)
                {
                    Console.WriteLine("This can be an Isosceles trangle");
                }
                else if (a == b && a == c && b == c)
                {
                    Console.WriteLine("This can be a Equilateral triangle");
                }
                else
                {
                    Console.WriteLine("This can be a triangle");
                }

            }

            else
                Console.WriteLine("This can't be a triangle");
            Console.ReadKey();
        }
    }
}
