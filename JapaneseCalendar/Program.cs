using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JapaneseCalendar
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string str;
                Console.WriteLine("Input the number of the year (Press Enter to stop the program)");
                str = Console.ReadLine();
                if (str == string.Empty)
                    break;
                var year = int.Parse(str);
                if (!int.TryParse(str, out year))
                {
                    Console.WriteLine("Input error. ");
                    continue;
                }

                int numberOfYear;
                if (year >= 1984)
                    numberOfYear = (year - 1984) % 60;
                else
                    numberOfYear = (year - 1984) % 60 + 60;
                Console.WriteLine("{0} is the year of {1} {2}.", year, getColour(numberOfYear / 12), getAnimal(numberOfYear % 12));
                Console.ReadKey();
            }

        }

        static string getColour(int number)
        {
            switch (number)
            {
                case 0:
                    return "Green";
                case 1:
                    return "Red";
                case 2:
                    return "Yellow";
                case 3:
                    return "White";
                default:
                    return "Black";

            }
        }

        static string getAnimal(int number)
        {
            switch (number)
            {
                case 0:
                    return "Rat";
                case 1:
                    return "Cow";
                case 2:
                    return "Tiger";
                case 3:
                    return "Hare";
                case 4:
                    return "Dragon";
                case 5:
                    return "Snake";
                case 6:
                    return "Horse";
                case 7:
                    return "Sheep";
                case 8:
                    return "Monkey";
                case 9:
                    return "Han";
                case 10:
                    return "Dog";
                default:
                    return "Pig";

            }
        }
    
    }
}
