using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionIterationStatement
{
    internal class EnumStructure
    {
        // Enum
        public enum Flowers
        {
            Rose, Lily, Daisy, Lotus 
        }

        // Structure
        public struct StructDemo
        {
            string name;
            int roll;
            public StructDemo(string n, int r) 
            {
                this.name = n;
                this.roll = r;
            }
            public void DisplayStruct()
            {
                Console.WriteLine($"Your Name: {name}, Your Roll: {roll}");
            }
        }
        static void Main()
        {
            // Enum
            Console.WriteLine(Flowers.Rose);
            Flowers f = Flowers.Lotus;
            Console.WriteLine(f);

            // Structure
            StructDemo s = new StructDemo("Mehedi Hasan",1280692);
            s.DisplayStruct();

            Console.ReadKey();
        }
    }
}
