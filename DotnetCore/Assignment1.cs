using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore
{
    internal class Assignment1
    {
        static void Main()
        { 
            Console.WriteLine("Enter the numbers to perform operations:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Addition of " + num1 + "and " + num2 + "= " +(num1+num2));
            Console.WriteLine("Subtraction of " + num1 + "and " + num2 + "= " +(num1-num2));
            Console.WriteLine("Multiplication of " + num1 + "and " + num2 + "= " +(num1*num2));
            Console.WriteLine("Division of " + num1 + "and " + num2 + "= " +(num1/num2));
        }
    }
}
