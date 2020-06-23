using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_VarialblesAndValueType

{
    enum PastryType { Cake, Cupcake, Croissant, Donut, Scone, Cookie, Danish };
    class Program
    {
        static void Main(string[] args)
        {
            bool isDeclared;
            isDeclared = true;

            char character = 'a';
            char symbol = '&';
            char number = '5';
            char space = ' ';
            char specialCharacter = '\n';

            byte byteExample = 255;
            sbyte sByteExample = -128;
            Int16 anotherShortExample = 32000;
            short shortExample = 32767;
            int intMin = -2147483648;
            Int32 intmax = 2147483647;
            long longExample = 9223372036854775807;
            Int64 longMin = -9223372036854775807;

            int a = 7;
            int b = -7000;
            byte age = 104;

            float floatExample = 1.045231f;
            double doubleExample = 1.789053278907036d;

            decimal decimalExample = 1.2578907289045789789789789787897m;
            Console.WriteLine(1.2578907289045789789789789787897f);
            Console.WriteLine(1.2578907289045789789789789787897d);

            Console.WriteLine(1.2578907289045789789789789787897m);
            Console.ReadKey();


            PastryType myPastry = PastryType.Croissant;
            PastryType anotherOne = PastryType.Donut;

            Int32 num = 42;
            DateTime today = DateTime.Today;
            DateTime birthday = new DateTime(1805, 11, 24);
            DateTime test = new DateTime();

        }
    }
}
