using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore
{
    public class Shape
    {

        public string Color { get; set; }

        public Shape(string color)
        {
            Color = color;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"color of shape in base is {Color}");
        }
    }

    public class Circle : Shape
    {
        public Circle(string color) : base(color)
        {
        }
        public void DisplaycolorDetail()
        {
            Console.WriteLine($"color of shape in Circle is {Color}");
        }
    }

    public class Rectangle : Shape
    {
        public Rectangle(string color) : base(color)
        {
        }
        public void DisplaycolorDetail()
        {
            Console.WriteLine($"color of shape in Rectangle is {Color}");
        }

    }

    internal class HierarchicalInterface
    {
        static void Main()
        {
            Shape s = new Circle("Green");
            s.DisplayDetails(); // Output: color of shape in base is Green
            Circle c = new Circle("Blue");
            c.DisplaycolorDetail(); // Output: color of circle in base is Blue
            c.DisplayDetails(); // Output: color of shape in base is Blue
            Rectangle r = new Rectangle("Red");
            r.DisplaycolorDetail(); // Output: color of shape in Rectangle is Red
            r.DisplayDetails(); // Output: color of shape in base is Red

        }

    }
}
