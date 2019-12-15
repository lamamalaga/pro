using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSinAndCos
{
    class Program
    {
        static void Main()
        {
            double x, y, z;
            x = 15;
            y = Math.Sin(x*(Math.PI / 180));
            z = Math.Cos(x * (Math.PI / 180));
            Console.WriteLine("Синус угла 15 градусов равен "+ "{0:0.000}",y);
            Console.WriteLine("Косинус угла 15 градусов равен "+ "{0:0.000}", z);

            double a, b, c;
            a = 37;
            b = Math.Sin(a * (Math.PI / 180));
            c = Math.Cos( a * (Math.PI / 180));
            Console.WriteLine("Синус угла 37 градусов равен "+ "{0:0.000}", b);
            Console.WriteLine("Косинус угла 15 градусов равен "+ "{0:0.000}", c);

            double m, l, n;
            m = 113;
            l = Math.Sin(m*(Math.PI / 180));
            n = Math.Cos(m*(Math.PI / 180));
            Console.WriteLine("Синус угла 113 градусов равен "+ "{0:0.000}", l);
            Console.WriteLine("Косинус угла 15 градусов равен "+ "{0:0.000}", n);

            double p, d, f;
            Console.Write("Введите значение угла ");
            p = double.Parse(Console.ReadLine());
            d = Math.Sin(p*(Math.PI/180));
            f = Math.Cos(p*(Math.PI / 180));
            Console.WriteLine("{0:0.000}", d);
            Console.WriteLine("{0:0.000}", f);
            
            Console.ReadKey();
        }
    }
}
