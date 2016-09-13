using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring variables but also converting to int32 can save time
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            //simple math expressions
            Console.WriteLine("Sum: " +(a + b));
            Console.WriteLine("Difference: " +(a - b));
            Console.WriteLine("Product: " +(a * b));
            Console.WriteLine("Quotient: " +(a / b));
            Console.WriteLine("Integer Quotient: " +(a / b));
            Console.WriteLine("Remainder: " +(a % b));
            Console.WriteLine("Exponent: " +Math.Pow(a, b));
            //to stop the console from dissapearing 
            Console.Read();

        }
    }
}
