using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore
{
    public delegate void CalculatorDelegate(int x, int y);
    public delegate void CalcDelegateMulticast(int x, int y);
    public class CalC
    {
        public static void Add(int a, int b) => Console.WriteLine($"Addition = {a + b}");
        public static void Subtract(int a, int b) => Console.WriteLine($"Subtraction = {a - b}");
        public static void Multiply(int a, int b) => Console.WriteLine($"Multiplication = {a * b}");
        public static void Divide(int a, int b) => Console.WriteLine($"Division = {a / b}");
    }

    internal class DelegatesDemo
    {
        public static void Main(string[] args)
        {
            // Unicast example
            CalculatorDelegate cdu = CalC.Add;
            Console.WriteLine("unicast delegate example addition");
            cdu(10, 22);
            cdu = CalC.Subtract;
            Console.WriteLine("Unicast delegate Example subtraction");
            cdu(10, 22);
            // Multicast example
            CalcDelegateMulticast cdm = CalC.Add;
            cdm+= CalC.Subtract;
            cdm += CalC.Multiply;
            cdm += CalC.Divide;
            Console.WriteLine("Multicast Delegate Example:");
            cdm(10, 2);

            //using lambda expression
            CalcDelegateMulticast lambdaDelegate = (x, y) =>
            {
                Console.WriteLine($"Lambda Addition = {x + y}");
                Console.WriteLine($"Lambda Subtraction = {x - y}");
                Console.WriteLine($"Lambda Multiplication = {x * y}");
                Console.WriteLine($"Lambda Division = {x / y}");
            };
            Console.WriteLine("Lambda Delegate Example:");
            lambdaDelegate(10, 2);
        }
    }
}
