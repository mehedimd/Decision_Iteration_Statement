using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionIterationStatement
{
    internal class MethodDemo
    {
        // ans c
        // method with default parameter
        static void Display(string name, int id = 1)
        {
            // this is display method sope
            Console.WriteLine($"Name = {name} , id = {id}");
        }
        static void Display(string name, int id = 1, double money = 500)
        {
            Console.WriteLine($"Name = {name} , id = {id}, money = {money}");
        }
        static void Main()
        {
            // calling method with default parameter
            Display("mehedi", 10);

            // calling method with named argument
            Display(name:"Shahanaj",money: 999);

            Console.ReadKey();
        }
    }
}
