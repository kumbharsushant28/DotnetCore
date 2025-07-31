using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore
{
    public class Vehicle
    {
        public virtual void StartEngine()
        {
            Console.WriteLine("Vehicle engine started");
        }
        public void StopEngine()
        {
            Console.WriteLine("Vehicle engine stopped");
        }
    }

    public class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car engine started");
        }
    }   

    public class Truck : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Truck engine started");
        }
    }



    internal class DynamicPolymorphism
    {
        static void Main()
        {   Vehicle v = new Vehicle();
            Vehicle car = new Car();
            Vehicle truck = new Truck();
            v.StartEngine(); // Calls the base class method
            v.StopEngine(); // Calls the base class method
            car.StartEngine(); // Calls the overridden method in Car class
            car.StopEngine(); // Calls the base class method
            truck.StartEngine(); // Calls the overridden method in Truck class
            truck.StopEngine(); // Calls the base class method
            //Truck t = v as Truck;
            //if (t != null)
            //{
            //    t.StartEngine(); // Calls the overridden method in Truck class
            //    t.StopEngine(); // Calls the base class method
            //}
        }
    }
}
