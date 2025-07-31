using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore
{
    public class ArrayListOps
    {
        public ArrayList arrayList = new ArrayList();

        public void DisplayElements()
        {
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }

        public void AddElement(object element)
        {
            arrayList.Add(element);
        }

        public void RemoveElement(object element)
        {
            arrayList.Remove(element);
        }
        public void RemoveElementIndex(int index)
        {
            if (index >= 0 && index < arrayList.Count)
            {
                arrayList.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Index out of range.");
            }
        }
    }

    internal class ArrayListDemo
    {
        static void Main()
        {
            ArrayListOps a = new ArrayListOps();
            a.AddElement(1);
            a.AddElement("Hello");
            a.AddElement(3.14);
            a.AddElement(new DateTime(2023, 10, 1));
            a.DisplayElements();
            Console.WriteLine("Total elements in ArrayList: " +  a.arrayList.Count);
            a.RemoveElement("Hello");
            a.DisplayElements();
            a.RemoveElementIndex(2);
            Console.WriteLine("After removing element at index 0:");
            a.DisplayElements();
        }
        
    }
}
