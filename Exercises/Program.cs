using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isQuestion;
            isQuestion = true;

            char letter = 'a';
            char symbol = '&';

            byte byteSample = 150;

            short shortsample = 12345;

            double doubleSample = 100.789d;

            string phrase1;
            phrase1 = "Welcome to Amazon ";

            string phrase2;
            phrase2 = " - The answer to everything you want! ";

            string phrase3;
            phrase3 = "-Junkemail@gmail.com - ";

            string color = "gold";


            Console.WriteLine(phrase1 + " " + color);
            Console.WriteLine(phrase2 + " " + color);
            Console.WriteLine(phrase3 + " " + color);
           
            string Ammazonmessage = (phrase1 + phrase2 + phrase1 + " " + color);
            Console.WriteLine(Ammazonmessage);
            

            string cheese = "string cheese";
            string pasta = "mac and cheese";
            string beans = "kidney beans";

            // Composite
            string compositFood = string.Format("Tonight is {0}, tomorrow is {1} ", pasta, beans);
                
            // interpolation
            string interpolatedCheese = $"{cheese} {pasta}";

            Console.WriteLine(compositFood);
            Console.WriteLine(interpolatedCheese);
            
            string variable = "Hello";
            string part2 = " world, and ";
            string part3 = " class. Wilcom to the gold badge.";
            string concatphrase = (variable + part2 + variable + part3);
            Console.WriteLine(concatphrase);

            string interpolatedphrase = $"{variable} {part2} {variable} {part3}";
            Console.WriteLine(concatphrase);

            char[] chararray=  new char[5] {'a', 'b', 'c', 'd','e'};
            

            Console.WriteLine(chararray[2]);
            Console.WriteLine(chararray);
            List<string> fruits = new List<string>();
            fruits.Add("Apple");
            fruits.Add("grape");
            fruits.Add("lemon");
            fruits.Add("lime");
            fruits.Add("orange");
            fruits.Add("pear");
            Console.WriteLine(fruits[0]);

            int a = 42;
            int b = 5;
            int first = a + b * 100;
            int second = a + b;
            int third = a - b;
            Console.WriteLine(first + " First");
            Console.WriteLine(second +  " Second");
            Console.WriteLine(third + " Third");

            int day = 16;
            bool firstDay = false;

            // bool halfMonth = true;
            bool halfMonth = (day - 1) == 15;
            firstDay = true || true;

            Console.WriteLine(halfMonth);
            Console.WriteLine(firstDay);
            int hours = 4;
            if (hours < 8)
            {
                Console.WriteLine("I am tired!");

            }
            else
            {
                if(hours > 20)
                {
                    Console.WriteLine("I might be in a coma!");
                }
            }

            bool isCarOn = true;
            bool carHasGas = false;
            if (isCarOn == true)
            {
                if(carHasGas == true)
                {
                    Console.WriteLine("Let the adventure begin!");
                }
                else
                {
                    Console.WriteLine("I need gas!!!");
                }
            }

            string hogsWartHouse = "Scary";
            switch (hogsWartHouse)
            {
                case "Nice":
                    Console.WriteLine("This is not the same house.");
                    break;
                case "Scary":
                    Console.WriteLine("This is it!!!");
                    break;
            }
            int total = 1;
            bool keepLooping = true;
            while (keepLooping)
            {
                if (total <= 50)
                {
                    if (total % 2 != 0)
                    {
                        Console.WriteLine(total);
                    }
                    else
                    {
                        keepLooping = false;
                    }
                    

                }
                total++;
            }

            Console.ReadLine();
            
            
        }



        public int AddTwoNumber(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }

    }
}
