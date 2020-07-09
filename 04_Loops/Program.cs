using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // While Loop  loop runs while condition is true
            int total = 1;
            while (total != 10)
            {
                Console.WriteLine(total);
                total = total + 1;

            }
            Console.ReadKey();

            total = 0;
            while (true)
            {
                if (total == 10)
                {
                    Console.WriteLine("You did it!");
                    break;

                }
                total++;
            }

            Random rand = new Random();
            int someCount;
            bool keepLooping = true;

            while (keepLooping)
            {
                someCount = rand.Next(0, 20);
                if (someCount == 6 || someCount == 10)
                {
                    //restart loop
                    continue;
                }
                Console.WriteLine(someCount);
                if (someCount == 15)
                {
                    keepLooping = false;
                }
            }




            //For Loop
            int studentCount = 5;
            //1 starting point
            //2 Conditions that while true, keep looping
            //3 what happens after each loop
            //4 Body of the loop, what happens each iteration

            // starting point, what will cause it to end, how it is incremented
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine(i);
            }

            string[] students = { "Nick", "Adam", "AJ", "Austin", "Severa", "Tim" };
            for(int i=0;i < students.Length; i++)
            {
                Console.WriteLine($"Hello there! {students[i]}!");

            }

            // foreach
            //1 colletion that's being worked on
            //2 Name of the current iteration being used
            //3 current Type in the collection
            //4 in keyword, used to seperate the individual and the collection
            //5 Body of the loop

            //foreach //3  //2     //4  //1
            foreach (string student in students)
            {
                Console.WriteLine(student + " is in the class today"); //5
            }
            // foreach will stop when it runs out of items in a collection
            string myName = "Amanda Joy Knight";
            foreach(char letter in myName)
            {
                if(letter != ' ')
                {
                    Console.WriteLine(letter);
                }
            }

            // do while - will execute at least once then check conditional
            int iterator = 0;
            do
            {
                Console.WriteLine("Hello!");
                iterator++;

            }
            while (iterator < 5);

            Console.ReadKey();



        }
    }
}
