using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uslov.Operator.Task4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите x ");
            var x = double.Parse(Console.ReadLine());
            if(x<-3)
            {
                Console.WriteLine("f(x)=0");
            }

            else if(x>=-3 & x<=-1)
            {
                Console.WriteLine("f(x)=1");
            }

            else 
            { 
                Console.WriteLine("f(x)=2"); 
            }

            Console.ReadKey();

                   


        }
    }
}
