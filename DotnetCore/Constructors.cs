using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore
{
    internal class ConstructorExample
    {
        int a,b;
        // Default constructor
        public ConstructorExample()
        {
            a = 0;
            b = 0;
        }

        // Parameterized constructor
        public ConstructorExample(int x, int y)
        {
            a = x;
            b = y;
        }

        // Copy constructor 
        public ConstructorExample(ConstructorExample other)
        {
            a = other.a;
            b = other.b;
        }

        public override string ToString()
        {
            return $"a: {a}, b: {b}";
        }
    }

    public class Constructors
    {
        static void Main(string[] args)
        {
            // Using default constructor
            ConstructorExample obj1 = new ConstructorExample();
            Console.WriteLine("Default constructor called");
            Console.WriteLine(obj1.ToString()); // Just to avoid unused variable warning
            // Using parameterized constructor
            ConstructorExample obj2 = new ConstructorExample(5, 10);
            Console.WriteLine($"Parameterized constructor {obj2.ToString()} ");
            // Using copy constructor
            ConstructorExample obj3 = new ConstructorExample(obj2);
            Console.WriteLine($"Parameterized constructor {obj3.ToString()} ");
        }
    }
}
