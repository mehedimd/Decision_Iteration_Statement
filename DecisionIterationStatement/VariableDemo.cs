using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionIterationStatement
{
    internal class VariableDemo
    {
        static void Main(string[] args)
        {
            // Ans b
            // declaring, naming, Assinging Variable using primitive data types
            int x = 5; int y = 5;
            // arithmatic operator
            double sum = x + y;
            double div = x / y;
            double sub = x - y;
            double mul = x * y;
            double mod = x % y;

            Console.WriteLine($"number: {x} and Number: {y} \n Sum = {sum},\n div = {div},\n sub = {sub},\n mul = {mul},\n mod = {mod}");

            // prefix and postfix increment
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"x++ = {x++}"); // x++ increment x value and we use it next statement
            Console.WriteLine($"y = {y}");
            Console.WriteLine($"++y = {++y}"); // ++y increment y value and we use it current statement
            Console.ReadKey();
        }
    }
}
