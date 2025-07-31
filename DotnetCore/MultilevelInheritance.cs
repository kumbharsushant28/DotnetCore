using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore
{
    public class Person2
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void test()
        {
            Console.WriteLine("test method");
        }
    }

    public class Teacher : Person2
    {
        public Teacher()
        {
            Name = "Default Teacher";
            Age = 30;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"inside teacher class Name: {Name}, Age: {Age}");
        }

    }

    public class Principal : Teacher
    {
        public void DisplayInfo()
        {
            Console.WriteLine($" inside princi class-> Name: {Name}, Age: {Age}");
        }
    }

    internal class MultilevelInheritance
    {
        static void Main()
        {
            Principal p = new Principal();
            p.Age = 45; // Overriding the default age
            p.Name = "John Doe"; // Overriding the default name
            p.DisplayInfo(); // Output: Name: John Doe, Age: 45
            p.test(); // Output: test method
            Teacher t = new Teacher();
            t.Name = "Jane Smith"; // Overriding the default name
            t.Age = 35; // Overriding the default age
            t.DisplayInfo();// Output: inside teacher class-> Name: Jane Smith, Age: 35
            p.DisplayInfo(); // Output: inside princi class-> Name: John Doe, Age: 45

        }
    }
}
