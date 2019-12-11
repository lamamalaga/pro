using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaPerimeterOfTheRhombus
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите длинну стороны ромба: ");
            var a=int.Parse(Console.ReadLine());

            Console.WriteLine("Введите любой угол: ");
            var b = double.Parse(Console.ReadLine());
            var g = b * Math.PI / 180;

            var d = a * 4;
            Console.WriteLine("Периметр ромба " + d);
            
            
            double n =a*a * Math.Sin(g);
            Console.WriteLine("Площадь ромба " + Math.Round(n));

            Console.ReadKey();
        }
    }
}
