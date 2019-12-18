using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysTask1Variant6_14
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите целое число, которое меньше или равно 20: ");
            var z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите действительное число: ");
            var y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            double[] numbers = new double[z];
            for (int i = 0; i < z; i++)
            {
                numbers[i] = ElementsOfArray(y, i);
            }

            foreach (var number in numbers)
                Console.WriteLine(number);

            Console.ReadKey();
        }
        static double ElementsOfArray(double a, int b)
        {
            int factorial = 1;
            for (int i = 2; i <= b; i++)
            {
                factorial = factorial * i;
            }
            return Math.Pow(a, b) / (factorial * Math.Pow(Math.E, a));
        }
    }
}
