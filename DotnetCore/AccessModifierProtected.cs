using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DotnetCore
{
    internal class Person
    {
        protected int id { get; set; }
        protected String name { get; set; }

        protected String address { get; set; }
    }

    internal class Employee : Person
    {
        public void SetDetails()
        { 
            id = 101;
            name = "Sush";
            address = "Pune, Maharashtra";
        }
        public void Display()
        { 
            Console.WriteLine("Employee ID: " + id);
            Console.WriteLine("Employee Name: " + name);
            Console.WriteLine("Employee Address: " + address);
        }
    }

    internal class AccessModifierProtected
    {
        static void Main()
        {
            Employee emp = new Employee();
            emp.SetDetails();
            emp.Display();
        }
    }
}
