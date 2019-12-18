using System;

namespace _07_10classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = F(1,2,3) + F(5,3,8) + F(1,5,6);

            Console.WriteLine("x = {0:F3}", x);

        }

        static double F(double x, double y, double z)
        {
            var t = Math.Tan(y);
            return Math.Sqrt((x + t *t) / z);
        }

    }
}
