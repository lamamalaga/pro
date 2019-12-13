using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите символ: ");
            int a = Convert.ToInt32(char.Parse(Console.ReadLine()));

            string symbol1 = a.ToString("X");
            a++;
            string symbol2 = a.ToString("X");

            Console.WriteLine("0x{0}, 0x{1}", symbol1, symbol2);
            Console.ReadKey();
        }
    }
}
