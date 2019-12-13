using System;

namespace _07_10CLASSWORKTASK2
{
    class Program
    {
        static void Main(string[] args)
        {
            var m = Input("m");
            var n = Input("n");
            Console.WriteLine("Числа больше 10:" + L(m, n));
            Console.ReadKey();
        }

        static bool L(double m, double n)
        {
            return m > 10 & n > 10;
        }

        static double Input(string name)
        {
            Console.WriteLine("Введите число " + name);
            return double.Parse(Console.ReadLine());
        }
    }
}
