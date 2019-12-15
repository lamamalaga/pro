using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicTask2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите координату X");
            double x = Console.ReadLine();

            Console.WriteLine("Введите координату Y");
            double y = Console.ReadLine();

            static bool Graphic(double x, double y)
            {
                return y > -2 || x < -3 || x>-1;
            }
            static double Input(string Name)
            {
                Console.WriteLine("Введите координаты точек x, y");
                return double.Parse(Console.ReadLine());
            }

        }
    }
}
