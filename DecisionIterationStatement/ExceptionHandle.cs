using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionIterationStatement
{
    internal class ExceptionHandle
    {
        public void ExceptionDisplay()
        {
            try
            {
                Console.WriteLine("Enter volue of x");
                int x = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter volue of y");
                int y = int.Parse(Console.ReadLine());  

                if( x == 5)
                {
                    return;
                }
                double result = x / y;

                Console.WriteLine($"{x} / {y} = {result}");
            }
            catch( Exception ex ) 
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally Block Always Must Execute");
            }
        }
        static void Main()
        {
            ExceptionHandle e = new ExceptionHandle();
            e.ExceptionDisplay();

            Console.WriteLine("End of Main Method");
            Console.ReadKey();
        }
    }
}
