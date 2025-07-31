using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore
{
    public abstract class Shape1
    {
        public abstract double CalculateArea(double d );
        public void Display()
        {
            Console.WriteLine($"type of shape is {this.GetType().Name} ");
        }
    }


    public class Circle1 : Shape1
    {
        public override double CalculateArea(double r)
        {
            return Math.PI * r * r; // Example radius of 5
        }
    }

    public class Rectangle1 : Shape1
    {
        public override double CalculateArea(double l)
        {
            return l * l; // Example length of 5
        }
    }

    internal class AbstractClass
    {
        static void Main()
        {
            Shape1 circle = new Circle1();
            double circleArea = circle.CalculateArea(5);
            Console.WriteLine($"Area of Circle: {circleArea}");
            circle.Display(); // Output: type of shape is 
            Shape1 rectangle = new Rectangle1();
            double rectangleArea = rectangle.CalculateArea(5);
            Console.WriteLine($"Area of Rectangle: {rectangleArea}");
            rectangle.Display(); // Output: type of shape is 
        }
    }
}
