using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore
{
    public class Person1
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Student : Person1
    {
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    internal class SingleInheritance
    {
        static void Main()
        {
            Student s = new Student();
            s.Name = "sushant";
            s.Age = 25;
            s.DisplayInfo(); // Output: Name: sushant, Age: 25
        }

    }
}
