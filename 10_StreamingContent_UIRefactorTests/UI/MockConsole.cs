using _09_StreamingContent_Console.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_StreamingContent_UIRefactorTests.UI
{
    public class MockConsole : IConsole
    {
        public Queue<string> UserInput;
        public string Output;

        // pass in a regular string and turn into Queue?
        // constructor - IEnumerables is a generic list of strings?
        public MockConsole(IEnumerable<string> input)
        {
            UserInput = new Queue<string>(input);
            Output = "";
        }

        public void Clear()
        {
            Output += "Called Clear Method\n";
            // Output = Output + "Called Clear Method\n";  Just so you know it ran
        }

        // Pause the console app
        public ConsoleKeyInfo ReadKey()
        {
            return new ConsoleKeyInfo();
        }

        // taking input from user - dequeue will take the next in line
        public string ReadLine()
        {
            return UserInput.Dequeue();

        }
        // take string and put in output variable
        public void WriteLine(string s)
        {
            Output += s + "\n";
        }
        // take an object and output variable
        public void WriteLine(object o)
        {
            Output += o + "\n";
        }
    }
}
