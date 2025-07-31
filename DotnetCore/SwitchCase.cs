using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore
{

    internal class FoodItem
    {
        public void DisplayFoodIteem(int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Burger");
                    break;
                case 2:
                    Console.WriteLine("Pizza");
                    break;
                case 3:
                    Console.WriteLine("Salad");
                    break;
                default:
                    Console.WriteLine("Invalid choice, please select a valid food item.");
                    break;  
            }
        }
    }
    internal class SwitchCase
    {
        static void Main()
        {
            Console.WriteLine("Enter a number to discover food item");
            int choice = Convert.ToInt32(Console.ReadLine());
            FoodItem item = new FoodItem();
            item.DisplayFoodIteem(choice);
        }
    }
}
