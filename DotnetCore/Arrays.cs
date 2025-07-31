using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore
{
    internal class Arrays
    {
        public int[] AddArrayElements()
        {
            Console.WriteLine("Enter size of array");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter element " + (i + 1));
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }
        static void Main()
        {
            Arrays arrays = new Arrays();
            int[] arr = arrays.AddArrayElements();
            Console.WriteLine("Array assignment....Enter your choice.");
            Console.WriteLine("1.Sum of array Elements \n2.Average of array Elements\n3.Print alternate elements in array\n4.length of array");
            Console.WriteLine("5.Smallest number\n6.Largest number");
            int choice = 0;
            do
            {
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        int sum = 0;
                        for (int i = 0; i < arr.Length; i++)
                        {
                            sum += arr[i];
                        }
                        Console.WriteLine($"sum of all elements in array is: {sum}");
                        break;

                    case 2:
                        double average = arr.Average();
                        Console.WriteLine($"Average of all elements in array is: {average}");
                        break;

                    case 3:
                        Console.WriteLine("alternate elements of arrays are");
                        for (int i = 0; i < arr.Length; i++)
                        {
                            if (arr[i] % 2 == 0)
                                Console.WriteLine($"{arr[i]}");
                        }
                        break;

                    case 4:
                        Console.WriteLine("length of array:" + arr.Length);
                        Console.WriteLine(arr.Length);
                        break;

                    case 5:
                        Console.WriteLine("smallest element in array is: " + arr.Min());
                        break;

                    case 6:
                        Console.WriteLine("largest element in array is: " + arr.Max());
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter between 1-6.");
                        break;

                }
            } while (choice >= 1 && choice <= 6);
        }
    }
}
