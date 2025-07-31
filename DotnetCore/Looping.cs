using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore
{
    internal class Looping
    {
        static void Main()
        {
            Console.WriteLine("Checking Student role numbers upto 10....");
            for (int j = 1; j <= 10; j++)
            {
                if (j == 1)
                {
                    Console.WriteLine("Inside for loop");
                }
                Console.WriteLine("Student Role Number: " + j);
            }
            
            int i=1;

            while (i <= 10)
            {
                if (i == 1)
                {
                    Console.WriteLine("Inside while loop");
                }
                Console.WriteLine("Student Role Number: " + i);
                i++;
            }

            i = 1;
            do 
            {
                if(i == 1)
                {
                    Console.WriteLine("Inside do-while loop");
                }
                Console.WriteLine("Student Role Number: " + i);
                i++;
            }while (i <= 10);
        }

    }

    
}
