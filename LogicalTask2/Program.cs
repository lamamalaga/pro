using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение X: ");
            var x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение Y: ");
            var y = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Принадлежность точки графику " + Graphic(x, y));
            Console.ReadKey();

        }

        static bool Graphic(double x, double y)
        {
            return y >-2 && x > 3 && y > -2 && x > -1;
        }
       
    }
}
