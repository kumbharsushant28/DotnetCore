using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DotnetCore
{
    internal class JumpStmt
    {
        static void Main()
        {
            int sum = 0;
            string[] mobiles = { "oppo", "vivo", "samsung", "realme", "xiaomi", "Motorola", "lenovo", "poco", "oneplus", "Iphone" };

            foreach (string mobile in mobiles)
            {
                Console.WriteLine(mobile);
            }


            // Usage of break Statement
            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("Enter number to perform addidtion:");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num < 0)
                {
                    Console.WriteLine("Sum of all previous numbers is " + sum + "Exiting loop now");
                    break;
                }
                sum += num;
            }

            // Usage of continue Statement
            for (int i = 1; i <= 20; i++)
            {
                if (i % 3 == 0)
                {
                    continue; // Skip divisible by 3 numbers
                }
                Console.WriteLine("not divisible by 3: " + i);
            }

        // Usage of goto Statement
        writeage: int age = 0;
            Console.WriteLine("Enter your age:");
            age = Convert.ToInt32(Console.ReadLine());

            if (age >= 0 && age <= 120)
            {
                Console.WriteLine("Your age is: " + age + "valid in records");
            }

            else
            {
                goto writeage; // If age is invalid, prompt again
            }
        }
    }
}

