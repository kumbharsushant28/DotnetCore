using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore
{
    internal class DetermineControlFlow
    {
        public void CheckNumber(int num)
        {
            if (num > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (num < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }

        }

        public char DetermineGrade(int score)
        {
            if (score >= 90)
            {
                return 'A';
            }
            else if (score >= 80)
            {
                return 'B';
            }
            else if (score >= 70)
            {
                return 'C';
            }
            else if (score >= 40)
            {
                return 'D';
            }
            else
            {
                return 'F';
            }
        }
    }

    internal class ControlFlow
    {
        static void Main()
        {
            DetermineControlFlow dcf = new DetermineControlFlow();
            Console.WriteLine("Enter number to verify it is positive or not: ");
            int num = Convert.ToInt32(Console.ReadLine());
            dcf.CheckNumber(num);
            Console.WriteLine("Enter score to determine grade: ");
            int score = Convert.ToInt32(Console.ReadLine());
            char grade = dcf.DetermineGrade(score);
            Console.WriteLine("The grade is: " + grade);
        }
    }

}
