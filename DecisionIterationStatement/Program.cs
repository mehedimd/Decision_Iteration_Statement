using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionIterationStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //------------Md. Mehedi Hasan ID: 1280692
            // ans a

            int x = 10;
            // if-else Statement
            if (x > 0)
            {
                Console.WriteLine("This is Positive Number");
            }
            else if (x < 0)
            {
                Console.WriteLine("This is Negative Number");
            }
            else
            {
                Console.WriteLine("This is Zero");
            }
            // Switch Case
            int day = 0;
            string dayName = "";
            switch (day)
            {
                case 0:
                    dayName = "Saturday";
                    break;
                case 1:
                    dayName = "Sunday";
                    break;
                case 3:
                    dayName = "Monday";
                    break;
                case 4:
                    dayName = "TuesDay";
                    break;
                case 5:
                    dayName = "WednesDay";
                    break;
                case 6:
                    dayName = "ThursDay";
                    break;
                default:
                    dayName = "Friday";
                    break;
            }
            Console.WriteLine($"Day Name: {dayName}");

            // for loop
            string result = "";
            for ( int i = 1; i <= 10; i++ )
            {
                result += i + ",";
            }
            Console.WriteLine(result.Substring(0,result.Length-1));

            // While Loop
            string resultWhile = "";
            int a = 10;
            while ( a <= 20 )
            {
                resultWhile += a + ",";
                a++;
            }
            Console.WriteLine(resultWhile.Substring(0,resultWhile.Length - 1));

            // do While Loop
            string resultDo = "";
            int w = 20;
            while (w <= 30)
            {
                resultDo += w + ",";
                w++;
            }
            Console.WriteLine(resultDo.Substring(0, resultDo.Length - 1));

            // forEach loop
            string[] fruits = { "Banana", "Apple", "Orange" };
            foreach ( string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Console.ReadKey();
        }
    }
}
