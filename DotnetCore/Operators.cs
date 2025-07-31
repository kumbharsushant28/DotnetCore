using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore
{
    internal class Operations
    {
        public void ArithmeticOperations(int a, int b)
        {
            Console.WriteLine("Addition: " + (a + b));
            Console.WriteLine("Subtraction: " + (a - b));
            Console.WriteLine("Multiplication: " + (a * b));
            Console.WriteLine("Division: " + (a / b));
            Console.WriteLine("Modulus: " + (a % b));
        }
        public void ComparisonOperations(int a, int b)
        {
            Console.WriteLine("Equal: " + (a == b));
            Console.WriteLine("Not Equal: " + (a != b));
            Console.WriteLine("Greater Than: " + (a > b));
            Console.WriteLine("Less Than: " + (a < b));
            Console.WriteLine("Greater Than or Equal To: " + (a >= b));
            Console.WriteLine("Less Than or Equal To: " + (a <= b));
        }
        
    }

    internal class Operators 
    {
        static void Main()
        {
            Operations ops = new Operations();
            Console.WriteLine("Enter two integers for arithmetic operations: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            ops.ArithmeticOperations(a, b);
            
            Console.WriteLine("Enter two integers for comparison operations: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            ops.ComparisonOperations(a, b);
        }
    }
}
