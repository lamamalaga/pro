using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicalFormulas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение переменной X: ");
            var x = double.Parse(Console.ReadLine());

            var d = x * x;
            var s = Math.Sqrt(d +( Math.Sqrt(d + (1 / d))));

            Console.WriteLine("Выражение равно "+s);

            Console.ReadLine();
        }
    }
}
