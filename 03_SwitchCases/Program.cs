using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_SwitchCases
{
    class Program
    {
        static void Main(string[] args)
        {

            int input = 1;
            switch (input)
            {
                case 1:
                    Console.WriteLine("Hello");
                    break;
                case 2:
                    Console.WriteLine("what are you doing?");
                    break;
                default:
                    Console.WriteLine("This is default.  It will execute if not other case is evaluated.");
                    break;
            }
            // Console.ReadKey();
            DayOfWeek today = DateTime.Today.DayOfWeek;
            switch (today)
            {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    Console.WriteLine("Hope You are ready to work!");
                    break;
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("Sorry we are closed");
                    break;


            }
        }
    }
}
