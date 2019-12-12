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

            var s = Math.Sqrt(x * x + Math.Sqrt(x * x + 1 / x * x));

            Console.WriteLine("Выражение равно "+s);

            Console.ReadLine();
        }
    }
}
