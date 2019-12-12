using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cycleTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число больше нуля: ");
            double sum = 0;
            var n = int.Parse(Console.ReadLine());

            if (n < 1)
            {
                Console.WriteLine("Программа считает сумму корней от 1 до n, ваше число {0} не подходит.", n);
                //Console.WriteLine();

                //return;
            }
            else
            {
                for (int i = 0; i <= n; i++)
                    sum += Math.Sqrt(i);
                Console.WriteLine("Сумма квадратных корней чисел от 1 до {0} = {1}", n, sum);
            }

            Console.ReadKey();
            
        }
    

    }
}
