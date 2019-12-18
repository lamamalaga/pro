using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cycleTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество студентов в группах: ");

            var k = int.Parse(Console.ReadLine());
            if (k == 0)
            {
                Console.WriteLine("Группа не может быть пустой!");
                Console.ReadKey();
                return;
            }
            if (k < 0)
            {
                Console.WriteLine("Количество студентов не может быть отрициательным");
                Console.ReadKey();
                return;
            }
            var firstGroup = GetGroup(new double[k], 1);
            if (double.IsInfinity(firstGroup[0]))
            {
                Console.WriteLine("Попробуй снова");
                Console.ReadKey();
                return;
            }
            var secondGroup = GetGroup(new double[k], 2);
            if (double.IsInfinity(secondGroup[0]))
            {
                Console.WriteLine("Попробуй еще раз!");
                Console.ReadKey();
                return;
            }
            WriteMiddleAge(firstGroup, 1);
            WriteMiddleAge(secondGroup, 2);
            Console.ReadKey();
        }

        public static double[] GetGroup(double[] group, int numberCroup)
        {
            Console.WriteLine("Введите возраст студентов {0} группы", numberCroup);
            for (int i = 0; i < group.Length; i++)
            {
                Console.WriteLine("Студент {0}.", i + 1);
                group[i] = double.Parse(Console.ReadLine());
                if (group[i] < 0)
                {

                    Console.WriteLine("Возраст студента не может быть равен {0}", group[i]);
                    return new double[1] { double.PositiveInfinity };
                }
            }
            return group;
        }

        public static void WriteMiddleAge(double[] group, int numberGroup)
        {
            var countStudentd = group.Length;
            var summAge = 0.0;
            foreach (var studentAge in group)
            {
                summAge += studentAge;
            }

            Console.WriteLine("Средний возраст студентов {0} группы = {1}", numberGroup, summAge / countStudentd);
            Console.ReadKey();
        }


    }
 }

        
    

