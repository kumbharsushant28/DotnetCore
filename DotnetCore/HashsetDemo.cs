using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore
{
    internal class HashsetOps
    {
        private HashSet<string> set;

        public HashsetOps(HashSet<string> _set)
        {
            set = _set;
        }
        public void AddElement(string item)
        {
            set.Add(item);
        }

        public void RemoveElement(string item)
        {
            set.Remove(item);
        }

        public void DisplayElements()
        {
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }

        public void UnionWith(List<string> otherSet)
        {
            set.UnionWith(otherSet);
        }

        public void IntersectWith(List<string> otherSet)
        {
            set.IntersectWith(otherSet);
        }

    }

    internal class HashsetDemo
    {
        static void Main()
        {
            HashSet<string> fruits = new HashSet<string>();
            var values = new List<string> {"banana", "peach", "Apple", "cherry", "banana" };
            HashsetOps hashsetOps = new HashsetOps(fruits);
            hashsetOps.AddElement("Apple");
            hashsetOps.AddElement("Banana");
            hashsetOps.AddElement("Cherry");
            Console.WriteLine("Elements in HashSet:");
            hashsetOps.DisplayElements();
            hashsetOps.RemoveElement("Banana");
            Console.WriteLine("After removing 'Banana':");
            hashsetOps.DisplayElements();
            Console.WriteLine("Adding elements from List:");
            hashsetOps.UnionWith(values);
            Console.WriteLine("Elements after union with List:");
            hashsetOps.DisplayElements();
            hashsetOps.IntersectWith(values);
            Console.WriteLine("Elements after intersection with List:");
            hashsetOps.DisplayElements();


        }
    }
}
