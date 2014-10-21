using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriangleTest
{
    public class triangle
    {
        public void checkpositive(int a, int b, int c)
        {
            a = b = c = 0;
            while (a <= 0)
            {
                Console.WriteLine("Please input 1st edge:");
                a = int.Parse(Console.ReadLine());
            }
            while (b <= 0)
            {
                Console.WriteLine("Please input 2nd edge:");
                b = int.Parse(Console.ReadLine());
            }
            while (c <= 0)
            {
                Console.WriteLine("Please input 3rd edge:");
                c = int.Parse(Console.ReadLine());
            }
        }

        public string checkTriangleType(int a, int b, int c)
        {
            checkpositive(a, b, c);
            if (a + b > c && b + c > a && a + c > b)
            {
                if (a == b || a == c || b == c)
                {
                    return "This can be an Isosceles trangle";
                }
                else if (a == b && a == c && b == c)
                {
                    return "This can be a Equilateral triangle";
                }
                else
                {
                    return "This can be a triangle";
                }

            }

            else
                return "This can't be a triangle";
        }
    }
}
