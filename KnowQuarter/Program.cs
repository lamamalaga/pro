using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowQuarter
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите координату точки X");
            var h = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату точки Y");
            var v = double.Parse(Console.ReadLine());

            if (h>0 & v>0)
            {
                Console.WriteLine("Первая четверть"); 
            }
            if (h < 0 & v > 0)
            {
                Console.WriteLine("Вторая четверть");
            }

            if (h < 0 & v < 0)
            {
                Console.WriteLine("Третья четверть");
            }

            if (h > 0 & v < 0)
            {
                Console.WriteLine("Четвертая четверть");
            }

            if(h==0 & v!=0)
            {
                Console.WriteLine("Точка лежит на оси ординат");
            }
            if (v == 0 & h!=0)
            {
                Console.WriteLine("Точка лежит на оси абсцисс");
            }

            if (v == 0 & h ==0)
            {
                Console.WriteLine("Точка совпадает с началом координат");
            }

            Console.ReadKey();
        }
    }
}
