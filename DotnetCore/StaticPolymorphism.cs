using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore
{

    public class Calculator
    {
        int a;
        int b;
        public Calculator(int A, int B)
        {
            a = A;
            b = B;
        }
        public void Add(int a, int b)
        {
            Console.WriteLine($"Adding integers: {a + b}");
        }
        public void Add(double a, double b)
        {
            Console.WriteLine($"Adding doubles: {a + b}");
        }
        public void Add(string a, string b)
        {
            Console.WriteLine($"Concatenating strings: {a + b}");
        }
    }
    internal class StaticPolymorphism
    {
        static void Main()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            double dA = double.Parse(Console.ReadLine());
            double dB = double.Parse(Console.ReadLine());
            string strA = Console.ReadLine();
            string strB = Console.ReadLine();

            Calculator c = new Calculator(A, B);
            c.Add(A, B); // Calls the integer version
            c.Add(dA, dB); // Calls the double version
            c.Add(strA, strB); // Calls the string version
        }
        
    }
}
