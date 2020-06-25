using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Methods
{
    [TestClass]
    public class MethodExamples
    {
        [TestMethod]
        public void MethodExecution()
        {
            SayHello("Erick");
            SayHello("Harry");

            int inputOne = 7;
            int inputTwo = 12;
            int sum = AddTwoNumber(inputOne, inputTwo);
            Console.WriteLine(sum);


            double doubleSum = AddTwoNumber(245.2d, 234.5d);
            Console.WriteLine(doubleSum);

            int myAge = CalculateAge(new DateTime(1892, 11, 24));
            Console.WriteLine("My age is: " + myAge);

        }
        // 1) Access Modifier - ex below is: public
        // 2) Return type - below: void
        // 3) Met hod Signature - method name and parameters: TestMethod1() type and name
        // 4) Body
        public void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        public int AddTwoNumber(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }

        public double AddTwoNumber(double one, double two)
        {
            double sum = one + two;
            return sum;
        }
        private int CalculateAge(DateTime birthday)
        {
            TimeSpan ageSpan = DateTime.Now - birthday;
            double totalAgeInYears = ageSpan.TotalDays / 365.25;
            int years = Convert.ToInt32(Math.Floor(totalAgeInYears));
            return years;
        }
    }
}
